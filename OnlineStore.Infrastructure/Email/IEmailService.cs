﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnlineStore.Infrastructure.Email
{
    public interface IEmailService
    {
        void SendMail(string from, string to, string subject, string body);
    }
}