
namespace CourseDB
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.clientGB = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.submitClient = new System.Windows.Forms.Button();
            this.addressTB = new System.Windows.Forms.TextBox();
            this.phoneTB = new System.Windows.Forms.TextBox();
            this.fullnameTB = new System.Windows.Forms.TextBox();
            this.clientGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // clientGB
            // 
            this.clientGB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.clientGB.Controls.Add(this.label3);
            this.clientGB.Controls.Add(this.label2);
            this.clientGB.Controls.Add(this.label1);
            this.clientGB.Controls.Add(this.submitClient);
            this.clientGB.Controls.Add(this.addressTB);
            this.clientGB.Controls.Add(this.phoneTB);
            this.clientGB.Controls.Add(this.fullnameTB);
            this.clientGB.Location = new System.Drawing.Point(-3, -12);
            this.clientGB.Name = "clientGB";
            this.clientGB.Size = new System.Drawing.Size(733, 239);
            this.clientGB.TabIndex = 0;
            this.clientGB.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(562, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Телефон";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(326, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Адреса";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(74, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Повне ім\'я";
            // 
            // submitClient
            // 
            this.submitClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.submitClient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.submitClient.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.submitClient.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitClient.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.submitClient.Location = new System.Drawing.Point(620, 183);
            this.submitClient.Name = "submitClient";
            this.submitClient.Size = new System.Drawing.Size(99, 35);
            this.submitClient.TabIndex = 3;
            this.submitClient.Text = "Додати";
            this.submitClient.UseVisualStyleBackColor = false;
            this.submitClient.Click += new System.EventHandler(this.submitClient_Click);
            // 
            // addressTB
            // 
            this.addressTB.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressTB.Location = new System.Drawing.Point(290, 104);
            this.addressTB.Name = "addressTB";
            this.addressTB.Size = new System.Drawing.Size(157, 29);
            this.addressTB.TabIndex = 2;
            // 
            // phoneTB
            // 
            this.phoneTB.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneTB.Location = new System.Drawing.Point(530, 104);
            this.phoneTB.Name = "phoneTB";
            this.phoneTB.Size = new System.Drawing.Size(157, 29);
            this.phoneTB.TabIndex = 1;
            // 
            // fullnameTB
            // 
            this.fullnameTB.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullnameTB.Location = new System.Drawing.Point(47, 104);
            this.fullnameTB.Name = "fullnameTB";
            this.fullnameTB.Size = new System.Drawing.Size(157, 29);
            this.fullnameTB.TabIndex = 0;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(728, 226);
            this.Controls.Add(this.clientGB);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Клієнт";
            this.clientGB.ResumeLayout(false);
            this.clientGB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox clientGB;
        private System.Windows.Forms.Button submitClient;
        private System.Windows.Forms.TextBox addressTB;
        private System.Windows.Forms.TextBox phoneTB;
        private System.Windows.Forms.TextBox fullnameTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}