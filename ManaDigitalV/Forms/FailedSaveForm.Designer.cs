﻿
namespace ManaDigitalV.Forms
{
    partial class FailedSaveForm
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
            this.FailedSavelabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Returnbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FailedSavelabel
            // 
            this.FailedSavelabel.AutoSize = true;
            this.FailedSavelabel.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FailedSavelabel.ForeColor = System.Drawing.Color.Silver;
            this.FailedSavelabel.Location = new System.Drawing.Point(27, 2);
            this.FailedSavelabel.Name = "FailedSavelabel";
            this.FailedSavelabel.Size = new System.Drawing.Size(79, 20);
            this.FailedSavelabel.TabIndex = 0;
            this.FailedSavelabel.Text = "تغییرات ثبت نشد";
            this.FailedSavelabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.FailedSavelabel.Click += new System.EventHandler(this.FailedSavelabel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(27, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "دوباره امتحان کنید";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Returnbutton
            // 
            this.Returnbutton.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Returnbutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.Returnbutton.Location = new System.Drawing.Point(31, 45);
            this.Returnbutton.Name = "Returnbutton";
            this.Returnbutton.Size = new System.Drawing.Size(75, 27);
            this.Returnbutton.TabIndex = 1;
            this.Returnbutton.Text = "بازگشت";
            this.Returnbutton.UseVisualStyleBackColor = true;
            // 
            // FailedSaveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(140, 84);
            this.Controls.Add(this.Returnbutton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FailedSavelabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FailedSaveForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FailedSaveForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FailedSavelabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Returnbutton;
    }
}