﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace AddressBook_PS2.Models
{
    public class Address
    {
        [Display(Name = "Ulica")]
        [StringLength(60, MinimumLength = 3), Required(ErrorMessage ="Pole jest obowiązkowe")]
        public string Street { get; set; }
        [Display(Name = "Kod pocztowy")]
        public string ZipCode { get; set; }
        [Display(Name = "Miasto")]
        public string City { get; set; }
        [Display(Name = "Numer")]
        public int Number { get; set; }
    }
}
