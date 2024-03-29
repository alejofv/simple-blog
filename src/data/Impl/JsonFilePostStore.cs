#nullable enable

using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Alejof.SimpleBlog.Data.Models;

namespace Alejof.SimpleBlog.Data.Impl
{
    public class JsonFilePostStore : IPostStore, IJsonFileStore
    {
        public string RootPath { get; private set; }
        public string FileName => "posts.json";

        public JsonFilePostStore(string rootPath)
        {
            this.RootPath = rootPath;
        }

        public Task<IList<Post>> GetPosts() => this.ReadContent<IList<Post>>(defaultContent: "[]");

        public async Task<Post?> GetPost(string slug)
        {
            var posts = await this.GetPosts();
            return posts.FindBySlug(slug);
        }

        public async Task<bool> CreatePost(Post post)
        {
            var posts = await this.GetPosts();
            var existingPost = posts.FindBySlug(post.Slug);

            if (existingPost != null)
                return false;

            posts.Add(post);

            await this.UpdateContent(posts);
            return true;
        }

        public async Task<bool> UpdatePost(Post post)
        {
            var posts = await this.GetPosts();
            var existingPost = posts.FindBySlug(post.Slug);

            if (existingPost == null)
                return false;

            posts.Remove(existingPost);
            posts.Add(post);

            await this.UpdateContent(posts);
            return true;
        }

        public async Task<bool> DeletePost(string slug)
        {
            var posts = await this.GetPosts();
            var existingPost = posts.FindBySlug(slug);

            if (existingPost == null)
                return false;

            posts.Remove(existingPost);

            await this.UpdateContent(posts);
            return true;
        }
    }

    public static class PostEnumerableExtensions
    {
        public static Post? FindBySlug(this IEnumerable<Post> posts, string slug)
            => posts.FirstOrDefault(p => string.Equals(p.Slug, slug, System.StringComparison.OrdinalIgnoreCase));
    }
}