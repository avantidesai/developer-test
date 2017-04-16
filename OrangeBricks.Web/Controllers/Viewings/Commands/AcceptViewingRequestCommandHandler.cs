using OrangeBricks.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OrangeBricks.Web.Controllers.Viewings.Commands
{
    public class AcceptViewingRequestCommandHandler
    {
        private readonly IOrangeBricksContext _context;

        public AcceptViewingRequestCommandHandler(IOrangeBricksContext context)
        {
            _context = context;
        }

        public void Handle(AcceptViewingRequestCommand command)
        {
            var viewingRequest = _context.Viewings.Find(command.ViewingId);
            viewingRequest.Status = Status.Accepted;
            _context.SaveChanges();
        }
    }
}