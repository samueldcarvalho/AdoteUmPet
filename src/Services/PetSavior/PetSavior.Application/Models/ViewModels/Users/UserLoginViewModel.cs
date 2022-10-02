﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetSavior.Application.Models.ViewModels.Users
{
    public class UserLoginViewModel
    {
        public string Token { get; private set; }
        public UserToken UserToken { get; private set; }

        public UserLoginViewModel(string token, string email, string name, int id)
        {
            Token = token;
            UserToken = new UserToken(id, name, email);
        }
    }
}
