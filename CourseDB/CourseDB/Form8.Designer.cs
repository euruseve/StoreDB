
namespace CourseDB
{
    partial class Form8
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form8));
            this.clientGB = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.descriptionL = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.priceL = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.descroptionTB = new System.Windows.Forms.TextBox();
            this.nameTB = new System.Windows.Forms.TextBox();
            this.clientGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // clientGB
            // 
            this.clientGB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.clientGB.Controls.Add(this.nameTB);
            this.clientGB.Controls.Add(this.descroptionTB);
            this.clientGB.Controls.Add(this.priceL);
            this.clientGB.Controls.Add(this.label4);
            this.clientGB.Controls.Add(this.descriptionL);
            this.clientGB.Controls.Add(this.label3);
            this.clientGB.Controls.Add(this.label1);
            this.clientGB.Controls.Add(this.pictureBox1);
            this.clientGB.Location = new System.Drawing.Point(-5, -29);
            this.clientGB.Name = "clientGB";
            this.clientGB.Size = new System.Drawing.Size(811, 486);
            this.clientGB.TabIndex = 2;
            this.clientGB.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(17, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(244, 214);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(64, 268);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "Назва товару";
            // 
            // descriptionL
            // 
            this.descriptionL.AutoSize = true;
            this.descriptionL.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.descriptionL.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.descriptionL.Location = new System.Drawing.Point(136, 370);
            this.descriptionL.Name = "descriptionL";
            this.descriptionL.Size = new System.Drawing.Size(0, 24);
            this.descriptionL.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(488, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 24);
            this.label3.TabIndex = 11;
            this.label3.Text = "Опис";
            // 
            // priceL
            // 
            this.priceL.AutoSize = true;
            this.priceL.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priceL.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.priceL.Location = new System.Drawing.Point(104, 440);
            this.priceL.Name = "priceL";
            this.priceL.Size = new System.Drawing.Size(0, 24);
            this.priceL.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(17, 440);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 24);
            this.label4.TabIndex = 13;
            this.label4.Text = "Ціна";
            // 
            // descroptionTB
            // 
            this.descroptionTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.descroptionTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.descroptionTB.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.descroptionTB.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.descroptionTB.Location = new System.Drawing.Point(279, 70);
            this.descroptionTB.Multiline = true;
            this.descroptionTB.Name = "descroptionTB";
            this.descroptionTB.ReadOnly = true;
            this.descroptionTB.Size = new System.Drawing.Size(514, 397);
            this.descroptionTB.TabIndex = 15;
            // 
            // nameTB
            // 
            this.nameTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.nameTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nameTB.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameTB.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nameTB.Location = new System.Drawing.Point(17, 306);
            this.nameTB.Multiline = true;
            this.nameTB.Name = "nameTB";
            this.nameTB.ReadOnly = true;
            this.nameTB.Size = new System.Drawing.Size(244, 119);
            this.nameTB.TabIndex = 16;
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.clientGB);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form8";
            this.Text = "Інформація про товар";
            this.clientGB.ResumeLayout(false);
            this.clientGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox clientGB;
        private System.Windows.Forms.Label priceL;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label descriptionL;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox descroptionTB;
        private System.Windows.Forms.TextBox nameTB;
    }
}