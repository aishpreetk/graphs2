namespace graphs
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
            this.pictureBoxPie = new System.Windows.Forms.PictureBox();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.generateBtn = new System.Windows.Forms.Button();
            this.lblpie = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPie)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxPie
            // 
            this.pictureBoxPie.Location = new System.Drawing.Point(104, 156);
            this.pictureBoxPie.Name = "pictureBoxPie";
            this.pictureBoxPie.Size = new System.Drawing.Size(252, 222);
            this.pictureBoxPie.TabIndex = 0;
            this.pictureBoxPie.TabStop = false;
            // 
            // inputTextBox
            // 
            this.inputTextBox.Location = new System.Drawing.Point(603, 53);
            this.inputTextBox.Multiline = true;
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(100, 22);
            this.inputTextBox.TabIndex = 1;
            // 
            // generateBtn
            // 
            this.generateBtn.Location = new System.Drawing.Point(488, 81);
            this.generateBtn.Name = "generateBtn";
            this.generateBtn.Size = new System.Drawing.Size(300, 40);
            this.generateBtn.TabIndex = 2;
            this.generateBtn.Text = "Create Pie Chart";
            this.generateBtn.UseVisualStyleBackColor = true;
            this.generateBtn.Click += new System.EventHandler(this.generateBtn_Click);
            // 
            // lblpie
            // 
            this.lblpie.AutoSize = true;
            this.lblpie.Location = new System.Drawing.Point(186, 81);
            this.lblpie.Name = "lblpie";
            this.lblpie.Size = new System.Drawing.Size(61, 16);
            this.lblpie.TabIndex = 3;
            this.lblpie.Text = "Pie Chart";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblpie);
            this.Controls.Add(this.generateBtn);
            this.Controls.Add(this.inputTextBox);
            this.Controls.Add(this.pictureBoxPie);
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxPie;
        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.Button generateBtn;
        private System.Windows.Forms.Label lblpie;
    }
}

