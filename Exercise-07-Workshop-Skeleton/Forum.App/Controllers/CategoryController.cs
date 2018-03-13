namespace Forum.App.Services
{
    using System;
    using System.Linq;
    using Forum.App.Services.Contracts;
    using Forum.App.UserInterface.Contracts;
    using Forum.App.Views;

    public class CategoryController : IController, IPaginationController
    {
        public const int PAGE_OFFSET = 10;
        private const int COMMAND_COUNT = PAGE_OFFSET + 3;

        private enum Command { Back = 0, ViewCategory = 1, PreviousPage = 11, NextPage = 12 }

        public string[] PostTitles { get; set; }

        private int LastPage => this.PostTitles.Length / (PAGE_OFFSET + 1);

        public int CategoryId { get; private set; }

        public int CurrentPage { get; set; }

        private bool IsFirstPage => this.CurrentPage == 0;

        private bool IsLastPage => this.CurrentPage == this.LastPage;

        public CategoryController()
        {
            CurrentPage = 0;
            this.SetCategory(0);
        }

        public MenuState ExecuteCommand(int index)
        {
            if (index > 1 && index < 11)
                index = 1;
            {
                switch ((Command)index)
                {
                    case Command.Back:
                        return MenuState.Back;

                    case Command.ViewCategory:
                        return MenuState.OpenCategory;

                    case Command.PreviousPage:
                        ChangePage(false);
                        return MenuState.Rerender;  //<-- must be .Rendered 
                    case Command.NextPage:
                        ChangePage();
                        return MenuState.Rerender;

                }
                throw new InvalidOperationException();
            }
        }

        public IView GetView(string userName)
        {
            
            GetPosts();
            var categoryName = PostService.GetCategory(CategoryId).Name;
            return new CategoryView(categoryName, PostTitles, IsFirstPage, IsLastPage);
        }

        public void SetCategory(int categoryId)
        {
            this.CategoryId = categoryId;
        }

        private void ChangePage(bool forward = true)
        {
            this.CurrentPage += forward ? 1 : -1;
        }

        private void GetPosts()
        {
            var allCategoryPosts = PostService.GetPostByCategory(this.CategoryId);

            this.PostTitles = allCategoryPosts
                .Skip(this.CurrentPage * PAGE_OFFSET)
                .Take(PAGE_OFFSET)
                .Select(p => p.Title)
                .ToArray();
        }
    }
}
