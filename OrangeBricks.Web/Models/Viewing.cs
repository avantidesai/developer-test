using System;
using System.ComponentModel.DataAnnotations;

namespace OrangeBricks.Web.Models
{
    public class Viewing
    {
        [Key]
        public int Id { get; set; }

        [DataType(DataType.Date)]
        public DateTime ViewingDate { get; set; }

        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public Status Status { get; set; }      
        public string ViewingRequestedBy { get; set; }
    }
}