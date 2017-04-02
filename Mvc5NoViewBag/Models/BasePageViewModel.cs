namespace Mvc5NoViewBag.Models
{
    public class BasePageViewModel
    {
        public BasePageViewModel(string title)
        {
            this.Title = title;
        }

        public string Title { get; }
    }
}