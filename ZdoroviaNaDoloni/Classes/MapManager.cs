using System.Text.Json;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;

namespace ZdoroviaNaDoloni.Classes
{
    public class MapManager
    {
        private GMapControl gMapControl;
        private List<Pharmacy> pharmacies;

        public class Pharmacy
        {
            public string Name { get; set; }
            public double Latitude { get; set; }
            public double Longitude { get; set; }
            public string Information { get; set; }

            public Pharmacy(string name, double latitude, double longitude, string information)
            {
                Name = name;
                Latitude = latitude;
                Longitude = longitude;
                Information = information;
            }
        }

        public event Action<string, double, double, string> InfoMarkClicked;

        public MapManager(GMapControl gMapControl)
        {
            this.gMapControl = gMapControl;
            InitializeMap();
            LoadPharmacies();
            AddPharmacyMarkers();
            gMapControl.OnMarkerClick += GMapControl_OnMarkerClick;
        }

        private void InitializeMap()
        {
            gMapControl.MapProvider = GMapProviders.OpenStreetMap;
            gMapControl.Position = new PointLatLng(Constants.Instance.KharkivCityPositionX, Constants.Instance.KharkivCityPositionY);
            gMapControl.MinZoom = Constants.Instance.MinZoom;
            gMapControl.MaxZoom = Constants.Instance.MaxZoom;
            gMapControl.Zoom = Constants.Instance.Zoom;
            gMapControl.Dock = DockStyle.Fill;
        }

        private void LoadPharmacies()
        {
            string projectDirectory = Directory.GetParent(Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).FullName).FullName;
            string pharmaciesJsonPath = Path.Combine(projectDirectory, Constants.Instance.pharmpath);
            pharmacies = new List<Pharmacy>();
            string pharmaciesJson = File.ReadAllText(pharmaciesJsonPath);
            pharmacies = JsonSerializer.Deserialize<List<Pharmacy>>(pharmaciesJson);
        }

        private void AddPharmacyMarkers()
        {
            GMapOverlay markersOverlay = new("markers");

            foreach (Pharmacy pharmacy in pharmacies)
            {
                PointLatLng position = new PointLatLng(pharmacy.Latitude, pharmacy.Longitude);
                GMapMarker marker = new GMarkerGoogle(position, GMarkerGoogleType.red)
                {
                    Tag = pharmacy
                };
                markersOverlay.Markers.Add(marker);
            }

            gMapControl.Overlays.Add(markersOverlay);
        }

        private void GMapControl_OnMarkerClick(GMapMarker item, MouseEventArgs e)
        {
            if (item.Tag != null)
            {
                Pharmacy pharmacy = (Pharmacy)item.Tag;
                MessageBox.Show(pharmacy.Information, pharmacy.Name);
                InfoMarkClicked?.Invoke(pharmacy.Name, pharmacy.Latitude, pharmacy.Longitude, pharmacy.Information);
            }
        }
    }
}
