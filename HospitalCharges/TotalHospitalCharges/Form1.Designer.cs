namespace TotalHospitalCharges
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.daysSelector = new System.Windows.Forms.NumericUpDown();
            this.surgInput = new System.Windows.Forms.TextBox();
            this.labInput = new System.Windows.Forms.TextBox();
            this.rehabInput = new System.Windows.Forms.TextBox();
            this.medInput = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.daysSelector)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(392, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Visit Charge Calulator";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Total days in: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(216, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Medication Charges: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Surgical Charges:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Lab Fees:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 332);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(217, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Physical Rehab Fee: ";
            // 
            // daysSelector
            // 
            this.daysSelector.Location = new System.Drawing.Point(362, 109);
            this.daysSelector.Name = "daysSelector";
            this.daysSelector.Size = new System.Drawing.Size(120, 31);
            this.daysSelector.TabIndex = 6;
            // 
            // surgInput
            // 
            this.surgInput.Location = new System.Drawing.Point(382, 208);
            this.surgInput.Name = "surgInput";
            this.surgInput.Size = new System.Drawing.Size(100, 31);
            this.surgInput.TabIndex = 7;
            // 
            // labInput
            // 
            this.labInput.Location = new System.Drawing.Point(382, 261);
            this.labInput.Name = "labInput";
            this.labInput.Size = new System.Drawing.Size(100, 31);
            this.labInput.TabIndex = 8;
            // 
            // rehabInput
            // 
            this.rehabInput.Location = new System.Drawing.Point(382, 326);
            this.rehabInput.Name = "rehabInput";
            this.rehabInput.Size = new System.Drawing.Size(100, 31);
            this.rehabInput.TabIndex = 9;
            // 
            // medInput
            // 
            this.medInput.Location = new System.Drawing.Point(382, 158);
            this.medInput.Name = "medInput";
            this.medInput.Size = new System.Drawing.Size(100, 31);
            this.medInput.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(189, 403);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 74);
            this.button1.TabIndex = 11;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 521);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.medInput);
            this.Controls.Add(this.rehabInput);
            this.Controls.Add(this.labInput);
            this.Controls.Add(this.surgInput);
            this.Controls.Add(this.daysSelector);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.daysSelector)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown daysSelector;
        private System.Windows.Forms.TextBox surgInput;
        private System.Windows.Forms.TextBox labInput;
        private System.Windows.Forms.TextBox rehabInput;
        private System.Windows.Forms.TextBox medInput;
        private System.Windows.Forms.Button button1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

