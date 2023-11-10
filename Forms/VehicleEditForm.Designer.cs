using System.ComponentModel;

namespace ThreeCee.Forms;

partial class VehicleEditForm
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
        this.txtID = new System.Windows.Forms.TextBox();
        this.button1 = new System.Windows.Forms.Button();
        this.SuspendLayout();
        // 
        // txtID
        // 
        this.txtID.Location = new System.Drawing.Point(18, 11);
        this.txtID.Name = "txtID";
        this.txtID.Size = new System.Drawing.Size(100, 20);
        this.txtID.TabIndex = 0;
        // 
        // button1
        // 
        this.button1.Location = new System.Drawing.Point(18, 219);
        this.button1.Name = "button1";
        this.button1.Size = new System.Drawing.Size(100, 23);
        this.button1.TabIndex = 8;
        this.button1.Text = "Übernehmen";
        this.button1.UseVisualStyleBackColor = true;
        this.button1.Click += new System.EventHandler(this.button1_Click);
        // 
        // VehicleEditForm
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(800, 450);
        this.Controls.Add(this.button1);
        this.Controls.Add(this.txtID);
        this.Name = "VehicleEditForm";
        this.Text = "VehicleEditForm";
        this.Load += new System.EventHandler(this.VehicleEditForm_Load);
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    private System.Windows.Forms.Button button1;

    private System.Windows.Forms.TextBox txtID;

    #endregion
}