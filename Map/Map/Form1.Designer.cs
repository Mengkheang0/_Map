
namespace Map
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.US = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.China = new System.Windows.Forms.PictureBox();
            this.Cambodia = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.US)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.China)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cambodia)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // US
            // 
            this.US.AccessibleDescription = resources.GetString("US.AccessibleDescription");
            this.US.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.US.BackColor = System.Drawing.Color.Transparent;
            this.US.Location = new System.Drawing.Point(672, 745);
            this.US.Name = "US";
            this.US.Size = new System.Drawing.Size(40, 40);
            this.US.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.US.TabIndex = 0;
            this.US.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Iomanoid Front", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(617, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "LOCAL MAP";
            // 
            // China
            // 
            this.China.AccessibleDescription = "China, officially the People\'s Republic of China, is a country in East Asia. It i" +
    "s the world\'s most populous country, with a population of more than 1.4 billion." +
    " ";
            this.China.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.China.BackColor = System.Drawing.Color.Transparent;
            this.China.Location = new System.Drawing.Point(524, 736);
            this.China.Name = "China";
            this.China.Size = new System.Drawing.Size(40, 40);
            this.China.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.China.TabIndex = 0;
            this.China.TabStop = false;
            // 
            // Cambodia
            // 
            this.Cambodia.AccessibleDescription = resources.GetString("Cambodia.AccessibleDescription");
            this.Cambodia.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Cambodia.BackColor = System.Drawing.Color.Transparent;
            this.Cambodia.Location = new System.Drawing.Point(379, 742);
            this.Cambodia.Name = "Cambodia";
            this.Cambodia.Size = new System.Drawing.Size(40, 40);
            this.Cambodia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Cambodia.TabIndex = 0;
            this.Cambodia.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 887);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1389, 44);
            this.panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(1341, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 45);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2PictureBox1.Image = global::Map.Properties.Resources.getfile;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(0, 0);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(1389, 931);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 3;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.UseTransparentBackground = true;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1389, 931);
            this.Controls.Add(this.China);
            this.Controls.Add(this.US);
            this.Controls.Add(this.Cambodia);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.guna2PictureBox1);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Map";
            ((System.ComponentModel.ISupportInitialize)(this.US)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.China)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cambodia)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox US;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox China;
        private System.Windows.Forms.PictureBox Cambodia;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
    }
}

