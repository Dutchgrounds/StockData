﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stocks.Data.Entities
{
    public class AppRole : IdentityRole<int>
    {
        public List<AppUser> Users { get; set; } = null!;
    }
}
