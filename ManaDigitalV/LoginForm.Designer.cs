
namespace ManaDigitalV
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
            this.Logopanel = new System.Windows.Forms.Panel();
            this.Toppanel = new System.Windows.Forms.Panel();
            this.Imagepanel = new System.Windows.Forms.Panel();
            this.Userlabel = new System.Windows.Forms.Label();
            this.Passlabel = new System.Windows.Forms.Label();
            this.UserbunifuMaterialTextbox1 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.PassbunifuMaterialTextbox2 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Loginbutton1 = new System.Windows.Forms.Button();
            this.Logopanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Logopanel
            // 
            this.Logopanel.Controls.Add(this.Imagepanel);
            this.Logopanel.Controls.Add(this.Toppanel);
            this.Logopanel.Location = new System.Drawing.Point(0, 0);
            this.Logopanel.Name = "Logopanel";
            this.Logopanel.Size = new System.Drawing.Size(179, 449);
            this.Logopanel.TabIndex = 0;
            // 
            // Toppanel
            // 
            this.Toppanel.Location = new System.Drawing.Point(174, 0);
            this.Toppanel.Name = "Toppanel";
            this.Toppanel.Size = new System.Drawing.Size(667, 27);
            this.Toppanel.TabIndex = 1;
            // 
            // Imagepanel
            // 
            this.Imagepanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Imagepanel.BackgroundImage")));
            this.Imagepanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Imagepanel.Location = new System.Drawing.Point(0, 3);
            this.Imagepanel.Name = "Imagepanel";
            this.Imagepanel.Size = new System.Drawing.Size(179, 391);
            this.Imagepanel.TabIndex = 1;
            // 
            // Userlabel
            // 
            this.Userlabel.AutoSize = true;
            this.Userlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Userlabel.ForeColor = System.Drawing.Color.Silver;
            this.Userlabel.Location = new System.Drawing.Point(736, 99);
            this.Userlabel.Name = "Userlabel";
            this.Userlabel.Size = new System.Drawing.Size(58, 17);
            this.Userlabel.TabIndex = 1;
            this.Userlabel.Text = "نام کاربری";
            // 
            // Passlabel
            // 
            this.Passlabel.AutoSize = true;
            this.Passlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Passlabel.ForeColor = System.Drawing.Color.Silver;
            this.Passlabel.Location = new System.Drawing.Point(739, 180);
            this.Passlabel.Name = "Passlabel";
            this.Passlabel.Size = new System.Drawing.Size(55, 17);
            this.Passlabel.TabIndex = 2;
            this.Passlabel.Text = "رمز عبور";
            // 
            // UserbunifuMaterialTextbox1
            // 
            this.UserbunifuMaterialTextbox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.UserbunifuMaterialTextbox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.UserbunifuMaterialTextbox1.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.UserbunifuMaterialTextbox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UserbunifuMaterialTextbox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.UserbunifuMaterialTextbox1.ForeColor = System.Drawing.Color.Silver;
            this.UserbunifuMaterialTextbox1.HintForeColor = System.Drawing.Color.Silver;
            this.UserbunifuMaterialTextbox1.HintText = "";
            this.UserbunifuMaterialTextbox1.isPassword = false;
            this.UserbunifuMaterialTextbox1.LineFocusedColor = System.Drawing.Color.Silver;
            this.UserbunifuMaterialTextbox1.LineIdleColor = System.Drawing.Color.Gray;
            this.UserbunifuMaterialTextbox1.LineMouseHoverColor = System.Drawing.Color.Silver;
            this.UserbunifuMaterialTextbox1.LineThickness = 3;
            this.UserbunifuMaterialTextbox1.Location = new System.Drawing.Point(545, 120);
            this.UserbunifuMaterialTextbox1.Margin = new System.Windows.Forms.Padding(4);
            this.UserbunifuMaterialTextbox1.MaxLength = 32767;
            this.UserbunifuMaterialTextbox1.Name = "UserbunifuMaterialTextbox1";
            this.UserbunifuMaterialTextbox1.Size = new System.Drawing.Size(211, 33);
            this.UserbunifuMaterialTextbox1.TabIndex = 3;
            this.UserbunifuMaterialTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // PassbunifuMaterialTextbox2
            // 
            this.PassbunifuMaterialTextbox2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.PassbunifuMaterialTextbox2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.PassbunifuMaterialTextbox2.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.PassbunifuMaterialTextbox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PassbunifuMaterialTextbox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.PassbunifuMaterialTextbox2.ForeColor = System.Drawing.Color.Silver;
            this.PassbunifuMaterialTextbox2.HintForeColor = System.Drawing.Color.Silver;
            this.PassbunifuMaterialTextbox2.HintText = "";
            this.PassbunifuMaterialTextbox2.isPassword = false;
            this.PassbunifuMaterialTextbox2.LineFocusedColor = System.Drawing.Color.Silver;
            this.PassbunifuMaterialTextbox2.LineIdleColor = System.Drawing.Color.Gray;
            this.PassbunifuMaterialTextbox2.LineMouseHoverColor = System.Drawing.Color.Silver;
            this.PassbunifuMaterialTextbox2.LineThickness = 3;
            this.PassbunifuMaterialTextbox2.Location = new System.Drawing.Point(545, 201);
            this.PassbunifuMaterialTextbox2.Margin = new System.Windows.Forms.Padding(4);
            this.PassbunifuMaterialTextbox2.MaxLength = 32767;
            this.PassbunifuMaterialTextbox2.Name = "PassbunifuMaterialTextbox2";
            this.PassbunifuMaterialTextbox2.Size = new System.Drawing.Size(211, 33);
            this.PassbunifuMaterialTextbox2.TabIndex = 4;
            this.PassbunifuMaterialTextbox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Loginbutton1
            // 
            this.Loginbutton1.BackColor = System.Drawing.Color.Silver;
            this.Loginbutton1.FlatAppearance.BorderSize = 0;
            this.Loginbutton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Loginbutton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Loginbutton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.Loginbutton1.Location = new System.Drawing.Point(237, 363);
            this.Loginbutton1.Name = "Loginbutton1";
            this.Loginbutton1.Size = new System.Drawing.Size(151, 31);
            this.Loginbutton1.TabIndex = 5;
            this.Loginbutton1.Text = "ورود";
            this.Loginbutton1.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(841, 450);
            this.Controls.Add(this.Loginbutton1);
            this.Controls.Add(this.PassbunifuMaterialTextbox2);
            this.Controls.Add(this.UserbunifuMaterialTextbox1);
            this.Controls.Add(this.Passlabel);
            this.Controls.Add(this.Userlabel);
            this.Controls.Add(this.Logopanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Logopanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Logopanel;
        private System.Windows.Forms.Panel Imagepanel;
        private System.Windows.Forms.Panel Toppanel;
        private System.Windows.Forms.Label Userlabel;
        private System.Windows.Forms.Label Passlabel;
        private Bunifu.Framework.UI.BunifuMaterialTextbox UserbunifuMaterialTextbox1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox PassbunifuMaterialTextbox2;
        private System.Windows.Forms.Button Loginbutton1;
    }
}

