using Microsoft.AspNetCore.Mvc;

namespace StudyPortal.Views.Cards
{
    public class CardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
