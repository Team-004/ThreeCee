using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ThreeCee.Infrastructure;
using ThreeCee.Models;

namespace ThreeCee.Forms
{
    public partial class MainForm : Form
    {
        private static List<Vehicle> _vehicles;
        private int _selectedVehicleIndex;

        public static readonly IRepository<Vehicle> Repo = new SqliteVehicleRepository(
            // ReSharper disable once StringLiteralTypo
            dbName: "Data Source=userdata/vehicles.db;",
            onUpdate: OnDbUpdate
        );
        
        private static void OnDbUpdate()
        {
            _vehicles = Repo.GetAll();
        }

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            OnDbUpdate();
            
            Repo.DeleteAll();
            AddExampleVehicles();

            //_vehicles = Vehicle.GetDummyVehicles();
            _selectedVehicleIndex = 0;
            UpdateVehicleList();
            UpdateVehicleInfo();
            UpdateCostEstimation();
        }
        
        private void AddExampleVehicles()
        {
            foreach (var vehicle in Vehicle.GetDummyVehicles()) Repo.Add(vehicle);
        }

        private void UpdateVehicleList()
        {
            VehicleListBox.Items.Clear();
            _vehicles.ForEach(it => VehicleListBox.Items.Add($"{it.Name}, {it.Model}"));
        }

        private void UpdateVehicleInfo()
        {
            if (!_vehicles.Any())
            {
                return;
            }
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
            if (!_vehicles.Any())
            {
                return;
            }
            numEstimatedCosts.Text = (((float)numCentPerLiter.Value *
                                       _vehicles[_selectedVehicleIndex].FuelConsumptionLPerKm *
                                       (float)numKilometers.Value)/100).ToString();
        }

        private void MenuItemFileExit_Click(object sender, EventArgs e) => ExitApp();

        private static void ExitApp()
        {
            Application.Exit();
        }

        //First add some items to your listBox1.Items     
        //MeasureItem event handler for your ListBox
        private void VehicleListBox_MeasureItem(object sender, MeasureItemEventArgs e)
        {

        }

        //DrawItem event handler for your ListBox
        private void VehicleListBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            e.Graphics.DrawString(VehicleListBox.Items[e.Index].ToString(), e.Font, new SolidBrush(e.ForeColor), e.Bounds);
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

        private void toolAdd_Click(object sender, EventArgs e)
        {
            new AddVehicleForm().Show();
        }

        private void btnEditVehicle_Click(object sender, EventArgs e)
        {
            EditVehicle();
        }

        private void DeleteVehicle()
        {
            Repo.Delete(_vehicles[_selectedVehicleIndex].Id);
            UpdateVehicleList();
        }

        private void EditVehicle()
        {
            new EditVehicleForm(_vehicles[_selectedVehicleIndex]).Show();
        }

        private void btnDeleteVehicle_Click(object sender, EventArgs e)
        {
            DeleteVehicle();
        }

        private void MenuEdit_DropDownOpened(object sender, EventArgs e)
        {
            if (!_vehicles.Any())
            {
                MenuItemEditDelete.Enabled = false;
                MenuItemEditEdit.Enabled = false;
            }
            else
            {
                MenuItemEditDelete.Enabled = true;
                MenuItemEditEdit.Enabled = true;
            }
        }

        private void MenuItemEditDelete_Click(object sender, EventArgs e)
        {
            DeleteVehicle();
        }

        private void MenuItemEditEdit_Click(object sender, EventArgs e)
        {
            EditVehicle();
        }
    }
}