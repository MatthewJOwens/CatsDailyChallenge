using System.Collections.Generic;
using CatsDailyChallenge.Models;

namespace CatsDailyChallenge.Services
{
  public class BlogsService
  {
    //loading dependency injection
    public IEnumerable<Blog> GetAll()
    {
      return new List<Blog>() { new Blog() };
    }
  }
}