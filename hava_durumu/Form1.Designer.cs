namespace hava_durumu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label_degree = new System.Windows.Forms.Label();
            this.label_location = new System.Windows.Forms.Label();
            this.picture_clouds = new System.Windows.Forms.PictureBox();
            this.label_clouds = new System.Windows.Forms.Label();
            this.picture_sun = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picture_clouds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_sun)).BeginInit();
            this.SuspendLayout();
            // 
            // label_degree
            // 
            this.label_degree.AutoSize = true;
            this.label_degree.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_degree.Location = new System.Drawing.Point(239, 94);
            this.label_degree.Name = "label_degree";
            this.label_degree.Size = new System.Drawing.Size(64, 25);
            this.label_degree.TabIndex = 0;
            this.label_degree.Text = "label1";
            // 
            // label_location
            // 
            this.label_location.AutoSize = true;
            this.label_location.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_location.Location = new System.Drawing.Point(239, 169);
            this.label_location.Name = "label_location";
            this.label_location.Size = new System.Drawing.Size(64, 25);
            this.label_location.TabIndex = 1;
            this.label_location.Text = "label2";
            // 
            // picture_clouds
            // 
            this.picture_clouds.Image = ((System.Drawing.Image)(resources.GetObject("picture_clouds.Image")));
            this.picture_clouds.Location = new System.Drawing.Point(497, 65);
            this.picture_clouds.Name = "picture_clouds";
            this.picture_clouds.Size = new System.Drawing.Size(229, 216);
            this.picture_clouds.TabIndex = 2;
            this.picture_clouds.TabStop = false;
            this.picture_clouds.Visible = false;
            // 
            // label_clouds
            // 
            this.label_clouds.AutoSize = true;
            this.label_clouds.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_clouds.Location = new System.Drawing.Point(239, 246);
            this.label_clouds.Name = "label_clouds";
            this.label_clouds.Size = new System.Drawing.Size(64, 25);
            this.label_clouds.TabIndex = 3;
            this.label_clouds.Text = "label1";
            // 
            // picture_sun
            // 
            this.picture_sun.Image = ((System.Drawing.Image)(resources.GetObject("picture_sun.Image")));
            this.picture_sun.Location = new System.Drawing.Point(497, 65);
            this.picture_sun.Name = "picture_sun";
            this.picture_sun.Size = new System.Drawing.Size(229, 216);
            this.picture_sun.TabIndex = 4;
            this.picture_sun.TabStop = false;
            this.picture_sun.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(40, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Derece:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(40, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Şehir:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(37, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Bulut Yüzdesi:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picture_sun);
            this.Controls.Add(this.label_clouds);
            this.Controls.Add(this.picture_clouds);
            this.Controls.Add(this.label_location);
            this.Controls.Add(this.label_degree);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picture_clouds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_sun)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_degree;
        private System.Windows.Forms.Label label_location;
        private System.Windows.Forms.PictureBox picture_clouds;
        private System.Windows.Forms.Label label_clouds;
        private System.Windows.Forms.PictureBox picture_sun;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

