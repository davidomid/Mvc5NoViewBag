using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security;

namespace Mvc5NoViewBag.Models
{
    public class IndexViewModel : BasePageViewModel
    {
        public IndexViewModel() : base("Manage")
        {
        }

        public bool HasPassword { get; set; }
        public IList<UserLoginInfo> Logins { get; set; }
        public string PhoneNumber { get; set; }
        public bool TwoFactor { get; set; }
        public bool BrowserRemembered { get; set; }
        public string StatusMessage { get; set; }
    }

    public class ManageLoginsViewModel : BasePageViewModel
    {
        public ManageLoginsViewModel() : base("Manage your external logins")
        {
        }

        public IList<UserLoginInfo> CurrentLogins { get; set; }
        public IList<AuthenticationDescription> OtherLogins { get; set; }
        public string StatusMessage { get; set; }
        public bool ShowRemoveButton { get; set; }
    }

    public class FactorViewModel
    {
        public string Purpose { get; set; }
    }

    public class SetPasswordPageViewModel : BasePageViewModel
    {

        public SetPasswordPageViewModel() : base("Create Password")
        {
        }

        [Display(Name = "Create Local Login")]
        public SetPasswordFormViewModel Form { get; } = new SetPasswordFormViewModel();
    }

    public class SetPasswordFormViewModel
    {
        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "New password")]
        public string NewPassword { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm new password")]
        [System.ComponentModel.DataAnnotations.Compare("NewPassword",
            ErrorMessage = "The new password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
    }

    public class ChangePasswordPageViewModel : BasePageViewModel
    {
        public ChangePasswordPageViewModel(ChangePasswordFormViewModel form) : base("Change Password")
        {
            this.Form = form;
        }

        [Display(Name = "Change Password Form")]
        public ChangePasswordFormViewModel Form { get; }
    }

    public class ChangePasswordFormViewModel
    {
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Current password")]
        public string OldPassword { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "New password")]
        public string NewPassword { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm new password")]
        [System.ComponentModel.DataAnnotations.Compare("NewPassword",
            ErrorMessage = "The new password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
    }

    public class AddPhoneNumberViewModel : BasePageViewModel
    {
        public AddPhoneNumberViewModel() : base("Phone Number")
        {
        }

        [Required]
        [Phone]
        [Display(Name = "Phone Number")]
        public string Number { get; set; }
    }

    public class VerifyPhoneNumberViewModel : BasePageViewModel
    {
        [Required]
        [Display(Name = "Code")]
        public string Code { get; set; }

        [Required]
        [Phone]
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }

        public string Status { get; set; }

        public VerifyPhoneNumberViewModel() : base("Verify Phone Number")
        {
        }
    }

    public class ConfigureTwoFactorViewModel
    {
        public string SelectedProvider { get; set; }
        public ICollection<SelectListItem> Providers { get; set; }
    }
}