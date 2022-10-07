
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pokedex
{
    public partial class Form1 : Form
    {
        private readonly DateTime fecha;
        readonly Buscarpokemon Buscar = new Buscarpokemon();
        readonly Historial dataGridView1;
        private readonly dbpokemonEntities2 conexion = new dbpokemonEntities2();

        public DateTime Fecha => fecha;

        public Form1()
        {
            InitializeComponent();
            fecha = DateTime.Now;
            dataGridView1 = new Historial();

        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }
       
       private void Cargargrid()
        {
            try
            {
                flowLayoutPanel1.Controls.Clear();
                _ = Buscar.Buscar(PokeNombreTxtBox.Text.ToLower());
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            Limpiar();
            try
            {
                flowLayoutPanel1.Controls.Add(new Pokevistas(nombre: Buscar.model.Name, imagen: Buscar.model.Id, Fecha, tipo: Buscar.model.Tipo));
            }
            catch { }
                    
                
                
                
              
        }
        public void Cargartabala()
        {
            flowLayoutPanel1.Controls.Clear();
             _=Buscar.Buscar(PokeNombreTxtBox.Text.ToLower());

            dataGridView1.Verhistorial();
            try
            {
                conexion.insertarpokemones(id: Convert.ToInt32(PokeNombreTxtBox.Text), nom: PokeNombreTxtBox.Text = Buscar.model.Name, Fecha, ti: PokeNombreTxtBox.Text, pa: PokeNombreTxtBox.Text);
            }catch (Exception)
            {

            }
            flowLayoutPanel1.Controls.Add(dataGridView1 as Historial);
            Limpiar();
        }
        public void Limpiar()
        {
            PokeNombreTxtBox.Text = "";   
        }
       
        private void Button1_Click(object sender, EventArgs e)
        { 
            Cargargrid();
        }
        private void Boton_ver_historial_Click(object sender, EventArgs e)
        {
            Cargartabala(); 
        }
    }

    
}
