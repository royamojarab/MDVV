
namespace ManaDigitalV.UserControls
{
    partial class RegisterUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterUserControl));
            this.Namelabel = new System.Windows.Forms.Label();
            this.Relationlabel = new System.Windows.Forms.Label();
            this.Addresslabel = new System.Windows.Forms.Label();
            this.Agelabel = new System.Windows.Forms.Label();
            this.Grouplabel = new System.Windows.Forms.Label();
            this.CVUploaderlabel = new System.Windows.Forms.Label();
            this.Phonelabel = new System.Windows.Forms.Label();
            this.NamebunifuMaterialTextbox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.RelationbunifuMaterialTextbox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.PhonebunifuMaterialTextbox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.AddressbunifuMaterialTextbox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.AgenumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.GroupcomboBox = new System.Windows.Forms.ComboBox();
            this.CVChoosebutton = new System.Windows.Forms.Button();
            this.CVSaverbutton = new System.Windows.Forms.Button();
            this.savebutton = new System.Windows.Forms.Button();
            this.cancelbutton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.AgenumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // Namelabel
            // 
            this.Namelabel.AutoSize = true;
            this.Namelabel.ForeColor = System.Drawing.Color.Silver;
            this.Namelabel.Location = new System.Drawing.Point(449, 71);
            this.Namelabel.Name = "Namelabel";
            this.Namelabel.Size = new System.Drawing.Size(94, 13);
            this.Namelabel.TabIndex = 0;
            this.Namelabel.Text = "نام و نام خانوادگی";
            // 
            // Relationlabel
            // 
            this.Relationlabel.AutoSize = true;
            this.Relationlabel.ForeColor = System.Drawing.Color.Silver;
            this.Relationlabel.Location = new System.Drawing.Point(478, 149);
            this.Relationlabel.Name = "Relationlabel";
            this.Relationlabel.Size = new System.Drawing.Size(65, 13);
            this.Relationlabel.TabIndex = 1;
            this.Relationlabel.Text = "عنوان شغلی";
            this.Relationlabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // Addresslabel
            // 
            this.Addresslabel.AutoSize = true;
            this.Addresslabel.ForeColor = System.Drawing.Color.Silver;
            this.Addresslabel.Location = new System.Drawing.Point(513, 305);
            this.Addresslabel.Name = "Addresslabel";
            this.Addresslabel.Size = new System.Drawing.Size(30, 13);
            this.Addresslabel.TabIndex = 3;
            this.Addresslabel.Text = "آدرس";
            // 
            // Agelabel
            // 
            this.Agelabel.AutoSize = true;
            this.Agelabel.ForeColor = System.Drawing.Color.Silver;
            this.Agelabel.Location = new System.Drawing.Point(230, 71);
            this.Agelabel.Name = "Agelabel";
            this.Agelabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Agelabel.Size = new System.Drawing.Size(23, 13);
            this.Agelabel.TabIndex = 4;
            this.Agelabel.Text = "سن";
            // 
            // Grouplabel
            // 
            this.Grouplabel.AutoSize = true;
            this.Grouplabel.ForeColor = System.Drawing.Color.Silver;
            this.Grouplabel.Location = new System.Drawing.Point(222, 149);
            this.Grouplabel.Name = "Grouplabel";
            this.Grouplabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Grouplabel.Size = new System.Drawing.Size(31, 13);
            this.Grouplabel.TabIndex = 5;
            this.Grouplabel.Text = "گروه";
            // 
            // CVUploaderlabel
            // 
            this.CVUploaderlabel.AutoSize = true;
            this.CVUploaderlabel.ForeColor = System.Drawing.Color.Silver;
            this.CVUploaderlabel.Location = new System.Drawing.Point(195, 227);
            this.CVUploaderlabel.Name = "CVUploaderlabel";
            this.CVUploaderlabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CVUploaderlabel.Size = new System.Drawing.Size(58, 13);
            this.CVUploaderlabel.TabIndex = 6;
            this.CVUploaderlabel.Text = "آپلود رزومه";
            // 
            // Phonelabel
            // 
            this.Phonelabel.AutoSize = true;
            this.Phonelabel.ForeColor = System.Drawing.Color.Silver;
            this.Phonelabel.Location = new System.Drawing.Point(485, 227);
            this.Phonelabel.Name = "Phonelabel";
            this.Phonelabel.Size = new System.Drawing.Size(58, 13);
            this.Phonelabel.TabIndex = 2;
            this.Phonelabel.Text = "شماره تلفن";
            // 
            // NamebunifuMaterialTextbox
            // 
            this.NamebunifuMaterialTextbox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.NamebunifuMaterialTextbox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.NamebunifuMaterialTextbox.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.NamebunifuMaterialTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NamebunifuMaterialTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.NamebunifuMaterialTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.NamebunifuMaterialTextbox.HintForeColor = System.Drawing.Color.Silver;
            this.NamebunifuMaterialTextbox.HintText = "";
            this.NamebunifuMaterialTextbox.isPassword = false;
            this.NamebunifuMaterialTextbox.LineFocusedColor = System.Drawing.Color.Silver;
            this.NamebunifuMaterialTextbox.LineIdleColor = System.Drawing.Color.Gray;
            this.NamebunifuMaterialTextbox.LineMouseHoverColor = System.Drawing.Color.Silver;
            this.NamebunifuMaterialTextbox.LineThickness = 3;
            this.NamebunifuMaterialTextbox.Location = new System.Drawing.Point(356, 88);
            this.NamebunifuMaterialTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.NamebunifuMaterialTextbox.MaxLength = 32767;
            this.NamebunifuMaterialTextbox.Name = "NamebunifuMaterialTextbox";
            this.NamebunifuMaterialTextbox.Size = new System.Drawing.Size(170, 24);
            this.NamebunifuMaterialTextbox.TabIndex = 1;
            this.NamebunifuMaterialTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // RelationbunifuMaterialTextbox
            // 
            this.RelationbunifuMaterialTextbox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.RelationbunifuMaterialTextbox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.RelationbunifuMaterialTextbox.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.RelationbunifuMaterialTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.RelationbunifuMaterialTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.RelationbunifuMaterialTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.RelationbunifuMaterialTextbox.HintForeColor = System.Drawing.Color.Silver;
            this.RelationbunifuMaterialTextbox.HintText = "";
            this.RelationbunifuMaterialTextbox.isPassword = false;
            this.RelationbunifuMaterialTextbox.LineFocusedColor = System.Drawing.Color.Silver;
            this.RelationbunifuMaterialTextbox.LineIdleColor = System.Drawing.Color.Gray;
            this.RelationbunifuMaterialTextbox.LineMouseHoverColor = System.Drawing.Color.Silver;
            this.RelationbunifuMaterialTextbox.LineThickness = 3;
            this.RelationbunifuMaterialTextbox.Location = new System.Drawing.Point(356, 166);
            this.RelationbunifuMaterialTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.RelationbunifuMaterialTextbox.MaxLength = 32767;
            this.RelationbunifuMaterialTextbox.Name = "RelationbunifuMaterialTextbox";
            this.RelationbunifuMaterialTextbox.Size = new System.Drawing.Size(170, 24);
            this.RelationbunifuMaterialTextbox.TabIndex = 2;
            this.RelationbunifuMaterialTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // PhonebunifuMaterialTextbox
            // 
            this.PhonebunifuMaterialTextbox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.PhonebunifuMaterialTextbox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.PhonebunifuMaterialTextbox.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.PhonebunifuMaterialTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PhonebunifuMaterialTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.PhonebunifuMaterialTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.PhonebunifuMaterialTextbox.HintForeColor = System.Drawing.Color.Silver;
            this.PhonebunifuMaterialTextbox.HintText = "";
            this.PhonebunifuMaterialTextbox.isPassword = false;
            this.PhonebunifuMaterialTextbox.LineFocusedColor = System.Drawing.Color.Silver;
            this.PhonebunifuMaterialTextbox.LineIdleColor = System.Drawing.Color.Gray;
            this.PhonebunifuMaterialTextbox.LineMouseHoverColor = System.Drawing.Color.Silver;
            this.PhonebunifuMaterialTextbox.LineThickness = 3;
            this.PhonebunifuMaterialTextbox.Location = new System.Drawing.Point(356, 244);
            this.PhonebunifuMaterialTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.PhonebunifuMaterialTextbox.MaxLength = 32767;
            this.PhonebunifuMaterialTextbox.Name = "PhonebunifuMaterialTextbox";
            this.PhonebunifuMaterialTextbox.Size = new System.Drawing.Size(170, 24);
            this.PhonebunifuMaterialTextbox.TabIndex = 3;
            this.PhonebunifuMaterialTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // AddressbunifuMaterialTextbox
            // 
            this.AddressbunifuMaterialTextbox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.AddressbunifuMaterialTextbox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.AddressbunifuMaterialTextbox.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.AddressbunifuMaterialTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.AddressbunifuMaterialTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.AddressbunifuMaterialTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.AddressbunifuMaterialTextbox.HintForeColor = System.Drawing.Color.Silver;
            this.AddressbunifuMaterialTextbox.HintText = "";
            this.AddressbunifuMaterialTextbox.isPassword = false;
            this.AddressbunifuMaterialTextbox.LineFocusedColor = System.Drawing.Color.Silver;
            this.AddressbunifuMaterialTextbox.LineIdleColor = System.Drawing.Color.Gray;
            this.AddressbunifuMaterialTextbox.LineMouseHoverColor = System.Drawing.Color.Silver;
            this.AddressbunifuMaterialTextbox.LineThickness = 3;
            this.AddressbunifuMaterialTextbox.Location = new System.Drawing.Point(356, 322);
            this.AddressbunifuMaterialTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.AddressbunifuMaterialTextbox.MaxLength = 32767;
            this.AddressbunifuMaterialTextbox.Name = "AddressbunifuMaterialTextbox";
            this.AddressbunifuMaterialTextbox.Size = new System.Drawing.Size(170, 24);
            this.AddressbunifuMaterialTextbox.TabIndex = 4;
            this.AddressbunifuMaterialTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // AgenumericUpDown
            // 
            this.AgenumericUpDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.AgenumericUpDown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AgenumericUpDown.ForeColor = System.Drawing.Color.Silver;
            this.AgenumericUpDown.Location = new System.Drawing.Point(139, 88);
            this.AgenumericUpDown.Name = "AgenumericUpDown";
            this.AgenumericUpDown.Size = new System.Drawing.Size(87, 20);
            this.AgenumericUpDown.TabIndex = 5;
            // 
            // GroupcomboBox
            // 
            this.GroupcomboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.GroupcomboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.GroupcomboBox.ForeColor = System.Drawing.Color.Silver;
            this.GroupcomboBox.FormattingEnabled = true;
            this.GroupcomboBox.Items.AddRange(new object[] {
            " اداری و مالی",
            "امور انبار",
            "اداره کارگزینی و رفاه کارکنان",
            "دبیر خانه ",
            "واحد تدارکات ",
            "واحد خرید ",
            "واحد ترابری",
            "حراست",
            "پشتیبانی"});
            this.GroupcomboBox.Location = new System.Drawing.Point(139, 166);
            this.GroupcomboBox.Name = "GroupcomboBox";
            this.GroupcomboBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.GroupcomboBox.Size = new System.Drawing.Size(87, 21);
            this.GroupcomboBox.TabIndex = 6;
            // 
            // CVChoosebutton
            // 
            this.CVChoosebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CVChoosebutton.ForeColor = System.Drawing.Color.Silver;
            this.CVChoosebutton.Location = new System.Drawing.Point(139, 244);
            this.CVChoosebutton.Name = "CVChoosebutton";
            this.CVChoosebutton.Size = new System.Drawing.Size(87, 23);
            this.CVChoosebutton.TabIndex = 7;
            this.CVChoosebutton.Text = "انتخاب فایل";
            this.CVChoosebutton.UseVisualStyleBackColor = true;
            this.CVChoosebutton.Click += new System.EventHandler(this.CVChoosebutton_Click);
            // 
            // CVSaverbutton
            // 
            this.CVSaverbutton.FlatAppearance.BorderSize = 0;
            this.CVSaverbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CVSaverbutton.ForeColor = System.Drawing.Color.Silver;
            this.CVSaverbutton.Location = new System.Drawing.Point(139, 273);
            this.CVSaverbutton.Name = "CVSaverbutton";
            this.CVSaverbutton.Size = new System.Drawing.Size(87, 23);
            this.CVSaverbutton.TabIndex = 8;
            this.CVSaverbutton.Text = "ذخیره";
            this.CVSaverbutton.UseVisualStyleBackColor = true;
            this.CVSaverbutton.Click += new System.EventHandler(this.CVSaverbutton_Click);
            // 
            // savebutton
            // 
            this.savebutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("savebutton.BackgroundImage")));
            this.savebutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.savebutton.FlatAppearance.BorderSize = 0;
            this.savebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.savebutton.Location = new System.Drawing.Point(417, 375);
            this.savebutton.Name = "savebutton";
            this.savebutton.Size = new System.Drawing.Size(75, 23);
            this.savebutton.TabIndex = 9;
            this.savebutton.UseVisualStyleBackColor = true;
            this.savebutton.Click += new System.EventHandler(this.savebutton_Click);
            // 
            // cancelbutton
            // 
            this.cancelbutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cancelbutton.BackgroundImage")));
            this.cancelbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cancelbutton.FlatAppearance.BorderSize = 0;
            this.cancelbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelbutton.Location = new System.Drawing.Point(151, 375);
            this.cancelbutton.Name = "cancelbutton";
            this.cancelbutton.Size = new System.Drawing.Size(75, 23);
            this.cancelbutton.TabIndex = 10;
            this.cancelbutton.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // RegisterUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.Controls.Add(this.cancelbutton);
            this.Controls.Add(this.savebutton);
            this.Controls.Add(this.CVSaverbutton);
            this.Controls.Add(this.CVChoosebutton);
            this.Controls.Add(this.GroupcomboBox);
            this.Controls.Add(this.AgenumericUpDown);
            this.Controls.Add(this.AddressbunifuMaterialTextbox);
            this.Controls.Add(this.PhonebunifuMaterialTextbox);
            this.Controls.Add(this.RelationbunifuMaterialTextbox);
            this.Controls.Add(this.NamebunifuMaterialTextbox);
            this.Controls.Add(this.CVUploaderlabel);
            this.Controls.Add(this.Grouplabel);
            this.Controls.Add(this.Agelabel);
            this.Controls.Add(this.Addresslabel);
            this.Controls.Add(this.Phonelabel);
            this.Controls.Add(this.Relationlabel);
            this.Controls.Add(this.Namelabel);
            this.Name = "RegisterUserControl";
            this.Size = new System.Drawing.Size(625, 411);
            this.Load += new System.EventHandler(this.RegisterUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AgenumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Namelabel;
        private System.Windows.Forms.Label Relationlabel;
        private System.Windows.Forms.Label Addresslabel;
        private System.Windows.Forms.Label Agelabel;
        private System.Windows.Forms.Label Grouplabel;
        private System.Windows.Forms.Label CVUploaderlabel;
        private System.Windows.Forms.Label Phonelabel;
        private System.Windows.Forms.Button CVChoosebutton;
        private System.Windows.Forms.Button savebutton;
        private System.Windows.Forms.Button cancelbutton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        public Bunifu.Framework.UI.BunifuMaterialTextbox NamebunifuMaterialTextbox;
        public Bunifu.Framework.UI.BunifuMaterialTextbox RelationbunifuMaterialTextbox;
        public Bunifu.Framework.UI.BunifuMaterialTextbox PhonebunifuMaterialTextbox;
        public Bunifu.Framework.UI.BunifuMaterialTextbox AddressbunifuMaterialTextbox;
        public System.Windows.Forms.NumericUpDown AgenumericUpDown;
        public System.Windows.Forms.ComboBox GroupcomboBox;
        public System.Windows.Forms.Button CVSaverbutton;
    }
}
