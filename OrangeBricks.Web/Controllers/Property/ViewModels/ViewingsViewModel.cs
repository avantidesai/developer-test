using OrangeBricks.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OrangeBricks.Web.Controllers.Property.ViewModels
{
    public class ViewingsViewModel
    {
        public List<ViewingViewModel> Viewings { get;set;}
    }

    public class ViewingViewModel
    {
        public int Id { get; set; }

        public DateTime ViewingDateTime { get; set; }

        public Status Status { get; set; }

        public int Property_Id { get; set; }

        public string ViewingRequestedBy { get; set; }
    }

}