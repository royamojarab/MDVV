
namespace ManaDigitalV.Forms
{
    partial class EditSuccessForm
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
            this.EditSuccesslabel = new System.Windows.Forms.Label();
            this.EditSuccessbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EditSuccesslabel
            // 
            this.EditSuccesslabel.AutoSize = true;
            this.EditSuccesslabel.Location = new System.Drawing.Point(0, 9);
            this.EditSuccesslabel.Name = "EditSuccesslabel";
            this.EditSuccesslabel.Size = new System.Drawing.Size(140, 13);
            this.EditSuccesslabel.TabIndex = 0;
            this.EditSuccesslabel.Text = ".اطلاعات با موفقیت تغییر کرد";
            this.EditSuccesslabel.Click += new System.EventHandler(this.EditSuccesslabel_Click);
            // 
            // EditSuccessbutton
            // 
            this.EditSuccessbutton.FlatAppearance.BorderSize = 0;
            this.EditSuccessbutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.EditSuccessbutton.Location = new System.Drawing.Point(43, 52);
            this.EditSuccessbutton.Name = "EditSuccessbutton";
            this.EditSuccessbutton.Size = new System.Drawing.Size(54, 20);
            this.EditSuccessbutton.TabIndex = 1;
            this.EditSuccessbutton.Text = "ادامه";
            this.EditSuccessbutton.UseVisualStyleBackColor = true;
            this.EditSuccessbutton.Click += new System.EventHandler(this.EditSuccessbutton_Click);
            // 
            // EditSuccessForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(140, 84);
            this.Controls.Add(this.EditSuccessbutton);
            this.Controls.Add(this.EditSuccesslabel);
            this.ForeColor = System.Drawing.Color.Silver;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditSuccessForm";
            this.Text = "EditSuccessForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label EditSuccesslabel;
        private System.Windows.Forms.Button EditSuccessbutton;
    }
}