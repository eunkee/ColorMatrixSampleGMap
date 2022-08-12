using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace TestGMap
{
    public partial class Form1 : Form
    {
        //google api key
        private readonly string API_KEY = "";

        // temp auto save & load path
        private readonly string _filePath = Path.Combine(Application.StartupPath, "Temp.txt");
        // data
        private CustomColorMatrix _mainMatrix = new CustomColorMatrix();
        
        // old data
        private PointLatLng _oldPosition = new PointLatLng(37.497872, 127.0275142);
        private double _oldZoom = 16d;

        private readonly GMapOverlay _markerOverlay = new GMapOverlay("markers");
        private readonly GMapOverlay _polygonOverlay = new GMapOverlay("polygons");

        public Form1()
        {
            InitializeComponent();
        }

        // string to float 
        private static float ConvertStringToFloat(string text)
        {
            const float MAX_VALUE = 2.0f;
            const float MIN_VALUE = -2.0f;

            float rslt = 0.0f;
            if (float.TryParse(text, out float value))
            {
                rslt = value;
            }

            rslt = rslt > MAX_VALUE ? MAX_VALUE : rslt;
            rslt = rslt < MIN_VALUE ? MIN_VALUE : rslt;

            return rslt;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // set combobox Item
            SetComboBoxItem();
            // auto load file
            LoadStatus(_filePath);
            // create gmap
            CreateMap();
            // set colormatrix
            SetColorMatrix();
        }

        private void SetComboBoxItem()
        {
            SetComboBoxItemSupport(comboBox1);
            SetComboBoxItemSupport(comboBox2);
            SetComboBoxItemSupport(comboBox3);
            SetComboBoxItemSupport(comboBox4);
            SetComboBoxItemSupport(comboBox5);
            SetComboBoxItemSupport(comboBox6);
            SetComboBoxItemSupport(comboBox7);
            SetComboBoxItemSupport(comboBox8);
            SetComboBoxItemSupport(comboBox9);
            SetComboBoxItemSupport(comboBox10);
            SetComboBoxItemSupport(comboBox11);
            SetComboBoxItemSupport(comboBox12);
            SetComboBoxItemSupport(comboBox13);
            SetComboBoxItemSupport(comboBox14);
            SetComboBoxItemSupport(comboBox15);
            SetComboBoxItemSupport(comboBox16);
            SetComboBoxItemSupport(comboBox17);
            SetComboBoxItemSupport(comboBox18);
            SetComboBoxItemSupport(comboBox19);
            SetComboBoxItemSupport(comboBox20);
            SetComboBoxItemSupport(comboBox21);
            SetComboBoxItemSupport(comboBox22);
            SetComboBoxItemSupport(comboBox23);
            SetComboBoxItemSupport(comboBox24);
            SetComboBoxItemSupport(comboBox25);
        }

        private void SetComboBoxItemSupport(ComboBox comboBox)
        {
            for(double i = 2.00d; i > -2.01d; i -= 0.01d)
            {
                comboBox.Items.Add(i.ToString("0.00"));
            }
        }

        private void CreateMap()
        {
            try
            {
                System.Net.IPHostEntry e1 =
                     System.Net.Dns.GetHostEntry("www.google.com");
            }
            catch
            {
                gMapControl1.Manager.Mode = AccessMode.CacheOnly;
                MessageBox.Show("No internet connection avaible, going to CacheOnly mode.",
                      "GMap.NET - Demo.WindowsForms", MessageBoxButtons.OK,
                      MessageBoxIcon.Warning);
            }

            GMaps.Instance.Mode = AccessMode.ServerAndCache;
            gMapControl1.CacheLocation = Application.StartupPath + "data.gmdp";
            GMapProviders.GoogleMap.ApiKey = API_KEY;
            gMapControl1.MapProvider = GMapProviders.GoogleMap;
            gMapControl1.DragButton = MouseButtons.Left;

            gMapControl1.MaxZoom = 20;
            gMapControl1.MinZoom = 2;
            gMapControl1.Zoom = RegistyTestGMap.LastGMapZoom;

            // center red cross 제거
            gMapControl1.ShowCenter = false;

            // 오버레이 추가
            //gMapControl1.Overlays.Add(_markerOverlay);
            //gMapControl1.Overlays.Add(_polygonOverlay);

            Console.WriteLine($"Lat: {RegistyTestGMap.LastGMapLat}, Lng: {RegistyTestGMap.LastGMapLng}");

            gMapControl1.Position = new PointLatLng(RegistyTestGMap.LastGMapLat, RegistyTestGMap.LastGMapLng);
            

            //포지션 변경 뒤에 유지하기 위해 추가
            //CenterMarkerAndCircleRange(gMapControl1.Position, 200, "test tooltip");

            //TestMarkerTypesDraw();

            // 이벤트 추가
            //gMapControl1.OnMapDrag += GMapControl1_OnMapDrag;
            //gMapControl1.OnMapZoomChanged += GMapControl1_OnMapZoomChanged;
        }

        private void TestMarkerTypesDraw()
        {
            int index = 0;
            //enum foreach
            foreach (GMarkerGoogleType type in (GMarkerGoogleType[])Enum.GetValues(typeof(GMarkerGoogleType)))
            {
                if (type != GMarkerGoogleType.none)
                {
                    GMapMarker gMarker = new GMarkerGoogle(GetPosition(index), type);
                    gMarker.ToolTipMode = MarkerTooltipMode.Always;
                    gMarker.ToolTipText = type.ToString();
                    gMarker.ToolTip.TextPadding = new Size(5, 3);
                    gMarker.ToolTip.Fill = new SolidBrush(Color.Black);
                    gMarker.ToolTip.Foreground = new SolidBrush(Color.Yellow);
                    gMarker.ToolTip.Offset = new Point(-30, 20);
                    gMarker.ToolTip.Stroke = new Pen(Color.Transparent, .0f);
                    _markerOverlay.Markers.Add(gMarker);
                    index++;
                }
            }
        }

        private PointLatLng GetPosition(int index)
        {
            PointLatLng latLng = gMapControl1.Position;

            if (index >= 40)
            {
                return latLng;
            }

            // x axis
            if (index < 8)
            {
                latLng = CalculateDerivedPosition(latLng, 400, 0);
            }
            else if (index < 16)
            {
                latLng = CalculateDerivedPosition(latLng, 200, 0);
            }
            else if (index < 24)
            {
                //xAxis = xAxis
            }
            else if (index < 32)
            {
                latLng = CalculateDerivedPosition(latLng, 200, 180);
            }
            else if (index < 40)
            {
                latLng = CalculateDerivedPosition(latLng, 400, 180);
            }

            // y axis
            if (index % 8 == 0)
            {
                latLng = CalculateDerivedPosition(latLng, 700, 270);
            }
            else if (index % 8 == 1)
            {
                latLng = CalculateDerivedPosition(latLng, 500, 270);
            }
            else if (index % 8 == 2)
            {
                latLng = CalculateDerivedPosition(latLng, 300, 270);
            }
            else if (index % 8 == 3)
            {
                latLng = CalculateDerivedPosition(latLng, 100, 270);
            }
            else if (index % 8 == 4)
            {
                latLng = CalculateDerivedPosition(latLng, 100, 90);
            }
            else if (index % 8 == 5)
            {
                latLng = CalculateDerivedPosition(latLng, 300, 90);
            }
            else if (index % 8 == 6)
            {
                latLng = CalculateDerivedPosition(latLng, 500, 90);
            }
            else if (index % 8 == 7)
            {
                latLng = CalculateDerivedPosition(latLng, 700, 90);
            }

            return latLng;
        }

        // bearing 시계방향
        public static PointLatLng CalculateDerivedPosition(PointLatLng source, double range, double bearing)
        {
            const double DEGREES_TO_RADIANS = Math.PI / 180;
            const double EARTH_RADIUS_M = 6371000;
            double latA = source.Lat * DEGREES_TO_RADIANS;
            double lonA = source.Lng * DEGREES_TO_RADIANS;
            double angularDistance = range / EARTH_RADIUS_M;
            double trueCourse = bearing * DEGREES_TO_RADIANS;

            double lat = Math.Asin(
                Math.Sin(latA) * Math.Cos(angularDistance) +
                Math.Cos(latA) * Math.Sin(angularDistance) * Math.Cos(trueCourse));

            double dlon = Math.Atan2(
                Math.Sin(trueCourse) * Math.Sin(angularDistance) * Math.Cos(latA),
                Math.Cos(angularDistance) - Math.Sin(latA) * Math.Sin(lat));

            double lon = ((lonA + dlon + Math.PI) % (Math.PI * 2)) - Math.PI;

            return new PointLatLng(
                lat / DEGREES_TO_RADIANS,
                lon / DEGREES_TO_RADIANS);
        }

        private void GMapControl1_OnMapZoomChanged()
        {
            CenterMarkerAndCircleRange(gMapControl1.Position, 200, "test tooltip");
        }

        private void GMapControl1_OnMapDrag()
        {
            CenterMarkerAndCircleRange(gMapControl1.Position, 200, "test tooltip");
        }

        #region center marker method
        private void CenterMarkerAndCircleRange(PointLatLng point, double radius, string text)
        {
            return;
            _markerOverlay.Clear();
            _polygonOverlay.Clear();

            //marker
            GMapMarker gMarker = new GMarkerGoogle(point, GMarkerGoogleType.blue_dot);
            gMarker.ToolTipMode = MarkerTooltipMode.OnMouseOver;
            gMarker.ToolTipText = text;
            gMarker.ToolTip.TextPadding = new Size(5, 3);
            gMarker.ToolTip.Fill = new SolidBrush(Color.DimGray);
            gMarker.ToolTip.Foreground = new SolidBrush(Color.White);
            gMarker.ToolTip.Offset = new Point(10, -30);
            gMarker.ToolTip.Stroke = new Pen(Color.Transparent, .0f);
            _markerOverlay.Markers.Add(gMarker);

            //circle range
            int segments = 1080;
            double seg = Math.PI * 2 / segments;
            List<PointLatLng> gpollist = new List<PointLatLng>();
            for (int i = 0; i < segments; i++)
            {
                gpollist.Add(FindPointAtDistanceFrom(point, i * (Math.PI / 180), radius / 1000));
            }
            GMapPolygon circle = new GMapPolygon(gpollist, "circle");
            circle.Stroke = new Pen(Color.Red, .5f);
            circle.Fill = new SolidBrush(Color.FromArgb(50, Color.Red));
            _polygonOverlay.Polygons.Add(circle);
        }

        public static PointLatLng FindPointAtDistanceFrom(PointLatLng startPoint, double initialBearingRadians, double distanceKilometres)
        {
            const double radiusEarthKilometres = 6371.01;
            var distRatio = distanceKilometres / radiusEarthKilometres;
            var distRatioSine = Math.Sin(distRatio);
            var distRatioCosine = Math.Cos(distRatio);

            var startLatRad = DegreesToRadians(startPoint.Lat);
            var startLonRad = DegreesToRadians(startPoint.Lng);

            var startLatCos = Math.Cos(startLatRad);
            var startLatSin = Math.Sin(startLatRad);

            var endLatRads = Math.Asin((startLatSin * distRatioCosine) + (startLatCos * distRatioSine * Math.Cos(initialBearingRadians)));
            var endLonRads = startLonRad + Math.Atan2(Math.Sin(initialBearingRadians) * distRatioSine * startLatCos, distRatioCosine - startLatSin * Math.Sin(endLatRads));

            return new GMap.NET.PointLatLng(RadiansToDegrees(endLatRads), RadiansToDegrees(endLonRads));
        }

        public static double DegreesToRadians(double degrees)
        {
            const double degToRadFactor = Math.PI / 180;
            return degrees * degToRadFactor;
        }

        public static double RadiansToDegrees(double radians)
        {
            const double radToDegFactor = 180 / Math.PI;
            return radians * radToDegFactor;
        }
        #endregion center marker method

        #region color matrix
        private void SetColorMatrix()
        {
            gMapControl1.ColorMatrix = MakeColorMatrixs(_mainMatrix);
        }

        private ColorMatrix MakeColorMatrixs(CustomColorMatrix custom)
        {
            return new ColorMatrix(new[]
            {
                // red scaling factor of 2
                new float[] {custom.matrix00, custom.matrix01, custom.matrix02, custom.matrix03, custom.matrix04},
                // green scaling factor of 1
                new float[] {custom.matrix10, custom.matrix11, custom.matrix12, custom.matrix13, custom.matrix14},
                // blue scaling factor of 1
                new float[] {custom.matrix20, custom.matrix21, custom.matrix22, custom.matrix23, custom.matrix24},
                // alpha scaling factor of 1
                new float[] {custom.matrix30, custom.matrix31, custom.matrix32, custom.matrix33, custom.matrix34},
                // three translations of 0.2
                new float[] {custom.matrix40, custom.matrix41, custom.matrix42, custom.matrix43, custom.matrix44},
            });
        }

        // control -> data
        private void ComboBox_TextChanged(object sender, EventArgs e)
        {
            if (sender is ComboBox control)
            {
                #region control text to matrix data
                if (control.Name == comboBox1.Name)
                {
                    _mainMatrix.matrix00 = ConvertStringToFloat(control.Text);
                }
                else if (control.Name == comboBox2.Name)
                {
                    _mainMatrix.matrix01 = ConvertStringToFloat(control.Text);
                }
                else if (control.Name == comboBox3.Name)
                {
                    _mainMatrix.matrix02 = ConvertStringToFloat(control.Text);
                }
                else if (control.Name == comboBox4.Name)
                {
                    _mainMatrix.matrix03 = ConvertStringToFloat(control.Text);
                }
                else if (control.Name == comboBox5.Name)
                {
                    _mainMatrix.matrix04 = ConvertStringToFloat(control.Text);
                }
                else if (control.Name == comboBox6.Name)
                {
                    _mainMatrix.matrix10 = ConvertStringToFloat(control.Text);
                }
                else if (control.Name == comboBox7.Name)
                {
                    _mainMatrix.matrix11 = ConvertStringToFloat(control.Text);
                }
                else if (control.Name == comboBox8.Name)
                {
                    _mainMatrix.matrix12 = ConvertStringToFloat(control.Text);
                }
                else if (control.Name == comboBox9.Name)
                {
                    _mainMatrix.matrix13 = ConvertStringToFloat(control.Text);
                }
                else if (control.Name == comboBox10.Name)
                {
                    _mainMatrix.matrix14 = ConvertStringToFloat(control.Text);
                }
                else if (control.Name == comboBox11.Name)
                {
                    _mainMatrix.matrix20 = ConvertStringToFloat(control.Text);
                }
                else if (control.Name == comboBox12.Name)
                {
                    _mainMatrix.matrix21 = ConvertStringToFloat(control.Text);
                }
                else if (control.Name == comboBox13.Name)
                {
                    _mainMatrix.matrix22 = ConvertStringToFloat(control.Text);
                }
                else if (control.Name == comboBox14.Name)
                {
                    _mainMatrix.matrix23 = ConvertStringToFloat(control.Text);
                }
                else if (control.Name == comboBox15.Name)
                {
                    _mainMatrix.matrix24 = ConvertStringToFloat(control.Text);
                }
                else if (control.Name == comboBox16.Name)
                {
                    _mainMatrix.matrix30 = ConvertStringToFloat(control.Text);
                }
                else if (control.Name == comboBox17.Name)
                {
                    _mainMatrix.matrix31 = ConvertStringToFloat(control.Text);
                }
                else if (control.Name == comboBox18.Name)
                {
                    _mainMatrix.matrix32 = ConvertStringToFloat(control.Text);
                }
                else if (control.Name == comboBox19.Name)
                {
                    _mainMatrix.matrix33 = ConvertStringToFloat(control.Text);
                }
                else if (control.Name == comboBox20.Name)
                {
                    _mainMatrix.matrix34 = ConvertStringToFloat(control.Text);
                }
                else if (control.Name == comboBox21.Name)
                {
                    _mainMatrix.matrix40 = ConvertStringToFloat(control.Text);
                }
                else if (control.Name == comboBox22.Name)
                {
                    _mainMatrix.matrix41 = ConvertStringToFloat(control.Text);
                }
                else if (control.Name == comboBox23.Name)
                {
                    _mainMatrix.matrix42 = ConvertStringToFloat(control.Text);
                }
                else if (control.Name == comboBox24.Name)
                {
                    _mainMatrix.matrix43 = ConvertStringToFloat(control.Text);
                }
                else if (control.Name == comboBox25.Name)
                {
                    _mainMatrix.matrix44 = ConvertStringToFloat(control.Text);
                }
                #endregion control text to matrix data

                gMapControl1.ColorMatrix = MakeColorMatrixs(_mainMatrix);
            }
        }

        // loadFileDialog
        private void ButtonLoad_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                LoadStatus(openFileDialog1.FileName);
                SetColorMatrix();
            }
        }

        // saveFileDialog
        private void ButtonSave_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = string.Empty;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                SaveStatus(saveFileDialog1.FileName);
            }
        }

        // data -> file
        private void SaveStatus(string path)
        {
            string saveData = JsonConvert.SerializeObject(_mainMatrix);
            File.WriteAllText(path, saveData.ToString());
        }

        // file -> data & control
        private void LoadStatus(string path)
        {
            if (!File.Exists(path))
            {
                return;
            }

            string loadData = File.ReadAllText(path);
            CustomColorMatrix classTextDatas = JsonConvert.DeserializeObject<CustomColorMatrix>(loadData);

            comboBox1.Text = classTextDatas.matrix00.ToString("0.00");
            comboBox2.Text = classTextDatas.matrix01.ToString("0.00");
            comboBox3.Text = classTextDatas.matrix02.ToString("0.00");
            comboBox4.Text = classTextDatas.matrix03.ToString("0.00");
            comboBox5.Text = classTextDatas.matrix04.ToString("0.00");
            comboBox6.Text = classTextDatas.matrix10.ToString("0.00");
            comboBox7.Text = classTextDatas.matrix11.ToString("0.00");
            comboBox8.Text = classTextDatas.matrix12.ToString("0.00");
            comboBox9.Text = classTextDatas.matrix13.ToString("0.00");
            comboBox10.Text = classTextDatas.matrix14.ToString("0.00");
            comboBox11.Text = classTextDatas.matrix20.ToString("0.00");
            comboBox12.Text = classTextDatas.matrix21.ToString("0.00");
            comboBox13.Text = classTextDatas.matrix22.ToString("0.00");
            comboBox14.Text = classTextDatas.matrix23.ToString("0.00");
            comboBox15.Text = classTextDatas.matrix24.ToString("0.00");
            comboBox16.Text = classTextDatas.matrix30.ToString("0.00");
            comboBox17.Text = classTextDatas.matrix31.ToString("0.00");
            comboBox18.Text = classTextDatas.matrix32.ToString("0.00");
            comboBox19.Text = classTextDatas.matrix33.ToString("0.00");
            comboBox20.Text = classTextDatas.matrix34.ToString("0.00");
            comboBox21.Text = classTextDatas.matrix40.ToString("0.00");
            comboBox22.Text = classTextDatas.matrix41.ToString("0.00");
            comboBox23.Text = classTextDatas.matrix42.ToString("0.00");
            comboBox24.Text = classTextDatas.matrix43.ToString("0.00");
            comboBox25.Text = classTextDatas.matrix44.ToString("0.00");
        }
        #endregion color matrix

        // auto save file
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveStatus(_filePath);

            if (gMapControl1 != null)
            {
                RegistyTestGMap.LastGMapLat = gMapControl1.Position.Lat;
                RegistyTestGMap.LastGMapLng = gMapControl1.Position.Lng;
                RegistyTestGMap.LastGMapZoom = gMapControl1.Zoom;

                try
                {
                    gMapControl1.Manager.CancelTileCaching();
                    gMapControl1.Dispose();
                    gMapControl1 = null;
                }
                catch { }
            }
        }

        #region change position

        private void ButtonPos1_Click(object sender, EventArgs e)
        {
            _oldPosition = gMapControl1.Position;
            _oldZoom = gMapControl1.Zoom;

            gMapControl1.Position = new PointLatLng(35.1933977, 129.0763879);
            //CenterMarkerAndCircleRange(gMapControl1.Position, 200, "test tooltip");
            buttonPos2.Enabled = true;
        }

        private void ButtonPos2_Click(object sender, EventArgs e)
        {
            gMapControl1.Position = _oldPosition;
            //CenterMarkerAndCircleRange(gMapControl1.Position, 200, "test tooltip");
            gMapControl1.Zoom = _oldZoom;

            buttonPos2.Enabled = false;
        }
        #endregion change position

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url = @"https://docs.microsoft.com/ko-kr/dotnet/api/system.drawing.imaging.colormatrix?view=dotnet-plat-ext-6.0";
            System.Diagnostics.Process.Start(url);
        }
    }
}
