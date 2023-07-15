using System.Linq;

namespace ormc.Api.Controllers;

[Microsoft.AspNetCore.Mvc.ApiController]
[Microsoft.AspNetCore.Mvc.Route("df")]
public class DataFirstController : Microsoft.AspNetCore.Mvc.ControllerBase
{
    ormc.DataFirst.Models.Context _Context;

    public DataFirstController(ormc.DataFirst.Models.Context context)
    {
        _Context = context;
    }

    [Microsoft.AspNetCore.Mvc.HttpPost("driver")]
    public Microsoft.AspNetCore.Mvc.IActionResult AddDriver([Microsoft.AspNetCore.Mvc.FromBody] ormc.DataFirst.Models.Driver value)
    {
        _Context.Add(value);
        _Context.SaveChanges();
        return base.Ok();
    }

    [Microsoft.AspNetCore.Mvc.HttpGet("driver")]
    public Microsoft.AspNetCore.Mvc.IActionResult GetDrivers()
    {
        return base.Ok(_Context.Driver.ToList());
    }
}
