using System.Collections.Generic;
using CatsDailyChallenge.Models;
using CatsDailyChallenge.Repositories;

namespace CatsDailyChallenge.Services
{
  public class BlogsService
  {
    private readonly BlogsRepository _repo;

    //loading dependency injection
    public BlogsService(BlogsRepository repo)
    {
      _repo = repo;
    }
    public IEnumerable<Blog> GetAll()
    {
      return _repo.GetAll();
    }
  }
}