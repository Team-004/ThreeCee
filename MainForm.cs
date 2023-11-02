using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ThreeCee
{
    public partial class MainForm : Form
    {
        private List<Vehicle> Vehicles;
        private int selectedVehicleIndex;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Vehicles = Vehicle.GetDummyVehicles();
            selectedVehicleIndex = 0;
            PopulateVehicleList(Vehicles);
            UpdateVehicleInfo();
        }

        private void PopulateVehicleList(List<Vehicle> list)
        {
            list.ForEach(it => VehicleListBox.Items.Add($"{it.Name}, {it.Model}"));
        }

        private void UpdateVehicleInfo()
        {
            var vehicle = Vehicles[selectedVehicleIndex];

            lblName.Text = vehicle.Name;
            lblModel.Text = vehicle.Model;
            lblFunctionFuelStatus.Text = $"{vehicle.Function}\n" +
                                         $"{vehicle.FuelTypeString()}\n" +
                                         $"{vehicle.StatusString()}";
        }

        private void beendenToolStripMenuItem_Click(object sender, EventArgs e) => ExitApp();

        private void ExitApp()
        {
            Application.Exit();
        }

        //First add some items to your listBox1.Items     
        //MeasureItem event handler for your ListBox
        private void VehicleListBox_MeasureItem(object sender, MeasureItemEventArgs e)
        {

        }

        //DrawItem event handler for your ListBox
        void VehicleListBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            e.Graphics.DrawString(VehicleListBox.Items[e.Index].ToString(), e.Font, new SolidBrush(e.ForeColor), e.Bounds);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void VehicleListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedVehicleIndex = VehicleListBox.SelectedIndex;
            UpdateVehicleInfo();
        }
    }
}