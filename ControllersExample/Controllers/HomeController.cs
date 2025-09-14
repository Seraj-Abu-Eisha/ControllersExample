using Microsoft.AspNetCore.Mvc;

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
        [Route("about")]
        public string About()
        {
            return "Hello From about, this is about page";
        }
        [Route("contact-us/{mobile:regex(^\\d{{10}}$)}")]
        public string Contact()
        {
            return "Hello From contact-us, this is contact-us page";
        }
    
    }
}
