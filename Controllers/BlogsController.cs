using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CatsDailyChallenge.Models;
using CatsDailyChallenge.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CatsDailyChallenge.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class BlogsController : ControllerBase
  {
    private readonly BlogsService _bs;
    public BlogsController(BlogsService bs)
    {
      _bs = bs;
    }
    [HttpGet]
    public ActionResult<IEnumerable<Blog>> getBlogs()
    {
      try
      {
        return Ok(_bs.GetAll());
      }
      catch (System.Exception)
      {

        throw;
      }
    }
  }
}
