using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Portfolio1.Controllers     // namespace!
{
    public class HelloController : Controller   //inheritance
    {
        [HttpGet]       
        [Route("")]     
        public IActionResult Index() // it will be string type if it's not routing
        {
            return View("Index"); 
        }
        [HttpGet]      
        [Route("projects")]     
        public IActionResult Projects() 
        {
            return View("Projects"); 
        }
        [HttpGet]       //type of request
        [Route("contact")]     //associated route string (exclude the leading /)
        public IActionResult Contact() 
        {
            return View("Contact"); 
        }
    }
}