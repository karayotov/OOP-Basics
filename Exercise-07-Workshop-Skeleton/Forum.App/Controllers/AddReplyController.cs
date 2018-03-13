namespace Forum.App.Services
{
    using Forum.App.Services.Contracts;
    using Forum.App.UserInterface;
    using Forum.App.UserInterface.Contracts;
    using Forum.App.UserInterface.Input;
    using Forum.App.UserInterface.ViewModel;
    using Forum.App.Views;
    using System.Linq;

    public class AddReplyController : IController
    {
        private enum Command { Write, Post }
        private const int TEXT_AREA_WIDTH = 37;
        private const int TEXT_AREA_HEIGHT = 6;
        private const int POST_MAX_LENGTH = 220;

        private static int centerTop = Position.ConsoleCenter().Top;
        private static int centerleft = Position.ConsoleCenter().Left;


        public bool Error { get; private set; }

        public AddReplyController()
        {
            ResetReply();
        }

        public ReplyViewModel Reply { get; private set; }

        private PostViewModel postViewModel;

        public TextArea TextArea { get; set; }


        public MenuState ExecuteCommand(int index)
        {
            switch ((Command)index)
            {
                case Command.Write:
                    TextArea.Write();
                    Reply.Content = TextArea.Lines.ToArray();
                    return MenuState.AddReply;

                case Command.Post:
                    var replyAdded = PostService.TrySaveReply(Reply, postViewModel.PostId);
                    if (!replyAdded)
                    {
                        Error = true;
                        return MenuState.Rerender;
                    }

                    return MenuState.ReplyAdded;
            }

            throw new InvalidCommandException();
        }

        public IView GetView(string userName)
        {
            this.Reply.Author = userName;
            return new AddReplyView(postViewModel, Reply, TextArea, Error);
        }

        public void ResetReply()
        {
            this.Error = false;
            this.Reply = new ReplyViewModel();

            int contentLingth = postViewModel?.Content.Count ?? 0;

            this.TextArea = new TextArea(centerleft - 18, centerTop + contentLingth - 6, TEXT_AREA_WIDTH, TEXT_AREA_HEIGHT, POST_MAX_LENGTH);
        }

        public void SetPostId(int postId)
        {
            postViewModel = PostService.GetPostViewModel(postId);
            ResetReply();
        }
    }
}