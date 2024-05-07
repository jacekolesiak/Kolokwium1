using Microsoft.AspNetCore.Mvc;
using WebApplication1.Services;

namespace WebApplication1.Controllers;

[ApiController]
[Route("api/[controller]")]
public class MyController(IDbService db) : ControllerBase
{

}