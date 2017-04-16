using System.Linq;
using OrangeBricks.Web.Controllers.Property.ViewModels;
using OrangeBricks.Web.Models;

namespace OrangeBricks.Web.Controllers.Property.Builders
{
    public class MyOffersViewModelBuilder
    {
        private readonly IOrangeBricksContext _context;

        public MyOffersViewModelBuilder(IOrangeBricksContext context)
        {
            _context = context;
        }

        public MyOffersViewModel Build(string buyerId)
        {
            var t = from p in _context.Properties
                    from v in p.Offers
                    where v.OfferUserId == buyerId
                    select new MyOfferViewModel
                    {
                        Id = v.Id,
                        Description = p.Description,
                        StreetName = p.StreetName,
                        Amount = v.Amount,
                        CreatedAt = v.CreatedAt,
                        PropertyType = p.PropertyType,
                        Status = v.Status.ToString()
                    };

            return new MyOffersViewModel()
            {
                MyOffers = t.ToList()
            };
        }
    }
}