﻿
namespace ManaDigitalV.Forms
{
    partial class FailedRegisterSubmitForm
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
            this.FailedRegisterSubmitlabel = new System.Windows.Forms.Label();
            this.Returnbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FailedRegisterSubmitlabel
            // 
            this.FailedRegisterSubmitlabel.AutoSize = true;
            this.FailedRegisterSubmitlabel.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FailedRegisterSubmitlabel.Location = new System.Drawing.Point(12, 9);
            this.FailedRegisterSubmitlabel.Name = "FailedRegisterSubmitlabel";
            this.FailedRegisterSubmitlabel.Size = new System.Drawing.Size(110, 20);
            this.FailedRegisterSubmitlabel.TabIndex = 0;
            this.FailedRegisterSubmitlabel.Text = "امکان ثبت نام وجود ندارد";
            // 
            // Returnbutton
            // 
            this.Returnbutton.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Returnbutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.Returnbutton.Location = new System.Drawing.Point(31, 49);
            this.Returnbutton.Name = "Returnbutton";
            this.Returnbutton.Size = new System.Drawing.Size(78, 23);
            this.Returnbutton.TabIndex = 1;
            this.Returnbutton.Text = "بازگشت";
            this.Returnbutton.UseVisualStyleBackColor = true;
            this.Returnbutton.Click += new System.EventHandler(this.Returnbutton_Click);
            // 
            // FailedRegisterSubmitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(140, 84);
            this.Controls.Add(this.Returnbutton);
            this.Controls.Add(this.FailedRegisterSubmitlabel);
            this.ForeColor = System.Drawing.Color.Silver;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FailedRegisterSubmitForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FailedRegisterSubmitForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FailedRegisterSubmitlabel;
        private System.Windows.Forms.Button Returnbutton;
    }
}