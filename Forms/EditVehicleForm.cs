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
        Program.mainForm.UpdateVehicleList();
        Program.mainForm.UpdateVehicleInfo();
        Close();
    }

    private void VehicleEditForm_Load(object sender, EventArgs e)
    {
        txtModel.Text = _vehicle.Model;
        txtName.Text = _vehicle.Name;
        cbStatus.Text = _vehicle.Status.ToString();
        cbFuelType.Text = _vehicle.FuelType.ToString();
        txtFunction.Text = _vehicle.Function;
        txtFuelPerKm.Text = (_vehicle.FuelConsumptionLPerKm*100).ToString();
        txtKilometersDriven.Text = _vehicle.KilometersDriven.ToString();

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