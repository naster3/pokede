using System;
using System.Net;
using System.IO;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Drawing;

namespace pokedex

{
    
    
    public class Buscarpokemon
    {
        
      //  List<Listatipo> listatipos = new List<Listatipo>();
        
        //instancia del modelo.
        public PokeModel model = new PokeModel();
       
       
        public async Task Buscar( string PokemonName) {

            HttpClient client = new HttpClient();
            try
            {
               //intacia de peticion api.
                // devuelve la identificacion.
                client.BaseAddress = new Uri("https://pokeapi.co/api/v2/pokemon-species/");
                //el response.
                HttpResponseMessage response = client.GetAsync(PokemonName).Result;
                //excepcion
                response.EnsureSuccessStatusCode();
                //serializa el contenido HTTP.
                string responseBody = await response.Content.ReadAsStringAsync();
                //Deserializacion del json.
                model = JsonConvert.DeserializeObject<PokeModel>(responseBody);

                

            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            
            
    }

    }
}
