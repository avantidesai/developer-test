using System.Collections;
using System.Linq;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using OrangeBricks.Web.Attributes;
using OrangeBricks.Web.Controllers.Property.Builders;
using OrangeBricks.Web.Controllers.Property.Commands;
using OrangeBricks.Web.Controllers.Property.ViewModels;
using OrangeBricks.Web.Models;

namespace OrangeBricks.Web.Controllers.Property
{
    public class PropertyController : Controller
    {
        private readonly IOrangeBricksContext _context;

        public PropertyController(IOrangeBricksContext context)
        {
            _context = context;
        }

        [Authorize]
        public ActionResult Index(PropertiesQuery query)
        {
            var builder = new PropertiesViewModelBuilder(_context);
            var viewModel = builder.Build(query);

            return View(viewModel);
        }

        [OrangeBricksAuthorize(Roles = "Seller")]
        public ActionResult Create()
        {
            var viewModel = new CreatePropertyViewModel();

            viewModel.PossiblePropertyTypes = new string[] { "House", "Flat", "Bungalow" }
                .Select(x => new SelectListItem { Value = x, Text = x })
                .AsEnumerable();

            return View(viewModel);
        }

        [OrangeBricksAuthorize(Roles = "Seller")]
        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult Create(CreatePropertyCommand command)
        {
            var handler = new CreatePropertyCommandHandler(_context);

            command.SellerUserId = User.Identity.GetUserId();

            handler.Handle(command);

            return RedirectToAction("MyProperties");
        }

        [OrangeBricksAuthorize(Roles = "Seller")]
        public ActionResult MyProperties()
        {
            var builder = new MyPropertiesViewModelBuilder(_context);
            var viewModel = builder.Build(User.Identity.GetUserId());

            return View(viewModel);
        }

        [HttpPost]
        [OrangeBricksAuthorize(Roles = "Seller")]
        [ValidateAntiForgeryToken]
        public ActionResult ListForSale(ListPropertyCommand command)
        {
            var handler = new ListPropertyCommandHandler(_context);

            handler.Handle(command);

            return RedirectToAction("MyProperties");
        }

        [OrangeBricksAuthorize(Roles = "Buyer")]
        public ActionResult MakeOffer(int id)
        {
            try
            {
                var builder = new MakeOfferViewModelBuilder(_context);
                var viewModel = builder.Build(id, User.Identity.GetUserId());
                return View(viewModel);
            }
            catch
            {
                return RedirectToAction("Error", "Home");
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [OrangeBricksAuthorize(Roles = "Buyer")]
        public ActionResult MakeOffer(MakeOfferCommand command)
        {
            try
            {
                var handler = new MakeOfferCommandHandler(_context);

                handler.Handle(command);

                return RedirectToAction("Index");
            }
            catch
            {
                return RedirectToAction("Error", "Home");
            }
        }
        [OrangeBricksAuthorize(Roles = "Buyer")]
        public ActionResult MyOffers()
        {
            try
            {
                var builder = new MyOffersViewModelBuilder(_context);
                var viewModel = builder.Build(User.Identity.GetUserId());

                return View(viewModel);
            }
            catch
            {
                return RedirectToAction("Error", "Home");
            }
        }

        [OrangeBricksAuthorize(Roles = "Buyer")]
        public ActionResult BookViewing(int id)
        {
            try
            {
                var builder = new BookViewingViewModelBuilder(_context);
                var viewModel = builder.Build(id, User.Identity.GetUserId());
                return View(viewModel);
            }
            catch
            {
                return RedirectToAction("Error", "Home");
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [OrangeBricksAuthorize(Roles = "Buyer")]
        public ActionResult BookViewing(BookViewingCommand command)
        {
            try
            {
                var handler = new BookViewingCommandHandler(_context);
                handler.Handle(command);
                return RedirectToAction("Index");
            }
            catch
            {
                return RedirectToAction("Error", "Home");
            }
        }

        [OrangeBricksAuthorize(Roles = "Buyer")]
        public ActionResult MyViewings()
        {
            try
            {
                var builder = new MyViewingsViewModelBuilder(_context);
                var viewModel = builder.Build(User.Identity.GetUserId());
                return View(viewModel);
            }
            catch
            {
                return RedirectToAction("Error", "Home");
            }
        }
    }
}