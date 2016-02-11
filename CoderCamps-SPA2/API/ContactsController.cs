using CoderCamps_SPA2.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CoderCamps_SPA2.API
{
    public class ContactsController : ApiController
    {
        private ApplicationDbContext db;

        public ContactsController()
        {
            this.db = new ApplicationDbContext();
        }

        public IHttpActionResult Get()
        {
            var dealId = 1;

            var data = db.DealContacts.Where(d => d.DealId == dealId).Select(c => c.Contact).ToList();

            return Ok(data);
        }

        

    }
}
