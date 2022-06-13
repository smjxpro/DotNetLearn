using System.ComponentModel.DataAnnotations;

namespace Core.Entities;

public class Post
{
    public int Id { get; set; }
    [Display(Name = "Title")]
    public string? Name { get; set; }
    public string? Description { get; set; }
    public string? Content { get; set; }
    public DateTime TimeStamp { get; set; }

    public Post()
    {
        TimeStamp = DateTime.Now;
    }
}