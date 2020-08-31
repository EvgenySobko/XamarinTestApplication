using System;
using System.Collections.Generic;
using Java.Util;
using Newtonsoft.Json;

namespace TestApp2.Entities{
    public class Beer{
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

        [JsonProperty(PropertyName = "volume")]
        public Volume volume{ get; set; }

        [JsonProperty(PropertyName = "food_pairing")]
        public List<string> food_pairing{ get; set; }

        [JsonProperty(PropertyName = "brewers_tips")]
        public string brewers_tips{ get; set; }

        [JsonProperty(PropertyName = "contributed_by")]
        public string contributed_by{ get; set; }

        [JsonProperty(PropertyName = "boil_volume")]
        public Volume boil_volume{ get; set; }

        [JsonProperty(PropertyName = "method")]
        public Method method{ get; set; }
    }

    public class Volume{
        [JsonProperty(PropertyName = "value")] public int value{ get; set; }

        [JsonProperty(PropertyName = "unit")] public string unit{ get; set; }
    }

    public class Method{
        [JsonProperty(PropertyName = "mash_temp")]
        public List<MashTemp> mash_temp{ get; set; }

        [JsonProperty(PropertyName = "fermentation")]
        public Fermentation fermentation{ get; set; }

        [JsonProperty(PropertyName = "twist")]
        public string? twist{ get; set; }
    }

    public class MashTemp{
        [JsonProperty(PropertyName = "temp")]
        public Volume temp{ get; set; }

        [JsonProperty(PropertyName = "duration")]
        public int? duration{ get; set; }
    }

    public class Fermentation{
        [JsonProperty(PropertyName = "temp")]
        public Volume temp{ get; set; }
    }
}