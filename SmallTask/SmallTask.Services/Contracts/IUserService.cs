namespace SmallTask.Services.Contracts
{
    using Models;
    using System.Linq;
    using System.Threading.Tasks;
    public interface IUserService
    {
        IQueryable<User> AllUsersNotDeleted();

        User GetById(string id);

        Task UpdateStatus(string id);

        Task DeleteUser(string id);
    }
}
