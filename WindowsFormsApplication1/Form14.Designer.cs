namespace WindowsFormsApplication1
{
    partial class Form14
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
            this.button48 = new System.Windows.Forms.Button();
            this.button49 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "History";
            // 
            // button48
            // 
            this.button48.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button48.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button48.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button48.Location = new System.Drawing.Point(12, 572);
            this.button48.Name = "button48";
            this.button48.Size = new System.Drawing.Size(320, 150);
            this.button48.TabIndex = 91;
            this.button48.Text = "<- Go Back";
            this.button48.UseVisualStyleBackColor = false;
            this.button48.Click += new System.EventHandler(this.button48_Click);
            this.button48.MouseDown += this.button48_MouseDown;
            this.button48.MouseUp += this.button48_MouseUp;
            // 
            // button49
            // 
            this.button49.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button49.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button49.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button49.Location = new System.Drawing.Point(684, 572);
            this.button49.Name = "button49";
            this.button49.Size = new System.Drawing.Size(320, 150);
            this.button49.TabIndex = 92;
            this.button49.Text = "Return to Main Page";
            this.button49.UseVisualStyleBackColor = false;
            this.button49.Click += new System.EventHandler(this.button49_Click);
            this.button49.MouseDown += this.button49_MouseDown;
            this.button49.MouseUp += this.button49_MouseUp;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(67, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(440, 31);
            this.label2.TabIndex = 96;
            this.label2.Text = "Click here for map and Exhibit\'s location";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            this.label2.MouseDown += this.label2_MouseDown;
            this.label2.MouseUp += this.label2_MouseUp;
            // 
            // Form14
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.BackgroundImage;
            this.ClientSize = new System.Drawing.Size(1016, 734);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button49);
            this.Controls.Add(this.button48);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Location = new System.Drawing.Point(100, 100);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form14";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form14";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button48;
        private System.Windows.Forms.Button button49;
        private System.Windows.Forms.Label label2;
    }
}