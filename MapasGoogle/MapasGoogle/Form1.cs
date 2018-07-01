using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using Microsoft.VisualBasic;

using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;

using System.Runtime.InteropServices;

namespace MapasGoogle
{
    public partial class Form1 : Form
    {


        [DllImport("C:\\Users\\Mario Flores JR\\Documents\\TrabajosEstructuraDatos1\\TrabajosEstructuraDatos1\\Airport_DLL_BACKEND\\Debug\\Airport_DLL_BACKEND.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void Creat_Airport(string name, double lat, double lon);


        [DllImport("C:\\Users\\Mario Flores JR\\Documents\\TrabajosEstructuraDatos1\\TrabajosEstructuraDatos1\\Airport_DLL_BACKEND\\Debug\\Airport_DLL_BACKEND.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void Read_Airport(StringBuilder buff, int pos);

        [DllImport("C:\\Users\\Mario Flores JR\\Documents\\TrabajosEstructuraDatos1\\TrabajosEstructuraDatos1\\Airport_DLL_BACKEND\\Debug\\Airport_DLL_BACKEND.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern int Lenght_File();

        [DllImport("C:\\Users\\Mario Flores JR\\Documents\\TrabajosEstructuraDatos1\\TrabajosEstructuraDatos1\\Airport_DLL_BACKEND\\Debug\\Airport_DLL_BACKEND.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void Delete_Airport(string name);

        [DllImport("C:\\Users\\Mario Flores JR\\Documents\\TrabajosEstructuraDatos1\\TrabajosEstructuraDatos1\\Airport_DLL_BACKEND\\Debug\\Airport_DLL_BACKEND.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void Update_Airport(string name, string Nname, double lat, double lon);

        [DllImport("C:\\Users\\Mario Flores JR\\Documents\\TrabajosEstructuraDatos1\\TrabajosEstructuraDatos1\\Airport_DLL_BACKEND\\Debug\\Airport_DLL_BACKEND.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern bool Exist_Airport(string name);

        [DllImport("C:\\Users\\Mario Flores JR\\Documents\\TrabajosEstructuraDatos1\\TrabajosEstructuraDatos1\\Airport_DLL_BACKEND\\Debug\\Airport_DLL_BACKEND.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern int Create_route(string id, string route);

        [DllImport("C:\\Users\\Mario Flores JR\\Documents\\TrabajosEstructuraDatos1\\TrabajosEstructuraDatos1\\Airport_DLL_BACKEND\\Debug\\Airport_DLL_BACKEND.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void Read_Route(StringBuilder buff, int pos);

        [DllImport("C:\\Users\\Mario Flores JR\\Documents\\TrabajosEstructuraDatos1\\TrabajosEstructuraDatos1\\Airport_DLL_BACKEND\\Debug\\Airport_DLL_BACKEND.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void Delete_Route(string id, string rou);

        [DllImport("C:\\Users\\Mario Flores JR\\Documents\\TrabajosEstructuraDatos1\\TrabajosEstructuraDatos1\\Airport_DLL_BACKEND\\Debug\\Airport_DLL_BACKEND.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void Update_Route(string id, string rou, string rouN);

        [DllImport("C:\\Users\\Mario Flores JR\\Documents\\TrabajosEstructuraDatos1\\TrabajosEstructuraDatos1\\Airport_DLL_BACKEND\\Debug\\Airport_DLL_BACKEND.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern int Length_R();

        [DllImport("C:\\Users\\Mario Flores JR\\Documents\\TrabajosEstructuraDatos1\\TrabajosEstructuraDatos1\\Airport_DLL_BACKEND\\Debug\\Airport_DLL_BACKEND.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void Update_IDroute(string id, string Nid);

        [DllImport("C:\\Users\\Mario Flores JR\\Documents\\TrabajosEstructuraDatos1\\TrabajosEstructuraDatos1\\Airport_DLL_BACKEND\\Debug\\Airport_DLL_BACKEND.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void Delete_allIDRoutes(string id);

        [DllImport("C:\\Users\\Mario Flores JR\\Documents\\TrabajosEstructuraDatos1\\TrabajosEstructuraDatos1\\Airport_DLL_BACKEND\\Debug\\Airport_DLL_BACKEND.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void Read_IDroutes(StringBuilder buff, int pos);

        [DllImport("C:\\Users\\Mario Flores JR\\Documents\\TrabajosEstructuraDatos1\\TrabajosEstructuraDatos1\\Airport_DLL_BACKEND\\Debug\\Airport_DLL_BACKEND.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void Creat_IDroutes(string org, string des, int dis);

        [DllImport("C:\\Users\\Mario Flores JR\\Documents\\TrabajosEstructuraDatos1\\TrabajosEstructuraDatos1\\Airport_DLL_BACKEND\\Debug\\Airport_DLL_BACKEND.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern int Lenght_IDroutes();

        [DllImport("C:\\Users\\Mario Flores JR\\Documents\\TrabajosEstructuraDatos1\\TrabajosEstructuraDatos1\\Airport_DLL_BACKEND\\Debug\\Airport_DLL_BACKEND.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void getID(StringBuilder buff, string nombre);

        [DllImport("C:\\Users\\Mario Flores JR\\Documents\\TrabajosEstructuraDatos1\\TrabajosEstructuraDatos1\\Airport_DLL_BACKEND\\Debug\\Airport_DLL_BACKEND.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern double getLat(string id);

        [DllImport("C:\\Users\\Mario Flores JR\\Documents\\TrabajosEstructuraDatos1\\TrabajosEstructuraDatos1\\Airport_DLL_BACKEND\\Debug\\Airport_DLL_BACKEND.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern double getLon(string id);

        [DllImport("C:\\Users\\Mario Flores JR\\Documents\\TrabajosEstructuraDatos1\\TrabajosEstructuraDatos1\\Airport_DLL_BACKEND\\Debug\\Airport_DLL_BACKEND.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern int getDist(string org, string dest);

        [DllImport("C:\\Users\\Mario Flores JR\\Documents\\TrabajosEstructuraDatos1\\TrabajosEstructuraDatos1\\Airport_DLL_BACKEND\\Debug\\Airport_DLL_BACKEND.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void Delete_IDRoutes(string id);

        GMapOverlay Routes;
        int[,] matrizAdyacencia;
        string s = "";

        DataTable dt;

        DataTable dt2;

        DataTable dt3;

        int filaSeleccionada = 0;
        int filaSelec = 0;
        double LatInicial = 15.561373;
        double LngInicial = -88.0243623;

        

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void gMapControl1_Load(object sender, EventArgs e)
        {
            dt = new DataTable();
            dt.Columns.Add(new DataColumn("Descripcion", typeof(string)));
            dt.Columns.Add(new DataColumn("Lat", typeof(double)));
            dt.Columns.Add(new DataColumn("Lng", typeof(double)));

            dt2 = new DataTable();
            dt2.Columns.Add(new DataColumn("ID", typeof(string)));
            dt2.Columns.Add(new DataColumn("Route", typeof(string)));

            dt3 = new DataTable();
            dt3.Columns.Add(new DataColumn("Routes", typeof(string)));

            dataGridView3.DataSource = dt3;
            dataGridView2.DataSource = dt2;

            //dt.Rows.Add("Ubicacion1", LatInicial, LngInicial);
            dataGridView1.DataSource = dt;

            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].Visible = false;

            dataGridView2.Columns[0].Visible = false;


            gMapControl1.DragButton = MouseButtons.Left;
            gMapControl1.CanDragMap = true;
            gMapControl1.MapProvider = GMapProviders.GoogleMap;
            gMapControl1.Position = new PointLatLng(LatInicial, LngInicial);
            gMapControl1.MinZoom = 0;
            gMapControl1.MaxZoom = 24;
            gMapControl1.Zoom = 9;
            gMapControl1.AutoScroll = true;

            ////marcador
            //markerOverlay = new GMapOverlay("marker");
            //marker = new GMarkerGoogle(new PointLatLng(LatInicial, LngInicial), GMarkerGoogleType.green);
            //markerOverlay.Markers.Add(marker);

            ////tooltip
            ////marker.ToolTipMode = MarkerTooltipMode.Always;
            //marker.ToolTipText = string.Format("Ubicacion: \n Latitud: {0} \n Longitud: {1}", LatInicial, LngInicial);
            //gMapControl1.Overlays.Add(markerOverlay);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Char delimit = ';';
            matrizAdyacencia = new int[Lenght_File(), Lenght_File()];

            for (int i = 0; i < Lenght_File(); i++)
            {
                for (int x = 0; x < Lenght_File(); x++)
                {
                    matrizAdyacencia[i, x] = 0;
                }
            }


            for (int i = 0; i < Lenght_File(); i++)
            {
                StringBuilder st = new StringBuilder(1000);
                Read_Airport(st, (i + 1));
                String[] elements = st.ToString().Split(delimit);

                dt.Rows.Add(elements[0], elements[1], elements[2]);

            }

            for (int i = 0; i < Length_R(); i++)
            {
                StringBuilder stb = new StringBuilder(1000);
                Read_Route(stb, (i + 1));
                String[] a = stb.ToString().Split(';');

                dt2.Rows.Add(a[0], a[1]);
            }

            for (int i = 0; i < Lenght_File(); i++)
            {
                double lat = Convert.ToDouble(dataGridView1.Rows[i].Cells[1].Value.ToString());
                double lon = Convert.ToDouble(dataGridView1.Rows[i].Cells[2].Value.ToString());

                GMarkerGoogle marker = new GMarkerGoogle(new PointLatLng(lat, lon), GMarkerGoogleType.blue_pushpin); ;
                GMapOverlay markerOverlay = new GMapOverlay("marker");


                markerOverlay.Markers.Add(marker);

                //tooltip
                //marker.ToolTipMode = MarkerTooltipMode.Always;
                marker.ToolTipText = string.Format("Ubicacion: \n Latitud: {0} \n Longitud: {1}", lat, lon);
                gMapControl1.Overlays.Add(markerOverlay);


            }

            for (int i = 0; i < Lenght_IDroutes(); i++)
            {
                int x, y;

                int dis;

                StringBuilder st = new StringBuilder(1000);
                Read_IDroutes(st, (i + 1));

                string[] elements = st.ToString().Split(delimit);
                dis = Convert.ToInt16(elements[2].ToString());

                StringBuilder st1 = new StringBuilder(1000);
                StringBuilder st2 = new StringBuilder(1000);

                getID(st1, elements[0]);
                getID(st2, elements[1]);

                matrizAdyacencia[PosIDname(st1.ToString()), PosIDname(st2.ToString())] = dis;
            }

            for (int i = 0; i < Lenght_IDroutes(); i++)
            {
                StringBuilder st = new StringBuilder(1000);
                Read_IDroutes(st, (i + 1));
                dt3.Rows.Add(st.ToString());
            }
            //for(int i = 0; i < Lenght_IDroutes(); i++)
            //{
            //    StringBuilder st = new StringBuilder(1000);
            //    Read_IDroutes(st, (i + 1));
            //    String[] elements = st.ToString().Split(delimit);

                //    StringBuilder st2 = new StringBuilder(1000);
                //    StringBuilder st3 = new StringBuilder(1000);


                //    getID(st2, elements[0]);
                //    getID(st3, elements[1]);

                //    Routes = new GMapOverlay(st.ToString());
                //    List<PointLatLng> l = new List<PointLatLng>();
                //    l.Add(new PointLatLng(getLat(st2.ToString()), getLon(st2.ToString())));
                //    l.Add(new PointLatLng(getLat(st3.ToString()), getLon(st3.ToString())));
                //    GMapRoute rou = new GMapRoute(l, st.ToString());
                //    rou.Stroke = new Pen(Color.Red, 3);
                //    Routes.Routes.Add(rou);
                //}
                // Routes = new GMapOverlay("rutas");
                // List<PointLatLng>abc= new List<PointLatLng>();
                // abc.Add(puntos[0]);
                // abc.Add(puntos[1]);
                //GMapRoute rou = new GMapRoute(abc, "Mi ruta");
                // rou.Stroke = new Pen(Color.Red, 3);

                // Routes.Routes.Add(rou);




                //List<PointLatLng> abcd = new List<PointLatLng>();
                //abcd.Add(puntos[2]);
                //abcd.Add(puntos[3]);
                // GMapRoute r = new GMapRoute(abcd,"Ru");
                // r.Stroke = new Pen(Color.Red, 3);
                // Routes.Routes.Add(r);

                // gMapControl1.Overlays.Add(Routes);


        }

        private void SeleccionarRegistro(object sender, DataGridViewCellEventArgs e)
        {
            filaSeleccionada = e.RowIndex;
            txtDescipcion.Text = dataGridView1.Rows[filaSeleccionada].Cells[0].Value.ToString();
            txtLatitud.Text = dataGridView1.Rows[filaSeleccionada].Cells[1].Value.ToString();
            txtLongitud.Text = dataGridView1.Rows[filaSeleccionada].Cells[2].Value.ToString();
            gMapControl1.Position = new PointLatLng(Double.Parse(dataGridView1.Rows[filaSeleccionada].Cells[1].Value.ToString()), Double.Parse(dataGridView1.Rows[filaSeleccionada].Cells[2].Value.ToString()));

        }

        private void gMapControl1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            double lat = gMapControl1.FromLocalToLatLng(e.X, e.Y).Lat;
            double lng = gMapControl1.FromLocalToLatLng(e.X, e.Y).Lng;

            txtLatitud.Text = lat.ToString();
            txtLongitud.Text = lng.ToString();
            txtDescipcion.Text = "";


        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtDescipcion.Text.Length != 0)
            {

                Creat_Airport(txtDescipcion.Text, Convert.ToDouble(txtLatitud.Text), Convert.ToDouble(txtLongitud.Text));
                dt.Rows.Add(txtDescipcion.Text, txtLatitud.Text, txtLongitud.Text);
               
                txtDescipcion.Text = "";
                txtLatitud.Text = "";
                txtLongitud.Text = "";

                gMapControl1.Overlays.Clear();

                matrizAdyacencia = new int[Lenght_File(), Lenght_File()];

                for (int i = 0; i < Lenght_File(); i++)
                {
                    for (int x = 0; x < Lenght_File(); x++)
                    {
                        matrizAdyacencia[i, x] = 0;
                    }
                }

                for (int i = 0; i < Lenght_IDroutes(); i++)
                {


                    int dis;

                    StringBuilder st = new StringBuilder(1000);
                    Read_IDroutes(st, (i + 1));

                    string[] elements = st.ToString().Split(';');
                    dis = Convert.ToInt16(elements[2].ToString());

                    StringBuilder st1 = new StringBuilder(1000);
                    StringBuilder st2 = new StringBuilder(1000);

                    getID(st1, elements[0]);
                    getID(st2, elements[1]);

                    matrizAdyacencia[PosIDname(st1.ToString()), PosIDname(st2.ToString())] = dis;
                }

                for (int i = 0; i < Lenght_File(); i++)
                {
                    double lat = Convert.ToDouble(dataGridView1.Rows[i].Cells[1].Value.ToString());
                    double lon = Convert.ToDouble(dataGridView1.Rows[i].Cells[2].Value.ToString());

                    GMarkerGoogle marker = new GMarkerGoogle(new PointLatLng(lat, lon), GMarkerGoogleType.blue_pushpin); ;
                    GMapOverlay markerOverlay = new GMapOverlay("marker");


                    markerOverlay.Markers.Add(marker);

                    //tooltip
                    //marker.ToolTipMode = MarkerTooltipMode.Always;
                    marker.ToolTipText = string.Format("Ubicacion: \n Latitud: {0} \n Longitud: {1}", lat, lon);
                    gMapControl1.Overlays.Add(markerOverlay);


                }

            }
            else
            {
                MessageBox.Show("Airport Name Field Empty");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            Delete_Airport(txtDescipcion.Text);
            Delete_allIDRoutes(txtDescipcion.Text);
            Delete_IDRoutes(dataGridView2.Rows[filaSeleccionada].Cells[1].Value.ToString());
            dataGridView1.Rows.RemoveAt(filaSeleccionada);
            
            txtDescipcion.Text = "";
            txtLatitud.Text = "";
            txtLongitud.Text = "";
            dt.Clear();
            dt2.Clear();
            dt3.Clear();
            Char delimit = ';';
            for (int i = 0; i < Lenght_File(); i++)
            {
                StringBuilder st = new StringBuilder(1000);
                Read_Airport(st, (i + 1));
                String[] elements = st.ToString().Split(delimit);

                dt.Rows.Add(elements[0], elements[1], elements[2]);

            }

            for (int i = 0; i < Length_R(); i++)
            {
                StringBuilder st = new StringBuilder(1000);
                Read_Route(st, (i + 1));
                String[] elements = st.ToString().Split(delimit);

                dt2.Rows.Add(elements[0], elements[1]);
            }
            for (int i = 0; i < Lenght_IDroutes(); i++)
            {
                StringBuilder st = new StringBuilder(1000);
                Read_IDroutes(st, (i + 1));
                dt3.Rows.Add(st.ToString());
            }
            matrizAdyacencia = new int[Lenght_File(), Lenght_File()];

            for (int i = 0; i < Lenght_File(); i++)
            {
                for (int x = 0; x < Lenght_File(); x++)
                {
                    matrizAdyacencia[i, x] = 0;
                }
            }
            for (int i = 0; i < Lenght_IDroutes(); i++)
                {
                    

                    int dis;

                    StringBuilder st = new StringBuilder(1000);
                    Read_IDroutes(st, (i + 1));

                    string[] elements = st.ToString().Split(';');
                    dis = Convert.ToInt16(elements[2].ToString());

                    StringBuilder st1 = new StringBuilder(1000);
                    StringBuilder st2 = new StringBuilder(1000);

                    getID(st1, elements[0]);
                    getID(st2, elements[1]);

                    matrizAdyacencia[PosIDname(st1.ToString()), PosIDname(st2.ToString())] = dis;
                }

            gMapControl1.Overlays.Clear();


            for (int i = 0; i < Lenght_File(); i++)
            {
                double lat = Convert.ToDouble(dataGridView1.Rows[i].Cells[1].Value.ToString());
                double lon = Convert.ToDouble(dataGridView1.Rows[i].Cells[2].Value.ToString());

                GMarkerGoogle marker = new GMarkerGoogle(new PointLatLng(lat, lon), GMarkerGoogleType.blue_pushpin); ;
                GMapOverlay markerOverlay = new GMapOverlay("marker");


                markerOverlay.Markers.Add(marker);

                //tooltip
                //marker.ToolTipMode = MarkerTooltipMode.Always;
                marker.ToolTipText = string.Format("Ubicacion: \n Latitud: {0} \n Longitud: {1}", lat, lon);
                gMapControl1.Overlays.Add(markerOverlay);


            }
        }



        private void DESTINO_BT_Click(object sender, EventArgs e)
        {
            if (TxTupdate.Text.Length != 0 && txtDescipcion.Text.Length != 0 && txtLatitud.Text.Length != 0 && txtLongitud.Text.Length != 0)
            {
                if (Exist_Airport(txtDescipcion.Text))
                {
                    Update_Airport(txtDescipcion.Text, TxTupdate.Text, Convert.ToDouble(txtLatitud.Text), Convert.ToDouble(txtLongitud.Text));

                    Update_IDroute(txtDescipcion.Text, TxTupdate.Text);

                    txtDescipcion.Text = "";
                    txtLatitud.Text = "";
                    txtLongitud.Text = "";
                    TxTupdate.Text = "";
                    dt.Rows.Clear();

                    IDtxt.Text = "";
                    RouteTXT.Text = "";
                    DisTXT.Text = "";
                    dt2.Rows.Clear();

                    Char delimit = ';';
                    for (int i = 0; i < Lenght_File(); i++)
                    {
                        StringBuilder st = new StringBuilder(1000);
                        Read_Airport(st, (i + 1));
                        String[] elements = st.ToString().Split(delimit);

                        dt.Rows.Add(elements[0], elements[1], elements[2]);

                    }

                    for (int i = 0; i < Length_R(); i++)
                    {
                        StringBuilder st = new StringBuilder(1000);
                        Read_Route(st, (i + 1));
                        String[] elements = st.ToString().Split(delimit);

                        dt2.Rows.Add(elements[0], elements[1]);
                    }
                }
                else
                {
                    MessageBox.Show("Check Airport ID");
                }
            }
            else
            {
                MessageBox.Show("Some of the fields are empty");
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            filaSelec = e.RowIndex;
            IDtxt.Text = dataGridView2.Rows[filaSelec].Cells[0].Value.ToString();
            RouteTXT.Text = dataGridView2.Rows[filaSelec].Cells[1].Value.ToString();



        }

        private void AddRoubtn_Click(object sender, EventArgs e)
        {
            if (IDtxt.Text.Length != 0 && RouteTXT.Text.Length != 0)
            {

                if (Create_route(IDtxt.Text, RouteTXT.Text) == 1)
                {
                    dt2.Rows.Add(IDtxt.Text, RouteTXT.Text);
                    IDtxt.Text = "";
                    RouteTXT.Text = "";
                    


                }
                else
                {
                    MessageBox.Show("Check the airport name");
                }
            }
            else
            {
                MessageBox.Show("Check the fields");
            }
        }

        private void DeleRoubtn_Click(object sender, EventArgs e)
        {
            if (IDtxt.Text.Length != 0 && RouteTXT.Text.Length != 0)
            {
                Delete_Route(IDtxt.Text, RouteTXT.Text);


                IDtxt.Text = "";
                RouteTXT.Text = "";
                DisTXT.Text = "";
                dt2.Rows.RemoveAt(filaSelec);


            }
            else
            {
                MessageBox.Show("Check the fields");
            }
        }

        private void Uproutbtn_Click(object sender, EventArgs e)
        {
            if (IDtxt.Text.Length != 0 && DisTXT.Text.Length != 0 && RouteTXT.Text.Length != 0 && UPRTXT.Text.Length != 0)
            {
                Update_Route(IDtxt.Text, RouteTXT.Text, UPRTXT.Text);
                IDtxt.Text = "";
                RouteTXT.Text = "";
                DisTXT.Text = "";
                UPRTXT.Text = "";

                dt2.Rows.Clear();
                for (int i = 0; i < Length_R(); i++)
                {
                    StringBuilder stb = new StringBuilder(1000);
                    Read_Route(stb, (i + 1));
                    String[] a = stb.ToString().Split(';');

                    dt2.Rows.Add(a[0], a[1]);
                }

            }
            else
            {
                MessageBox.Show("Check the fields");
            }
        }

        private void Marcadores_Click(object sender, EventArgs e)
        {
            gMapControl1.Overlays.Clear();

            for (int i = 0; i < Lenght_IDroutes(); i++)
            {

                StringBuilder st = new StringBuilder(1000);
                Read_IDroutes(st, (i + 1));
                String[] elements = st.ToString().Split(';');

                StringBuilder st2 = new StringBuilder(1000);
                StringBuilder st3 = new StringBuilder(1000);

                getID(st2, elements[0]);
                getID(st3, elements[1]);

                Routes = new GMapOverlay("Rutas");
           
                List<PointLatLng> l = new List<PointLatLng>();
                l.Add(new PointLatLng(getLat(st2.ToString()), getLon(st2.ToString())));
                l.Add(new PointLatLng(getLat(st3.ToString()), getLon(st3.ToString())));
                GMapRoute rou = new GMapRoute(l, st.ToString());

                AdjustableArrowCap bigarrow = new AdjustableArrowCap(5, 5);
                Pen p = new Pen(Color.Red, 1);
                p.CustomEndCap = bigarrow;
                rou.Stroke = p;
                Routes.Routes.Add(rou);
                gMapControl1.Overlays.Add(Routes);
            }

            for (int i = 0; i < Lenght_File(); i++)
            {
                double lat = Convert.ToDouble(dataGridView1.Rows[i].Cells[1].Value.ToString());
                double lon = Convert.ToDouble(dataGridView1.Rows[i].Cells[2].Value.ToString());

                GMarkerGoogle marker = new GMarkerGoogle(new PointLatLng(lat, lon), GMarkerGoogleType.blue_pushpin); ;
                GMapOverlay markerOverlay = new GMapOverlay("marker");


                markerOverlay.Markers.Add(marker);

                //tooltip
                //marker.ToolTipMode = MarkerTooltipMode.Always;
                marker.ToolTipText = string.Format("Ubicacion: \n Latitud: {0} \n Longitud: {1}", lat, lon);
                gMapControl1.Overlays.Add(markerOverlay);


            }
            //MessageBox.Show(Routes.Routes[1].Name);
            //for(int i = 0; i < Lenght_File(); i++)
            //{
            //    double lat = Convert.ToDouble(dataGridView1.Rows[i].Cells[1].Value.ToString());
            //    double lon = Convert.ToDouble(dataGridView1.Rows[i].Cells[2].Value.ToString());

            //    GMarkerGoogle marker= new GMarkerGoogle(new PointLatLng(lat, lon), GMarkerGoogleType.green); ;
            //    GMapOverlay markerOverlay= new GMapOverlay("marker");


            //    markerOverlay.Markers.Add(marker);

            //    //tooltip
            //    //marker.ToolTipMode = MarkerTooltipMode.Always;
            //    marker.ToolTipText = string.Format("Ubicacion: \n Latitud: {0} \n Longitud: {1}", lat, lon);
            //    gMapControl1.Overlays.Add(markerOverlay);


            //}
        }

        private void ADDconections_Click(object sender, EventArgs e)
        {
            if (OriginTxt.Text.Length != 0 && DestinyTxt.Text.Length != 0 && DisTXT.Text.Length!=0)
            {
                dt3.Rows.Clear();
                Creat_IDroutes(OriginTxt.Text, DestinyTxt.Text, Convert.ToInt16(DisTXT.Text));
                OriginTxt.Text = "";
                DestinyTxt.Text = "";
                DisTXT.Text = "";

                for (int i = 0; i < Lenght_IDroutes(); i++)
                {
                    StringBuilder st = new StringBuilder(1000);
                    Read_IDroutes(st, (i + 1));
                    dt3.Rows.Add(st.ToString());
                }

                matrizAdyacencia = new int[Lenght_File(), Lenght_File()];

                for (int i = 0; i < Lenght_File(); i++)
                {
                    for (int x = 0; x < Lenght_File(); x++)
                    {
                        matrizAdyacencia[i, x] = 0;
                    }
                }

                for (int i = 0; i < Lenght_IDroutes(); i++)
                {
                    

                    int dis;

                    StringBuilder st = new StringBuilder(1000);
                    Read_IDroutes(st, (i + 1));

                    string[] elements = st.ToString().Split(';');
                    dis = Convert.ToInt16(elements[2].ToString());

                    StringBuilder st1 = new StringBuilder(1000);
                    StringBuilder st2 = new StringBuilder(1000);

                    getID(st1, elements[0]);
                    getID(st2, elements[1]);

                    matrizAdyacencia[PosIDname(st1.ToString()), PosIDname(st2.ToString())] = dis;
                }

                MessageBox.Show("Conections Created");

            }
            else
            {
                MessageBox.Show("Check Fields");
            }
        }

        public int PosIDname(string id)
        {
            int i = 0;
            for (int x = 0; x < Lenght_File(); x++)
            {
                if (id == dataGridView1.Rows[x].Cells[0].Value.ToString())
                {
                    return i;
                }
                i++;
            }
            return -1;
        }

        public string IDnamePos(int pos)
        {
            return dataGridView1.Rows[pos].Cells[0].Value.ToString();
        }

        public string Dijkstra(int[,] matriz, int inicio, int final)
        {

            if (matriz[inicio, final] != 0)
            {
                s = s + IDnamePos(inicio) + ";" + IDnamePos(final) + ";";
            }
            else
            {
                int i = 0;
                bool a = false;
                for (int x = 0; x < Lenght_File(); x++)
                {

                    if (matriz[inicio, x] != 0)
                    {
                        i = x;
                        a = true;
                        s = s + IDnamePos(inicio) + ";" + IDnamePos(x) + ";";
                        break;
                    }
                }

                if (a)
                {
                    Dijkstra(matriz, i, final);
                }
                else
                {
                    s = "";
                    return s;
                }
            }
            return s;
        }

        private void Dijk_Click(object sender, EventArgs e)
        {

            s = "";
            gMapControl1.Overlays.Clear();
            string[] elements;
            StringBuilder st1 = new StringBuilder(1000);
            StringBuilder st2 = new StringBuilder(1000);

            getID(st1, OriginTxt.Text);
            getID(st2, DestinyTxt.Text);

            if (Dijkstra(matrizAdyacencia, PosIDname(st1.ToString()), PosIDname(st2.ToString())) != "")
            {
                s = "";
                elements = Dijkstra(matrizAdyacencia, PosIDname(st1.ToString()), PosIDname(st2.ToString())).Split(';');
                //for (int i = 0; i < Lenght_IDroutes(); i++)
                //{

                //    StringBuilder st = new StringBuilder(1000);
                //    Read_IDroutes(st, (i + 1));
                //    String[] elements1 = st.ToString().Split(';');

                //    StringBuilder st3 = new StringBuilder(1000);
                //    StringBuilder st4 = new StringBuilder(1000);

                //    getID(st3, elements1[0]);
                //    getID(st4, elements1[1]);

                //    Routes = new GMapOverlay("Allroutes");


                //    List<PointLatLng> g = new List<PointLatLng>();
                //    g.Add(new PointLatLng(getLat(st3.ToString()), getLon(st3.ToString())));
                //    g.Add(new PointLatLng(getLat(st4.ToString()), getLon(st4.ToString())));
                //    GMapRoute rou1 = new GMapRoute(g, st.ToString());

                //    AdjustableArrowCap bigarrow1 = new AdjustableArrowCap(5, 5);
                //    Pen p1 = new Pen(Color.Red, 1);
                //    p1.CustomEndCap = bigarrow1;
                //    rou1.Stroke = p1;
                //    Routes.Routes.Add(rou1);
                //    gMapControl1.Overlays.Add(Routes);
                //}


                Routes = new GMapOverlay("Rutas");
                List<PointLatLng> l = new List<PointLatLng>();
                for (int i = 0; i < elements.Length - 1; i++)
                {

                    l.Add(new PointLatLng(getLat(elements[i]), getLon(elements[i])));

                }

                GMapRoute rou = new GMapRoute(l, "SHORT ROUTE");

                AdjustableArrowCap bigarrow = new AdjustableArrowCap(5, 5);
                Pen p = new Pen(Color.Blue, 1);
                p.CustomEndCap = bigarrow;
                rou.Stroke = p;
                Routes.Routes.Add(rou);
                gMapControl1.Overlays.Add(Routes);


                for (int i = 0; i < Lenght_File(); i++)
                {
                    double lat = Convert.ToDouble(dataGridView1.Rows[i].Cells[1].Value.ToString());
                    double lon = Convert.ToDouble(dataGridView1.Rows[i].Cells[2].Value.ToString());

                    GMarkerGoogle marker = new GMarkerGoogle(new PointLatLng(lat, lon), GMarkerGoogleType.blue_pushpin); ;
                    GMapOverlay markerOverlay = new GMapOverlay("marker");


                    markerOverlay.Markers.Add(marker);

                    //tooltip
                    //marker.ToolTipMode = MarkerTooltipMode.Always;
                    marker.ToolTipText = string.Format("Ubicacion: \n Latitud: {0} \n Longitud: {1}", lat, lon);
                    gMapControl1.Overlays.Add(markerOverlay);


                }
            }
            else
            {
                MessageBox.Show("No routes Conections");
            }

        }
            //string salt(int m[5][5], int in, int fi)
            //{
            //    string s;
            //    if (m[in -1][fi - 1] != 0)
            //    {
            //        s = s + "-" + IDnamePos(in) + "-" + IDnamePos(fi);
            //    }
            //    else
            //    {
            //        int i = 0;
            //        bool visit = false;
            //        for (int x = 0; x < 5; x++)
            //        {
            //            if ((m[in -1][x] == 1) && (x != (in -2)) && (visit = false)) {
            //            s = s + "-" + IDnamePos(in) + "-" + IDnamePos(x);
            //            i = x;
            //            visit = true;
            //        }
            //    }
            //    salt(m, (i + 1), fi);
            //}
            //return s;
        }
    }

   


