namespace WindowsFormsApp1
{
    partial class FilterFile
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
            this.newFile = new System.Windows.Forms.Button();
            this.inputText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.outputText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.emailOutput = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // newFile
            // 
            this.newFile.Location = new System.Drawing.Point(12, 415);
            this.newFile.Name = "newFile";
            this.newFile.Size = new System.Drawing.Size(128, 23);
            this.newFile.TabIndex = 0;
            this.newFile.Text = "Seleccionar archivo";
            this.newFile.UseVisualStyleBackColor = true;
            this.newFile.Click += new System.EventHandler(this.newFile_Click);
            // 
            // inputText
            // 
            this.inputText.Location = new System.Drawing.Point(12, 25);
            this.inputText.Multiline = true;
            this.inputText.Name = "inputText";
            this.inputText.ReadOnly = true;
            this.inputText.Size = new System.Drawing.Size(380, 384);
            this.inputText.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Archivo de entrada";
            // 
            // outputText
            // 
            this.outputText.Location = new System.Drawing.Point(408, 25);
            this.outputText.Multiline = true;
            this.outputText.Name = "outputText";
            this.outputText.ReadOnly = true;
            this.outputText.Size = new System.Drawing.Size(380, 384);
            this.outputText.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(405, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Archivo de salida";
            // 
            // emailOutput
            // 
            this.emailOutput.Location = new System.Drawing.Point(408, 415);
            this.emailOutput.Name = "emailOutput";
            this.emailOutput.Size = new System.Drawing.Size(128, 23);
            this.emailOutput.TabIndex = 5;
            this.emailOutput.Text = "Enviar a correo";
            this.emailOutput.UseVisualStyleBackColor = true;
            this.emailOutput.Click += new System.EventHandler(this.emailOutput_Click);
            // 
            // FilterFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.emailOutput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.outputText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inputText);
            this.Controls.Add(this.newFile);
            this.Name = "FilterFile";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FilterFile_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button newFile;
        private System.Windows.Forms.TextBox inputText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox outputText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button emailOutput;
    }
}

