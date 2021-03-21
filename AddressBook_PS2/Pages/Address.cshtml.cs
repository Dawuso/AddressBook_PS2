using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using AddressBook_PS2.Models;

namespace AddressBook_PS2.Pages
{
    public class Index1Model : PageModel
    {
        public Address Address { get; set; }
        public void OnGet()
        {
            var SessionAddress = HttpContext.Session.GetString("SessionAddress");
            if (SessionAddress != null)
                Address = JsonConvert.DeserializeObject<Address>(SessionAddress);
        }
    }
}
