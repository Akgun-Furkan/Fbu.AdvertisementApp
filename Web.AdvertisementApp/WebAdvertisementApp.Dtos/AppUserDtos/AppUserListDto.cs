﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.AdvertisementApp.Dtos.Interfaces;

namespace Web.AdvertisementApp.Dtos
{
    public class AppUserListDto : IDto
    {
        public int Id { get; set; }

        public string Firstname { get; set; }

        public string Surname { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public string PhoneNumber { get; set; }

        public int GenderId { get; set; }

    }
}
