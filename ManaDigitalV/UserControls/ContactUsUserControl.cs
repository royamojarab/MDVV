using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManaDigitalV.UserControls
{
    public partial class ContactUsUserControl : UserControl
    {
        public ContactUsUserControl()
        {
            InitializeComponent();

            gMapControl1.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerAndCache;
            gMapControl1.Position = new GMap.NET.PointLatLng(35.7305, 51.41422);
            gMapControl1.CanDragMap = true;
            gMapControl1.MapProvider = GMapProviders.GoogleMap;
            gMapControl1.Zoom = 10;
            gMapControl1.MarkersEnabled = true;
            gMapControl1.MaxZoom = 20;
            gMapControl1.DragButton = MouseButtons.Left;
            gMapControl1.MinZoom = 1;
            gMapControl1.AutoScroll = true;
          var  markerOverlay = new GMapOverlay("markers");
            GMapMarker gmm = new GMarkerGoogle(new GMap.NET.PointLatLng( 35.73050621973318, 51.414222220804696),GMarkerGoogleType.red);
            //GMapMarker marker = new GMapMarker()
            markerOverlay.Markers.Add(gmm);
            gMapControl1.Overlays.Add(markerOverlay);

        }

        private void ContactUsUserControl_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {







        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {


        }

        private void mapControl1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void webBrowser1_DocumentCompleted_1(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
