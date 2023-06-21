using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using local__login.Models;

namespace local__login.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Login()
        {

            return View();
        }
        public List<UserModel> PutValue()
        {
            var users = new List<UserModel>
            {
                new UserModel{id=1,username="amitkumar",password="abc111"},
                new UserModel{id=2,username="amitkumar1",password="abc1111"},
                new UserModel{id=3,username="amitkumar2",password="abc1112"},
                new UserModel{id=4,username="amitkumar3",password="abc1113"},
                new UserModel{id=5,username="amitkumar4",password="abc1114"}
            };

            return users;
        }
        [HttpPost]
        public ActionResult Verify(UserModel usr)
        {
            var u = PutValue();

            var ue = u.Where(e => e.username.Equals(usr.username));

            var up = ue.Where(p => p.password.Equals(usr.password));

            if (up.Count() == 1)
            {
                ViewBag.message = "Login Success";
                return View("LoginSuccess_SI");
            }
            else if (up.Count() == 2)
            {
                ViewBag.message = "Login Success_H";
                return View("LoginO");
            }
            else
            {
                ViewBag.message = "Login Failed";
                return View("Login");
            }
        }
    }
}