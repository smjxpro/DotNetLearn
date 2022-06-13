using Core.Repositories;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApp.Pages.Post;

public class IndexModel : PageModel
{
    private readonly IPostRepository _postRepository;

    public IndexModel(IPostRepository postRepository)
    {
        _postRepository = postRepository;
    }

    public IList<Core.Entities.Post> Posts { get; set; } = new List<Core.Entities.Post>();

    public async Task OnGetAsync()
    {
        Posts = (IList<Core.Entities.Post>) await _postRepository.GetAllPostAsync();
    }
}