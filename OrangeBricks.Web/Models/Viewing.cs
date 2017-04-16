using System;
using System.ComponentModel.DataAnnotations;

namespace OrangeBricks.Web.Models
{
    public class Viewing
    {
        [Key]
        public int Id { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime ViewingDate { get; set; }

       
        public Status Status { get; set; }      
        public string ViewingRequestedBy { get; set; }
    }
}