namespace Lecture_07_Takehome
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
            this.btnUserControl1 = new System.Windows.Forms.Button();
            this.btnUserControl2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnUserControl1
            // 
            this.btnUserControl1.Location = new System.Drawing.Point(176, 65);
            this.btnUserControl1.Name = "btnUserControl1";
            this.btnUserControl1.Size = new System.Drawing.Size(109, 23);
            this.btnUserControl1.TabIndex = 0;
            this.btnUserControl1.Text = "User Control 1";
            this.btnUserControl1.UseVisualStyleBackColor = true;
            this.btnUserControl1.Click += new System.EventHandler(this.btnUserControl1_Click);
            // 
            // btnUserControl2
            // 
            this.btnUserControl2.Location = new System.Drawing.Point(176, 129);
            this.btnUserControl2.Name = "btnUserControl2";
            this.btnUserControl2.Size = new System.Drawing.Size(109, 23);
            this.btnUserControl2.TabIndex = 1;
            this.btnUserControl2.Text = "User Control 2";
            this.btnUserControl2.UseVisualStyleBackColor = true;
            this.btnUserControl2.Click += new System.EventHandler(this.btnUserControl2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnUserControl2);
            this.Controls.Add(this.btnUserControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUserControl1;
        private System.Windows.Forms.Button btnUserControl2;
    }
}

