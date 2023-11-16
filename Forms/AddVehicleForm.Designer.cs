namespace ThreeCee.Forms
{
    partial class AddVehicleForm
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
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.modellTextBox = new System.Windows.Forms.TextBox();
            this.functionTextBox = new System.Windows.Forms.TextBox();
            this.kilometerNumberBox = new System.Windows.Forms.NumericUpDown();
            this.addVehicleButton = new System.Windows.Forms.Button();
            this.fuelTypeComboBox = new System.Windows.Forms.ComboBox();
            this.statusComboBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.fuelConsumptionNumberBox = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.kilometerNumberBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fuelConsumptionNumberBox)).BeginInit();
            this.SuspendLayout();
            // 
            // nameTextBox
            // 
            this.nameTextBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.nameTextBox.Location = new System.Drawing.Point(359, 75);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(144, 22);
            this.nameTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fahrzeug Name";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(108, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(250, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fahrzeug hinzufügen";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Fahrzeug Modell";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Kraftstoff Art";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Funktion";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(21, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Status";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(21, 288);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(218, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Bereits gefahrene Kilometer";
            // 
            // modellTextBox
            // 
            this.modellTextBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.modellTextBox.Location = new System.Drawing.Point(359, 112);
            this.modellTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.modellTextBox.Name = "modellTextBox";
            this.modellTextBox.Size = new System.Drawing.Size(144, 22);
            this.modellTextBox.TabIndex = 1;
            // 
            // functionTextBox
            // 
            this.functionTextBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.functionTextBox.Location = new System.Drawing.Point(359, 182);
            this.functionTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.functionTextBox.Name = "functionTextBox";
            this.functionTextBox.Size = new System.Drawing.Size(144, 22);
            this.functionTextBox.TabIndex = 3;
            // 
            // kilometerNumberBox
            // 
            this.kilometerNumberBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.kilometerNumberBox.Location = new System.Drawing.Point(359, 287);
            this.kilometerNumberBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kilometerNumberBox.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.kilometerNumberBox.Name = "kilometerNumberBox";
            this.kilometerNumberBox.Size = new System.Drawing.Size(144, 22);
            this.kilometerNumberBox.TabIndex = 6;
            // 
            // addVehicleButton
            // 
            this.addVehicleButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.addVehicleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addVehicleButton.Location = new System.Drawing.Point(113, 332);
            this.addVehicleButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addVehicleButton.Name = "addVehicleButton";
            this.addVehicleButton.Size = new System.Drawing.Size(259, 36);
            this.addVehicleButton.TabIndex = 13;
            this.addVehicleButton.Text = "Fahrzeug hinzufügen";
            this.addVehicleButton.UseVisualStyleBackColor = true;
            this.addVehicleButton.Click += new System.EventHandler(this.addVehicleButton_Click);
            // 
            // fuelTypeComboBox
            // 
            this.fuelTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fuelTypeComboBox.FormattingEnabled = true;
            this.fuelTypeComboBox.Items.AddRange(new object[] {
            "Diesel",
            "Benzin"});
            this.fuelTypeComboBox.Location = new System.Drawing.Point(359, 145);
            this.fuelTypeComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fuelTypeComboBox.Name = "fuelTypeComboBox";
            this.fuelTypeComboBox.Size = new System.Drawing.Size(144, 24);
            this.fuelTypeComboBox.TabIndex = 2;
            // 
            // statusComboBox
            // 
            this.statusComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statusComboBox.FormattingEnabled = true;
            this.statusComboBox.Items.AddRange(new object[] {
            "Gekauft",
            "Geleast"});
            this.statusComboBox.Location = new System.Drawing.Point(359, 220);
            this.statusComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(144, 24);
            this.statusComboBox.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(21, 251);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(186, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "Verbrauch in L / 100Km";
            // 
            // fuelConsumptionNumberBox
            // 
            this.fuelConsumptionNumberBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.fuelConsumptionNumberBox.Location = new System.Drawing.Point(359, 252);
            this.fuelConsumptionNumberBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fuelConsumptionNumberBox.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.fuelConsumptionNumberBox.Name = "fuelConsumptionNumberBox";
            this.fuelConsumptionNumberBox.Size = new System.Drawing.Size(144, 22);
            this.fuelConsumptionNumberBox.TabIndex = 5;
            this.fuelConsumptionNumberBox.ValueChanged += new System.EventHandler(this.fuelConsumptionNumberBox_ValueChanged);
            // 
            // AddVehicleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 377);
            this.Controls.Add(this.fuelConsumptionNumberBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.statusComboBox);
            this.Controls.Add(this.fuelTypeComboBox);
            this.Controls.Add(this.addVehicleButton);
            this.Controls.Add(this.kilometerNumberBox);
            this.Controls.Add(this.functionTextBox);
            this.Controls.Add(this.modellTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameTextBox);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(534, 406);
            this.Name = "AddVehicleForm";
            this.Text = "Fahrzeug hinzufügen";
            this.Load += new System.EventHandler(this.AddVehicle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kilometerNumberBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fuelConsumptionNumberBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox modellTextBox;
        private System.Windows.Forms.TextBox functionTextBox;
        private System.Windows.Forms.NumericUpDown kilometerNumberBox;
        private System.Windows.Forms.Button addVehicleButton;
        private System.Windows.Forms.ComboBox fuelTypeComboBox;
        private System.Windows.Forms.ComboBox statusComboBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown fuelConsumptionNumberBox;
    }
}