using OrangeBricks.Web.Controllers.Viewings.Builders;
using OrangeBricks.Web.Controllers.Viewings.Commands;
using OrangeBricks.Web.Models;
using System.Web.Mvc;

namespace OrangeBricks.Web.Controllers.Viewings
{
    public class ViewingsController : Controller
    {
        private readonly IOrangeBricksContext _context;

        public ViewingsController(IOrangeBricksContext context)
        {
            _context = context;
        }

        // GET: Viewings
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult OnProperty(int id)
        {
            var builder = new ViewingsOnPropertyViewModelBuilder(_context);
            var viewModel = builder.Build(id);
            return View(viewModel);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Accept(AcceptViewingRequestCommand command)
        {
            var handler = new AcceptViewingRequestCommandHandler(_context);

            handler.Handle(command);

            return RedirectToAction("OnProperty", new { id = command.PropertyId });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Reject(RejectViewingRequestCommand command)
        {
            var handler = new RejectViewingRequestCommandHandler(_context);

            handler.Handle(command);

            return RedirectToAction("OnProperty", new { id = command.PropertyId });
        }
    }
}