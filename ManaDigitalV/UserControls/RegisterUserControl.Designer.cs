
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
            this.bunifuMaterialTextbox1 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuMaterialTextbox2 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuMaterialTextbox3 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuMaterialTextbox4 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.CVChoosebutton = new System.Windows.Forms.Button();
            this.CVSaverbutton = new System.Windows.Forms.Button();
            this.savebutton = new System.Windows.Forms.Button();
            this.cancelbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
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
            // bunifuMaterialTextbox1
            // 
            this.bunifuMaterialTextbox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.bunifuMaterialTextbox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.bunifuMaterialTextbox1.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.bunifuMaterialTextbox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMaterialTextbox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.bunifuMaterialTextbox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMaterialTextbox1.HintForeColor = System.Drawing.Color.Silver;
            this.bunifuMaterialTextbox1.HintText = "";
            this.bunifuMaterialTextbox1.isPassword = false;
            this.bunifuMaterialTextbox1.LineFocusedColor = System.Drawing.Color.Silver;
            this.bunifuMaterialTextbox1.LineIdleColor = System.Drawing.Color.Gray;
            this.bunifuMaterialTextbox1.LineMouseHoverColor = System.Drawing.Color.Silver;
            this.bunifuMaterialTextbox1.LineThickness = 3;
            this.bunifuMaterialTextbox1.Location = new System.Drawing.Point(356, 88);
            this.bunifuMaterialTextbox1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMaterialTextbox1.MaxLength = 32767;
            this.bunifuMaterialTextbox1.Name = "bunifuMaterialTextbox1";
            this.bunifuMaterialTextbox1.Size = new System.Drawing.Size(170, 24);
            this.bunifuMaterialTextbox1.TabIndex = 7;
            this.bunifuMaterialTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuMaterialTextbox2
            // 
            this.bunifuMaterialTextbox2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.bunifuMaterialTextbox2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.bunifuMaterialTextbox2.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.bunifuMaterialTextbox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMaterialTextbox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.bunifuMaterialTextbox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMaterialTextbox2.HintForeColor = System.Drawing.Color.Silver;
            this.bunifuMaterialTextbox2.HintText = "";
            this.bunifuMaterialTextbox2.isPassword = false;
            this.bunifuMaterialTextbox2.LineFocusedColor = System.Drawing.Color.Silver;
            this.bunifuMaterialTextbox2.LineIdleColor = System.Drawing.Color.Gray;
            this.bunifuMaterialTextbox2.LineMouseHoverColor = System.Drawing.Color.Silver;
            this.bunifuMaterialTextbox2.LineThickness = 3;
            this.bunifuMaterialTextbox2.Location = new System.Drawing.Point(356, 166);
            this.bunifuMaterialTextbox2.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMaterialTextbox2.MaxLength = 32767;
            this.bunifuMaterialTextbox2.Name = "bunifuMaterialTextbox2";
            this.bunifuMaterialTextbox2.Size = new System.Drawing.Size(170, 24);
            this.bunifuMaterialTextbox2.TabIndex = 8;
            this.bunifuMaterialTextbox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuMaterialTextbox3
            // 
            this.bunifuMaterialTextbox3.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.bunifuMaterialTextbox3.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.bunifuMaterialTextbox3.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.bunifuMaterialTextbox3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMaterialTextbox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.bunifuMaterialTextbox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMaterialTextbox3.HintForeColor = System.Drawing.Color.Silver;
            this.bunifuMaterialTextbox3.HintText = "";
            this.bunifuMaterialTextbox3.isPassword = false;
            this.bunifuMaterialTextbox3.LineFocusedColor = System.Drawing.Color.Silver;
            this.bunifuMaterialTextbox3.LineIdleColor = System.Drawing.Color.Gray;
            this.bunifuMaterialTextbox3.LineMouseHoverColor = System.Drawing.Color.Silver;
            this.bunifuMaterialTextbox3.LineThickness = 3;
            this.bunifuMaterialTextbox3.Location = new System.Drawing.Point(356, 244);
            this.bunifuMaterialTextbox3.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMaterialTextbox3.MaxLength = 32767;
            this.bunifuMaterialTextbox3.Name = "bunifuMaterialTextbox3";
            this.bunifuMaterialTextbox3.Size = new System.Drawing.Size(170, 24);
            this.bunifuMaterialTextbox3.TabIndex = 9;
            this.bunifuMaterialTextbox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuMaterialTextbox4
            // 
            this.bunifuMaterialTextbox4.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.bunifuMaterialTextbox4.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.bunifuMaterialTextbox4.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.bunifuMaterialTextbox4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMaterialTextbox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.bunifuMaterialTextbox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMaterialTextbox4.HintForeColor = System.Drawing.Color.Silver;
            this.bunifuMaterialTextbox4.HintText = "";
            this.bunifuMaterialTextbox4.isPassword = false;
            this.bunifuMaterialTextbox4.LineFocusedColor = System.Drawing.Color.Silver;
            this.bunifuMaterialTextbox4.LineIdleColor = System.Drawing.Color.Gray;
            this.bunifuMaterialTextbox4.LineMouseHoverColor = System.Drawing.Color.Silver;
            this.bunifuMaterialTextbox4.LineThickness = 3;
            this.bunifuMaterialTextbox4.Location = new System.Drawing.Point(356, 322);
            this.bunifuMaterialTextbox4.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMaterialTextbox4.MaxLength = 32767;
            this.bunifuMaterialTextbox4.Name = "bunifuMaterialTextbox4";
            this.bunifuMaterialTextbox4.Size = new System.Drawing.Size(170, 24);
            this.bunifuMaterialTextbox4.TabIndex = 10;
            this.bunifuMaterialTextbox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.numericUpDown1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDown1.ForeColor = System.Drawing.Color.Silver;
            this.numericUpDown1.Location = new System.Drawing.Point(139, 88);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(87, 20);
            this.numericUpDown1.TabIndex = 11;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(139, 166);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboBox1.Size = new System.Drawing.Size(87, 21);
            this.comboBox1.TabIndex = 12;
            // 
            // CVChoosebutton
            // 
            this.CVChoosebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CVChoosebutton.ForeColor = System.Drawing.Color.Silver;
            this.CVChoosebutton.Location = new System.Drawing.Point(139, 244);
            this.CVChoosebutton.Name = "CVChoosebutton";
            this.CVChoosebutton.Size = new System.Drawing.Size(87, 23);
            this.CVChoosebutton.TabIndex = 13;
            this.CVChoosebutton.Text = "انتخاب فایل";
            this.CVChoosebutton.UseVisualStyleBackColor = true;
            // 
            // CVSaverbutton
            // 
            this.CVSaverbutton.FlatAppearance.BorderSize = 0;
            this.CVSaverbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CVSaverbutton.ForeColor = System.Drawing.Color.Silver;
            this.CVSaverbutton.Location = new System.Drawing.Point(139, 273);
            this.CVSaverbutton.Name = "CVSaverbutton";
            this.CVSaverbutton.Size = new System.Drawing.Size(87, 23);
            this.CVSaverbutton.TabIndex = 14;
            this.CVSaverbutton.Text = "ذخیره";
            this.CVSaverbutton.UseVisualStyleBackColor = true;
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
            this.savebutton.TabIndex = 15;
            this.savebutton.UseVisualStyleBackColor = true;
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
            this.cancelbutton.TabIndex = 16;
            this.cancelbutton.UseVisualStyleBackColor = true;
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
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.bunifuMaterialTextbox4);
            this.Controls.Add(this.bunifuMaterialTextbox3);
            this.Controls.Add(this.bunifuMaterialTextbox2);
            this.Controls.Add(this.bunifuMaterialTextbox1);
            this.Controls.Add(this.CVUploaderlabel);
            this.Controls.Add(this.Grouplabel);
            this.Controls.Add(this.Agelabel);
            this.Controls.Add(this.Addresslabel);
            this.Controls.Add(this.Phonelabel);
            this.Controls.Add(this.Relationlabel);
            this.Controls.Add(this.Namelabel);
            this.Name = "RegisterUserControl";
            this.Size = new System.Drawing.Size(625, 411);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
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
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox4;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button CVChoosebutton;
        private System.Windows.Forms.Button CVSaverbutton;
        private System.Windows.Forms.Button savebutton;
        private System.Windows.Forms.Button cancelbutton;
    }
}
