namespace WindowsFormsApp1
{
    partial class EmailFile
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.senderPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.senderEmail = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.targetEmail = new System.Windows.Forms.TextBox();
            this.sendEmail = new System.Windows.Forms.Button();
            this.defaultCredentialsCheck = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.defaultCredentialsCheck);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.senderPassword);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.senderEmail);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(284, 95);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del remitente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Contraseña";
            // 
            // senderPassword
            // 
            this.senderPassword.Location = new System.Drawing.Point(73, 45);
            this.senderPassword.Name = "senderPassword";
            this.senderPassword.PasswordChar = '*';
            this.senderPassword.Size = new System.Drawing.Size(205, 20);
            this.senderPassword.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Correo";
            // 
            // senderEmail
            // 
            this.senderEmail.Location = new System.Drawing.Point(73, 19);
            this.senderEmail.Name = "senderEmail";
            this.senderEmail.Size = new System.Drawing.Size(205, 20);
            this.senderEmail.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.targetEmail);
            this.groupBox2.Location = new System.Drawing.Point(12, 113);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(284, 50);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos del destinatario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Correo";
            // 
            // targetEmail
            // 
            this.targetEmail.Location = new System.Drawing.Point(73, 19);
            this.targetEmail.Name = "targetEmail";
            this.targetEmail.Size = new System.Drawing.Size(205, 20);
            this.targetEmail.TabIndex = 3;
            // 
            // sendEmail
            // 
            this.sendEmail.Location = new System.Drawing.Point(115, 169);
            this.sendEmail.Name = "sendEmail";
            this.sendEmail.Size = new System.Drawing.Size(75, 23);
            this.sendEmail.TabIndex = 2;
            this.sendEmail.Text = "Enviar";
            this.sendEmail.UseVisualStyleBackColor = true;
            this.sendEmail.Click += new System.EventHandler(this.sendEmail_Click);
            // 
            // defaultCredentialsCheck
            // 
            this.defaultCredentialsCheck.AutoSize = true;
            this.defaultCredentialsCheck.Location = new System.Drawing.Point(9, 71);
            this.defaultCredentialsCheck.Name = "defaultCredentialsCheck";
            this.defaultCredentialsCheck.Size = new System.Drawing.Size(168, 17);
            this.defaultCredentialsCheck.TabIndex = 4;
            this.defaultCredentialsCheck.Text = "Usar credenciales por defecto";
            this.defaultCredentialsCheck.UseVisualStyleBackColor = true;
            this.defaultCredentialsCheck.CheckStateChanged += new System.EventHandler(this.defaultCredentialsCheck_CheckStateChanged);
            // 
            // EmailFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 199);
            this.Controls.Add(this.sendEmail);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "EmailFile";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.EmailFile_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox senderPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox senderEmail;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox targetEmail;
        private System.Windows.Forms.Button sendEmail;
        private System.Windows.Forms.CheckBox defaultCredentialsCheck;
    }
}