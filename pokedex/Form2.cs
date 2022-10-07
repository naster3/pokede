using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
namespace pokedex
{
    public partial class Form2 : Form
    {
        GMarkerGoogle marker;
        GMapOverlay mapOverlay;
        DataTable dt;

        //ruta automatizada(direccion)
         bool trazarruta = false;
         int contadorindicadoresruta = 0;
        PointLatLng inicio;
        PointLatLng final;
         int filaseleccionada = 0;
        readonly double latinicial = 20.9688132813906;
        readonly double lnginicial = -89.6250915527344;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            dt = new DataTable();
            dt.Columns.Add(new DataColumn("Descrpcion",typeof(string)));
            dt.Columns.Add(new DataColumn("Lat", typeof(double)));
            dt.Columns.Add(new DataColumn("Long", typeof(double)));
            //insertarndo datos al dt para mostrar en la lista
            dt.Rows.Add("ubicacion", latinicial, lnginicial);
            dataGridView1.DataSource = dt;
            //desactivar datos al dt para mostrar en la lista
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].Visible = false;

            //creando las dimensones del GMAPCONTROL(herramienta)
            gMapControl1.DragButton = MouseButtons.Left;
            gMapControl1.CanDragMap = true;
            gMapControl1.MapProvider = GMapProviders.GoogleMap;
            gMapControl1.Position = new PointLatLng(latinicial, lnginicial);
            gMapControl1.MinZoom = 0;
            gMapControl1.MaxZoom = 24;
            gMapControl1.Zoom = 9;
            gMapControl1.AutoScroll = true;

            //marcador
            mapOverlay = new GMapOverlay("marcador");
            marker = new GMarkerGoogle(new PointLatLng(latinicial, lnginicial), GMarkerGoogleType.green);
            mapOverlay.Markers.Add(marker);//agregamos el mapa

            //agregamos un tooltip de texto a los marcadores
            marker.ToolTipMode = MarkerTooltipMode.Never;
            marker.ToolTipText = string.Format("ubicacion:\n latitud:{0}\n longitud:{1}", latinicial, lnginicial);

