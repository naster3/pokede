using DocumentFormat.OpenXml.Office2013.PowerPoint.Roaming;
using pokedex.controladores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace pokedex
{
    public partial class Pokevistas : UserControl
    {
        public Pokevistas( string nombre, string imagen, DateTime fecha, List<Listatipo>tipo)
        {
            InitializeComponent();
          
                var texto = tipo.First().Name;
                Convert.ToString(texto);
                 this.tipo.Text = texto;
                this.fecha.Text = fecha.ToString();
                this.nombre.Text = nombre.ToString();
                this.imagen.LoadAsync($"https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/{imagen}.png");   
        } 
        private void Ubicacionpoke_Click(object sender, EventArgs e)
        {
            Form2 ex = new Form2();
            ex.ShowDialog();
        }
    }
}
