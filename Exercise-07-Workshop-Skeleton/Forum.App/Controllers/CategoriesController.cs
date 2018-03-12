namespace Forum.App.Services
{
    using System;
    using System.Linq;
    using Forum.App.Services.Contracts;
    using Forum.App.UserInterface.Contracts;
    using Forum.Data;

    public class CategoriesController : IController, IPaginationController
    {
        public const int PAGE_OFFSET = 10;
        private const int COMMAND_COUNT = PAGE_OFFSET + 3;

        public int CurrentPage { get; set; }

        private string[] AllCategoryNames { get; set; }

        private string[] CurrentPageCategories { get; set; }

        private int LastPage => this.AllCategoryNames.Length / (PAGE_OFFSET + 1);

        private bool IsFirstPage => this.CurrentPage == 0;

        private bool IsLastPage => this.CurrentPage == this.LastPage;

        public MenuState ExecuteCommand(int index)
        {
            throw new NotImplementedException();

            //if (index > 1 || index < 11)
            //{
            //    switch ((Command)index)
            //    {
            //        case Command.Back:
            //           return MenuState.Back;

            //        case Command.ViewCategory:

            //            return MenuState.OpenCategory;

            //        case Command.PreviousPage:
            //            ChangePage(false);
            //            return MenuState.OpenCategory;  //<-- must be .Rendered 
            //        case Command.NaxtPage:
            //            break;
            //        default:
            //            break;
            //    }
            //  }
        }
    

        public IView GetView(string userName)
        {
            throw new NotImplementedException();
        }

        private enum Command
        {
            Back = 0,
            ViewCategory = 1,
            PreviousPage = 11,
            NaxtPage = 12
        }
        private void ChangePage(bool forward = true)
        {
            this.CurrentPage += forward ? 1 : -1;
            //GetPosts();
        }

        private void LoadCategories()
        {
            this.AllCategoryNames = PostService.GetAllCatergoryNames();
            this.CurrentPageCategories = this.AllCategoryNames
                .Skip(this.CurrentPage * PAGE_OFFSET)
                .Take(PAGE_OFFSET)
                .ToArray();
        }

        //public IView GetView(string userName)
        //{
        //    LoadCategories();
        //    // CategoriesView does not have ctors!!!
        //    return new CategoriesView(this.CurrentPageCategories, this.IsFirstPage, this.IsLastPage);
        //}


    }
}
