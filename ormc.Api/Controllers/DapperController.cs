namespace ormc.Api.Controllers;

[Microsoft.AspNetCore.Mvc.ApiController]
[Microsoft.AspNetCore.Mvc.Route("dapper")]
public class DapperController : Microsoft.AspNetCore.Mvc.ControllerBase
{
    private ormc.Dapper.Repositories.IReadRepository _ReadRepository;
    private ormc.Dapper.Repositories.IWriteRepository _WriteRepository;

    public DapperController(ormc.Dapper.Repositories.IReadRepository readRepository, ormc.Dapper.Repositories.IWriteRepository writeRepository)
    {
        _ReadRepository = readRepository;
        _WriteRepository = writeRepository;
    }

    [Microsoft.AspNetCore.Mvc.HttpPost("driver")]
    public Microsoft.AspNetCore.Mvc.IActionResult AddDriver([Microsoft.AspNetCore.Mvc.FromBody] ormc.Dapper.Models.DapperDriver value)
    {
        _WriteRepository.AddDriver(value);
        return base.Ok();
    }

    [Microsoft.AspNetCore.Mvc.HttpPut("driver")]
    public Microsoft.AspNetCore.Mvc.IActionResult EditDriver([Microsoft.AspNetCore.Mvc.FromBody] ormc.Dapper.Models.DapperDriver value)
    {
        _WriteRepository.EditDriver(value);
        return base.Ok();
    }

    [Microsoft.AspNetCore.Mvc.HttpGet("driver")]
    public Microsoft.AspNetCore.Mvc.IActionResult GetDrivers()
    {
        return base.Ok(_ReadRepository.GetDrivers());
    }

    [Microsoft.AspNetCore.Mvc.HttpGet("result/{raceSeason}")]
    public Microsoft.AspNetCore.Mvc.IActionResult GetSeasonResults([Microsoft.AspNetCore.Mvc.FromRoute] int raceSeason)
    {
        return base.Ok(_ReadRepository.GetSeasonResults(raceSeason));
    }

    [Microsoft.AspNetCore.Mvc.HttpGet("track")]
    public Microsoft.AspNetCore.Mvc.IActionResult GetTracks()
    {
        return base.Ok(_ReadRepository.GetTracks());
    }

    [Microsoft.AspNetCore.Mvc.HttpDelete("driver")]
    public Microsoft.AspNetCore.Mvc.IActionResult RemoveDriver([Microsoft.AspNetCore.Mvc.FromBody] ormc.Dapper.Models.DapperDriver value)
    {
        _WriteRepository.RemoveDriver(value);
        return base.Ok();
    }
}
