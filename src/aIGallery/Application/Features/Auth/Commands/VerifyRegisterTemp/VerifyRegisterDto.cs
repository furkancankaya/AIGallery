﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Auth.Commands.VerifyRegisterTemp;
public class VerifyRegisterDto
{
    public string Email { get; set; }
    public int Otp { get; set; }
}
