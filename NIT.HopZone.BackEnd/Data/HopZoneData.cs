using System;
using System.Collections.Generic;
using MongoDB.Bson;
using NIT.HopZone.Web.Models;

namespace NIT.HopZone.BackEnd.Data
{
    public class HopZoneData
    {

        private List<Admin> _admins = new List<Admin>();

        public HopZoneData()
        {
            _admins.Add(new Admin
            {
                Id = ObjectId.GenerateNewId(),
                FirstName = "Irhad",
                LastName = "Fejzic",
                Password = "12345",
                Email = "irhad.fejzic@gmail.com",
                CreatedOn = System.DateTime.Now,
                UpdatedOn = System.DateTime.Now
            });
        }

        public Admin AddAdmin(Admin admin)
        {
            admin.Id = ObjectId.GenerateNewId();
            _admins.Add(admin);
            return admin;
        }
    }
}
