using Newtonsoft.Json;
using System.Collections.Generic;
using Newtonsoft.Json.Converters;
using System.Globalization;
using System.Drawing;
using System;

namespace pokedex
{
    public class PokeModel
    {

        //buscar pokemon.
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
        
        [JsonProperty("egg_groups")]
        public List<Listatipo> Tipo { get; set; }

        
        //lista de pokemon.



        /*  [JsonProperty("location_area_encounters")]
          public string ubicacion { get; set; }*/





    }
    public class Listatipo
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        
        
    }
    
}
