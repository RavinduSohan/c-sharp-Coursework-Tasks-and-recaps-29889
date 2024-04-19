namespace Lecture_06_Task01
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
            this.btnclick = new System.Windows.Forms.Button();
            this.labelcounter = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnclick
            // 
            this.btnclick.Location = new System.Drawing.Point(283, 189);
            this.btnclick.Name = "btnclick";
            this.btnclick.Size = new System.Drawing.Size(75, 23);
            this.btnclick.TabIndex = 0;
            this.btnclick.Text = "CLICK ME";
            this.btnclick.UseVisualStyleBackColor = true;
            this.btnclick.Click += new System.EventHandler(this.btnclick_Click);
            // 
            // labelcounter
            // 
            this.labelcounter.AutoSize = true;
            this.labelcounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelcounter.Location = new System.Drawing.Point(313, 72);
            this.labelcounter.Name = "labelcounter";
            this.labelcounter.Size = new System.Drawing.Size(25, 25);
            this.labelcounter.TabIndex = 1;
            this.labelcounter.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelcounter);
            this.Controls.Add(this.btnclick);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnclick;
        private System.Windows.Forms.Label labelcounter;
    }
}

