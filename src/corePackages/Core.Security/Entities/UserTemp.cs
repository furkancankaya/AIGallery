﻿using Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Security.Entities;
public class UserTemp : Entity<Guid>
{
    public string Email { get; set; }
    public int OTP { get; set; }

    public UserTemp()
    {
        OTP = 0;
        Email = string.Empty;
    }
}
