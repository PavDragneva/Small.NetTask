namespace SmallTask.Services
{
    using SmallTask.Services.Contracts;
    using Data.Repository;
    using Models;
    using System.Linq;
    using Common.Enums;
    using System.Threading.Tasks;

    public class UserService: IUserService
    {
        private readonly IRepository<User> users;

        public UserService(IRepository<User> users)
        {
            this.users = users;
        }

        public User GetById(string id)
        {
            return this.users.All()
                .Where(u => u.Id == id)
                .FirstOrDefault();
        }

        public IQueryable<User> AllUsersNotDeleted()
        {
            return this.users.All()
                .Where(u => u.Status != Status.Deleted)
                .OrderBy(u => u.FirstName);
        }

        public async Task UpdateStatus(string id)
        {
            var userForUpdate = GetById(id);

            if (userForUpdate != null)
            {
                if (userForUpdate.Status == Status.Active)
                {
                    userForUpdate.Status = Status.Inactive;
                }
                else
                {
                    userForUpdate.Status = Status.Active;
                }

                await this.users.SaveChangesAsync();
            }
        }

        public async Task DeleteUser(string id)
        {
            var userForDelete = this.users.All()
                .Where(u => u.Id == id)
                .FirstOrDefault();

            userForDelete.Status = Status.Deleted;

            await this.users.SaveChangesAsync();
        }
    }
}
