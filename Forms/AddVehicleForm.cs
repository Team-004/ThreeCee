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
            Debug.WriteLine("Add vehicle Button clicked!");
            string vehicleName = nameTextBox.Text;
            string vehicleModell = modellTextBox.Text;
            string vehicleFunction = functionTextBox.Text;
            string vehicleFuelType = fuelTypeComboBox.Text;
            string vehicleStatus = statusComboBox.Text;
            decimal vehicleKilometers = kilometerNumberBox.Value;
            //check that all variables arent empty
            if (vehicleName != "" && vehicleModell != "" && vehicleFunction != "" && vehicleFuelType != "" && vehicleStatus != "")
            {
                MainForm.Repo.Add(new Vehicle());                                                                                                                               ));
            }
            else
            {
                MessageBox.Show("Bitte alle Felder ausfüllen!");
            }
        }
    }
}
