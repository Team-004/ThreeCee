using System.ComponentModel;

namespace ThreeCee.Forms;

partial class EditVehicleForm
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

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
            this.button1 = new System.Windows.Forms.Button();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.cbFuelType = new System.Windows.Forms.ComboBox();
            this.txtFunction = new System.Windows.Forms.TextBox();
            this.txtFuelPerKm = new System.Windows.Forms.TextBox();
            this.txtKilometersDriven = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 213);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 28);
            this.button1.TabIndex = 8;
            this.button1.Text = "Übernehmen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(12, 12);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(100, 22);
            this.txtModel.TabIndex = 9;
            this.txtModel.TextChanged += new System.EventHandler(this.txtModel_TextChanged);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(12, 40);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 22);
            this.txtName.TabIndex = 10;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // cbStatus
            // 
            this.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            "Gekauft",
            "Geleast"});
            this.cbStatus.Location = new System.Drawing.Point(12, 68);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(100, 24);
            this.cbStatus.TabIndex = 11;
            this.cbStatus.SelectedIndexChanged += new System.EventHandler(this.cbStatus_SelectedIndexChanged);
            // 
            // cbFuelType
            // 
            this.cbFuelType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFuelType.FormattingEnabled = true;
            this.cbFuelType.Items.AddRange(new object[] {
            "Benzin",
            "Diesel"});
            this.cbFuelType.Location = new System.Drawing.Point(12, 98);
            this.cbFuelType.Name = "cbFuelType";
            this.cbFuelType.Size = new System.Drawing.Size(100, 24);
            this.cbFuelType.TabIndex = 12;
            this.cbFuelType.SelectedIndexChanged += new System.EventHandler(this.cbFuelType_SelectedIndexChanged);
            // 
            // txtFunction
            // 
            this.txtFunction.Location = new System.Drawing.Point(12, 128);
            this.txtFunction.Name = "txtFunction";
            this.txtFunction.Size = new System.Drawing.Size(100, 22);
            this.txtFunction.TabIndex = 13;
            this.txtFunction.TextChanged += new System.EventHandler(this.txtFunction_TextChanged);
            // 
            // txtFuelPerKm
            // 
            this.txtFuelPerKm.Location = new System.Drawing.Point(12, 156);
            this.txtFuelPerKm.Name = "txtFuelPerKm";
            this.txtFuelPerKm.Size = new System.Drawing.Size(100, 22);
            this.txtFuelPerKm.TabIndex = 14;
            // 
            // txtKilometersDriven
            // 
            this.txtKilometersDriven.Location = new System.Drawing.Point(12, 184);
            this.txtKilometersDriven.Name = "txtKilometersDriven";
            this.txtKilometersDriven.Size = new System.Drawing.Size(100, 22);
            this.txtKilometersDriven.TabIndex = 15;
            this.txtKilometersDriven.TextChanged += new System.EventHandler(this.txtKilometersDriven_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "Model";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(118, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 18;
            this.label3.Text = "Status";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(118, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 19;
            this.label4.Text = "Kraftstoffart";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(118, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 16);
            this.label5.TabIndex = 20;
            this.label5.Text = "Funktion";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(118, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 16);
            this.label6.TabIndex = 21;
            this.label6.Text = "Verbrauch auf 100Km";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(118, 190);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 16);
            this.label7.TabIndex = 22;
            this.label7.Text = "Gefahrene Kilometer";
            // 
            // EditVehicleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 250);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtKilometersDriven);
            this.Controls.Add(this.txtFuelPerKm);
            this.Controls.Add(this.txtFunction);
            this.Controls.Add(this.cbFuelType);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EditVehicleForm";
            this.Text = "VehicleEditForm";
            this.Load += new System.EventHandler(this.VehicleEditForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    private System.Windows.Forms.Button button1;

    #endregion
    private System.Windows.Forms.TextBox txtModel;
    private System.Windows.Forms.TextBox txtName;
    private System.Windows.Forms.ComboBox cbStatus;
    private System.Windows.Forms.ComboBox cbFuelType;
    private System.Windows.Forms.TextBox txtFunction;
    private System.Windows.Forms.TextBox txtFuelPerKm;
    private System.Windows.Forms.TextBox txtKilometersDriven;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label label7;
}