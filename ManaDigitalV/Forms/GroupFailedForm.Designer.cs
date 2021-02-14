
namespace ManaDigitalV.Forms
{
    partial class GroupFailedForm
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
            this.FailedGroupMakelabel = new System.Windows.Forms.Label();
            this.Returnbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FailedGroupMakelabel
            // 
            this.FailedGroupMakelabel.AutoSize = true;
            this.FailedGroupMakelabel.Location = new System.Drawing.Point(12, 9);
            this.FailedGroupMakelabel.Name = "FailedGroupMakelabel";
            this.FailedGroupMakelabel.Size = new System.Drawing.Size(116, 13);
            this.FailedGroupMakelabel.TabIndex = 0;
            this.FailedGroupMakelabel.Text = "عملیات با خطا مواجه شد";
            // 
            // Returnbutton
            // 
            this.Returnbutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.Returnbutton.Location = new System.Drawing.Point(43, 52);
            this.Returnbutton.Name = "Returnbutton";
            this.Returnbutton.Size = new System.Drawing.Size(54, 20);
            this.Returnbutton.TabIndex = 1;
            this.Returnbutton.Text = "بازگشت";
            this.Returnbutton.UseVisualStyleBackColor = true;
            // 
            // GroupFailedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(140, 84);
            this.Controls.Add(this.Returnbutton);
            this.Controls.Add(this.FailedGroupMakelabel);
            this.ForeColor = System.Drawing.Color.Silver;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GroupFailedForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GroupFailedForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FailedGroupMakelabel;
        private System.Windows.Forms.Button Returnbutton;
    }
}