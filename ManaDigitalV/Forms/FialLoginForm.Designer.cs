
namespace ManaDigitalV.Forms
{
    partial class FialLoginForm
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
            this.Faillabel = new System.Windows.Forms.Label();
            this.Returnbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Faillabel
            // 
            this.Faillabel.AutoSize = true;
            this.Faillabel.ForeColor = System.Drawing.Color.Silver;
            this.Faillabel.Location = new System.Drawing.Point(12, 9);
            this.Faillabel.Name = "Faillabel";
            this.Faillabel.Size = new System.Drawing.Size(120, 13);
            this.Faillabel.TabIndex = 2;
            this.Faillabel.Text = "اطلاعات شما اشتباه است";
            this.Faillabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Returnbutton
            // 
            this.Returnbutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.Returnbutton.Location = new System.Drawing.Point(40, 52);
            this.Returnbutton.Name = "Returnbutton";
            this.Returnbutton.Size = new System.Drawing.Size(54, 20);
            this.Returnbutton.TabIndex = 1;
            this.Returnbutton.Text = "بازگشت";
            this.Returnbutton.UseVisualStyleBackColor = true;
            this.Returnbutton.Click += new System.EventHandler(this.Returnbutton_Click);
            // 
            // FialLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(140, 84);
            this.Controls.Add(this.Returnbutton);
            this.Controls.Add(this.Faillabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FialLoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FialLoginForm";
            this.Load += new System.EventHandler(this.FialLoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Faillabel;
        private System.Windows.Forms.Button Returnbutton;
    }
}