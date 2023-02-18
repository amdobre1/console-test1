using System;

namespace HypoplusToDwhExporter.Entities
{
#pragma warning disable IDE1006 // Naming Styles
    public class referrer
    {
        public string address { get; set; }
        public string comment { get; set; }
        public string comment_commission_share { get; set; }
        public string contact { get; set; }
        public string contact_internal { get; set; }
        public string create_user { get; set; }
        public string email { get; set; }
        public string name { get; set; }
        public string phone { get; set; }
        public string update_user { get; set; }
        public string domains { get; set; }
        public string refkeys { get; set; }
        public DateTime? create_timestamp { get; set; }
        public DateTime? update_timestamp { get; set; }
        public bool? commission_share { get; set; }
        public int? id { get; set; }
        public int? referrer_category { get; set; }
        public int? status { get; set; }
        public int? version { get; set; }
    }
#pragma warning restore IDE1006 // Naming Styles
}
