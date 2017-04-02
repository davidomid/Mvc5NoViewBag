namespace Mvc5NoViewBag.Models
{
    public class AboutPageViewModel : BasePageViewModel
    {
        public AboutPageViewModel() : base("About")
        {
        }

        public string Message => "Your application description page.";
    }
}