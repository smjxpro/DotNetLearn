using Core.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApp.Pages.Post;

public class AddModel : PageModel
{
    private readonly IPostRepository _postRepository;

    public AddModel(IPostRepository postRepository)
    {
        _postRepository = postRepository;
    }

    [BindProperty] public Core.Entities.Post Post { get; set; }

    public void OnGet()
    {
    }

    public async Task<IActionResult> OnPostAsync()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }

        await _postRepository.CreatePostAsync(Post);
        return RedirectToPage("/Post/Index");
    }
}