            //ahora agregamos el mapa y el marcador al control map
            gMapControl1.Overlays.Add(mapOverlay);

        }

        private void DataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            filaseleccionada = e.RowIndex;// Fila seleccionda
            //recuperamos los datos del grid y los asignamos a los texbox
            txtdescripcion.Text = dataGridView1.Rows[filaseleccionada].Cells[0].Value.ToString();
            txtlatitud.Text = dataGridView1.Rows[filaseleccionada].Cells[1].Value.ToString();
            txtlongitud.Text = dataGridView1.Rows[filaseleccionada].Cells[2].Value.ToString();
            //se asignan los valores del grid al marcador
            marker.Position = new PointLatLng(Convert.ToDouble(txtlatitud.Text), Convert.ToDouble(txtlongitud.Text));
            //se posiciona el foco del mapa en ese punto
            marker.Position = marker.Position;
        }

        private void DataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ////se obtiene los datos de lat lng del mapa donde usuario presiono
            //double lat = gMapControl1.FromLocalToLatLng(e.X, e.Y).Lat;
            //double lng = gMapControl1.FromLocalToLatLng(e.X, e.Y).Lng;

            ////se posicionan en el txt de la latitud y longitud
            //txtlatitud.Text = lat.ToString();
            //txtlongitud.Text = lng.ToString();
            ////creamos el marcador para moverlo al lugar indicado por el usuario
            //marker.Position = new PointLatLng(lat, lng);
            ////tmabien se agregara el mensaje al marcador es decir el tooltip
            //marker.ToolTipText = string.Format("ubicacion:\n latitud:{0}\n longitud:{1}", lat, lng);
        }

        private void GMapControl1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            double lat = gMapControl1.FromLocalToLatLng(e.X, e.Y).Lat;
            double lng = gMapControl1.FromLocalToLatLng(e.X, e.Y).Lng;

            //se posicionan en el txt de la latitud y longitud
            txtlatitud.Text = lat.ToString();
            txtlongitud.Text = lng.ToString();
            //creamos el marcador para moverlo al lugar indicado por el usuario
            marker.Position = new PointLatLng(lat, lng);
            //tmabien se agregara el mensaje al marcador es decir el tooltip
            marker.ToolTipText = string.Format("ubicacion:\n latitud:{0}\n longitud:{1}", lat, lng);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                dt.Rows.Add(txtdescripcion.Text, txtlatitud.Text, txtlongitud.Text);//agregar a la tabla
            }
            catch (Exception w)
            {
                MessageBox.Show(w.Message, "valor de ruta incorrecto");
            }
                //procedimiento para insertar a una base de datos sql
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.Rows.RemoveAt(filaseleccionada);//remover de la tabla
                                                              //procedimiento para eliminar datos de una base de datos sin sql
            }catch(Exception w)
            {
                MessageBox.Show(w.Message, "no puede eliminar una fila vacia");
            }
            }

        private void Button3_Click(object sender, EventArgs e)
        {
            GMapOverlay poligono = new GMapOverlay("poligono");
            List<PointLatLng> puntos = new List<PointLatLng>();
            //variable para almacenar los datos
            double lng, lat;
            //agregamos lps datos del grid
            
            for(int filas=0;filas<dataGridView1.Rows.Count; filas++ ) {
                lat = Convert.ToDouble(dataGridView1.Rows[filas].Cells[1].Value);
                lng = Convert.ToDouble(dataGridView1.Rows[filas].Cells[2].Value);
                puntos.Add(new PointLatLng(lat, lng));
            }
            GMapPolygon poligonospuntos = new GMapPolygon(puntos, "poligonos");
            poligono.Polygons.Add(poligonospuntos);
            gMapControl1.Overlays.Add(poligono);
            //actualizara el mapa
            gMapControl1.Zoom++;
            gMapControl1.Zoom--;

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            GMapOverlay ruta = new GMapOverlay("CapaRuta");
            List<PointLatLng> puntos = new List<PointLatLng>();
            //variables para almacenar los datos
            double lng, lat;
            //agregamos los datos del grid
            for (int filas = 0; filas < dataGridView1.Rows.Count; filas++)
            {
                lat = Convert.ToDouble(dataGridView1.Rows[filas].Cells[1].Value);
                lng = Convert.ToDouble(dataGridView1.Rows[filas].Cells[2].Value);
                puntos.Add(new PointLatLng(lat, lng));
            }
            GMapRoute puntosruta = new GMapRoute(puntos, "Ruta");
            ruta.Routes.Add(puntosruta);
            gMapControl1.Overlays.Add(ruta);

            //actualizar el mapa
            gMapControl1.Zoom++;
            gMapControl1.Zoom--;

        }
        public void Creardirecciontrazarruta(double lat, double lng)
        {
            if (trazarruta)
            {
                switch (contadorindicadoresruta)
                {
                    case 0://primer marcador de inicio
                        contadorindicadoresruta++;
                        inicio = new PointLatLng(lat, lng);
                        break;
                    case 1://segundo marcador o final
                        contadorindicadoresruta++;
                        final = new PointLatLng(lat, lng);
                        GDirections direccion;
                        _ = GMapProviders.GoogleMap.GetDirections(out direccion, inicio, final, false, false, false, false, false);
                        GMapRoute rutaobtenida = new GMapRoute(direccion.Route, "ruta ubicacion");
                        GMapOverlay caparutas = new GMapOverlay("capa de la ruta");
                        caparutas.Routes.Add(rutaobtenida);
                        gMapControl1.Overlays.Add(caparutas);
                        gMapControl1.Zoom--;
                        gMapControl1.Zoom++;
                        contadorindicadoresruta = 0;
                        trazarruta = false;
                            break;
                }
            }
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            gMapControl1.MapProvider = GMapProviders.GoogleChinaSatelliteMap;
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            gMapControl1.MapProvider=GMapProviders.GoogleMap;
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            gMapControl1.MapProvider= GMapProviders.GoogleTerrainMap;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            trackBar1.Value = Convert.ToInt32(gMapControl1.Zoom);
        }

        private void TrackBar1_Scroll(object sender, EventArgs e)
        {
            gMapControl1.Zoom = trackBar1.Value;
        }
    }
}
