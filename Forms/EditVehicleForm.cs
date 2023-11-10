using System;
using System.Windows.Forms;
using ThreeCee.Models;
using System.Data.SQLite;

namespace ThreeCee.Forms;

public partial class EditVehicleForm : Form
{
    private Vehicle _vehicle;

    public EditVehicleForm(Vehicle vehicle)
    {
        InitializeComponent();
        _vehicle = vehicle;
    }

    private void button1_Click(object sender, EventArgs e)
    {
        _vehicle.Model = txtModel.Text;
        _vehicle.Name = txtName.Text;
        _vehicle.Status = (Vehicle.EStatus)Enum.Parse(typeof(Vehicle.EStatus),cbStatus.Text);
        _vehicle.FuelType = (Vehicle.EFuelType)Enum.Parse(typeof(Vehicle.EFuelType), cbFuelType.Text);
        _vehicle.Function = txtFunction.Text;
        _vehicle.FuelConsumptionLPerKm = float.Parse(txtFuelPerKm.Text)/100;
        _vehicle.KilometersDriven = float.Parse(txtKilometersDriven.Text);
        MainForm.Repo.Update(_vehicle);
    }

    private void VehicleEditForm_Load(object sender, EventArgs e)
    {
        Console.WriteLine(_vehicle.Name);
    }

    private void txtModel_TextChanged(object sender, EventArgs e)
    {

    }

    private void txtName_TextChanged(object sender, EventArgs e)
    {

    }

    private void cbStatus_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void cbFuelType_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void txtFunction_TextChanged(object sender, EventArgs e)
    {

    }

    private void txtKilometersDriven_TextChanged(object sender, EventArgs e)
    {

    }
}