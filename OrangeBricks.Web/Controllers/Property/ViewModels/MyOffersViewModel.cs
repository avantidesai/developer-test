using OrangeBricks.Web.Controllers.Offers.ViewModels;
using System;
using System.Collections.Generic;

namespace OrangeBricks.Web.Controllers.Property.ViewModels
{
    public class MyOffersViewModel
    {
        public List<MyOfferViewModel> MyOffers { get; set; }
    }

    public class MyOfferViewModel
    {
        public int Id { get; set; }
        public string PropertyType { get; set; }
        public string StreetName { get; set; }
        public string Description { get; set; }
        public int Amount { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Status { get; set; }
    }
}