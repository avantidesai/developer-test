using OrangeBricks.Web.Models;
using System.Collections.Generic;

namespace OrangeBricks.Web.Controllers.Property.Commands
{
    public class BookViewingCommandHandler
    {
        private readonly IOrangeBricksContext _context;

        public BookViewingCommandHandler(IOrangeBricksContext context)
        {
            _context = context;
        }

        public void Handle(BookViewingCommand command)
        {
            var property = _context.Properties.Find(command.PropertyId);

            var viewing = new Viewing
            {
                Status = Status.Pending,
               ViewingDate = command.ViewingDate,
               StartTime = command.StartTime,
               EndTime = command.EndTime,
               ViewingRequestedBy = command.ViewingUserId              
            };

            if (property.Viewings == null)
            {
                property.Viewings = new List<Viewing>();
            }

            property.Viewings.Add(viewing);

            _context.SaveChanges();
        }
    }
}