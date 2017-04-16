using OrangeBricks.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OrangeBricks.Web.Controllers.Viewings.Commands
{
    public class RejectViewingRequestCommandHandler
    {
        private readonly IOrangeBricksContext _context;

        public RejectViewingRequestCommandHandler(IOrangeBricksContext context)
        {
            _context = context;
        }

        public void Handle(RejectViewingRequestCommand command)
        {
            var viewingRequest = _context.Viewings.Find(command.ViewingId);
            viewingRequest.Status = Status.Rejected;
            _context.SaveChanges();
        }
    }
}