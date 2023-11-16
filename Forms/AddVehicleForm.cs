using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure.Design;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThreeCee.Forms;
using ThreeCee.Models;

namespace ThreeCee.Forms
{
    public partial class AddVehicleForm : Form
    {
        public AddVehicleForm()
        {
            InitializeComponent();
        }

        private void AddVehicle_Load(object sender, EventArgs e)
        {

        }

        private void addVehicleButton_Click(object sender, EventArgs e)
        {
            string vehicleName = nameTextBox.Text;
            string vehicleModell = modellTextBox.Text;
            string vehicleFunction = functionTextBox.Text;
            string vehicleFuelTypeText = fuelTypeComboBox.Text;
            string vehicleStatusText = statusComboBox.Text;
            float vehicleFuelConsumption = (float)fuelConsumptionNumberBox.Value/100;
            float vehicleKilometers = (float)kilometerNumberBox.Value;
            if (vehicleName != "" && vehicleModell != "" && vehicleFunction != "" && vehicleFuelTypeText != "" && vehicleStatusText != "")
            {
                var vehicleFuelType = vehicleFuelTypeText switch
                {
                    "Benzin" => Vehicle.EFuelType.Gasoline,
                    "Diesel" => Vehicle.EFuelType.Diesel,
                    "Strom" => Vehicle.EFuelType.Electric,
                    _ => throw new Exception("Unexpected Error: invalid fuel type"),
                };
                var vehicleStatus = vehicleStatusText switch
                {
                    "Gekauft" => Vehicle.EStatus.Bought,
                    "Geleast" => Vehicle.EStatus.Leased,
                    _ => throw new Exception("Unexpected Error: invalid status"),
                };
                MainForm.Repo.Add(new Vehicle(vehicleModell, vehicleName, vehicleStatus, vehicleFuelType,
                    vehicleFunction, vehicleFuelConsumption, vehicleKilometers));
                Console.WriteLine("added");
                Program.mainForm.UpdateVehicleList();
                Close();
            }
            else
            {
                MessageBox.Show("Bitte alle Felder ausfüllen!");
            }
        }

        private void fuelConsumptionNumberBox_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
