
namespace CourseDB
{
    partial class Form7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form7));
            this.clientGB = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.submitClient = new System.Windows.Forms.Button();
            this.nameTB = new System.Windows.Forms.TextBox();
            this.img = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.supplyIDCB = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.descriptionTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.supllyerpriceTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.countTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.priceTB = new System.Windows.Forms.TextBox();
            this.aviable = new System.Windows.Forms.CheckBox();
            this.clientGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // clientGB
            // 
            this.clientGB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.clientGB.Controls.Add(this.aviable);
            this.clientGB.Controls.Add(this.label5);
            this.clientGB.Controls.Add(this.priceTB);
            this.clientGB.Controls.Add(this.label4);
            this.clientGB.Controls.Add(this.countTB);
            this.clientGB.Controls.Add(this.label2);
            this.clientGB.Controls.Add(this.supllyerpriceTB);
            this.clientGB.Controls.Add(this.label1);
            this.clientGB.Controls.Add(this.descriptionTB);
            this.clientGB.Controls.Add(this.supplyIDCB);
            this.clientGB.Controls.Add(this.label6);
            this.clientGB.Controls.Add(this.pictureBox1);
            this.clientGB.Controls.Add(this.img);
            this.clientGB.Controls.Add(this.label3);
            this.clientGB.Controls.Add(this.submitClient);
            this.clientGB.Controls.Add(this.nameTB);
            this.clientGB.Location = new System.Drawing.Point(-6, -15);
            this.clientGB.Name = "clientGB";
            this.clientGB.Size = new System.Drawing.Size(811, 508);
            this.clientGB.TabIndex = 1;
            this.clientGB.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(258, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Назва товару";
            // 
            // submitClient
            // 
            this.submitClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.submitClient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.submitClient.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.submitClient.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitClient.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.submitClient.Location = new System.Drawing.Point(695, 457);
            this.submitClient.Name = "submitClient";
            this.submitClient.Size = new System.Drawing.Size(99, 35);
            this.submitClient.TabIndex = 3;
            this.submitClient.Text = "Додати";
            this.submitClient.UseVisualStyleBackColor = false;
            this.submitClient.Click += new System.EventHandler(this.submitClient_Click);
            // 
            // nameTB
            // 
            this.nameTB.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTB.Location = new System.Drawing.Point(222, 65);
            this.nameTB.Name = "nameTB";
            this.nameTB.Size = new System.Drawing.Size(196, 29);
            this.nameTB.TabIndex = 1;
            // 
            // img
            // 
            this.img.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.img.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.img.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.img.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.img.Location = new System.Drawing.Point(18, 187);
            this.img.Name = "img";
            this.img.Size = new System.Drawing.Size(167, 47);
            this.img.TabIndex = 7;
            this.img.Text = "Додати картинку";
            this.img.UseVisualStyleBackColor = false;
            this.img.Click += new System.EventHandler(this.img_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(18, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(167, 144);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // supplyIDCB
            // 
            this.supplyIDCB.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supplyIDCB.FormattingEnabled = true;
            this.supplyIDCB.Location = new System.Drawing.Point(525, 65);
            this.supplyIDCB.Name = "supplyIDCB";
            this.supplyIDCB.Size = new System.Drawing.Size(259, 30);
            this.supplyIDCB.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(606, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 24);
            this.label6.TabIndex = 16;
            this.label6.Text = "ID поставки";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(283, 264);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 24);
            this.label1.TabIndex = 19;
            this.label1.Text = "Опис товару";
            // 
            // descriptionTB
            // 
            this.descriptionTB.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionTB.Location = new System.Drawing.Point(18, 291);
            this.descriptionTB.Multiline = true;
            this.descriptionTB.Name = "descriptionTB";
            this.descriptionTB.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.descriptionTB.Size = new System.Drawing.Size(635, 204);
            this.descriptionTB.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(623, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 24);
            this.label2.TabIndex = 21;
            this.label2.Text = "Ціна поставки";
            // 
            // supllyerpriceTB
            // 
            this.supllyerpriceTB.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supllyerpriceTB.Location = new System.Drawing.Point(588, 153);
            this.supllyerpriceTB.Name = "supllyerpriceTB";
            this.supllyerpriceTB.Size = new System.Drawing.Size(196, 29);
            this.supllyerpriceTB.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(273, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 24);
            this.label4.TabIndex = 23;
            this.label4.Text = "Кількість";
            // 
            // countTB
            // 
            this.countTB.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countTB.Location = new System.Drawing.Point(222, 142);
            this.countTB.Name = "countTB";
            this.countTB.Size = new System.Drawing.Size(196, 29);
            this.countTB.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(623, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 24);
            this.label5.TabIndex = 25;
            this.label5.Text = "Ціна продажу";
            // 
            // priceTB
            // 
            this.priceTB.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceTB.Location = new System.Drawing.Point(588, 237);
            this.priceTB.Name = "priceTB";
            this.priceTB.Size = new System.Drawing.Size(196, 29);
            this.priceTB.TabIndex = 24;
            // 
            // aviable
            // 
            this.aviable.AutoSize = true;
            this.aviable.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aviable.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.aviable.Location = new System.Drawing.Point(222, 196);
            this.aviable.Name = "aviable";
            this.aviable.Size = new System.Drawing.Size(119, 28);
            this.aviable.TabIndex = 26;
            this.aviable.Text = "Наявність";
            this.aviable.UseVisualStyleBackColor = true;
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(800, 489);
            this.Controls.Add(this.clientGB);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form7";
            this.Text = "Товар";
            this.clientGB.ResumeLayout(false);
            this.clientGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox clientGB;
        private System.Windows.Forms.Button img;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button submitClient;
        private System.Windows.Forms.TextBox nameTB;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox supllyerpriceTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox descriptionTB;
        private System.Windows.Forms.ComboBox supplyIDCB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox aviable;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox priceTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox countTB;
    }
}