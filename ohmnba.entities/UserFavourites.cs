using MongoORM4NetCore.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace ohmnba.entities
{
    public class UserFavourites : DbObjectSD
    {
        public string DeviceID { get; set; }

        public ICollection<string> TeamCodes { get; set; }
    }



}
