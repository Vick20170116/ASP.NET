﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TestCore2.Models
{
    public class UserModel
    {
        [Required]
        public int Id { get; set; }

        [RegularExpression(@"\w+")]
        [StringLength(20, MinimumLength = 4)]
        public string Name { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [Phone]
        public string PhoneNumber { get; set; }

        [StringLength(200)]
        public string Address { get; set; }

        [DataType(DataType.Date)]
        [AgeCheck(18, 120)]
        public DateTime BirthDate { get; set; }
    }
}
