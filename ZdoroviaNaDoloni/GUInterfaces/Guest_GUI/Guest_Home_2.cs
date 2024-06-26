﻿using GMap.NET.WindowsForms;
using ZdoroviaNaDoloni.Classes;

namespace ZdoroviaNaDoloni.GUInterfaces.Guest_GUI
{
    public partial class Guest_Home_2 : Form
    {
        private Point previousLocation;
        private Guest_Home_2 GetLocation() => this;

        public Guest_Home_2()
        {
            InitializeComponent();
            InitializeMap();
        }

        private void InitializeMap()
        {
            GMapControl gMapControl = new();
            _ = new MapManager(gMapControl);
            mapBox.Controls.Add(gMapControl);
        }

        private void Txt_suggest_Click(object sender, EventArgs e)
        {
            previousLocation = GetLocation().Location;
            Guest_Home_1 guestForm1 = new()
            {
                StartPosition = FormStartPosition.Manual,
                Location = previousLocation
            };
            guestForm1.Show();
            Hide();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            previousLocation = GetLocation().Location;
            Search_Form searchForm = new()
            {
                StartPosition = FormStartPosition.Manual,
                Location = previousLocation
            };
            searchForm.Show();
            Hide();
        }

        private void guest_categor_btn_Click(object sender, EventArgs e)
        {
            previousLocation = GetLocation().Location;
            Categories_Form categorForm = new()
            {
                StartPosition = FormStartPosition.Manual,
                Location = previousLocation
            };
            categorForm.Show();
            Hide();
        }

        private void Txt_Log_in_Click(object sender, EventArgs e)
        {
            previousLocation = GetLocation().Location;
            Registration_Form registrationForm = new()
            {
                StartPosition = FormStartPosition.Manual,
                Location = previousLocation
            };
            registrationForm.Show();
            Hide();
        }

        private void Txt_Sign_in_Click(object sender, EventArgs e)
        {
            previousLocation = GetLocation().Location;
            Autorization_Form autorizationForm = new()
            {
                StartPosition = FormStartPosition.Manual,
                Location = previousLocation
            };
            autorizationForm.Show();
            Hide();
        }
    }
}
