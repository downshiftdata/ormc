Param( `
    [parameter(Mandatory=$true, HelpMessage="ServerName")] $ServerName, `
    [parameter(Mandatory=$true, HelpMessage="DatabaseName")] $DatabaseName
);

$rootPath = (Split-Path $MyInvocation.MyCommand.Path -Parent);

function DeployScript([String] $path)
{
    Write-Host "$path";
    try
    {
        Invoke-Sqlcmd `
            -InputFile $path `
            -ServerInstance $ServerName `
            -Database $DatabaseName `
            -ErrorAction Stop;
    }
    catch
    {
        Write-Host("Error:{0},State:{1},File:{2},Line:{3},Message:{4}" -f `
            $_.Exception.InnerException.Number, `
            $_.Exception.InnerException.State, `
            $path, `
            $_.Exception.InnerException.LineNumber, `
            $_.Exception.InnerException.Message) `
            -ForegroundColor Red
        Exit 1;
    }
}

function DeployFolder([String] $schemaPath, [String] $folderName)
{
    Write-Host "Folder: $schemaPath\$folderName";
    Get-ChildItem "$schemaPath\$folderName" -Filter "*.sql" -Recurse `
        | Foreach-Object { DeployScript $_.FullName };
}

Get-ChildItem $rootPath -Filter "_*.sql" -Recurse `
    | Foreach-Object { DeployScript $_.FullName };

Get-ChildItem $rootPath -Directory `
    | Foreach-Object { DeployFolder $_.FullName "table" };

Get-ChildItem $rootPath -Directory `
    | Foreach-Object { DeployFolder $_.FullName "data" };

Get-ChildItem $rootPath -Directory `
    | Foreach-Object { DeployFolder $_.FullName "procedure" };

Get-ChildItem $rootPath -Directory `
    | Foreach-Object { DeployFolder $_.FullName "test" };
