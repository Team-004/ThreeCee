namespace ThreeCee.Forms
{
    partial class MainForm
    {

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MenuMain = new System.Windows.Forms.MenuStrip();
            this.dateiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.bearbeitenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ansichtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hilfeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.VehicleListBox = new System.Windows.Forms.ListBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolAdd = new System.Windows.Forms.ToolStripButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.numEstimatedCosts = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numCentPerLiter = new System.Windows.Forms.NumericUpDown();
            this.numKilometers = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDeleteVehicle = new System.Windows.Forms.Button();
            this.btnEditVehicle = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblFunctionStatusKilometers = new System.Windows.Forms.Label();
            this.lblModelFueltype = new System.Windows.Forms.Label();
            this.MenuMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCentPerLiter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numKilometers)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuMain
            // 
            this.MenuMain.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.MenuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.dateiToolStripMenuItem, this.bearbeitenToolStripMenuItem, this.ansichtToolStripMenuItem, this.hilfeToolStripMenuItem });
            this.MenuMain.Location = new System.Drawing.Point(0, 0);
            this.MenuMain.Name = "MenuMain";
            this.MenuMain.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.MenuMain.Size = new System.Drawing.Size(800, 24);
            this.MenuMain.TabIndex = 0;
            this.MenuMain.Text = "menuStrip1";
            // 
            // dateiToolStripMenuItem
            // 
            this.dateiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.MenuItemFileExit });
            this.dateiToolStripMenuItem.Name = "dateiToolStripMenuItem";
            this.dateiToolStripMenuItem.Size = new System.Drawing.Size(46, 22);
            this.dateiToolStripMenuItem.Text = "Datei";
            // 
            // beendenToolStripMenuItem
            // 
            this.MenuItemFileExit.Name = "MenuItemFileExit";
            this.MenuItemFileExit.Size = new System.Drawing.Size(120, 22);
            this.MenuItemFileExit.Text = "Beenden";
            this.MenuItemFileExit.Click += new System.EventHandler(this.MenuItemFileExit_Click);
            // 
            // bearbeitenToolStripMenuItem
            // 
            this.bearbeitenToolStripMenuItem.Name = "bearbeitenToolStripMenuItem";
            this.bearbeitenToolStripMenuItem.Size = new System.Drawing.Size(75, 22);
            this.bearbeitenToolStripMenuItem.Text = "Bearbeiten";
            // 
            // ansichtToolStripMenuItem
            // 
            this.ansichtToolStripMenuItem.Name = "ansichtToolStripMenuItem";
            this.ansichtToolStripMenuItem.Size = new System.Drawing.Size(59, 22);
            this.ansichtToolStripMenuItem.Text = "Ansicht";
            // 
            // hilfeToolStripMenuItem
            // 
            this.hilfeToolStripMenuItem.Name = "hilfeToolStripMenuItem";
            this.hilfeToolStripMenuItem.Size = new System.Drawing.Size(44, 22);
            this.hilfeToolStripMenuItem.Text = "Hilfe";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Size = new System.Drawing.Size(800, 426);
            this.splitContainer1.SplitterDistance = 266;
            this.splitContainer1.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.VehicleListBox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.toolStrip1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(266, 426);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // VehicleListBox
            // 
            this.VehicleListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VehicleListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VehicleListBox.FormattingEnabled = true;
            this.VehicleListBox.ItemHeight = 16;
            this.VehicleListBox.Location = new System.Drawing.Point(3, 28);
            this.VehicleListBox.Name = "VehicleListBox";
            this.VehicleListBox.Size = new System.Drawing.Size(260, 406);
            this.VehicleListBox.TabIndex = 0;
            this.VehicleListBox.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.VehicleListBox_DrawItem);
            this.VehicleListBox.MeasureItem += new System.Windows.Forms.MeasureItemEventHandler(this.VehicleListBox_MeasureItem);
            this.VehicleListBox.SelectedIndexChanged += new System.EventHandler(this.VehicleListBox_SelectedIndexChanged);
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.toolStripSeparator2, this.toolStripLabel1, this.toolStripSeparator1, this.toolAdd });
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStrip1.Size = new System.Drawing.Size(266, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(65, 22);
            this.toolStripLabel1.Text = "Fahrzeuge";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolAdd
            // 
            this.toolAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolAdd.Name = "toolAdd";
            this.toolAdd.Size = new System.Drawing.Size(33, 22);
            this.toolAdd.Text = "Neu";
            this.toolAdd.Click += new System.EventHandler(this.toolAdd_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.numEstimatedCosts);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.numCentPerLiter);
            this.groupBox2.Controls.Add(this.numKilometers);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(15, 126);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(501, 136);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Spritrechner";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(211, 63);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 9;
            this.textBox1.Text = "0,07";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(188, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Spritverbrauch (Liter/Km):";
            // 
            // numEstimatedCosts
            // 
            this.numEstimatedCosts.Enabled = false;
            this.numEstimatedCosts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numEstimatedCosts.Location = new System.Drawing.Point(270, 97);
            this.numEstimatedCosts.Name = "numEstimatedCosts";
            this.numEstimatedCosts.Size = new System.Drawing.Size(100, 26);
            this.numEstimatedCosts.TabIndex = 7;
            this.numEstimatedCosts.Text = "ergebnis";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(247, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Vorraussichtliche Fahrtkosten (€):";
            // 
            // numCentPerLiter
            // 
            this.numCentPerLiter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numCentPerLiter.Location = new System.Drawing.Point(323, 32);
            this.numCentPerLiter.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            this.numCentPerLiter.Name = "numCentPerLiter";
            this.numCentPerLiter.Size = new System.Drawing.Size(100, 26);
            this.numCentPerLiter.TabIndex = 5;
            this.numCentPerLiter.Value = new decimal(new int[] { 176, 0, 0, 0 });
            this.numCentPerLiter.ValueChanged += new System.EventHandler(this.numCentPerLiter_ValueChanged);
            // 
            // numKilometers
            // 
            this.numKilometers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numKilometers.Location = new System.Drawing.Point(98, 32);
            this.numKilometers.Name = "numKilometers";
            this.numKilometers.Size = new System.Drawing.Size(100, 26);
            this.numKilometers.TabIndex = 4;
            this.numKilometers.ValueChanged += new System.EventHandler(this.numKilometers_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(239, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cent/Liter:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kilometer:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnDeleteVehicle);
            this.groupBox1.Controls.Add(this.btnEditVehicle);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Controls.Add(this.lblFunctionStatusKilometers);
            this.groupBox1.Controls.Add(this.lblModelFueltype);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(15, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(501, 106);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informationen";
            // 
            // btnDeleteVehicle
            // 
            this.btnDeleteVehicle.Location = new System.Drawing.Point(323, 61);
            this.btnDeleteVehicle.Name = "btnDeleteVehicle";
            this.btnDeleteVehicle.Size = new System.Drawing.Size(167, 30);
            this.btnDeleteVehicle.TabIndex = 4;
            this.btnDeleteVehicle.Text = "Entfernen";
            this.btnDeleteVehicle.UseVisualStyleBackColor = true;
            this.btnDeleteVehicle.Click += new System.EventHandler(this.btnDeleteVehicle_Click);
            // 
            // btnEditVehicle
            // 
            this.btnEditVehicle.Location = new System.Drawing.Point(323, 24);
            this.btnEditVehicle.Name = "btnEditVehicle";
            this.btnEditVehicle.Size = new System.Drawing.Size(167, 30);
            this.btnEditVehicle.TabIndex = 3;
            this.btnEditVehicle.Text = "Bearbeiten";
            this.btnEditVehicle.UseVisualStyleBackColor = true;
            this.btnEditVehicle.Click += new System.EventHandler(this.btnEditVehicle_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(17, 25);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(132, 20);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Fahrzeugname";
            // 
            // lblFunctionStatusKilometers
            // 
            this.lblFunctionStatusKilometers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFunctionStatusKilometers.Location = new System.Drawing.Point(202, 25);
            this.lblFunctionStatusKilometers.Name = "lblFunctionStatusKilometers";
            this.lblFunctionStatusKilometers.Size = new System.Drawing.Size(121, 66);
            this.lblFunctionStatusKilometers.TabIndex = 2;
            this.lblFunctionStatusKilometers.Text = "Funktion\r\nStatus\r\nKilometer";
            // 
            // lblModelFueltype
            // 
            this.lblModelFueltype.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModelFueltype.Location = new System.Drawing.Point(17, 47);
            this.lblModelFueltype.Name = "lblModelFueltype";
            this.lblModelFueltype.Size = new System.Drawing.Size(150, 44);
            this.lblModelFueltype.TabIndex = 1;
            this.lblModelFueltype.Text = "Fahrzeugmodell\r\nKraftstoff";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.MenuMain);
            this.MainMenuStrip = this.MenuMain;
            this.Name = "MainForm";
            this.Text = "ThreeCee";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MenuMain.ResumeLayout(false);
            this.MenuMain.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCentPerLiter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numKilometers)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuMain;
        private System.Windows.Forms.ToolStripMenuItem dateiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bearbeitenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ansichtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hilfeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuItemFileExit;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListBox VehicleListBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolAdd;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblModelFueltype;
        private System.Windows.Forms.Label lblFunctionStatusKilometers;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numCentPerLiter;
        private System.Windows.Forms.NumericUpDown numKilometers;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox numEstimatedCosts;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnEditVehicle;
        private System.Windows.Forms.Button btnDeleteVehicle;
    }
}

