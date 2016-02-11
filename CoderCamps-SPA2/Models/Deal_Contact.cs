using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CoderCamps_SPA2.Models
{
    public class Deal_Contact
    {
        public int Id { get; set; }
        public int DealId { get; set; }
        public int ContactId { get; set; }
        [ForeignKey("ContactId")]
        public Contact Contact { get; set; }
    }
}