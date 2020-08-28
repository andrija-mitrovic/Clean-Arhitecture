﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CleanArhitecture.Core.Interfaces
{
    public interface IEmailSender
    {
        Task SendEmailAsync(string to, string from, string subject, string body);
    }
}
