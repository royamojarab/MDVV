
namespace ManaDigitalV.Forms
{
    partial class RegisterSubmitForm
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
            this.RegisterSubmitlabel = new System.Windows.Forms.Label();
            this.Nextbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RegisterSubmitlabel
            // 
            this.RegisterSubmitlabel.AutoSize = true;
            this.RegisterSubmitlabel.Location = new System.Drawing.Point(-3, 9);
            this.RegisterSubmitlabel.Name = "RegisterSubmitlabel";
            this.RegisterSubmitlabel.Size = new System.Drawing.Size(143, 13);
            this.RegisterSubmitlabel.TabIndex = 0;
            this.RegisterSubmitlabel.Text = "ثبت نام کاربر موفقیت آمیز بود";
            // 
            // Nextbutton
            // 
            this.Nextbutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.Nextbutton.Location = new System.Drawing.Point(48, 52);
            this.Nextbutton.Name = "Nextbutton";
            this.Nextbutton.Size = new System.Drawing.Size(39, 20);
            this.Nextbutton.TabIndex = 2;
            this.Nextbutton.Text = "ادامه";
            this.Nextbutton.UseVisualStyleBackColor = true;
            this.Nextbutton.Click += new System.EventHandler(this.Nextbutton_Click);
            // 
            // RegisterSubmitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(140, 84);
            this.Controls.Add(this.Nextbutton);
            this.Controls.Add(this.RegisterSubmitlabel);
            this.ForeColor = System.Drawing.Color.Silver;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegisterSubmitForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterSubmitForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label RegisterSubmitlabel;
        private System.Windows.Forms.Button Nextbutton;
    }
}