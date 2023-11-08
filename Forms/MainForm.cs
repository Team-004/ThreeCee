using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using ThreeCee.Models;

namespace ThreeCee.Forms
{
    public partial class MainForm : Form
    {
        private List<Vehicle> _vehicles;
        private int _selectedVehicleIndex;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            _vehicles = Vehicle.GetDummyVehicles();
            _selectedVehicleIndex = 0;
            PopulateVehicleList(_vehicles);
            UpdateVehicleInfo();
            UpdateCostEstimation();
        }

        private void PopulateVehicleList(List<Vehicle> list)
        {
            list.ForEach(it => VehicleListBox.Items.Add($"{it.Name}, {it.Model}"));
        }

        private void UpdateVehicleInfo()
        {
            var vehicle = _vehicles[_selectedVehicleIndex];

            lblName.Text = vehicle.Name;
            lblModelFueltype.Text = $"{vehicle.Model}\n" +
                                       $"{vehicle.FuelTypeString()}";
            lblFunctionStatusKilometers.Text = $"{vehicle.Function}\n" +
                                            $"{vehicle.StatusString()}\n" +
                                            $"{vehicle.KilometersDriven.ToString("#,#")} km";
        }

        private void UpdateCostEstimation()
        {
            numEstimatedCosts.Text = (((float)numCentPerLiter.Value *
                                       _vehicles[_selectedVehicleIndex].FuelConsumptionLPerKm *
                                       (float)numKilometers.Value)/100).ToString();
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
            _selectedVehicleIndex = VehicleListBox.SelectedIndex;
            UpdateVehicleInfo();
        }

        private void numKilometers_ValueChanged(object sender, EventArgs e)
        {
            UpdateCostEstimation();
        }

        private void numCentPerLiter_ValueChanged(object sender, EventArgs e)
        {
            UpdateCostEstimation();
        }
    }
}