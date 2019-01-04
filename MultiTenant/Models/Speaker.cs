using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MultiTenant.Models
{
    public class Speaker
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ImageUrl { get; set; }
        public string Website { get; set; }
        public string Bio { get; set; }
        public bool AllowHtml { get; set; }
        public int PictureId { get; set; }
        public List<Session> Sessions { get; set; }


    }
}