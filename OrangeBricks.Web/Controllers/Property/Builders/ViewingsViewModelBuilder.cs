using OrangeBricks.Web.Controllers.Property.ViewModels;
using OrangeBricks.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OrangeBricks.Web.Controllers.Property.Builders
{
    public class ViewingsViewModelBuilder
    {
        private readonly IOrangeBricksContext _context;

        public ViewingsViewModelBuilder(IOrangeBricksContext context)
        {
            _context = context;
        }

        public ViewingsViewModel Build(string buyerId)
        {
            throw new NotImplementedException();
        }
    }
}