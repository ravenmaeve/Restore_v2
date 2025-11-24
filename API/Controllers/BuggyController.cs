using System;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

public class BuggyController:BaseApiController
{
    [HttpGet("not-found")]
    public IActionResult GetNotFound()
    {
        return NotFound();//404 Not found
    }

    [HttpGet("bad-request")]
    public IActionResult GetBadRequest()
    {
        return BadRequest("This is not a good request");//400 Bad request
    }

    [HttpGet("unauthorized")]
    public IActionResult GetUnauthorized()
    {
        return Unauthorized();//401 Unathorized
    }

    [HttpGet("validation-error")]
    public IActionResult GetValidationError()
    {
        ModelState.AddModelError("Problem1","This is the first error");
        ModelState.AddModelError("Problem2","This is the second error");
        return ValidationProblem();//400 Bad request
    }

    [HttpGet("server-error")]
    public IActionResult GetServerError()
    {
        throw new Exception("This is a server error");//500 Internal server error
    }

}
