using MongoORM4NetCore.Interfaces;

namespace ohmnba.entities
{
    public class Team : DbObjectSD
    {
        public string AltCityName { get; set; }
        public long TeamId { get; set; }
        public string UrlName { get; set; }
        public string Nickname { get; set; }
        public bool IsAllStar { get; set; }
        public string DivName { get; set; }
        public string TeamShortName { get; set; }
        public string Tricode { get; set; }
        public string ConfName { get; set; }
        public bool IsNbaFranchise { get; set; }
        public string FullName { get; set; }
        public string City { get; set; }
    }



}
