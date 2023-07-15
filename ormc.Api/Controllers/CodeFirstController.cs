using System.Linq;

namespace ormc.Api.Controllers;

[Microsoft.AspNetCore.Mvc.ApiController]
[Microsoft.AspNetCore.Mvc.Route("cf")]
public class CodeFirstController : Microsoft.AspNetCore.Mvc.ControllerBase
{
    ormc.CodeFirst.DataAccess.Context _Context;

    public CodeFirstController(ormc.CodeFirst.DataAccess.Context context)
    {
        _Context = context;
    }

    [Microsoft.AspNetCore.Mvc.HttpPost("driver")]
    public Microsoft.AspNetCore.Mvc.IActionResult AddDriver([Microsoft.AspNetCore.Mvc.FromBody] ormc.CodeFirst.Models.CodeFirstDriver value)
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
