using Core.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApp.Pages.Post;

public class DetailsModel : PageModel
{
    private readonly IPostRepository _postRepository;

    public DetailsModel(IPostRepository postRepository)
    {
        _postRepository = postRepository;
    }

    public Core.Entities.Post Post { get; set; }
    
    public async Task OnGetAsync(int id)
    {
        Post= (await _postRepository.GetPostByIdAsync(id))!;
    }
    
    public async Task<IActionResult> OnPostDeleteAsync(int id)
    {
        var post = await _postRepository.GetPostByIdAsync(id);
        
        await _postRepository.DeletePostAsync(post);
        
        return RedirectToPage("/Post/Index");
    }
}