using System;
using System.Windows.Forms;
using ThreeCee.Models;

namespace ThreeCee.Forms;

public partial class VehicleEditForm : Form
{
    private Vehicle _vehicle;

    public VehicleEditForm(Vehicle vehicle)
    {
        InitializeComponent();
        _vehicle = vehicle;
    }

    private void button1_Click(object sender, EventArgs e)
    {
        _vehicle.Id = int.Parse(txtID.Text);
        // _vehicle.Model = txtModel.Text;
        // _vehicle.Name = txtModel.Text;
        // _vehicle.FuelType = 
    }
    
    private void VehicleEditForm_Load(object sender, EventArgs e)
    {
        Console.WriteLine(_vehicle.Name);
    }
}