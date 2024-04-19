namespace Lecture_08_Task_01
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
            this.btnSad = new System.Windows.Forms.Button();
            this.btnCSharp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSad
            // 
            this.btnSad.Location = new System.Drawing.Point(296, 101);
            this.btnSad.Name = "btnSad";
            this.btnSad.Size = new System.Drawing.Size(170, 23);
            this.btnSad.TabIndex = 0;
            this.btnSad.Text = "SAD MARKS";
            this.btnSad.UseVisualStyleBackColor = true;
            this.btnSad.Click += new System.EventHandler(this.btnSad_Click);
            // 
            // btnCSharp
            // 
            this.btnCSharp.Location = new System.Drawing.Point(296, 207);
            this.btnCSharp.Name = "btnCSharp";
            this.btnCSharp.Size = new System.Drawing.Size(170, 23);
            this.btnCSharp.TabIndex = 1;
            this.btnCSharp.Text = "C# MARKS";
            this.btnCSharp.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCSharp);
            this.Controls.Add(this.btnSad);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSad;
        private System.Windows.Forms.Button btnCSharp;
    }
}

