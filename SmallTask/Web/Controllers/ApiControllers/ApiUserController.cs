namespace SmallTask.Web.Controllers
{
    using Services.Contracts;
    using System.Threading.Tasks;
    using System.Web.Http;

    public class ApiUserController : ApiController
    {
        private IUserService userService;

        public ApiUserController(IUserService userService)
        {
            this.userService = userService;
        }

        [HttpPut]
        public async Task<IHttpActionResult> UpdateStatus(string id)
        {
            if (id == null)
            {
                return this.BadRequest("You're id shouldn't be null");
            }

            await this.userService.UpdateStatus(id);
            return this.Ok();
        }

        [HttpPut]
        public async Task<IHttpActionResult> DeleteUser(string id)
        {
            if(id == null)
            {
                return this.BadRequest("You're id shouldn't be null");
            }
            await this.userService.DeleteUser(id);
            return this.Ok();
        }
    }
}
