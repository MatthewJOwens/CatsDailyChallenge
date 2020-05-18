using System.ComponentModel.DataAnnotations;

namespace CatsDailyChallenge.Models
{
  public class Blog
  {
    public int Id { get; set; }
    [Required]
    [MaxLength(50)]
    public string Title { get; set; }
    public string Body { get; set; }
    public bool isPublished { get; set; }
    public Blog()
    {

    }
  }
}