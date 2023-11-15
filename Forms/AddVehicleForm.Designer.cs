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
            this.nameTextBox.Location = new System.Drawing.Point(269, 61);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(109, 20);
            this.nameTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fahrzeug Name";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(81, 6);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fahrzeug hinzufügen";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 90);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Fahrzeug Modell";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 120);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Kraftstoff Art";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 149);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Funktion";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 178);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Status";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 234);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(184, 17);
            this.label7.TabIndex = 7;
            this.label7.Text = "Bereits gefahrene Kilometer";
            // 
            // modellTextBox
            // 
            this.modellTextBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.modellTextBox.Location = new System.Drawing.Point(269, 91);
            this.modellTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.modellTextBox.Name = "modellTextBox";
            this.modellTextBox.Size = new System.Drawing.Size(109, 20);
            this.modellTextBox.TabIndex = 1;
            // 
            // functionTextBox
            // 
            this.functionTextBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.functionTextBox.Location = new System.Drawing.Point(269, 148);
            this.functionTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.functionTextBox.Name = "functionTextBox";
            this.functionTextBox.Size = new System.Drawing.Size(109, 20);
            this.functionTextBox.TabIndex = 3;
            // 
            // kilometerNumberBox
            // 
            this.kilometerNumberBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.kilometerNumberBox.Location = new System.Drawing.Point(269, 233);
            this.kilometerNumberBox.Margin = new System.Windows.Forms.Padding(2);
            this.kilometerNumberBox.Name = "kilometerNumberBox";
            this.kilometerNumberBox.Size = new System.Drawing.Size(108, 20);
            this.kilometerNumberBox.TabIndex = 6;
            // 
            // addVehicleButton
            // 
            this.addVehicleButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.addVehicleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addVehicleButton.Location = new System.Drawing.Point(85, 270);
            this.addVehicleButton.Margin = new System.Windows.Forms.Padding(2);
            this.addVehicleButton.Name = "addVehicleButton";
            this.addVehicleButton.Size = new System.Drawing.Size(194, 29);
            this.addVehicleButton.TabIndex = 13;
            this.addVehicleButton.Text = "Fahrzeug hinzufügen";
            this.addVehicleButton.UseVisualStyleBackColor = true;
            this.addVehicleButton.Click += new System.EventHandler(this.addVehicleButton_Click);
            // 
            // fuelTypeComboBox
            // 
            this.fuelTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fuelTypeComboBox.FormattingEnabled = true;
            this.fuelTypeComboBox.Items.AddRange(new object[] { "Diesel", "Benzin", "Strom" });
            this.fuelTypeComboBox.Location = new System.Drawing.Point(269, 118);
            this.fuelTypeComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.fuelTypeComboBox.Name = "fuelTypeComboBox";
            this.fuelTypeComboBox.Size = new System.Drawing.Size(109, 21);
            this.fuelTypeComboBox.TabIndex = 2;
            // 
            // statusComboBox
            // 
            this.statusComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statusComboBox.FormattingEnabled = true;
            this.statusComboBox.Items.AddRange(new object[] { "Gekauft", "Geleast" });
            this.statusComboBox.Location = new System.Drawing.Point(269, 179);
            this.statusComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(109, 21);
            this.statusComboBox.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(16, 204);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 17);
            this.label8.TabIndex = 16;
            this.label8.Text = "Verbrauch in L / Km";
            // 
            // fuelConsumptionNumberBox
            // 
            this.fuelConsumptionNumberBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.fuelConsumptionNumberBox.Location = new System.Drawing.Point(269, 205);
            this.fuelConsumptionNumberBox.Margin = new System.Windows.Forms.Padding(2);
            this.fuelConsumptionNumberBox.Name = "fuelConsumptionNumberBox";
            this.fuelConsumptionNumberBox.Size = new System.Drawing.Size(108, 20);
            this.fuelConsumptionNumberBox.TabIndex = 5;
            // 
            // AddVehicleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 306);
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
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(405, 339);
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