using Microsoft.AspNetCore.Mvc;
using FriendLetter.Models;

namespace FriendLetter.Controllers
{
  public class HomeController : Controller
  {
      [Route("/hello")]
      public string Hello() { return "Hello friend!"; } // this is the path home/hello would be how you get here. home corresponds to the name of the controller HomeController 
    
    [Route("/goodbye")]
    public string Goodbye() { return "Goodbye friend."; }

    [Route ("/")]
    public ActionResult Letter() 
    { 
      LetterVariable myLetterVariable = new LetterVariable(); 
      myLetterVariable.Recipient = "Tyler";
      myLetterVariable.Sender = "Svea";
      return View(myLetterVariable); 
    }
    [Route("/form")]
    public ActionResult Form() { return View(); }

    [Route("/postcard")]
    public ActionResult Postcard(string recipient, string sender, string location, string souvenir)
    {
      LetterVariable myLetterVariable =  new LetterVariable();
      myLetterVariable.Recipient = recipient;
      myLetterVariable.Sender = sender;
      myLetterVariable.Location = location;
      myLetterVariable.Souvenir = souvenir;
      return View(myLetterVariable);
    }
  }
}