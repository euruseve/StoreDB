
namespace CourseDB
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.clientGB = new System.Windows.Forms.GroupBox();
            this.idCB = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.submitProvider = new System.Windows.Forms.Button();
            this.dateTB = new System.Windows.Forms.TextBox();
            this.clientGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // clientGB
            // 
            this.clientGB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.clientGB.Controls.Add(this.idCB);
            this.clientGB.Controls.Add(this.label7);
            this.clientGB.Controls.Add(this.label6);
            this.clientGB.Controls.Add(this.label1);
            this.clientGB.Controls.Add(this.submitProvider);
            this.clientGB.Controls.Add(this.dateTB);
            this.clientGB.Location = new System.Drawing.Point(-4, -11);
            this.clientGB.Name = "clientGB";
            this.clientGB.Size = new System.Drawing.Size(742, 292);
            this.clientGB.TabIndex = 3;
            this.clientGB.TabStop = false;
            // 
            // idCB
            // 
            this.idCB.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idCB.FormattingEnabled = true;
            this.idCB.Location = new System.Drawing.Point(116, 66);
            this.idCB.Name = "idCB";
            this.idCB.Size = new System.Drawing.Size(510, 30);
            this.idCB.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(305, 146);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 24);
            this.label7.TabIndex = 14;
            this.label7.Text = "Дата поставки";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(361, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 24);
            this.label6.TabIndex = 10;
            this.label6.Text = "ID";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 13;
            // 
            // submitProvider
            // 
            this.submitProvider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.submitProvider.Cursor = System.Windows.Forms.Cursors.Hand;
            this.submitProvider.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.submitProvider.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitProvider.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.submitProvider.Location = new System.Drawing.Point(628, 243);
            this.submitProvider.Name = "submitProvider";
            this.submitProvider.Size = new System.Drawing.Size(99, 35);
            this.submitProvider.TabIndex = 3;
            this.submitProvider.Text = "Додати";
            this.submitProvider.UseVisualStyleBackColor = false;
            this.submitProvider.Click += new System.EventHandler(this.submitProvider_Click);
            // 
            // dateTB
            // 
            this.dateTB.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTB.Location = new System.Drawing.Point(116, 183);
            this.dateTB.Name = "dateTB";
            this.dateTB.Size = new System.Drawing.Size(510, 29);
            this.dateTB.TabIndex = 0;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 279);
            this.Controls.Add(this.clientGB);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form5";
            this.Text = "Поставка";
            this.clientGB.ResumeLayout(false);
            this.clientGB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox clientGB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button submitProvider;
        private System.Windows.Forms.TextBox dateTB;
        private System.Windows.Forms.ComboBox idCB;
    }
}