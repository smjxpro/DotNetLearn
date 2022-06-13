using Core.Entities;

namespace Core.Repositories;

public interface IPostRepository
{
    Task<IEnumerable<Post?>> GetAllPostAsync();
    Task<Post?> GetPostByIdAsync(int id);
    Task CreatePostAsync(Post post);
    Task UpdatePostAsync(Post post);
    Task DeletePostAsync(Post post);
}