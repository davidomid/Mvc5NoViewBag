namespace Mvc5NoViewBag.Models
{
    public class ContactPageViewModel : BasePageViewModel
    {
        public ContactPageViewModel() : base("Contact")
        {
        }

        public string Message => "Your contact page.";
    }
}