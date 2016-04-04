namespace SmallTask.Web.Controllers
{
    using AutoMapper.QueryableExtensions;
    using Common.Constants;
    using Models.User;
    using PagedList;
    using Services.Contracts;
    using System.Web.Mvc;

    public class UserController : Controller
    {
        private IUserService userService;

        public UserController(IUserService userService)
        {
            this.userService = userService;
        }
        
        [HttpGet]
        public ActionResult Index(int? page)
        {
            int pageNumber = (page ?? 1);
            var allUsers = this.userService.AllUsersNotDeleted().ProjectTo<ListUsersViewModel>();
            return View("Index", allUsers.ToPagedList(pageNumber, ControllersConstants.PageSize));
        }
    }
}