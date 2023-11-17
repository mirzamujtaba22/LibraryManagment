using API.DataAccess;
using API.Models;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class LibraryController : Controller
    {
        private readonly IDataAccess library;
        public LibraryController(IDataAccess library)
        {
            this.library = library;
        }
        [HttpPost("CreatedAccount")]
        public ActionResult CreateAccount(User user) 
        {
            if(!library.IsEmailAvailable(user.Email))
            {
                return Ok("Email is not Available");
            }
            user.CreatedOn = DateTime.Now.ToString("yyy-MM-dd HH:mm:ss");
            user.UserType = UserType.USER;
            library.CreateUser(user);
            return Ok("Account Created successfully");
               
        }
    }
}
