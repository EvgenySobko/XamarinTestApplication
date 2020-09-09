using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using SQLite;

namespace TestApp2.Entities{
    
    public class Beer{
        [PrimaryKey, AutoIncrement]
        [JsonProperty(PropertyName = "id")] public int id{ get; set; }

        [JsonProperty(PropertyName = "name")] public string name{ get; set; }

        [JsonProperty(PropertyName = "tagline")]
        public string tagline{ get; set; }

        [JsonProperty(PropertyName = "first_brewed")]
        public string first_brewed{ get; set; }

        [JsonProperty(PropertyName = "description")]
        public string description{ get; set; }

        [JsonProperty(PropertyName = "image_url")]
        public string image_url{ get; set; }

        [JsonProperty(PropertyName = "abv")] public double? abv{ get; set; }

        [JsonProperty(PropertyName = "ibu")] public double? ibu{ get; set; }

        [JsonProperty(PropertyName = "target_fg")]
        public double? target_fg{ get; set; }

        [JsonProperty(PropertyName = "target_og")]
        public double? target_og{ get; set; }

        [JsonProperty(PropertyName = "ebc")] public double? ebc{ get; set; }

        [JsonProperty(PropertyName = "srm")] public double? srm{ get; set; }

        [JsonProperty(PropertyName = "ph")] public double? ph{ get; set; }

        [JsonProperty(PropertyName = "attenuation_level")]
        public string attenuation_level{ get; set; }

        [JsonProperty(PropertyName = "brewers_tips")]
        public string brewers_tips{ get; set; }

        [JsonProperty(PropertyName = "contributed_by")]
        public string contributed_by{ get; set; }
    }
}