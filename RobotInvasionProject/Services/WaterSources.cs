namespace RobotInvasionProjectApi.Services
{
    public class WaterSources
    {
        public class Rootobject
        {
            public int place_id { get; set; }
            public int parent_place_id { get; set; }
            public string osm_type { get; set; }
            public int osm_id { get; set; }
            public string category { get; set; }
            public string type { get; set; }
            public int admin_level { get; set; }
            public string localname { get; set; }
            public Names names { get; set; }
            public object[] addresstags { get; set; }
            public object housenumber { get; set; }
            public string calculated_postcode { get; set; }
            public string country_code { get; set; }
            public DateTime indexed_date { get; set; }
            public float importance { get; set; }
            public float calculated_importance { get; set; }
            public Extratags extratags { get; set; }
            public string calculated_wikipedia { get; set; }
            public int rank_address { get; set; }
            public int rank_search { get; set; }
            public bool isarea { get; set; }
            public Centroid centroid { get; set; }
            public Geometry geometry { get; set; }
            public Address[] address { get; set; }
        }

        public class Names
        {
            public string name { get; set; }
        }

        public class Extratags
        {
            public string tidal { get; set; }
            public string water { get; set; }
            public string wikidata { get; set; }
            public string wikipedia { get; set; }
        }

        public class Centroid
        {
            public string type { get; set; }
            public float[] coordinates { get; set; }
        }

        public class Geometry
        {
            public string type { get; set; }
            public float[][][] coordinates { get; set; }
        }

        public class Address
        {
            public string localname { get; set; }
            public int? place_id { get; set; }
            public int? osm_id { get; set; }
            public string osm_type { get; set; }
            public string place_type { get; set; }
            public string _class { get; set; }
            public string type { get; set; }
            public int? admin_level { get; set; }
            public int rank_address { get; set; }
            public float distance { get; set; }
            public bool isaddress { get; set; }
        }

    }
}
