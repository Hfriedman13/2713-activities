namespace HospitalCharges
{
    partial class Form1
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
            this.stayCharge = new System.Windows.Forms.Button();
            this.MiscCharges = new System.Windows.Forms.Button();
            this.totalCharges = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.days = new System.Windows.Forms.TextBox();
            this.med = new System.Windows.Forms.TextBox();
            this.surg = new System.Windows.Forms.TextBox();
            this.lab = new System.Windows.Forms.TextBox();
            this.rehab = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // stayCharge
            // 
            this.stayCharge.Location = new System.Drawing.Point(12, 384);
            this.stayCharge.Name = "stayCharge";
            this.stayCharge.Size = new System.Drawing.Size(170, 54);
            this.stayCharge.TabIndex = 0;
            this.stayCharge.Text = "Stay Charges";
            this.stayCharge.UseVisualStyleBackColor = true;
            this.stayCharge.Click += new System.EventHandler(this.stayCharge_Click);
            // 
            // MiscCharges
            // 
            this.MiscCharges.Location = new System.Drawing.Point(282, 384);
            this.MiscCharges.Name = "MiscCharges";
            this.MiscCharges.Size = new System.Drawing.Size(186, 54);
            this.MiscCharges.TabIndex = 1;
            this.MiscCharges.Text = "Misc Charges";
            this.MiscCharges.UseVisualStyleBackColor = true;
            this.MiscCharges.Click += new System.EventHandler(this.MiscCharges_Click);
            // 
            // totalCharges
            // 
            this.totalCharges.Location = new System.Drawing.Point(588, 384);
            this.totalCharges.Name = "totalCharges";
            this.totalCharges.Size = new System.Drawing.Size(167, 54);
            this.totalCharges.TabIndex = 2;
            this.totalCharges.Text = "Total Charges";
            this.totalCharges.UseVisualStyleBackColor = true;
            this.totalCharges.Click += new System.EventHandler(this.totalCharges_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Days Spent :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Medication Charges :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Surgical Charges :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Lab Fees :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 292);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(242, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "Rehabilitation Charges :";
            // 
            // days
            // 
            this.days.Location = new System.Drawing.Point(404, 43);
            this.days.Name = "days";
            this.days.Size = new System.Drawing.Size(100, 31);
            this.days.TabIndex = 8;
            // 
            // med
            // 
            this.med.Location = new System.Drawing.Point(404, 105);
            this.med.Name = "med";
            this.med.Size = new System.Drawing.Size(100, 31);
            this.med.TabIndex = 9;
            // 
            // surg
            // 
            this.surg.Location = new System.Drawing.Point(404, 170);
            this.surg.Name = "surg";
            this.surg.Size = new System.Drawing.Size(100, 31);
            this.surg.TabIndex = 10;
            // 
            // lab
            // 
            this.lab.Location = new System.Drawing.Point(404, 226);
            this.lab.Name = "lab";
            this.lab.Size = new System.Drawing.Size(100, 31);
            this.lab.TabIndex = 11;
            // 
            // rehab
            // 
            this.rehab.Location = new System.Drawing.Point(404, 286);
            this.rehab.Name = "rehab";
            this.rehab.Size = new System.Drawing.Size(100, 31);
            this.rehab.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rehab);
            this.Controls.Add(this.lab);
            this.Controls.Add(this.surg);
            this.Controls.Add(this.med);
            this.Controls.Add(this.days);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.totalCharges);
            this.Controls.Add(this.MiscCharges);
            this.Controls.Add(this.stayCharge);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button stayCharge;
        private System.Windows.Forms.Button MiscCharges;
        private System.Windows.Forms.Button totalCharges;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox days;
        private System.Windows.Forms.TextBox med;
        private System.Windows.Forms.TextBox surg;
        private System.Windows.Forms.TextBox lab;
        private System.Windows.Forms.TextBox rehab;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

