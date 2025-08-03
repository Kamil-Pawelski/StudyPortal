using Domain.Entities.Cards;
using Microsoft.AspNetCore.Mvc;

namespace StudyPortal.Views.Cards
{
    public class CardsController : Controller
    {
        // GET: CardController
        public ActionResult Index()
        {
            var cards = new List<Card>
            {
                new Card { Id = Guid.NewGuid(), Word = "Card 1", Translation = "Description for Card 1" },
                new Card { Id = Guid.NewGuid(), Word = "Card 2", Translation = "Description for Card 2" },
                new Card { Id = Guid.NewGuid(), Word = "Card 3", Translation = "Description for Card 3" }
            };

            var model = new MainCardView(cards);
            return View(model);
        }

        // GET: CardController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CardController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CardController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CardController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CardController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CardController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CardController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
