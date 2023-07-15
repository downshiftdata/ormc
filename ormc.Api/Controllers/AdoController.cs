namespace ormc.Api.Controllers;

[Microsoft.AspNetCore.Mvc.ApiController]
[Microsoft.AspNetCore.Mvc.Route("ado")]
public class AdoController : Microsoft.AspNetCore.Mvc.ControllerBase
{
    private ormc.Ado.Repositories.IReadRepository _ReadRepository;
    private ormc.Ado.Repositories.IWriteRepository _WriteRepository;

    public AdoController(ormc.Ado.Repositories.IReadRepository readRepository, ormc.Ado.Repositories.IWriteRepository writeRepository)
    {
        _ReadRepository = readRepository;
        _WriteRepository = writeRepository;
    }

    [Microsoft.AspNetCore.Mvc.HttpPost("driver")]
    public Microsoft.AspNetCore.Mvc.IActionResult AddDriver([Microsoft.AspNetCore.Mvc.FromBody] ormc.Ado.Models.AdoDriver value)
    {
        _WriteRepository.AddDriver(value);
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
}
