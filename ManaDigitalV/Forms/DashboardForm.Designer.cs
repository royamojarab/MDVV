
namespace ManaDigitalV.Forms
{
    partial class DashboardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardForm));
            this.Dashboardpanel = new System.Windows.Forms.Panel();
            this.Groupsbutton = new System.Windows.Forms.Button();
            this.Searchbutton = new System.Windows.Forms.Button();
            this.Registerbutton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Sliderpanel = new System.Windows.Forms.Panel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Motherpanel = new System.Windows.Forms.Panel();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.Closebutton = new System.Windows.Forms.Button();
            this.Minimizebutton = new System.Windows.Forms.Button();
            this.Supportbutton = new System.Windows.Forms.Button();
            this.Chartbutton = new System.Windows.Forms.Button();
            this.Dashboardpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Dashboardpanel
            // 
            this.Dashboardpanel.Controls.Add(this.Chartbutton);
            this.Dashboardpanel.Controls.Add(this.Supportbutton);
            this.Dashboardpanel.Controls.Add(this.Groupsbutton);
            this.Dashboardpanel.Controls.Add(this.Searchbutton);
            this.Dashboardpanel.Controls.Add(this.Registerbutton);
            this.Dashboardpanel.Controls.Add(this.panel1);
            this.Dashboardpanel.Location = new System.Drawing.Point(646, 2);
            this.Dashboardpanel.Name = "Dashboardpanel";
            this.Dashboardpanel.Size = new System.Drawing.Size(179, 456);
            this.Dashboardpanel.TabIndex = 0;
            // 
            // Groupsbutton
            // 
            this.Groupsbutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Groupsbutton.BackgroundImage")));
            this.Groupsbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Groupsbutton.FlatAppearance.BorderSize = 0;
            this.Groupsbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Groupsbutton.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Groupsbutton.ForeColor = System.Drawing.Color.Silver;
            this.Groupsbutton.Location = new System.Drawing.Point(0, 282);
            this.Groupsbutton.Name = "Groupsbutton";
            this.Groupsbutton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Groupsbutton.Size = new System.Drawing.Size(179, 40);
            this.Groupsbutton.TabIndex = 3;
            this.Groupsbutton.Text = "گروه ها";
            this.Groupsbutton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Groupsbutton.UseVisualStyleBackColor = true;
            this.Groupsbutton.Click += new System.EventHandler(this.Groupsbutton_Click);
            // 
            // Searchbutton
            // 
            this.Searchbutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Searchbutton.BackgroundImage")));
            this.Searchbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Searchbutton.FlatAppearance.BorderSize = 0;
            this.Searchbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Searchbutton.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Searchbutton.ForeColor = System.Drawing.Color.Silver;
            this.Searchbutton.Location = new System.Drawing.Point(0, 219);
            this.Searchbutton.Name = "Searchbutton";
            this.Searchbutton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Searchbutton.Size = new System.Drawing.Size(179, 40);
            this.Searchbutton.TabIndex = 2;
            this.Searchbutton.Text = "جستجو کاربر";
            this.Searchbutton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Searchbutton.UseVisualStyleBackColor = true;
            this.Searchbutton.Click += new System.EventHandler(this.Searchbutton_Click);
            // 
            // Registerbutton
            // 
            this.Registerbutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Registerbutton.BackgroundImage")));
            this.Registerbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Registerbutton.FlatAppearance.BorderSize = 0;
            this.Registerbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Registerbutton.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Registerbutton.ForeColor = System.Drawing.Color.Silver;
            this.Registerbutton.Location = new System.Drawing.Point(0, 156);
            this.Registerbutton.Name = "Registerbutton";
            this.Registerbutton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Registerbutton.Size = new System.Drawing.Size(179, 43);
            this.Registerbutton.TabIndex = 1;
            this.Registerbutton.Text = "ثبت کاربر";
            this.Registerbutton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Registerbutton.UseVisualStyleBackColor = true;
            this.Registerbutton.Click += new System.EventHandler(this.Registerbutton_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(179, 143);
            this.panel1.TabIndex = 1;
            // 
            // Sliderpanel
            // 
            this.Sliderpanel.BackColor = System.Drawing.Color.Yellow;
            this.Sliderpanel.Location = new System.Drawing.Point(633, 163);
            this.Sliderpanel.Name = "Sliderpanel";
            this.Sliderpanel.Size = new System.Drawing.Size(10, 46);
            this.Sliderpanel.TabIndex = 1;
            // 
            // Motherpanel
            // 
            this.Motherpanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Motherpanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Motherpanel.Location = new System.Drawing.Point(2, 58);
            this.Motherpanel.Name = "Motherpanel";
            this.Motherpanel.Size = new System.Drawing.Size(625, 400);
            this.Motherpanel.TabIndex = 4;
            this.Motherpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.Motherpanel_Paint);
            // 
            // Closebutton
            // 
            this.Closebutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Closebutton.BackgroundImage")));
            this.Closebutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Closebutton.FlatAppearance.BorderSize = 0;
            this.Closebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Closebutton.Location = new System.Drawing.Point(2, 2);
            this.Closebutton.Name = "Closebutton";
            this.Closebutton.Size = new System.Drawing.Size(38, 28);
            this.Closebutton.TabIndex = 5;
            this.Closebutton.UseVisualStyleBackColor = true;
            this.Closebutton.Click += new System.EventHandler(this.Closebutton_Click);
            // 
            // Minimizebutton
            // 
            this.Minimizebutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Minimizebutton.BackgroundImage")));
            this.Minimizebutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Minimizebutton.FlatAppearance.BorderSize = 0;
            this.Minimizebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Minimizebutton.Location = new System.Drawing.Point(46, 2);
            this.Minimizebutton.Name = "Minimizebutton";
            this.Minimizebutton.Size = new System.Drawing.Size(38, 28);
            this.Minimizebutton.TabIndex = 6;
            this.Minimizebutton.UseVisualStyleBackColor = true;
            this.Minimizebutton.Click += new System.EventHandler(this.Minimizebutton_Click);
            // 
            // Supportbutton
            // 
            this.Supportbutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Supportbutton.BackgroundImage")));
            this.Supportbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Supportbutton.FlatAppearance.BorderSize = 0;
            this.Supportbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Supportbutton.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Supportbutton.ForeColor = System.Drawing.Color.Silver;
            this.Supportbutton.Image = ((System.Drawing.Image)(resources.GetObject("Supportbutton.Image")));
            this.Supportbutton.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.Supportbutton.Location = new System.Drawing.Point(3, 408);
            this.Supportbutton.Name = "Supportbutton";
            this.Supportbutton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Supportbutton.Size = new System.Drawing.Size(179, 40);
            this.Supportbutton.TabIndex = 0;
            this.Supportbutton.Text = "پشتیبانی";
            this.Supportbutton.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.Supportbutton.UseVisualStyleBackColor = true;
            this.Supportbutton.Click += new System.EventHandler(this.Supportbutton_Click);
            // 
            // Chartbutton
            // 
            this.Chartbutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Chartbutton.BackgroundImage")));
            this.Chartbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Chartbutton.FlatAppearance.BorderSize = 0;
            this.Chartbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Chartbutton.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Chartbutton.ForeColor = System.Drawing.Color.Silver;
            this.Chartbutton.Image = ((System.Drawing.Image)(resources.GetObject("Chartbutton.Image")));
            this.Chartbutton.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.Chartbutton.Location = new System.Drawing.Point(3, 345);
            this.Chartbutton.Name = "Chartbutton";
            this.Chartbutton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Chartbutton.Size = new System.Drawing.Size(179, 40);
            this.Chartbutton.TabIndex = 4;
            this.Chartbutton.Text = "گزارش گیری";
            this.Chartbutton.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.Chartbutton.UseVisualStyleBackColor = true;
            this.Chartbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(825, 460);
            this.Controls.Add(this.Minimizebutton);
            this.Controls.Add(this.Sliderpanel);
            this.Controls.Add(this.Dashboardpanel);
            this.Controls.Add(this.Closebutton);
            this.Controls.Add(this.Motherpanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.DashboardForm_Load);
            this.Dashboardpanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Dashboardpanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Groupsbutton;
        private System.Windows.Forms.Button Searchbutton;
        private System.Windows.Forms.Button Registerbutton;
        private System.Windows.Forms.Panel Sliderpanel;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel Motherpanel;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Button Closebutton;
        private System.Windows.Forms.Button Minimizebutton;
        private System.Windows.Forms.Button Chartbutton;
        private System.Windows.Forms.Button Supportbutton;
    }
}