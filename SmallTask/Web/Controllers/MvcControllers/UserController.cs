namespace SmallTask.Web.Controllers
{
    using AutoMapper.QueryableExtensions;
    using Models.User;
    using Services.Contracts;
    using System.Web.Mvc;

    public class UserController : Controller
    {
        IUserService userService;

        public UserController(IUserService userService)
        {
            this.userService = userService;
        }
        
        [HttpGet]
        public ActionResult Index()
        {
            var allUsers = this.userService.AllUsersNotDeleted().ProjectTo<ListUsersViewModel>();
            return View("Index", allUsers);
        }


    }
}