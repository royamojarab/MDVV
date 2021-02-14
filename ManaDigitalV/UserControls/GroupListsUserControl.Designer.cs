
namespace ManaDigitalV.UserControls
{
    partial class GroupListsUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GroupListsUserControl));
            this.Groupslabel = new System.Windows.Forms.Label();
            this.Memberslabel = new System.Windows.Forms.Label();
            this.GroupNamelistBox = new System.Windows.Forms.ListBox();
            this.groupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.MemberslistBox = new System.Windows.Forms.ListBox();
            this.personPhoneBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.FlashpictureBox = new System.Windows.Forms.PictureBox();
            this.GroupBackbutton = new System.Windows.Forms.Button();
            this.Refreshbutton = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.groupBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personPhoneBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FlashpictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Groupslabel
            // 
            this.Groupslabel.AutoSize = true;
            this.Groupslabel.ForeColor = System.Drawing.Color.Silver;
            this.Groupslabel.Location = new System.Drawing.Point(480, 73);
            this.Groupslabel.Name = "Groupslabel";
            this.Groupslabel.Size = new System.Drawing.Size(45, 13);
            this.Groupslabel.TabIndex = 0;
            this.Groupslabel.Text = "گروه ها";
            // 
            // Memberslabel
            // 
            this.Memberslabel.AutoSize = true;
            this.Memberslabel.ForeColor = System.Drawing.Color.Silver;
            this.Memberslabel.Location = new System.Drawing.Point(168, 73);
            this.Memberslabel.Name = "Memberslabel";
            this.Memberslabel.Size = new System.Drawing.Size(36, 13);
            this.Memberslabel.TabIndex = 1;
            this.Memberslabel.Text = "اعضاء";
            // 
            // GroupNamelistBox
            // 
            this.GroupNamelistBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.GroupNamelistBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.groupBindingSource, "Id", true));
            this.GroupNamelistBox.DataSource = this.groupBindingSource;
            this.GroupNamelistBox.DisplayMember = "groupName";
            this.GroupNamelistBox.ForeColor = System.Drawing.Color.Silver;
            this.GroupNamelistBox.FormattingEnabled = true;
            this.GroupNamelistBox.Location = new System.Drawing.Point(405, 120);
            this.GroupNamelistBox.Name = "GroupNamelistBox";
            this.GroupNamelistBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.GroupNamelistBox.Size = new System.Drawing.Size(120, 160);
            this.GroupNamelistBox.TabIndex = 1;
            this.GroupNamelistBox.ValueMember = "Id";
            this.GroupNamelistBox.Click += new System.EventHandler(this.GroupNamelistBox_Click);
            this.GroupNamelistBox.SelectedIndexChanged += new System.EventHandler(this.GroupNamelistBox_SelectedIndexChanged);
            // 
            // groupBindingSource
            // 
            this.groupBindingSource.DataSource = typeof(BusinessEntity.group);
            // 
            // MemberslistBox
            // 
            this.MemberslistBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.MemberslistBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.personPhoneBindingSource, "Id", true));
            this.MemberslistBox.DataSource = this.personBindingSource;
            this.MemberslistBox.DisplayMember = "fullName";
            this.MemberslistBox.ForeColor = System.Drawing.Color.Silver;
            this.MemberslistBox.FormattingEnabled = true;
            this.MemberslistBox.Location = new System.Drawing.Point(84, 120);
            this.MemberslistBox.Name = "MemberslistBox";
            this.MemberslistBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.MemberslistBox.Size = new System.Drawing.Size(120, 160);
            this.MemberslistBox.TabIndex = 2;
            this.MemberslistBox.ValueMember = "Id";
            // 
            // personPhoneBindingSource
            // 
            this.personPhoneBindingSource.DataSource = typeof(BusinessEntity.personPhone);
            // 
            // personBindingSource
            // 
            this.personBindingSource.DataSource = typeof(BusinessEntity.person);
            // 
            // FlashpictureBox
            // 
            this.FlashpictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("FlashpictureBox.BackgroundImage")));
            this.FlashpictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.FlashpictureBox.Location = new System.Drawing.Point(204, 120);
            this.FlashpictureBox.Name = "FlashpictureBox";
            this.FlashpictureBox.Size = new System.Drawing.Size(201, 160);
            this.FlashpictureBox.TabIndex = 4;
            this.FlashpictureBox.TabStop = false;
            // 
            // GroupBackbutton
            // 
            this.GroupBackbutton.FlatAppearance.BorderSize = 0;
            this.GroupBackbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GroupBackbutton.ForeColor = System.Drawing.Color.Silver;
            this.GroupBackbutton.Location = new System.Drawing.Point(3, 367);
            this.GroupBackbutton.Name = "GroupBackbutton";
            this.GroupBackbutton.Size = new System.Drawing.Size(75, 23);
            this.GroupBackbutton.TabIndex = 3;
            this.GroupBackbutton.Text = "بازگشت";
            this.GroupBackbutton.UseVisualStyleBackColor = true;
            this.GroupBackbutton.Click += new System.EventHandler(this.GroupBackbutton_Click);
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
            this.toolTip1.SetToolTip(this.Refreshbutton, " نمایش کامل اطلاعات");
            this.Refreshbutton.UseVisualStyleBackColor = true;
            this.Refreshbutton.Click += new System.EventHandler(this.Refreshbutton_Click);
            // 
            // GroupListsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.Controls.Add(this.Refreshbutton);
            this.Controls.Add(this.GroupBackbutton);
            this.Controls.Add(this.FlashpictureBox);
            this.Controls.Add(this.MemberslistBox);
            this.Controls.Add(this.GroupNamelistBox);
            this.Controls.Add(this.Memberslabel);
            this.Controls.Add(this.Groupslabel);
            this.Name = "GroupListsUserControl";
            this.Size = new System.Drawing.Size(625, 411);
            this.Load += new System.EventHandler(this.GroupListsUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personPhoneBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FlashpictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Groupslabel;
        private System.Windows.Forms.Label Memberslabel;
        private System.Windows.Forms.ListBox GroupNamelistBox;
        private System.Windows.Forms.ListBox MemberslistBox;
        private System.Windows.Forms.PictureBox FlashpictureBox;
        private System.Windows.Forms.Button GroupBackbutton;
        private System.Windows.Forms.BindingSource groupBindingSource;
        private System.Windows.Forms.BindingSource personPhoneBindingSource;
        private System.Windows.Forms.BindingSource personBindingSource;
        private System.Windows.Forms.Button Refreshbutton;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
