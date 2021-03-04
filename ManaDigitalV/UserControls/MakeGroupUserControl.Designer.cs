
namespace ManaDigitalV.UserControls
{
    partial class MakeGroupUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MakeGroupUserControl));
            this.MakeGrouplabel = new System.Windows.Forms.Label();
            this.GroupNamelabel = new System.Windows.Forms.Label();
            this.GroupNamebunifuMaterialTextbox1 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.NewGroupMemberlistBox = new System.Windows.Forms.ListBox();
            this.personBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.MemberslistBox = new System.Windows.Forms.ListBox();
            this.Memberslabel = new System.Windows.Forms.Label();
            this.GroupListbutton = new System.Windows.Forms.Button();
            this.MakeNewGroupbutton = new System.Windows.Forms.Button();
            this.Refreshbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // MakeGrouplabel
            // 
            this.MakeGrouplabel.AutoSize = true;
            this.MakeGrouplabel.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.MakeGrouplabel.ForeColor = System.Drawing.Color.Silver;
            this.MakeGrouplabel.Location = new System.Drawing.Point(506, 27);
            this.MakeGrouplabel.Name = "MakeGrouplabel";
            this.MakeGrouplabel.Size = new System.Drawing.Size(96, 24);
            this.MakeGrouplabel.TabIndex = 0;
            this.MakeGrouplabel.Text = ":ایجاد گروه جدید";
            // 
            // GroupNamelabel
            // 
            this.GroupNamelabel.AutoSize = true;
            this.GroupNamelabel.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.GroupNamelabel.ForeColor = System.Drawing.Color.Silver;
            this.GroupNamelabel.Location = new System.Drawing.Point(553, 66);
            this.GroupNamelabel.Name = "GroupNamelabel";
            this.GroupNamelabel.Size = new System.Drawing.Size(49, 24);
            this.GroupNamelabel.TabIndex = 1;
            this.GroupNamelabel.Text = "نام گروه";
            // 
            // GroupNamebunifuMaterialTextbox1
            // 
            this.GroupNamebunifuMaterialTextbox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.GroupNamebunifuMaterialTextbox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.GroupNamebunifuMaterialTextbox1.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.GroupNamebunifuMaterialTextbox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.GroupNamebunifuMaterialTextbox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.GroupNamebunifuMaterialTextbox1.ForeColor = System.Drawing.Color.Silver;
            this.GroupNamebunifuMaterialTextbox1.HintForeColor = System.Drawing.Color.Silver;
            this.GroupNamebunifuMaterialTextbox1.HintText = "";
            this.GroupNamebunifuMaterialTextbox1.isPassword = false;
            this.GroupNamebunifuMaterialTextbox1.LineFocusedColor = System.Drawing.Color.Silver;
            this.GroupNamebunifuMaterialTextbox1.LineIdleColor = System.Drawing.Color.Gray;
            this.GroupNamebunifuMaterialTextbox1.LineMouseHoverColor = System.Drawing.Color.Silver;
            this.GroupNamebunifuMaterialTextbox1.LineThickness = 3;
            this.GroupNamebunifuMaterialTextbox1.Location = new System.Drawing.Point(445, 83);
            this.GroupNamebunifuMaterialTextbox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GroupNamebunifuMaterialTextbox1.MaxLength = 32767;
            this.GroupNamebunifuMaterialTextbox1.Name = "GroupNamebunifuMaterialTextbox1";
            this.GroupNamebunifuMaterialTextbox1.Size = new System.Drawing.Size(119, 33);
            this.GroupNamebunifuMaterialTextbox1.TabIndex = 1;
            this.GroupNamebunifuMaterialTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.GroupNamebunifuMaterialTextbox1.OnValueChanged += new System.EventHandler(this.GroupNamebunifuMaterialTextbox1_OnValueChanged);
            // 
            // NewGroupMemberlistBox
            // 
            this.NewGroupMemberlistBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.NewGroupMemberlistBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.personBindingSource, "Id", true));
            this.NewGroupMemberlistBox.DataSource = this.personBindingSource;
            this.NewGroupMemberlistBox.DisplayMember = "fullName";
            this.NewGroupMemberlistBox.ForeColor = System.Drawing.Color.Silver;
            this.NewGroupMemberlistBox.FormattingEnabled = true;
            this.NewGroupMemberlistBox.Location = new System.Drawing.Point(445, 153);
            this.NewGroupMemberlistBox.Name = "NewGroupMemberlistBox";
            this.NewGroupMemberlistBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.NewGroupMemberlistBox.Size = new System.Drawing.Size(119, 186);
            this.NewGroupMemberlistBox.TabIndex = 2;
            this.NewGroupMemberlistBox.ValueMember = "Id";
            this.NewGroupMemberlistBox.Click += new System.EventHandler(this.NewGroupMemberlistBox_Click);
            this.NewGroupMemberlistBox.SelectedIndexChanged += new System.EventHandler(this.NewGroupMemberlistBox_SelectedIndexChanged);
            // 
            // personBindingSource
            // 
            this.personBindingSource.DataSource = typeof(BusinessEntity.person);
            // 
            // personBindingSource1
            // 
            this.personBindingSource1.DataSource = typeof(BusinessEntity.person);
            // 
            // MemberslistBox
            // 
            this.MemberslistBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.MemberslistBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.personBindingSource, "Id", true));
            this.MemberslistBox.DataSource = this.personBindingSource;
            this.MemberslistBox.DisplayMember = "fullName";
            this.MemberslistBox.ForeColor = System.Drawing.Color.Silver;
            this.MemberslistBox.FormattingEnabled = true;
            this.MemberslistBox.Location = new System.Drawing.Point(166, 114);
            this.MemberslistBox.Name = "MemberslistBox";
            this.MemberslistBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.MemberslistBox.Size = new System.Drawing.Size(119, 225);
            this.MemberslistBox.TabIndex = 3;
            this.MemberslistBox.ValueMember = "Id";
            this.MemberslistBox.Click += new System.EventHandler(this.MemberslistBox_Click);
            // 
            // Memberslabel
            // 
            this.Memberslabel.AutoSize = true;
            this.Memberslabel.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Memberslabel.ForeColor = System.Drawing.Color.Silver;
            this.Memberslabel.Location = new System.Drawing.Point(243, 66);
            this.Memberslabel.Name = "Memberslabel";
            this.Memberslabel.Size = new System.Drawing.Size(45, 24);
            this.Memberslabel.TabIndex = 5;
            this.Memberslabel.Text = "کاربران";
            // 
            // GroupListbutton
            // 
            this.GroupListbutton.FlatAppearance.BorderSize = 0;
            this.GroupListbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GroupListbutton.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.GroupListbutton.ForeColor = System.Drawing.Color.Silver;
            this.GroupListbutton.Location = new System.Drawing.Point(3, 358);
            this.GroupListbutton.Name = "GroupListbutton";
            this.GroupListbutton.Size = new System.Drawing.Size(94, 35);
            this.GroupListbutton.TabIndex = 5;
            this.GroupListbutton.Text = "مشاهده گروه ها";
            this.GroupListbutton.UseVisualStyleBackColor = true;
            this.GroupListbutton.Click += new System.EventHandler(this.GroupListbutton_Click);
            // 
            // MakeNewGroupbutton
            // 
            this.MakeNewGroupbutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MakeNewGroupbutton.BackgroundImage")));
            this.MakeNewGroupbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.MakeNewGroupbutton.FlatAppearance.BorderSize = 0;
            this.MakeNewGroupbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MakeNewGroupbutton.Location = new System.Drawing.Point(466, 370);
            this.MakeNewGroupbutton.Name = "MakeNewGroupbutton";
            this.MakeNewGroupbutton.Size = new System.Drawing.Size(75, 23);
            this.MakeNewGroupbutton.TabIndex = 4;
            this.MakeNewGroupbutton.UseVisualStyleBackColor = true;
            this.MakeNewGroupbutton.Click += new System.EventHandler(this.MakeNewGroupbutton_Click);
            // 
            // Refreshbutton
            // 
            this.Refreshbutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Refreshbutton.BackgroundImage")));
            this.Refreshbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Refreshbutton.FlatAppearance.BorderSize = 0;
            this.Refreshbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Refreshbutton.Location = new System.Drawing.Point(588, 3);
            this.Refreshbutton.Name = "Refreshbutton";
            this.Refreshbutton.Size = new System.Drawing.Size(34, 22);
            this.Refreshbutton.TabIndex = 32;
            this.Refreshbutton.UseVisualStyleBackColor = true;
            this.Refreshbutton.Click += new System.EventHandler(this.Refreshbutton_Click);
            // 
            // MakeGroupUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.Controls.Add(this.Refreshbutton);
            this.Controls.Add(this.MakeNewGroupbutton);
            this.Controls.Add(this.GroupListbutton);
            this.Controls.Add(this.Memberslabel);
            this.Controls.Add(this.MemberslistBox);
            this.Controls.Add(this.NewGroupMemberlistBox);
            this.Controls.Add(this.GroupNamebunifuMaterialTextbox1);
            this.Controls.Add(this.GroupNamelabel);
            this.Controls.Add(this.MakeGrouplabel);
            this.Name = "MakeGroupUserControl";
            this.Size = new System.Drawing.Size(625, 411);
            this.Load += new System.EventHandler(this.MakeGroupUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MakeGrouplabel;
        private System.Windows.Forms.Label GroupNamelabel;
        private Bunifu.Framework.UI.BunifuMaterialTextbox GroupNamebunifuMaterialTextbox1;
        private System.Windows.Forms.ListBox NewGroupMemberlistBox;
        private System.Windows.Forms.ListBox MemberslistBox;
        private System.Windows.Forms.Label Memberslabel;
        private System.Windows.Forms.Button GroupListbutton;
        private System.Windows.Forms.BindingSource personBindingSource;
        private System.Windows.Forms.BindingSource personBindingSource1;
        private System.Windows.Forms.Button MakeNewGroupbutton;
        private System.Windows.Forms.Button Refreshbutton;
    }
}
