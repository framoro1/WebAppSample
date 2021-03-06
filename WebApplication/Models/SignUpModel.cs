﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication.Models.Entities;

namespace WebApplication.Models
{
    public class SignUpModel : BaseModel
    {
        public string LabelSignUp { get; set; }
        public string LabelUsername { get; set; }
        public string LabelName { get; set; }
        public string LabelPassword { get; set; }
        public string LabelConfirmPassword { get; set; }
        public string LabelEmail { get; set; }
        public string LabelButtonSend { get; set; }

        public User User { get; set; }
        public string ConfirmPassword { get; set; }

        public string ErrorMessage { get; set; }
    }
}