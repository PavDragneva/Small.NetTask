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
        public IHttpActionResult UpdateStatus(string id)
        {
            this.userService.UpdateStatus(id);
            return this.Ok();
        }

        [HttpPut]
        public IHttpActionResult DeleteUser(string id)
        {
            var list = this.userService.DeleteUser(id);
            return this.Ok();
        }
    }
}
