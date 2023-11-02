using System;
using System.Drawing;
using System.Windows.Forms;

namespace ThreeCee
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            PopulateVehicleList();
        }

        private void PopulateVehicleList()
        {
            var list = Vehicle.GetDummyVehicles();

            list.ForEach(it => VehicleListBox.Items.Add($"{it.Name}, {it.Model}"));
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
    }
}