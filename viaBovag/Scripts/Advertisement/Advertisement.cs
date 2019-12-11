using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace viaBovag
{
    public class Advertisement
    {
        public string title { get; set; }
        public string description { get; set; }
        public float price { get; set; }

        [JsonProperty("advertiser")]
        public AdvertiserJson advertiser { get; set; }
        public Vehicle vehicle { get; set; }
        
        [JsonProperty ("media")]
        public MediaRoot media { get; set; }
    }

    public class AdvertiserJson
    {
        //[JsonProperty("advertiser")]
        public Advertiser advertiser { get; set; }

    }

    public class Advertiser
    {
        //[JsonProperty("name")]
        public string name { get; set; }
        //[JsonProperty("emailAdress")]
        public string emailAdress { get; set; }

        //[JsonProperty("phoneNumber")]
        public string phoneNumber { get; set; }
    }

    public class Vehicle
    {
        public string brand { get; set; }
        public string model { get; set; }
        public int year { get; set; }
        public string vehicleRegistrationNumber { get; set; }
    }

    public class MediaRoot
    {
        public List<Media> mediaList { get; set; }
    }
    public class Media
    {
        [JsonProperty ("url")]
        public string url { get; set; }
        [JsonProperty("caption")]
        public string caption { get; set; }

    }
}
