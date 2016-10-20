namespace WindowsFormsApplication8
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
            this.lblinput1 = new System.Windows.Forms.Label();
            this.lblinput2 = new System.Windows.Forms.Label();
            this.txtoutput1 = new System.Windows.Forms.TextBox();
            this.txtoutput2 = new System.Windows.Forms.TextBox();
            this.lblDisplay = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.total = new System.Windows.Forms.Label();
            this.btnCaculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblinput1
            // 
            this.lblinput1.AutoSize = true;
            this.lblinput1.Location = new System.Drawing.Point(540, 183);
            this.lblinput1.Name = "lblinput1";
            this.lblinput1.Size = new System.Drawing.Size(32, 13);
            this.lblinput1.TabIndex = 0;
            this.lblinput1.Text = "item1";
            // 
            // lblinput2
            // 
            this.lblinput2.AutoSize = true;
            this.lblinput2.Location = new System.Drawing.Point(543, 262);
            this.lblinput2.Name = "lblinput2";
            this.lblinput2.Size = new System.Drawing.Size(32, 13);
            this.lblinput2.TabIndex = 1;
            this.lblinput2.Text = "item2";
            // 
            // txtoutput1
            // 
            this.txtoutput1.Location = new System.Drawing.Point(710, 175);
            this.txtoutput1.Name = "txtoutput1";
            this.txtoutput1.Size = new System.Drawing.Size(100, 20);
            this.txtoutput1.TabIndex = 2;
            // 
            // txtoutput2
            // 
            this.txtoutput2.Location = new System.Drawing.Point(710, 262);
            this.txtoutput2.Name = "txtoutput2";
            this.txtoutput2.Size = new System.Drawing.Size(100, 20);
            this.txtoutput2.TabIndex = 3;
            // 
            // lblDisplay
            // 
            this.lblDisplay.Location = new System.Drawing.Point(707, 357);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(284, 105);
            this.lblDisplay.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(597, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // total
            // 
            this.total.AutoSize = true;
            this.total.Location = new System.Drawing.Point(543, 371);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(30, 13);
            this.total.TabIndex = 6;
            this.total.Text = "total:";
            // 
            // btnCaculate
            // 
            this.btnCaculate.Location = new System.Drawing.Point(983, 251);
            this.btnCaculate.Name = "btnCaculate";
            this.btnCaculate.Size = new System.Drawing.Size(75, 23);
            this.btnCaculate.TabIndex = 7;
            this.btnCaculate.Text = "Caculate";
            this.btnCaculate.UseVisualStyleBackColor = true;
            this.btnCaculate.Click += new System.EventHandler(this.btnCaculate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1369, 624);
            this.Controls.Add(this.btnCaculate);
            this.Controls.Add(this.total);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDisplay);
            this.Controls.Add(this.txtoutput2);
            this.Controls.Add(this.txtoutput1);
            this.Controls.Add(this.lblinput2);
            this.Controls.Add(this.lblinput1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblinput1;
        private System.Windows.Forms.Label lblinput2;
        private System.Windows.Forms.TextBox txtoutput1;
        private System.Windows.Forms.TextBox txtoutput2;
        private System.Windows.Forms.Label lblDisplay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label total;
        private System.Windows.Forms.Button btnCaculate;
    }
}

