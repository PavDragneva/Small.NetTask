namespace SmallTask.Models
{
    using Common.Enums;
    using Common.Constants;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System.Threading.Tasks;
    using System.Security.Claims;
    using Microsoft.AspNet.Identity;
    public class User : IdentityUser
    {
        [Required(ErrorMessage = ModelsConstants.RequiredFieldErrorMessage)]
        [DisplayName("First name")]
        [StringLength(ModelsConstants.NameMaximalLength,
            MinimumLength = ModelsConstants.NameMimimalLength,
            ErrorMessage = ModelsConstants.NameLengthErrorMessage)]
        public string FirstName { get; set; }

        [DisplayName("Last name")]
        [StringLength(ModelsConstants.NameMaximalLength,
            MinimumLength = ModelsConstants.NameMimimalLength,
            ErrorMessage = ModelsConstants.NameLengthErrorMessage)]
        public string LastName { get; set; }

        [Required(ErrorMessage = ModelsConstants.RequiredFieldErrorMessage)]
        [DisplayName("Gender")]
        public bool IsMale { get; set; }

        [Required(ErrorMessage = ModelsConstants.RequiredFieldErrorMessage)]
        [RegularExpression(@"^(?([0-9]{3}))?[-. ]?([0-9]{3})[-. ]?([0-9]{4}).*$",
            ErrorMessage = ModelsConstants.InvalidFieldErrorMessage)]
        [StringLength(ModelsConstants.NumberMaximalLength,
            MinimumLength = ModelsConstants.NumberMinimalLength,
            ErrorMessage = ModelsConstants.PhoneNumberLengthErrorMessage)]
        public string Telephone { get; set; }

        [Url(ErrorMessage = ModelsConstants.InvalidFieldErrorMessage)]
        public string PhotoUrl{ get; set; }

        public Status Status { get; set; }
    }
}