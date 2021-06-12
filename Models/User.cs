﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Webtt.Models
{
    public class User: IdentityUser
    {
        [PersonalData]
        [Column(TypeName = "nvarchar(30)")]
        public string FullName { set; get; }
    }
}
