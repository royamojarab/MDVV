
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GroupListsUserControl));
            this.Groupslabel = new System.Windows.Forms.Label();
            this.Memberslabel = new System.Windows.Forms.Label();
            this.GroupNamelistBox = new System.Windows.Forms.ListBox();
            this.MemberslistBox = new System.Windows.Forms.ListBox();
            this.FlashpictureBox = new System.Windows.Forms.PictureBox();
            this.GroupBackbutton = new System.Windows.Forms.Button();
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
            this.GroupNamelistBox.ForeColor = System.Drawing.Color.Silver;
            this.GroupNamelistBox.FormattingEnabled = true;
            this.GroupNamelistBox.Location = new System.Drawing.Point(405, 120);
            this.GroupNamelistBox.Name = "GroupNamelistBox";
            this.GroupNamelistBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.GroupNamelistBox.Size = new System.Drawing.Size(120, 160);
            this.GroupNamelistBox.TabIndex = 2;
            // 
            // MemberslistBox
            // 
            this.MemberslistBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.MemberslistBox.ForeColor = System.Drawing.Color.Silver;
            this.MemberslistBox.FormattingEnabled = true;
            this.MemberslistBox.Location = new System.Drawing.Point(84, 120);
            this.MemberslistBox.Name = "MemberslistBox";
            this.MemberslistBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.MemberslistBox.Size = new System.Drawing.Size(120, 160);
            this.MemberslistBox.TabIndex = 3;
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
            this.GroupBackbutton.TabIndex = 5;
            this.GroupBackbutton.Text = "بازگشت";
            this.GroupBackbutton.UseVisualStyleBackColor = true;
            this.GroupBackbutton.Click += new System.EventHandler(this.GroupBackbutton_Click);
            // 
            // GroupListsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.Controls.Add(this.GroupBackbutton);
            this.Controls.Add(this.FlashpictureBox);
            this.Controls.Add(this.MemberslistBox);
            this.Controls.Add(this.GroupNamelistBox);
            this.Controls.Add(this.Memberslabel);
            this.Controls.Add(this.Groupslabel);
            this.Name = "GroupListsUserControl";
            this.Size = new System.Drawing.Size(625, 411);
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
    }
}
