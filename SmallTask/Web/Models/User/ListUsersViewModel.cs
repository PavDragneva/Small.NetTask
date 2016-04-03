namespace SmallTask.Web.Models.User
{
    using Common.Constants;
    using Common.Enums;
    using Infrastructure.Mappings;
    using SmallTask.Models;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using AutoMapper;
    using System;

    public class ListUsersViewModel : IMapFrom<User>, IHaveCustomMappings
    {
        public string Id { get; set; }

        [DisplayName("Full name")]
        public string FullName { get; set; }

        [DisplayName("Gender")]
        public bool IsMale { get; set; }

        public string PhotoUrl { get; set; }

        public string Telephone { get; set; }

        public Status Status { get; set; }

        public void CreateMappings(IConfiguration configuration)
        {
            configuration.CreateMap<User, ListUsersViewModel>()
                .ForMember(m => m.FullName, opt => opt.MapFrom(x => x.FirstName + " " + x.LastName));
        }
    }
}