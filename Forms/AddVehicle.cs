using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThreeCee.Forms
{
    public partial class AddVehicle : Form
    {
        public AddVehicle()
        {
            InitializeComponent();
        }

        private void AddVehicle_Load(object sender, EventArgs e)
        {

        }

        private void addVehicleButton_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("Add vehicle Button clicked!");

        }
    }
}
