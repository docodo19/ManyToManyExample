using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CoderCamps_SPA2.Models
{
    public class Contact
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }

        public int CompanyId { get; set; }
        [ForeignKey("CompanyId")]
        public Company Company { get; set; }

      

    }
}