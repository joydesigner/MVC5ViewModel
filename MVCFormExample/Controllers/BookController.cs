using System.Web.Mvc;
using MVCFormExample.ViewModels;

namespace MVCFormExample.Controllers
{
    public class BookController : Controller
    {
        // GET: Book
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create() {
            return View(new BookViewModel());
        }

        [HttpPost]
        public ActionResult Create(BookViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                // TODO: Save book
                return RedirectToAction("Index");
            }
            return View(viewModel);
        }
    }
}