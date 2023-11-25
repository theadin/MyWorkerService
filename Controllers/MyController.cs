using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWorkerService.Controllers;
[Route("[controller]")]
[ApiController]
public class MyController : ControllerBase
{
    [HttpGet]
    public ContentResult Get()
    {
        string someContent = "Some Content";

        return new ContentResult
        {
            Content = someContent,
            ContentType = "text/html"
        };
    }
}

