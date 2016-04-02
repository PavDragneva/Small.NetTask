namespace SmallTask.Services.Contracts
{
    using Models;
    using System.Linq;

    public interface IUserService
    {
        IQueryable<User> AllUsersNotDeleted();
    }
}
