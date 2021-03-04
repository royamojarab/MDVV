
namespace ManaDigitalV
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.Imagepanel = new System.Windows.Forms.Panel();
            this.Userlabel = new System.Windows.Forms.Label();
            this.Passlabel = new System.Windows.Forms.Label();
            this.UserbunifuMaterialTextbox1 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.PassbunifuMaterialTextbox2 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Loginbutton1 = new System.Windows.Forms.Button();
            this.Minimizebutton = new System.Windows.Forms.Button();
            this.Closebutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Imagepanel
            // 
            this.Imagepanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Imagepanel.BackgroundImage")));
            this.Imagepanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Imagepanel.Location = new System.Drawing.Point(219, 3);
            this.Imagepanel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Imagepanel.Name = "Imagepanel";
            this.Imagepanel.Size = new System.Drawing.Size(179, 423);
            this.Imagepanel.TabIndex = 1;
            // 
            // Userlabel
            // 
            this.Userlabel.AutoSize = true;
            this.Userlabel.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Userlabel.ForeColor = System.Drawing.Color.Silver;
            this.Userlabel.Location = new System.Drawing.Point(126, 100);
            this.Userlabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Userlabel.Name = "Userlabel";
            this.Userlabel.Size = new System.Drawing.Size(61, 24);
            this.Userlabel.TabIndex = 1;
            this.Userlabel.Text = "نام کاربری";
            // 
            // Passlabel
            // 
            this.Passlabel.AutoSize = true;
            this.Passlabel.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Passlabel.ForeColor = System.Drawing.Color.Silver;
            this.Passlabel.Location = new System.Drawing.Point(128, 181);
            this.Passlabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Passlabel.Name = "Passlabel";
            this.Passlabel.Size = new System.Drawing.Size(52, 24);
            this.Passlabel.TabIndex = 2;
            this.Passlabel.Text = "رمز عبور";
            // 
            // UserbunifuMaterialTextbox1
            // 
            this.UserbunifuMaterialTextbox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.UserbunifuMaterialTextbox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.UserbunifuMaterialTextbox1.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.UserbunifuMaterialTextbox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UserbunifuMaterialTextbox1.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.UserbunifuMaterialTextbox1.ForeColor = System.Drawing.Color.Silver;
            this.UserbunifuMaterialTextbox1.HintForeColor = System.Drawing.Color.Silver;
            this.UserbunifuMaterialTextbox1.HintText = "";
            this.UserbunifuMaterialTextbox1.isPassword = false;
            this.UserbunifuMaterialTextbox1.LineFocusedColor = System.Drawing.Color.Silver;
            this.UserbunifuMaterialTextbox1.LineIdleColor = System.Drawing.Color.Gray;
            this.UserbunifuMaterialTextbox1.LineMouseHoverColor = System.Drawing.Color.Silver;
            this.UserbunifuMaterialTextbox1.LineThickness = 4;
            this.UserbunifuMaterialTextbox1.Location = new System.Drawing.Point(13, 121);
            this.UserbunifuMaterialTextbox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UserbunifuMaterialTextbox1.MaxLength = 32767;
            this.UserbunifuMaterialTextbox1.Name = "UserbunifuMaterialTextbox1";
            this.UserbunifuMaterialTextbox1.Size = new System.Drawing.Size(124, 33);
            this.UserbunifuMaterialTextbox1.TabIndex = 1;
            this.UserbunifuMaterialTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // PassbunifuMaterialTextbox2
            // 
            this.PassbunifuMaterialTextbox2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.PassbunifuMaterialTextbox2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.PassbunifuMaterialTextbox2.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.PassbunifuMaterialTextbox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PassbunifuMaterialTextbox2.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.PassbunifuMaterialTextbox2.ForeColor = System.Drawing.Color.Silver;
            this.PassbunifuMaterialTextbox2.HintForeColor = System.Drawing.Color.Silver;
            this.PassbunifuMaterialTextbox2.HintText = "";
            this.PassbunifuMaterialTextbox2.isPassword = true;
            this.PassbunifuMaterialTextbox2.LineFocusedColor = System.Drawing.Color.Silver;
            this.PassbunifuMaterialTextbox2.LineIdleColor = System.Drawing.Color.Gray;
            this.PassbunifuMaterialTextbox2.LineMouseHoverColor = System.Drawing.Color.Silver;
            this.PassbunifuMaterialTextbox2.LineThickness = 4;
            this.PassbunifuMaterialTextbox2.Location = new System.Drawing.Point(13, 202);
            this.PassbunifuMaterialTextbox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PassbunifuMaterialTextbox2.MaxLength = 32767;
            this.PassbunifuMaterialTextbox2.Name = "PassbunifuMaterialTextbox2";
            this.PassbunifuMaterialTextbox2.Size = new System.Drawing.Size(124, 33);
            this.PassbunifuMaterialTextbox2.TabIndex = 2;
            this.PassbunifuMaterialTextbox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Loginbutton1
            // 
            this.Loginbutton1.BackColor = System.Drawing.Color.Silver;
            this.Loginbutton1.FlatAppearance.BorderSize = 0;
            this.Loginbutton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Loginbutton1.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Loginbutton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.Loginbutton1.Location = new System.Drawing.Point(29, 358);
            this.Loginbutton1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Loginbutton1.Name = "Loginbutton1";
            this.Loginbutton1.Size = new System.Drawing.Size(151, 31);
            this.Loginbutton1.TabIndex = 3;
            this.Loginbutton1.Text = "ورود";
            this.Loginbutton1.UseVisualStyleBackColor = false;
            this.Loginbutton1.Click += new System.EventHandler(this.Loginbutton1_Click);
            // 
            // Minimizebutton
            // 
            this.Minimizebutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Minimizebutton.BackgroundImage")));
            this.Minimizebutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Minimizebutton.FlatAppearance.BorderSize = 0;
            this.Minimizebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Minimizebutton.Location = new System.Drawing.Point(44, 3);
            this.Minimizebutton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Minimizebutton.Name = "Minimizebutton";
            this.Minimizebutton.Size = new System.Drawing.Size(38, 28);
            this.Minimizebutton.TabIndex = 5;
            this.Minimizebutton.UseVisualStyleBackColor = true;
            this.Minimizebutton.Click += new System.EventHandler(this.Minimizebutton_Click);
            // 
            // Closebutton
            // 
            this.Closebutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Closebutton.BackgroundImage")));
            this.Closebutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Closebutton.FlatAppearance.BorderSize = 0;
            this.Closebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Closebutton.Location = new System.Drawing.Point(1, 3);
            this.Closebutton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Closebutton.Name = "Closebutton";
            this.Closebutton.Size = new System.Drawing.Size(38, 28);
            this.Closebutton.TabIndex = 4;
            this.Closebutton.UseVisualStyleBackColor = true;
            this.Closebutton.Click += new System.EventHandler(this.Closebutton_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(401, 427);
            this.Controls.Add(this.Imagepanel);
            this.Controls.Add(this.Minimizebutton);
            this.Controls.Add(this.Closebutton);
            this.Controls.Add(this.Loginbutton1);
            this.Controls.Add(this.PassbunifuMaterialTextbox2);
            this.Controls.Add(this.UserbunifuMaterialTextbox1);
            this.Controls.Add(this.Passlabel);
            this.Controls.Add(this.Userlabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel Imagepanel;
        private System.Windows.Forms.Label Userlabel;
        private System.Windows.Forms.Label Passlabel;
        private Bunifu.Framework.UI.BunifuMaterialTextbox UserbunifuMaterialTextbox1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox PassbunifuMaterialTextbox2;
        private System.Windows.Forms.Button Loginbutton1;
        private System.Windows.Forms.Button Minimizebutton;
        private System.Windows.Forms.Button Closebutton;
    }
}

