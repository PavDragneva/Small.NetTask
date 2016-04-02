namespace SmallTask.Services
{
    using SmallTask.Services.Contracts;
    using Data.Repository;
    using Models;
    using System.Linq;
    using Common.Enums;

    public class UserService: IUserService
    {
        private readonly IRepository<User> users;

        public UserService(IRepository<User> users)
        {
            this.users = users;
        }

        public IQueryable<User> AllUsersNotDeleted()
        {
            return this.users.All()
                .Where(u => u.Status != Status.Deleted)
                .OrderBy(u => u.FirstName);
        }
    }
}
