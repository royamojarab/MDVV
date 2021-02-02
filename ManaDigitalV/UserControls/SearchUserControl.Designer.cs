
namespace ManaDigitalV.UserControls
{
    partial class SearchUserControl
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchUserControl));
            this.Searchlabel = new System.Windows.Forms.Label();
            this.SearchbunifuMaterialTextbox1 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.SearchlistBox = new System.Windows.Forms.ListBox();
            this.personBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CVSaverbutton = new System.Windows.Forms.Button();
            this.CVChoosebutton = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.bunifuMaterialTextbox4 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuMaterialTextbox3 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuMaterialTextbox2 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuMaterialTextbox1 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.CVUploaderlabel = new System.Windows.Forms.Label();
            this.Grouplabel = new System.Windows.Forms.Label();
            this.Agelabel = new System.Windows.Forms.Label();
            this.Addresslabel = new System.Windows.Forms.Label();
            this.Phonelabel = new System.Windows.Forms.Label();
            this.Relationlabel = new System.Windows.Forms.Label();
            this.Namelabel = new System.Windows.Forms.Label();
            this.savebutton = new System.Windows.Forms.Button();
            this.manaDigitalDataSet = new ManaDigitalV.ManaDigitalDataSet();
            this.manaDigitalDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manaDigitalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manaDigitalDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Searchlabel
            // 
            this.Searchlabel.AutoSize = true;
            this.Searchlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Searchlabel.Location = new System.Drawing.Point(543, 58);
            this.Searchlabel.Name = "Searchlabel";
            this.Searchlabel.Size = new System.Drawing.Size(41, 17);
            this.Searchlabel.TabIndex = 0;
            this.Searchlabel.Text = "جستجو";
            // 
            // SearchbunifuMaterialTextbox1
            // 
            this.SearchbunifuMaterialTextbox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.SearchbunifuMaterialTextbox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.SearchbunifuMaterialTextbox1.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.SearchbunifuMaterialTextbox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SearchbunifuMaterialTextbox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.SearchbunifuMaterialTextbox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.SearchbunifuMaterialTextbox1.HintForeColor = System.Drawing.Color.Silver;
            this.SearchbunifuMaterialTextbox1.HintText = "";
            this.SearchbunifuMaterialTextbox1.isPassword = false;
            this.SearchbunifuMaterialTextbox1.LineFocusedColor = System.Drawing.Color.Silver;
            this.SearchbunifuMaterialTextbox1.LineIdleColor = System.Drawing.Color.Gray;
            this.SearchbunifuMaterialTextbox1.LineMouseHoverColor = System.Drawing.Color.Silver;
            this.SearchbunifuMaterialTextbox1.LineThickness = 3;
            this.SearchbunifuMaterialTextbox1.Location = new System.Drawing.Point(428, 79);
            this.SearchbunifuMaterialTextbox1.Margin = new System.Windows.Forms.Padding(4);
            this.SearchbunifuMaterialTextbox1.MaxLength = 32767;
            this.SearchbunifuMaterialTextbox1.Name = "SearchbunifuMaterialTextbox1";
            this.SearchbunifuMaterialTextbox1.Size = new System.Drawing.Size(141, 33);
            this.SearchbunifuMaterialTextbox1.TabIndex = 1;
            this.SearchbunifuMaterialTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.SearchbunifuMaterialTextbox1.OnValueChanged += new System.EventHandler(this.SearchbunifuMaterialTextbox1_OnValueChanged);
            // 
            // SearchlistBox
            // 
            this.SearchlistBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.SearchlistBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SearchlistBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.personBindingSource, "Id", true));
            this.SearchlistBox.DataSource = this.personBindingSource;
            this.SearchlistBox.DisplayMember = "fullName";
            this.SearchlistBox.ForeColor = System.Drawing.Color.Silver;
            this.SearchlistBox.FormattingEnabled = true;
            this.SearchlistBox.Location = new System.Drawing.Point(428, 167);
            this.SearchlistBox.Name = "SearchlistBox";
            this.SearchlistBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.SearchlistBox.Size = new System.Drawing.Size(141, 171);
            this.SearchlistBox.TabIndex = 2;
            this.SearchlistBox.ValueMember = "Id";
            this.SearchlistBox.SelectedIndexChanged += new System.EventHandler(this.SearchlistBox_SelectedIndexChanged);
            // 
            // personBindingSource
            // 
            this.personBindingSource.DataSource = typeof(BusinessEntity.person);
            // 
            // CVSaverbutton
            // 
            this.CVSaverbutton.FlatAppearance.BorderSize = 0;
            this.CVSaverbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CVSaverbutton.ForeColor = System.Drawing.Color.Silver;
            this.CVSaverbutton.Location = new System.Drawing.Point(235, 366);
            this.CVSaverbutton.Name = "CVSaverbutton";
            this.CVSaverbutton.Size = new System.Drawing.Size(87, 23);
            this.CVSaverbutton.TabIndex = 29;
            this.CVSaverbutton.Text = "ذخیره";
            this.CVSaverbutton.UseVisualStyleBackColor = true;
            // 
            // CVChoosebutton
            // 
            this.CVChoosebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CVChoosebutton.ForeColor = System.Drawing.Color.Silver;
            this.CVChoosebutton.Location = new System.Drawing.Point(235, 337);
            this.CVChoosebutton.Name = "CVChoosebutton";
            this.CVChoosebutton.Size = new System.Drawing.Size(87, 23);
            this.CVChoosebutton.TabIndex = 28;
            this.CVChoosebutton.Text = "انتخاب فایل";
            this.CVChoosebutton.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(235, 295);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboBox1.Size = new System.Drawing.Size(87, 21);
            this.comboBox1.TabIndex = 27;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.numericUpDown1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDown1.ForeColor = System.Drawing.Color.Silver;
            this.numericUpDown1.Location = new System.Drawing.Point(235, 256);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(87, 20);
            this.numericUpDown1.TabIndex = 26;
            // 
            // bunifuMaterialTextbox4
            // 
            this.bunifuMaterialTextbox4.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.bunifuMaterialTextbox4.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.bunifuMaterialTextbox4.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.bunifuMaterialTextbox4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMaterialTextbox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.bunifuMaterialTextbox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuMaterialTextbox4.HintForeColor = System.Drawing.Color.Silver;
            this.bunifuMaterialTextbox4.HintText = "";
            this.bunifuMaterialTextbox4.isPassword = false;
            this.bunifuMaterialTextbox4.LineFocusedColor = System.Drawing.Color.Silver;
            this.bunifuMaterialTextbox4.LineIdleColor = System.Drawing.Color.Gray;
            this.bunifuMaterialTextbox4.LineMouseHoverColor = System.Drawing.Color.Silver;
            this.bunifuMaterialTextbox4.LineThickness = 3;
            this.bunifuMaterialTextbox4.Location = new System.Drawing.Point(152, 212);
            this.bunifuMaterialTextbox4.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMaterialTextbox4.MaxLength = 32767;
            this.bunifuMaterialTextbox4.Name = "bunifuMaterialTextbox4";
            this.bunifuMaterialTextbox4.Size = new System.Drawing.Size(170, 24);
            this.bunifuMaterialTextbox4.TabIndex = 25;
            this.bunifuMaterialTextbox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuMaterialTextbox3
            // 
            this.bunifuMaterialTextbox3.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.bunifuMaterialTextbox3.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.bunifuMaterialTextbox3.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.bunifuMaterialTextbox3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMaterialTextbox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.bunifuMaterialTextbox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuMaterialTextbox3.HintForeColor = System.Drawing.Color.Silver;
            this.bunifuMaterialTextbox3.HintText = "";
            this.bunifuMaterialTextbox3.isPassword = false;
            this.bunifuMaterialTextbox3.LineFocusedColor = System.Drawing.Color.Silver;
            this.bunifuMaterialTextbox3.LineIdleColor = System.Drawing.Color.Gray;
            this.bunifuMaterialTextbox3.LineMouseHoverColor = System.Drawing.Color.Silver;
            this.bunifuMaterialTextbox3.LineThickness = 3;
            this.bunifuMaterialTextbox3.Location = new System.Drawing.Point(152, 167);
            this.bunifuMaterialTextbox3.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMaterialTextbox3.MaxLength = 32767;
            this.bunifuMaterialTextbox3.Name = "bunifuMaterialTextbox3";
            this.bunifuMaterialTextbox3.Size = new System.Drawing.Size(170, 24);
            this.bunifuMaterialTextbox3.TabIndex = 24;
            this.bunifuMaterialTextbox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuMaterialTextbox2
            // 
            this.bunifuMaterialTextbox2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.bunifuMaterialTextbox2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.bunifuMaterialTextbox2.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.bunifuMaterialTextbox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMaterialTextbox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.bunifuMaterialTextbox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuMaterialTextbox2.HintForeColor = System.Drawing.Color.Silver;
            this.bunifuMaterialTextbox2.HintText = "";
            this.bunifuMaterialTextbox2.isPassword = false;
            this.bunifuMaterialTextbox2.LineFocusedColor = System.Drawing.Color.Silver;
            this.bunifuMaterialTextbox2.LineIdleColor = System.Drawing.Color.Gray;
            this.bunifuMaterialTextbox2.LineMouseHoverColor = System.Drawing.Color.Silver;
            this.bunifuMaterialTextbox2.LineThickness = 3;
            this.bunifuMaterialTextbox2.Location = new System.Drawing.Point(152, 120);
            this.bunifuMaterialTextbox2.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMaterialTextbox2.MaxLength = 32767;
            this.bunifuMaterialTextbox2.Name = "bunifuMaterialTextbox2";
            this.bunifuMaterialTextbox2.Size = new System.Drawing.Size(170, 24);
            this.bunifuMaterialTextbox2.TabIndex = 23;
            this.bunifuMaterialTextbox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuMaterialTextbox1
            // 
            this.bunifuMaterialTextbox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.bunifuMaterialTextbox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.bunifuMaterialTextbox1.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.bunifuMaterialTextbox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMaterialTextbox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.bunifuMaterialTextbox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuMaterialTextbox1.HintForeColor = System.Drawing.Color.Silver;
            this.bunifuMaterialTextbox1.HintText = "";
            this.bunifuMaterialTextbox1.isPassword = false;
            this.bunifuMaterialTextbox1.LineFocusedColor = System.Drawing.Color.Silver;
            this.bunifuMaterialTextbox1.LineIdleColor = System.Drawing.Color.Gray;
            this.bunifuMaterialTextbox1.LineMouseHoverColor = System.Drawing.Color.Silver;
            this.bunifuMaterialTextbox1.LineThickness = 3;
            this.bunifuMaterialTextbox1.Location = new System.Drawing.Point(152, 75);
            this.bunifuMaterialTextbox1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMaterialTextbox1.MaxLength = 32767;
            this.bunifuMaterialTextbox1.Name = "bunifuMaterialTextbox1";
            this.bunifuMaterialTextbox1.Size = new System.Drawing.Size(170, 24);
            this.bunifuMaterialTextbox1.TabIndex = 22;
            this.bunifuMaterialTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // CVUploaderlabel
            // 
            this.CVUploaderlabel.AutoSize = true;
            this.CVUploaderlabel.ForeColor = System.Drawing.Color.Silver;
            this.CVUploaderlabel.Location = new System.Drawing.Point(284, 319);
            this.CVUploaderlabel.Name = "CVUploaderlabel";
            this.CVUploaderlabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CVUploaderlabel.Size = new System.Drawing.Size(58, 13);
            this.CVUploaderlabel.TabIndex = 21;
            this.CVUploaderlabel.Text = "آپلود رزومه";
            // 
            // Grouplabel
            // 
            this.Grouplabel.AutoSize = true;
            this.Grouplabel.ForeColor = System.Drawing.Color.Silver;
            this.Grouplabel.Location = new System.Drawing.Point(311, 279);
            this.Grouplabel.Name = "Grouplabel";
            this.Grouplabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Grouplabel.Size = new System.Drawing.Size(31, 13);
            this.Grouplabel.TabIndex = 20;
            this.Grouplabel.Text = "گروه";
            // 
            // Agelabel
            // 
            this.Agelabel.AutoSize = true;
            this.Agelabel.ForeColor = System.Drawing.Color.Silver;
            this.Agelabel.Location = new System.Drawing.Point(319, 240);
            this.Agelabel.Name = "Agelabel";
            this.Agelabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Agelabel.Size = new System.Drawing.Size(23, 13);
            this.Agelabel.TabIndex = 19;
            this.Agelabel.Text = "سن";
            // 
            // Addresslabel
            // 
            this.Addresslabel.AutoSize = true;
            this.Addresslabel.ForeColor = System.Drawing.Color.Silver;
            this.Addresslabel.Location = new System.Drawing.Point(309, 195);
            this.Addresslabel.Name = "Addresslabel";
            this.Addresslabel.Size = new System.Drawing.Size(30, 13);
            this.Addresslabel.TabIndex = 18;
            this.Addresslabel.Text = "آدرس";
            // 
            // Phonelabel
            // 
            this.Phonelabel.AutoSize = true;
            this.Phonelabel.ForeColor = System.Drawing.Color.Silver;
            this.Phonelabel.Location = new System.Drawing.Point(281, 148);
            this.Phonelabel.Name = "Phonelabel";
            this.Phonelabel.Size = new System.Drawing.Size(58, 13);
            this.Phonelabel.TabIndex = 17;
            this.Phonelabel.Text = "شماره تلفن";
            // 
            // Relationlabel
            // 
            this.Relationlabel.AutoSize = true;
            this.Relationlabel.ForeColor = System.Drawing.Color.Silver;
            this.Relationlabel.Location = new System.Drawing.Point(274, 103);
            this.Relationlabel.Name = "Relationlabel";
            this.Relationlabel.Size = new System.Drawing.Size(65, 13);
            this.Relationlabel.TabIndex = 16;
            this.Relationlabel.Text = "عنوان شغلی";
            // 
            // Namelabel
            // 
            this.Namelabel.AutoSize = true;
            this.Namelabel.ForeColor = System.Drawing.Color.Silver;
            this.Namelabel.Location = new System.Drawing.Point(245, 58);
            this.Namelabel.Name = "Namelabel";
            this.Namelabel.Size = new System.Drawing.Size(94, 13);
            this.Namelabel.TabIndex = 15;
            this.Namelabel.Text = "نام و نام خانوادگی";
            // 
            // savebutton
            // 
            this.savebutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("savebutton.BackgroundImage")));
            this.savebutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.savebutton.FlatAppearance.BorderSize = 0;
            this.savebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.savebutton.Location = new System.Drawing.Point(23, 366);
            this.savebutton.Name = "savebutton";
            this.savebutton.Size = new System.Drawing.Size(75, 23);
            this.savebutton.TabIndex = 30;
            this.savebutton.UseVisualStyleBackColor = true;
            this.savebutton.Click += new System.EventHandler(this.savebutton_Click);
            // 
            // manaDigitalDataSet
            // 
            this.manaDigitalDataSet.DataSetName = "ManaDigitalDataSet";
            this.manaDigitalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // manaDigitalDataSetBindingSource
            // 
            this.manaDigitalDataSetBindingSource.DataSource = this.manaDigitalDataSet;
            this.manaDigitalDataSetBindingSource.Position = 0;
            // 
            // SearchUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
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
            this.Controls.Add(this.SearchlistBox);
            this.Controls.Add(this.SearchbunifuMaterialTextbox1);
            this.Controls.Add(this.Searchlabel);
            this.ForeColor = System.Drawing.Color.Silver;
            this.Name = "SearchUserControl";
            this.Size = new System.Drawing.Size(625, 411);
            this.Load += new System.EventHandler(this.SearchUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manaDigitalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manaDigitalDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Searchlabel;
        private Bunifu.Framework.UI.BunifuMaterialTextbox SearchbunifuMaterialTextbox1;
        private System.Windows.Forms.ListBox SearchlistBox;
        private System.Windows.Forms.Button CVSaverbutton;
        private System.Windows.Forms.Button CVChoosebutton;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox4;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox1;
        private System.Windows.Forms.Label CVUploaderlabel;
        private System.Windows.Forms.Label Grouplabel;
        private System.Windows.Forms.Label Agelabel;
        private System.Windows.Forms.Label Addresslabel;
        private System.Windows.Forms.Label Phonelabel;
        private System.Windows.Forms.Label Relationlabel;
        private System.Windows.Forms.Label Namelabel;
        private System.Windows.Forms.Button savebutton;
        private System.Windows.Forms.BindingSource personBindingSource;
        private ManaDigitalDataSet manaDigitalDataSet;
        private System.Windows.Forms.BindingSource manaDigitalDataSetBindingSource;
    }
}
