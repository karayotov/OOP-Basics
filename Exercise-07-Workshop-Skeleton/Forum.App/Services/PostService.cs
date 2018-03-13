using Forum.App.UserInterface.ViewModel;
using Forum.Data;
using Forum.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Forum.App.Services
{
    public static class PostService
    {
        internal static Category GetCategory(int categoryId)
        {
            ForumData forumData = new ForumData();
            Category category = forumData.Categories.SingleOrDefault(u => u.Id == categoryId);

            return category;
        }

        internal static IList<ReplyViewModel> GetPostReplies(int postId)
        {
            ForumData forumData = new ForumData();

            Post post = forumData.Posts.Find(p => p.Id == postId);

            IList<ReplyViewModel> replies = new List<ReplyViewModel>();

            foreach (var replyId in post.ReplyIds)
            {
                var reply = forumData.Replies.Single(r => r.Id == replyId);
                replies.Add(new ReplyViewModel(reply));
            }

            return replies;
        }

        internal static string[] GetAllCatergoryNames()
        {
            ForumData forumData = new ForumData();

            var allCategories = forumData.Categories.Select(c => c.Name).ToArray();

            return allCategories;
        }

        public static IEnumerable<Post> GetPostByCategory(int categoryId)
        {
            ForumData forumData = new ForumData();
            var category = forumData.Categories.Single(c => c.Id == categoryId);
            return forumData.Posts.Where(p => category.PostIds.Contains(p.Id)).ToList();
        }

        public static PostViewModel GetPostViewModel(int postId)
        {
            var forumData = new ForumData();
            var post = forumData.Posts.Single(p => p.Id == postId);
            return new PostViewModel(post);
        }

        private static Category EnsureCategory(PostViewModel postView, ForumData forumData)
        {
            var categoryName = postView.Category;

            Category category = forumData.Categories.FirstOrDefault(x => x.Name == categoryName);

            if (category == null)
            {
                var categories = forumData.Categories;

                int categoryId = categories.LastOrDefault()?.Id + 1 ?? 1; ;

                category = new Category(categoryId, categoryName, new List<int>());

                forumData.Categories.Add(category);
            }

            return category;
        }

        public static bool TrySavePost(PostViewModel postViewModel)
        {
            var isTitleValid = !string.IsNullOrWhiteSpace(postViewModel.Title);
            var isContentValid = postViewModel.Content.Any();
            var isCategoryValid = !string.IsNullOrWhiteSpace(postViewModel.Category);

            if (!isTitleValid || !isContentValid || !isCategoryValid)
            {
                return false;
            }

            var forumData = new ForumData();

            var category = EnsureCategory(postViewModel, forumData);

            var postId = forumData.Posts.LastOrDefault()?.Id + 1 ?? 1;

            var author = UserService.GetUser(postViewModel.Author, forumData);

            var content = string.Join("", postViewModel.Content);

            var post = new Post(postId, postViewModel.Title, content, category.Id, author.Id, new List<int>());

            forumData.Posts.Add(post);
            category.PostIds.Add(postId);
            author.PostIds.Add(postId);

            forumData.SaveChanges();
            postViewModel.PostId = postId;

            return true;

        }

        public static bool TrySaveReply(ReplyViewModel replyViewModel, int postId)
        {
            if (!replyViewModel.Content.Any())
            {
                return false;
            }

            var forumData = new ForumData();

            var author = UserService.GetUser(replyViewModel.Author, forumData);

            var post = forumData.Posts.Single(p => p.Id == postId);

            

            var replyId = forumData.Replies.LastOrDefault()?.Id + 1 ?? 1;

            var content = string.Join("", replyViewModel.Content);

            var reply = new Reply(replyId, content, author.Id, postId);

            forumData.Replies.Add(reply);

            post.ReplyIds.Add(replyId);

            forumData.SaveChanges();

            return true;
        }
    }
}
