
namespace ManaDigitalV.Forms
{
    partial class EditFailedForm
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
            this.EditFaildlabel1 = new System.Windows.Forms.Label();
            this.EditFaildlabel2 = new System.Windows.Forms.Label();
            this.EditFailedbutton1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EditFaildlabel1
            // 
            this.EditFaildlabel1.AutoSize = true;
            this.EditFaildlabel1.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.EditFaildlabel1.Location = new System.Drawing.Point(30, 9);
            this.EditFaildlabel1.Name = "EditFaildlabel1";
            this.EditFaildlabel1.Size = new System.Drawing.Size(78, 20);
            this.EditFaildlabel1.TabIndex = 0;
            this.EditFaildlabel1.Text = "اطلاعات ثبت نشد";
            // 
            // EditFaildlabel2
            // 
            this.EditFaildlabel2.AutoSize = true;
            this.EditFaildlabel2.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.EditFaildlabel2.Location = new System.Drawing.Point(25, 31);
            this.EditFaildlabel2.Name = "EditFaildlabel2";
            this.EditFaildlabel2.Size = new System.Drawing.Size(83, 20);
            this.EditFaildlabel2.TabIndex = 1;
            this.EditFaildlabel2.Text = "دوباره امتحان کنید";
            // 
            // EditFailedbutton1
            // 
            this.EditFailedbutton1.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.EditFailedbutton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.EditFailedbutton1.Location = new System.Drawing.Point(33, 54);
            this.EditFailedbutton1.Name = "EditFailedbutton1";
            this.EditFailedbutton1.Size = new System.Drawing.Size(65, 24);
            this.EditFailedbutton1.TabIndex = 1;
            this.EditFailedbutton1.Text = "بازگشت";
            this.EditFailedbutton1.UseVisualStyleBackColor = true;
            this.EditFailedbutton1.Click += new System.EventHandler(this.EditFailedbutton1_Click);
            // 
            // EditFailedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(140, 84);
            this.Controls.Add(this.EditFailedbutton1);
            this.Controls.Add(this.EditFaildlabel2);
            this.Controls.Add(this.EditFaildlabel1);
            this.ForeColor = System.Drawing.Color.Silver;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditFailedForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditFailedForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label EditFaildlabel1;
        private System.Windows.Forms.Label EditFaildlabel2;
        private System.Windows.Forms.Button EditFailedbutton1;
    }
}