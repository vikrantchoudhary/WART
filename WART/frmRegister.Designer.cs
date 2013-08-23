﻿namespace WART
{
    partial class frmRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegister));
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.btnCodeRequest = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.grpStep1 = new System.Windows.Forms.GroupBox();
            this.radVoice = new System.Windows.Forms.RadioButton();
            this.radSMS = new System.Windows.Forms.RadioButton();
            this.grpStep2 = new System.Windows.Forms.GroupBox();
            this.btnRegisterCode = new System.Windows.Forms.Button();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.grpResult = new System.Windows.Forms.GroupBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.grpStep1.SuspendLayout();
            this.grpStep2.SuspendLayout();
            this.grpResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(111, 19);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(142, 20);
            this.txtPhoneNumber.TabIndex = 1;
            // 
            // btnCodeRequest
            // 
            this.btnCodeRequest.Location = new System.Drawing.Point(159, 72);
            this.btnCodeRequest.Name = "btnCodeRequest";
            this.btnCodeRequest.Size = new System.Drawing.Size(94, 23);
            this.btnCodeRequest.TabIndex = 6;
            this.btnCodeRequest.Text = "Request code";
            this.btnCodeRequest.UseVisualStyleBackColor = true;
            this.btnCodeRequest.Click += new System.EventHandler(this.btnCodeRequest_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Phone number";
            // 
            // grpStep1
            // 
            this.grpStep1.Controls.Add(this.label3);
            this.grpStep1.Controls.Add(this.txtPassword);
            this.grpStep1.Controls.Add(this.radVoice);
            this.grpStep1.Controls.Add(this.radSMS);
            this.grpStep1.Controls.Add(this.label2);
            this.grpStep1.Controls.Add(this.btnCodeRequest);
            this.grpStep1.Controls.Add(this.txtPhoneNumber);
            this.grpStep1.Location = new System.Drawing.Point(13, 13);
            this.grpStep1.Name = "grpStep1";
            this.grpStep1.Size = new System.Drawing.Size(259, 104);
            this.grpStep1.TabIndex = 4;
            this.grpStep1.TabStop = false;
            this.grpStep1.Text = "Step 1: Request code";
            // 
            // radVoice
            // 
            this.radVoice.AutoSize = true;
            this.radVoice.Location = new System.Drawing.Point(63, 75);
            this.radVoice.Name = "radVoice";
            this.radVoice.Size = new System.Drawing.Size(52, 17);
            this.radVoice.TabIndex = 3;
            this.radVoice.Text = "Voice";
            this.radVoice.UseVisualStyleBackColor = true;
            // 
            // radSMS
            // 
            this.radSMS.AutoSize = true;
            this.radSMS.Checked = true;
            this.radSMS.Location = new System.Drawing.Point(9, 75);
            this.radSMS.Name = "radSMS";
            this.radSMS.Size = new System.Drawing.Size(48, 17);
            this.radSMS.TabIndex = 3;
            this.radSMS.TabStop = true;
            this.radSMS.Text = "SMS";
            this.radSMS.UseVisualStyleBackColor = true;
            // 
            // grpStep2
            // 
            this.grpStep2.Controls.Add(this.btnRegisterCode);
            this.grpStep2.Controls.Add(this.txtCode);
            this.grpStep2.Controls.Add(this.label1);
            this.grpStep2.Enabled = false;
            this.grpStep2.Location = new System.Drawing.Point(12, 123);
            this.grpStep2.Name = "grpStep2";
            this.grpStep2.Size = new System.Drawing.Size(259, 50);
            this.grpStep2.TabIndex = 5;
            this.grpStep2.TabStop = false;
            this.grpStep2.Text = "Step 2: Confirm code";
            // 
            // btnRegisterCode
            // 
            this.btnRegisterCode.Location = new System.Drawing.Point(159, 17);
            this.btnRegisterCode.Name = "btnRegisterCode";
            this.btnRegisterCode.Size = new System.Drawing.Size(94, 23);
            this.btnRegisterCode.TabIndex = 2;
            this.btnRegisterCode.Text = "Confirm code";
            this.btnRegisterCode.UseVisualStyleBackColor = true;
            this.btnRegisterCode.Click += new System.EventHandler(this.btnRegisterCode_Click);
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(88, 19);
            this.txtCode.MaxLength = 6;
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(65, 20);
            this.txtCode.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Code";
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(9, 19);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.Size = new System.Drawing.Size(244, 102);
            this.txtOutput.TabIndex = 3;
            // 
            // grpResult
            // 
            this.grpResult.Controls.Add(this.txtOutput);
            this.grpResult.Enabled = false;
            this.grpResult.Location = new System.Drawing.Point(13, 179);
            this.grpResult.Name = "grpResult";
            this.grpResult.Size = new System.Drawing.Size(259, 134);
            this.grpResult.TabIndex = 7;
            this.grpResult.TabStop = false;
            this.grpResult.Text = "Step 3: Retrieve password";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(111, 46);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(142, 20);
            this.txtPassword.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Password (optional)";
            // 
            // frmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 323);
            this.Controls.Add(this.grpResult);
            this.Controls.Add(this.grpStep2);
            this.Controls.Add(this.grpStep1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRegister";
            this.Text = "WhatsApp Registration";
            this.grpStep1.ResumeLayout(false);
            this.grpStep1.PerformLayout();
            this.grpStep2.ResumeLayout(false);
            this.grpStep2.PerformLayout();
            this.grpResult.ResumeLayout(false);
            this.grpResult.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Button btnCodeRequest;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grpStep1;
        private System.Windows.Forms.RadioButton radSMS;
        private System.Windows.Forms.GroupBox grpStep2;
        private System.Windows.Forms.RadioButton radVoice;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Button btnRegisterCode;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpResult;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPassword;
    }
}