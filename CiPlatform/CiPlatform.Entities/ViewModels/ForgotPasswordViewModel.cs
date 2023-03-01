﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CiPlatform.Entities.ViewModels
{
    public class ForgotPasswordViewModel
    {

        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}