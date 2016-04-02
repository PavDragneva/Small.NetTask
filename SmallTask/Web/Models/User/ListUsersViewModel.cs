namespace SmallTask.Web.Models.User
{
    using Common.Constants;
    using Common.Enums;
    using Infrastructure.Mappings;
    using SmallTask.Models;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    public class ListUsersViewModel: IMapFrom<User>
    {
        public string Id { get; set; }

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

        [Url(ErrorMessage = ModelsConstants.InvalidFieldErrorMessage)]
        public string PhotoUrl { get; set; }

        public Status Status { get; set; }
    }
}