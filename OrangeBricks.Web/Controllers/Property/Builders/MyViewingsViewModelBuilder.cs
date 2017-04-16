using OrangeBricks.Web.Controllers.Property.ViewModels;
using OrangeBricks.Web.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace OrangeBricks.Web.Controllers.Property.Builders
{
    public class MyViewingsViewModelBuilder
    {
        private readonly IOrangeBricksContext _context;

        public MyViewingsViewModelBuilder(IOrangeBricksContext context)
        {
            _context = context;
        }

        public MyViewingsViewModel Build(string buyerId)
        {
            var t = from p in _context.Properties
                    from v in p.Viewings
                    where v.ViewingRequestedBy == buyerId
                    select new MyViewingViewModel
                    {
                        Id = v.Id,
                        Description = p.Description,
                        StreetName = p.StreetName,
                        PropertyId = p.Id,
                        Status = v.Status.ToString(),
                        ViewingDate = v.ViewingDate
                    };

            return new MyViewingsViewModel()
            {
                MyViewings = t.ToList()
            };
        }
    }
}