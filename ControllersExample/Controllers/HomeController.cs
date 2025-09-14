using Microsoft.AspNetCore.Mvc;
using ControllersExample.Models;
namespace ControllersExample.Controllers
{
    [Controller]
    public class HomeController :Controller
    {
        [Route("home")]
        [Route("/")]
        public ContentResult Index()
        {
            return Content("<h1>:3</h1><h2>Meow</h2>", "text/HTML"); 
        }
        [Route("person")]
        public JsonResult person()
        {
            Person person = new Person() { Id = Guid.NewGuid(),
                FName = "James", LName = "Smith", Age = 36};
            return Json(person);
        }
        [Route("contact-us/{mobile:regex(^\\d{{10}}$)}")]
        public string Contact()
        {
            return "Hello From contact-us, this is contact-us page";
        }
    
    }
}
