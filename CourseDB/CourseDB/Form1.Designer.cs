
namespace CourseDB
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.productLB = new System.Windows.Forms.ListBox();
            this.providerLB = new System.Windows.Forms.ListBox();
            this.supplyLB = new System.Windows.Forms.ListBox();
            this.employeesLB = new System.Windows.Forms.ListBox();
            this.orderLB = new System.Windows.Forms.ListBox();
            this.clientLB = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.productTextBox = new System.Windows.Forms.TextBox();
            this.providerTextBox = new System.Windows.Forms.TextBox();
            this.supplyTextBox = new System.Windows.Forms.TextBox();
            this.employeesTextBox = new System.Windows.Forms.TextBox();
            this.orderTextBox = new System.Windows.Forms.TextBox();
            this.clientTextBox = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.добавитиКлієнтаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.видалитиКлієнтаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редагуватиКлієнтаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.додатиПостачальникаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.видалитиПостачальникаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редагуватиПостачальникаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip3 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.додатиСпівробітникаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.видалитиСпівробітникаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редагуватиСпівробітникаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip4 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.додатиПоставкуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.видалитиПоставкуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip5 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.додатиЗамовленняToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.видалитиЗамовленняToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip6 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.додатиТоварToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.видалитиТоварToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редагуватиТоварToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.contextMenuStrip3.SuspendLayout();
            this.contextMenuStrip4.SuspendLayout();
            this.contextMenuStrip5.SuspendLayout();
            this.contextMenuStrip6.SuspendLayout();
            this.SuspendLayout();
            // 
            // productLB
            // 
            this.productLB.ContextMenuStrip = this.contextMenuStrip6;
            this.productLB.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productLB.FormattingEnabled = true;
            this.productLB.HorizontalScrollbar = true;
            this.productLB.ItemHeight = 19;
            this.productLB.Location = new System.Drawing.Point(31, 93);
            this.productLB.Name = "productLB";
            this.productLB.Size = new System.Drawing.Size(283, 175);
            this.productLB.TabIndex = 0;
            this.productLB.DoubleClick += new System.EventHandler(this.productLB_DoubleClick);
            // 
            // providerLB
            // 
            this.providerLB.ContextMenuStrip = this.contextMenuStrip2;
            this.providerLB.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.providerLB.FormattingEnabled = true;
            this.providerLB.HorizontalScrollbar = true;
            this.providerLB.ItemHeight = 19;
            this.providerLB.Location = new System.Drawing.Point(403, 93);
            this.providerLB.Name = "providerLB";
            this.providerLB.Size = new System.Drawing.Size(283, 175);
            this.providerLB.TabIndex = 1;
            // 
            // supplyLB
            // 
            this.supplyLB.ContextMenuStrip = this.contextMenuStrip4;
            this.supplyLB.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.supplyLB.FormattingEnabled = true;
            this.supplyLB.HorizontalScrollbar = true;
            this.supplyLB.ItemHeight = 19;
            this.supplyLB.Location = new System.Drawing.Point(775, 93);
            this.supplyLB.Name = "supplyLB";
            this.supplyLB.Size = new System.Drawing.Size(283, 175);
            this.supplyLB.TabIndex = 2;
            // 
            // employeesLB
            // 
            this.employeesLB.ContextMenuStrip = this.contextMenuStrip3;
            this.employeesLB.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.employeesLB.FormattingEnabled = true;
            this.employeesLB.HorizontalScrollbar = true;
            this.employeesLB.ItemHeight = 19;
            this.employeesLB.Location = new System.Drawing.Point(775, 402);
            this.employeesLB.Name = "employeesLB";
            this.employeesLB.Size = new System.Drawing.Size(283, 175);
            this.employeesLB.TabIndex = 5;
            // 
            // orderLB
            // 
            this.orderLB.ContextMenuStrip = this.contextMenuStrip5;
            this.orderLB.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.orderLB.FormattingEnabled = true;
            this.orderLB.HorizontalScrollbar = true;
            this.orderLB.ItemHeight = 19;
            this.orderLB.Location = new System.Drawing.Point(403, 402);
            this.orderLB.Name = "orderLB";
            this.orderLB.Size = new System.Drawing.Size(283, 175);
            this.orderLB.TabIndex = 4;
            // 
            // clientLB
            // 
            this.clientLB.ContextMenuStrip = this.contextMenuStrip1;
            this.clientLB.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clientLB.FormattingEnabled = true;
            this.clientLB.HorizontalScrollbar = true;
            this.clientLB.ItemHeight = 19;
            this.clientLB.Location = new System.Drawing.Point(31, 402);
            this.clientLB.Name = "clientLB";
            this.clientLB.Size = new System.Drawing.Size(283, 175);
            this.clientLB.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(135, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Товар";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(466, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Постачальник";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(861, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Поставка";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(130, 339);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Клієнт";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(476, 339);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Замовлення";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(838, 339);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(166, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "Співробітники";
            // 
            // productTextBox
            // 
            this.productTextBox.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productTextBox.Location = new System.Drawing.Point(31, 58);
            this.productTextBox.Name = "productTextBox";
            this.productTextBox.Size = new System.Drawing.Size(283, 29);
            this.productTextBox.TabIndex = 12;
            this.productTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.productTextBox_KeyUp);
            // 
            // providerTextBox
            // 
            this.providerTextBox.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.providerTextBox.Location = new System.Drawing.Point(403, 58);
            this.providerTextBox.Name = "providerTextBox";
            this.providerTextBox.Size = new System.Drawing.Size(283, 29);
            this.providerTextBox.TabIndex = 13;
            this.providerTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.providerTextBox_KeyUp);
            // 
            // supplyTextBox
            // 
            this.supplyTextBox.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.supplyTextBox.Location = new System.Drawing.Point(775, 58);
            this.supplyTextBox.Name = "supplyTextBox";
            this.supplyTextBox.Size = new System.Drawing.Size(283, 29);
            this.supplyTextBox.TabIndex = 14;
            this.supplyTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.supplyTextBox_KeyUp);
            // 
            // employeesTextBox
            // 
            this.employeesTextBox.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.employeesTextBox.Location = new System.Drawing.Point(775, 367);
            this.employeesTextBox.Name = "employeesTextBox";
            this.employeesTextBox.Size = new System.Drawing.Size(283, 29);
            this.employeesTextBox.TabIndex = 17;
            this.employeesTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.employeesTextBox_KeyUp);
            // 
            // orderTextBox
            // 
            this.orderTextBox.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.orderTextBox.Location = new System.Drawing.Point(403, 367);
            this.orderTextBox.Name = "orderTextBox";
            this.orderTextBox.Size = new System.Drawing.Size(283, 29);
            this.orderTextBox.TabIndex = 16;
            this.orderTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.orderTextBox_KeyUp);
            // 
            // clientTextBox
            // 
            this.clientTextBox.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clientTextBox.Location = new System.Drawing.Point(31, 367);
            this.clientTextBox.Name = "clientTextBox";
            this.clientTextBox.Size = new System.Drawing.Size(283, 29);
            this.clientTextBox.TabIndex = 15;
            this.clientTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.clientTextBox_KeyUp);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитиКлієнтаToolStripMenuItem,
            this.видалитиКлієнтаToolStripMenuItem,
            this.редагуватиКлієнтаToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(178, 70);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // добавитиКлієнтаToolStripMenuItem
            // 
            this.добавитиКлієнтаToolStripMenuItem.Name = "добавитиКлієнтаToolStripMenuItem";
            this.добавитиКлієнтаToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.добавитиКлієнтаToolStripMenuItem.Text = "Добавити клієнта";
            this.добавитиКлієнтаToolStripMenuItem.Click += new System.EventHandler(this.добавитиКлієнтаToolStripMenuItem_Click);
            // 
            // видалитиКлієнтаToolStripMenuItem
            // 
            this.видалитиКлієнтаToolStripMenuItem.Name = "видалитиКлієнтаToolStripMenuItem";
            this.видалитиКлієнтаToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.видалитиКлієнтаToolStripMenuItem.Text = "Видалити клієнта";
            this.видалитиКлієнтаToolStripMenuItem.Click += new System.EventHandler(this.видалитиКлієнтаToolStripMenuItem_Click);
            // 
            // редагуватиКлієнтаToolStripMenuItem
            // 
            this.редагуватиКлієнтаToolStripMenuItem.Name = "редагуватиКлієнтаToolStripMenuItem";
            this.редагуватиКлієнтаToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.редагуватиКлієнтаToolStripMenuItem.Text = "Редагувати клієнта";
            this.редагуватиКлієнтаToolStripMenuItem.Click += new System.EventHandler(this.редагуватиКлієнтаToolStripMenuItem_Click);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.додатиПостачальникаToolStripMenuItem,
            this.видалитиПостачальникаToolStripMenuItem,
            this.редагуватиПостачальникаToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(221, 70);
            // 
            // додатиПостачальникаToolStripMenuItem
            // 
            this.додатиПостачальникаToolStripMenuItem.Name = "додатиПостачальникаToolStripMenuItem";
            this.додатиПостачальникаToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.додатиПостачальникаToolStripMenuItem.Text = "Додати постачальника";
            this.додатиПостачальникаToolStripMenuItem.Click += new System.EventHandler(this.додатиПостачальникаToolStripMenuItem_Click);
            // 
            // видалитиПостачальникаToolStripMenuItem
            // 
            this.видалитиПостачальникаToolStripMenuItem.Name = "видалитиПостачальникаToolStripMenuItem";
            this.видалитиПостачальникаToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.видалитиПостачальникаToolStripMenuItem.Text = "Видалити постачальника";
            this.видалитиПостачальникаToolStripMenuItem.Click += new System.EventHandler(this.видалитиПостачальникаToolStripMenuItem_Click);
            // 
            // редагуватиПостачальникаToolStripMenuItem
            // 
            this.редагуватиПостачальникаToolStripMenuItem.Name = "редагуватиПостачальникаToolStripMenuItem";
            this.редагуватиПостачальникаToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.редагуватиПостачальникаToolStripMenuItem.Text = "Редагувати постачальника";
            this.редагуватиПостачальникаToolStripMenuItem.Click += new System.EventHandler(this.редагуватиПостачальникаToolStripMenuItem_Click);
            // 
            // contextMenuStrip3
            // 
            this.contextMenuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.додатиСпівробітникаToolStripMenuItem,
            this.видалитиСпівробітникаToolStripMenuItem,
            this.редагуватиСпівробітникаToolStripMenuItem});
            this.contextMenuStrip3.Name = "contextMenuStrip3";
            this.contextMenuStrip3.Size = new System.Drawing.Size(215, 70);
            // 
            // додатиСпівробітникаToolStripMenuItem
            // 
            this.додатиСпівробітникаToolStripMenuItem.Name = "додатиСпівробітникаToolStripMenuItem";
            this.додатиСпівробітникаToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.додатиСпівробітникаToolStripMenuItem.Text = "Додати співробітника";
            this.додатиСпівробітникаToolStripMenuItem.Click += new System.EventHandler(this.додатиСпівробітникаToolStripMenuItem_Click);
            // 
            // видалитиСпівробітникаToolStripMenuItem
            // 
            this.видалитиСпівробітникаToolStripMenuItem.Name = "видалитиСпівробітникаToolStripMenuItem";
            this.видалитиСпівробітникаToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.видалитиСпівробітникаToolStripMenuItem.Text = "Видалити співробітника";
            this.видалитиСпівробітникаToolStripMenuItem.Click += new System.EventHandler(this.видалитиСпівробітникаToolStripMenuItem_Click);
            // 
            // редагуватиСпівробітникаToolStripMenuItem
            // 
            this.редагуватиСпівробітникаToolStripMenuItem.Name = "редагуватиСпівробітникаToolStripMenuItem";
            this.редагуватиСпівробітникаToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.редагуватиСпівробітникаToolStripMenuItem.Text = "Редагувати співробітника";
            this.редагуватиСпівробітникаToolStripMenuItem.Click += new System.EventHandler(this.редагуватиСпівробітникаToolStripMenuItem_Click);
            // 
            // contextMenuStrip4
            // 
            this.contextMenuStrip4.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.додатиПоставкуToolStripMenuItem,
            this.видалитиПоставкуToolStripMenuItem});
            this.contextMenuStrip4.Name = "contextMenuStrip4";
            this.contextMenuStrip4.Size = new System.Drawing.Size(179, 48);
            // 
            // додатиПоставкуToolStripMenuItem
            // 
            this.додатиПоставкуToolStripMenuItem.Name = "додатиПоставкуToolStripMenuItem";
            this.додатиПоставкуToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.додатиПоставкуToolStripMenuItem.Text = "Додати поставку";
            this.додатиПоставкуToolStripMenuItem.Click += new System.EventHandler(this.додатиПоставкуToolStripMenuItem_Click);
            // 
            // видалитиПоставкуToolStripMenuItem
            // 
            this.видалитиПоставкуToolStripMenuItem.Name = "видалитиПоставкуToolStripMenuItem";
            this.видалитиПоставкуToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.видалитиПоставкуToolStripMenuItem.Text = "Видалити поставку";
            this.видалитиПоставкуToolStripMenuItem.Click += new System.EventHandler(this.видалитиПоставкуToolStripMenuItem_Click);
            // 
            // contextMenuStrip5
            // 
            this.contextMenuStrip5.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.додатиЗамовленняToolStripMenuItem,
            this.видалитиЗамовленняToolStripMenuItem});
            this.contextMenuStrip5.Name = "contextMenuStrip5";
            this.contextMenuStrip5.Size = new System.Drawing.Size(196, 48);
            // 
            // додатиЗамовленняToolStripMenuItem
            // 
            this.додатиЗамовленняToolStripMenuItem.Name = "додатиЗамовленняToolStripMenuItem";
            this.додатиЗамовленняToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.додатиЗамовленняToolStripMenuItem.Text = "Додати замовлення";
            this.додатиЗамовленняToolStripMenuItem.Click += new System.EventHandler(this.додатиЗамовленняToolStripMenuItem_Click);
            // 
            // видалитиЗамовленняToolStripMenuItem
            // 
            this.видалитиЗамовленняToolStripMenuItem.Name = "видалитиЗамовленняToolStripMenuItem";
            this.видалитиЗамовленняToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.видалитиЗамовленняToolStripMenuItem.Text = "Видалити замовлення";
            this.видалитиЗамовленняToolStripMenuItem.Click += new System.EventHandler(this.видалитиЗамовленняToolStripMenuItem_Click);
            // 
            // contextMenuStrip6
            // 
            this.contextMenuStrip6.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.додатиТоварToolStripMenuItem,
            this.видалитиТоварToolStripMenuItem,
            this.редагуватиТоварToolStripMenuItem});
            this.contextMenuStrip6.Name = "contextMenuStrip6";
            this.contextMenuStrip6.Size = new System.Drawing.Size(169, 70);
            // 
            // додатиТоварToolStripMenuItem
            // 
            this.додатиТоварToolStripMenuItem.Name = "додатиТоварToolStripMenuItem";
            this.додатиТоварToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.додатиТоварToolStripMenuItem.Text = "Додати товар";
            this.додатиТоварToolStripMenuItem.Click += new System.EventHandler(this.додатиТоварToolStripMenuItem_Click);
            // 
            // видалитиТоварToolStripMenuItem
            // 
            this.видалитиТоварToolStripMenuItem.Name = "видалитиТоварToolStripMenuItem";
            this.видалитиТоварToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.видалитиТоварToolStripMenuItem.Text = "Видалити товар";
            this.видалитиТоварToolStripMenuItem.Click += new System.EventHandler(this.видалитиТоварToolStripMenuItem_Click);
            // 
            // редагуватиТоварToolStripMenuItem
            // 
            this.редагуватиТоварToolStripMenuItem.Name = "редагуватиТоварToolStripMenuItem";
            this.редагуватиТоварToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.редагуватиТоварToolStripMenuItem.Text = "Редагувати товар";
            this.редагуватиТоварToolStripMenuItem.Click += new System.EventHandler(this.редагуватиТоварToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1087, 594);
            this.Controls.Add(this.employeesTextBox);
            this.Controls.Add(this.orderTextBox);
            this.Controls.Add(this.clientTextBox);
            this.Controls.Add(this.supplyTextBox);
            this.Controls.Add(this.providerTextBox);
            this.Controls.Add(this.productTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.employeesLB);
            this.Controls.Add(this.orderLB);
            this.Controls.Add(this.clientLB);
            this.Controls.Add(this.supplyLB);
            this.Controls.Add(this.providerLB);
            this.Controls.Add(this.productLB);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Магазин комп\'ютерних товарів";
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            this.contextMenuStrip3.ResumeLayout(false);
            this.contextMenuStrip4.ResumeLayout(false);
            this.contextMenuStrip5.ResumeLayout(false);
            this.contextMenuStrip6.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox productLB;
        private System.Windows.Forms.ListBox providerLB;
        private System.Windows.Forms.ListBox supplyLB;
        private System.Windows.Forms.ListBox employeesLB;
        private System.Windows.Forms.ListBox orderLB;
        private System.Windows.Forms.ListBox clientLB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox productTextBox;
        private System.Windows.Forms.TextBox providerTextBox;
        private System.Windows.Forms.TextBox supplyTextBox;
        private System.Windows.Forms.TextBox employeesTextBox;
        private System.Windows.Forms.TextBox orderTextBox;
        private System.Windows.Forms.TextBox clientTextBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem добавитиКлієнтаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem видалитиКлієнтаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редагуватиКлієнтаToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem додатиПостачальникаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem видалитиПостачальникаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редагуватиПостачальникаToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip3;
        private System.Windows.Forms.ToolStripMenuItem додатиСпівробітникаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem видалитиСпівробітникаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редагуватиСпівробітникаToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip4;
        private System.Windows.Forms.ToolStripMenuItem додатиПоставкуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem видалитиПоставкуToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip5;
        private System.Windows.Forms.ToolStripMenuItem додатиЗамовленняToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem видалитиЗамовленняToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip6;
        private System.Windows.Forms.ToolStripMenuItem додатиТоварToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem видалитиТоварToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редагуватиТоварToolStripMenuItem;
    }
}

