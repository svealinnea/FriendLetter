using Microsoft.AspNetCore.Mvc;

namespace FriendLetter.Controllers
{
  public class HomeController : Controller
  {
      [Route("/hello")]
      public string Hello() { return "Hello friend!"; } // this is the path home/hello would be how you get here. home corresponds to the name of the controller HomeController 
    
    [Route("/goodbye")]
    public string Goodbye() { return "Goodbye friend."; }

    [Route ("/")]
    public string Letter() { return "Our virtual postcard will go here soon!"; }
  }
}