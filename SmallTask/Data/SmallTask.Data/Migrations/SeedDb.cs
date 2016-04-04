namespace SmallTask.Data.Migrations
{
    using Common.Enums;
    using Models;
    using System.Linq;

    public class SeedDb
    {
        public void Start(SmallTaskDbContext context)
        {
            SeedUsers(context);
        }

        private void SeedUsers(SmallTaskDbContext context)
        {
            if (!context.Users.Any())
            {
                for (int i = 0; i <= 25; i++)
                {
                   var user = CreateNewUser("FName" + i, "MyLastName" + i, i%2 == 0, "0888/23-12-1" + i, i%3, "MySecretName" + i);
                    context.Users.Add(user);
                }

                context.SaveChanges();
            }
        }

        private static User CreateNewUser(string firstName, string lastName, bool isMale, string telephone, int status, string userName)
        {
            var user = new User();
            user.FirstName = firstName;
            user.LastName = lastName;
            user.IsMale = isMale;
            user.Telephone = telephone;
            user.Status = (Status)status;
            user.UserName = userName;

            if(isMale)
            {
                user.PhotoUrl = "http://rollycat.com/wp-content/uploads/2016/03/test.jpg";
            }

            return user;
        }
    }
}
