using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OrangeBricks.Web.Controllers.Property.ViewModels
{
    public class MyViewingsViewModel
    {
        public List<MyViewingViewModel> MyViewings { get; set; }
    }

    public class MyViewingViewModel
    {
        public int Id { get; set; }
        public int PropertyId { get; set; }
        public string PropertyType { get; set; }
        public string StreetName { get; set; }
        public string Description { get; set; }
        public int Amount { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Status { get; set; }

        public DateTime ViewingDate { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
    }
}