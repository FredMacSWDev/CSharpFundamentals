using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_API_Challenge_W5D1
{
    //public class SuperHero
    //{
        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
        public class Powerstats
        {
            [JsonProperty("intelligence")]
            public string Intelligence { get; set; }

            [JsonProperty("strength")]
            public string Strength { get; set; }

            [JsonProperty("speed")]
            public string Speed { get; set; }

            [JsonProperty("durability")]
            public string Durability { get; set; }

            [JsonProperty("power")]
            public string Power { get; set; }

            [JsonProperty("combat")]
            public string Combat { get; set; }
        }

        public class Biography
        {
            [JsonProperty("full-name")]
            public string FullName { get; set; }

            [JsonProperty("alter-egos")]
            public string AlterEgos { get; set; }

            [JsonProperty("aliases")]
            public List<string> Aliases { get; set; }

            [JsonProperty("place-of-birth")]
            public string PlaceOfBirth { get; set; }

            [JsonProperty("first-appearance")]
            public string FirstAppearance { get; set; }

            [JsonProperty("publisher")]
            public string Publisher { get; set; }

            [JsonProperty("alignment")]
            public string Alignment { get; set; }
        }

        public class Appearance
        {
            [JsonProperty("gender")]
            public string Gender { get; set; }

            [JsonProperty("race")]
            public string Race { get; set; }

            [JsonProperty("height")]
            public List<string> Height { get; set; }

            [JsonProperty("weight")]
            public List<string> Weight { get; set; }

            [JsonProperty("eye-color")]
            public string EyeColor { get; set; }

            [JsonProperty("hair-color")]
            public string HairColor { get; set; }
        }

        public class Work
        {
            [JsonProperty("occupation")]
            public string Occupation { get; set; }

            [JsonProperty("base")]
            public string Base { get; set; }
        }

        public class Connections
        {
            [JsonProperty("group-affiliation")]
            public string GroupAffiliation { get; set; }

            [JsonProperty("relatives")]
            public string Relatives { get; set; }
        }

        public class Image
        {
            [JsonProperty("url")]
            public string Url { get; set; }
        }

        public class Root
        {
            [JsonProperty("response")]
            public string Response { get; set; }

            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("powerstats")]
            public Powerstats Powerstats { get; set; }

            [JsonProperty("biography")]
            public Biography Biography { get; set; }

            [JsonProperty("appearance")]
            public Appearance Appearance { get; set; }

            [JsonProperty("work")]
            public Work Work { get; set; }

            [JsonProperty("connections")]
            public Connections Connections { get; set; }

            [JsonProperty("image")]
            public Image Image { get; set; }
        }

    //}
}
