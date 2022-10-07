using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Data.SqlClient;
using DocumentFormat.OpenXml.Bibliography;
using Newtonsoft.Json;

namespace pokedex
{
    public partial class Historial : UserControl
    {
        private readonly dbpokemonEntities2 conexion = new dbpokemonEntities2();
     
        // private readonly BindingList<pokemon> Persons = new BindingList<pokemon>();

        public Historial( )
        {
            InitializeComponent();
        }
        private void Historial_Load(object sender, EventArgs e)
        {
            
            try
            {
                pokemonBindingSource.DataSource = conexion.pokemon.ToList();
               // dataGridView1.DataSource = conexion.leerpokemones();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
       public void Verhistorial()
        {
            pokemonBindingSource.DataSource= conexion.pokemon.ToList();
        }
        
        private void Button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            int idpokemon = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            try
            {
                conexion.modificarpokemones(nom: form1.PokeNombreTxtBox1.Text, fe: form1.Fecha, idpokemon, ti: form1.PokeNombreTxtBox1.Text, pa: form1.PokeNombreTxtBox1.Text);
                dataGridView1.DataSource = conexion.pokemon.ToList();
                form1.Limpiar();
                MessageBox.Show("producto insertado");
            }
            catch (Exception w)
            {
                MessageBox.Show(w.Message, "no se pudo insertar los datos");
            } 
            
           // pokemonBindingSource.DataSource.ToString();
        }

        private void Boton_borrar_historial_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            try
            {
                  
                int idpokemon = Convert.ToInt32( dataGridView1.CurrentRow.Cells[0].Value);
                conexion.eliminarpokemones(idpokemon);
                MessageBox.Show("pokemon eliminado");
                dataGridView1.DataSource=conexion.pokemon.ToList();
                form1.Limpiar();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void Exportar_html_Click(object sender, EventArgs e)
        { 
            Convertirhtml();
        }
        public void Convertirhtml()
        {
            //Table start.
            string html = "<table cellpadding='5' cellspacing='0' style='border: 1px solid #ccc;font-size: 9pt;font-family:arial'>";

            //Adding HeaderRow.
            html += "<tr>";
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                html += "<th style='background-color: #B8DBFD;border: 1px solid #ccc'>" + column.HeaderText + "</th>";
            }
            html += "</tr>";

            //Adding DataRow.
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                html += "<tr>";
                foreach (DataGridViewCell cell in row.Cells)
                {
                    html += "<td style='width:120px;border: 1px solid #ccc'>" + cell.Value.ToString() + "</td>";
                }
                html += "</tr>";
            }

            //Table end.
            html += "</table>";

            File.WriteAllText(@"C:\Users\Escuela\Documents\DataGridView.htm", html);
            MessageBox.Show("archivo creado");
        }
        private void Exportar_csv_Click(object sender, EventArgs e)
        {
            Convertircsv();
        }
        public void Convertircsv()
        {

            var sb = new StringBuilder();

            var headers = dataGridView1.Columns.Cast<DataGridViewColumn>();
           sb.AppendLine(string.Join(",", headers.Select(column => "\"" + column.HeaderText + "\"").ToArray()));
            

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                var cells = row.Cells.Cast<DataGridViewCell>();
                sb.AppendLine(string.Join(",", cells.Select(cell => "\"" + cell.Value + "\"").ToArray()));
            }
            File.WriteAllText(@"C:\Users\Escuela\Documents\datagridview.csv", sb.ToString());
            MessageBox.Show("archivo creado");
        }

        private void Exportar_txt_Click(object sender, EventArgs e)
        {  
            Convertirtxt();
        }
        public void Convertirtxt()
        {
            System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\\Users\\Escuela\\Documents\\sample.txt");
            try
            {
                string sLine = "";

                //This for loop loops through each row in the table
                for (int r = 0; r <= dataGridView1.Rows.Count - 1; r++)
                {
                    //This for loop loops through each column, and the row number
                    //is passed from the for loop above.
                    for (int c = 0; c <= dataGridView1.Columns.Count - 1; c++)
                    {
                        sLine += dataGridView1.Rows[r].Cells[c].Value;
                        if (c != dataGridView1.Columns.Count - 1)
                        {
                            //A comma is added as a text delimiter in order
                            //to separate each field in the text file.
                            //You can choose another character as a delimiter.
                            sLine += ",";
                        }
                    }
                    //The exported text is written to the text file, one line at a time.
                    file.WriteLine(sLine);
                    sLine = "";
                }

                file.Close();
                System.Windows.Forms.MessageBox.Show("Export Complete.", "Program Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (System.Exception err)
            {
                System.Windows.Forms.MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                file.Close();
            }
        
    }   

        private void Boton_guardar_historial_Click(object sender, EventArgs e)
        {
            Convertircsv();
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
           Form1 form1 = new Form1();
           
            if (dataGridView1.CurrentRow.Cells[1].Value!=null)
            {
                form1.PokeNombreTxtBox1.Text= dataGridView1.CurrentRow.Cells[1].Value.ToString();
                form1.PokeNombreTxtBox1.Text=  dataGridView1.CurrentRow.Cells[2].Value.ToString();
                form1.PokeNombreTxtBox1.Text =   dataGridView1.CurrentRow.Cells[3].Value.ToString();
               // form1.PokeNombreTxtBox1.Text= dataGridView1.CurrentRow.Cells[4].Value.ToString();
                //form1.PokeNombreTxtBox1.Text=dataGridView1.CurrentRow.Cells[5].Value.ToString();  
            }
            else
            { 
                form1.Limpiar();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
