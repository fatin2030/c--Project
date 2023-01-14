namespace TestForm1
{
    partial class Salesman_Profile
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
            this.btnBackToForm3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCurrentPass = new System.Windows.Forms.Label();
            this.btnNewPass = new System.Windows.Forms.Label();
            this.txtCurrentPass = new System.Windows.Forms.TextBox();
            this.txtNewPass = new System.Windows.Forms.TextBox();
            this.btnSavePass = new System.Windows.Forms.Button();
            this.lblUserId = new System.Windows.Forms.Label();
            this.txtUserId = new System.Windows.Forms.TextBox();
            this.lblMistake = new System.Windows.Forms.Label();
            this.txtConfirmPass = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBackToForm3
            // 
            this.btnBackToForm3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnBackToForm3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackToForm3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBackToForm3.Location = new System.Drawing.Point(12, 381);
            this.btnBackToForm3.Name = "btnBackToForm3";
            this.btnBackToForm3.Size = new System.Drawing.Size(94, 39);
            this.btnBackToForm3.TabIndex = 0;
            this.btnBackToForm3.Text = "<<Back";
            this.btnBackToForm3.UseVisualStyleBackColor = false;
            this.btnBackToForm3.Click += new System.EventHandler(this.btnBackToForm3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Change Password";
            // 
            // lblCurrentPass
            // 
            this.lblCurrentPass.AutoSize = true;
            this.lblCurrentPass.Location = new System.Drawing.Point(26, 109);
            this.lblCurrentPass.Name = "lblCurrentPass";
            this.lblCurrentPass.Size = new System.Drawing.Size(112, 16);
            this.lblCurrentPass.TabIndex = 2;
            this.lblCurrentPass.Text = "Current Password";
            // 
            // btnNewPass
            // 
            this.btnNewPass.AutoSize = true;
            this.btnNewPass.Location = new System.Drawing.Point(29, 153);
            this.btnNewPass.Name = "btnNewPass";
            this.btnNewPass.Size = new System.Drawing.Size(97, 16);
            this.btnNewPass.TabIndex = 3;
            this.btnNewPass.Text = "New Password";
            // 
            // txtCurrentPass
            // 
            this.txtCurrentPass.Location = new System.Drawing.Point(160, 106);
            this.txtCurrentPass.Name = "txtCurrentPass";
            this.txtCurrentPass.Size = new System.Drawing.Size(100, 22);
            this.txtCurrentPass.TabIndex = 4;
            // 
            // txtNewPass
            // 
            this.txtNewPass.Location = new System.Drawing.Point(160, 147);
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.Size = new System.Drawing.Size(100, 22);
            this.txtNewPass.TabIndex = 5;
            // 
            // btnSavePass
            // 
            this.btnSavePass.Location = new System.Drawing.Point(129, 244);
            this.btnSavePass.Name = "btnSavePass";
            this.btnSavePass.Size = new System.Drawing.Size(75, 23);
            this.btnSavePass.TabIndex = 6;
            this.btnSavePass.Text = "Save";
            this.btnSavePass.UseVisualStyleBackColor = true;
            this.btnSavePass.Click += new System.EventHandler(this.btnSavePass_Click);
            // 
            // lblUserId
            // 
            this.lblUserId.AutoSize = true;
            this.lblUserId.Location = new System.Drawing.Point(29, 63);
            this.lblUserId.Name = "lblUserId";
            this.lblUserId.Size = new System.Drawing.Size(83, 16);
            this.lblUserId.TabIndex = 7;
            this.lblUserId.Text = "Enter Your Id";
            // 
            // txtUserId
            // 
            this.txtUserId.Location = new System.Drawing.Point(160, 63);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.Size = new System.Drawing.Size(100, 22);
            this.txtUserId.TabIndex = 8;
            // 
            // lblMistake
            // 
            this.lblMistake.AutoSize = true;
            this.lblMistake.Location = new System.Drawing.Point(41, 197);
            this.lblMistake.Name = "lblMistake";
            this.lblMistake.Size = new System.Drawing.Size(115, 16);
            this.lblMistake.TabIndex = 9;
            this.lblMistake.Text = "Confirm Password";
            // 
            // txtConfirmPass
            // 
            this.txtConfirmPass.Location = new System.Drawing.Point(160, 191);
            this.txtConfirmPass.Name = "txtConfirmPass";
            this.txtConfirmPass.Size = new System.Drawing.Size(100, 22);
            this.txtConfirmPass.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtConfirmPass);
            this.panel1.Controls.Add(this.lblCurrentPass);
            this.panel1.Controls.Add(this.lblMistake);
            this.panel1.Controls.Add(this.btnNewPass);
            this.panel1.Controls.Add(this.txtUserId);
            this.panel1.Controls.Add(this.txtCurrentPass);
            this.panel1.Controls.Add(this.lblUserId);
            this.panel1.Controls.Add(this.txtNewPass);
            this.panel1.Controls.Add(this.btnSavePass);
            this.panel1.Location = new System.Drawing.Point(197, 79);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(352, 302);
            this.panel1.TabIndex = 11;
            // 
            // Salesman_Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnBackToForm3);
            this.Name = "Salesman_Profile";
            this.Text = "Salesman_Profile";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBackToForm3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCurrentPass;
        private System.Windows.Forms.Label btnNewPass;
        private System.Windows.Forms.TextBox txtCurrentPass;
        private System.Windows.Forms.TextBox txtNewPass;
        private System.Windows.Forms.Button btnSavePass;
        private System.Windows.Forms.Label lblUserId;
        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.Label lblMistake;
        private System.Windows.Forms.TextBox txtConfirmPass;
        private System.Windows.Forms.Panel panel1;
    }
}