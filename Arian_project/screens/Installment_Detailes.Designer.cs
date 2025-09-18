namespace Arian_project.screens
{
    partial class Installment_Detailes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Installment_Detailes));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.payments_list = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label63 = new System.Windows.Forms.Label();
            this.one_installment_price_lb = new System.Windows.Forms.Label();
            this.label54 = new System.Windows.Forms.Label();
            this.first_installment_date_lb = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.full_installment_price_lb = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.status_lb = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.factor_id_lb = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.reminder_lb = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.client_name_lb = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.end_installment_lb = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.client_id_lb = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.installment_payed_count_lb = new System.Windows.Forms.Label();
            this.installment_id_lb = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.installment_count_lb = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.installment_list = new System.Windows.Forms.DataGridView();
            this.glassButton2 = new GlassButton();
            this.glassButton1 = new GlassButton();
            this.glassButton3 = new GlassButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.payments_list)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.installment_list)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.56824F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.43176F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.79569F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 63.99104F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.21327F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1352, 748);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.payments_list);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 233);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(380, 472);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "لیست پرداختی ها";
            // 
            // payments_list
            // 
            this.payments_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.payments_list.Dock = System.Windows.Forms.DockStyle.Fill;
            this.payments_list.Location = new System.Drawing.Point(3, 18);
            this.payments_list.Name = "payments_list";
            this.payments_list.RowHeadersWidth = 51;
            this.payments_list.RowTemplate.Height = 24;
            this.payments_list.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.payments_list.Size = new System.Drawing.Size(374, 451);
            this.payments_list.TabIndex = 0;
            this.payments_list.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.payments_list_CellContentClick);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 9;
            this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel2, 2);
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel2.Controls.Add(this.label63, 8, 6);
            this.tableLayoutPanel2.Controls.Add(this.one_installment_price_lb, 7, 6);
            this.tableLayoutPanel2.Controls.Add(this.label54, 8, 5);
            this.tableLayoutPanel2.Controls.Add(this.first_installment_date_lb, 7, 5);
            this.tableLayoutPanel2.Controls.Add(this.label45, 8, 4);
            this.tableLayoutPanel2.Controls.Add(this.full_installment_price_lb, 7, 4);
            this.tableLayoutPanel2.Controls.Add(this.label43, 6, 4);
            this.tableLayoutPanel2.Controls.Add(this.status_lb, 5, 4);
            this.tableLayoutPanel2.Controls.Add(this.label36, 8, 3);
            this.tableLayoutPanel2.Controls.Add(this.factor_id_lb, 7, 3);
            this.tableLayoutPanel2.Controls.Add(this.label34, 6, 3);
            this.tableLayoutPanel2.Controls.Add(this.reminder_lb, 5, 3);
            this.tableLayoutPanel2.Controls.Add(this.label27, 8, 2);
            this.tableLayoutPanel2.Controls.Add(this.client_name_lb, 7, 2);
            this.tableLayoutPanel2.Controls.Add(this.label25, 6, 2);
            this.tableLayoutPanel2.Controls.Add(this.end_installment_lb, 5, 2);
            this.tableLayoutPanel2.Controls.Add(this.label18, 8, 1);
            this.tableLayoutPanel2.Controls.Add(this.client_id_lb, 7, 1);
            this.tableLayoutPanel2.Controls.Add(this.label16, 6, 1);
            this.tableLayoutPanel2.Controls.Add(this.installment_payed_count_lb, 5, 1);
            this.tableLayoutPanel2.Controls.Add(this.installment_id_lb, 7, 0);
            this.tableLayoutPanel2.Controls.Add(this.label8, 6, 0);
            this.tableLayoutPanel2.Controls.Add(this.installment_count_lb, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.label1, 8, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 7;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142857F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142857F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142857F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142857F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142857F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142857F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142857F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1346, 224);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label63
            // 
            this.label63.AutoSize = true;
            this.label63.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label63.Location = new System.Drawing.Point(1195, 192);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(148, 32);
            this.label63.TabIndex = 62;
            this.label63.Text = ": مبلغ هرقسط";
            this.label63.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // one_installment_price_lb
            // 
            this.one_installment_price_lb.AutoSize = true;
            this.one_installment_price_lb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.one_installment_price_lb.Location = new System.Drawing.Point(1046, 192);
            this.one_installment_price_lb.Name = "one_installment_price_lb";
            this.one_installment_price_lb.Size = new System.Drawing.Size(143, 32);
            this.one_installment_price_lb.TabIndex = 61;
            this.one_installment_price_lb.Text = "0";
            this.one_installment_price_lb.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label54.Location = new System.Drawing.Point(1195, 160);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(148, 32);
            this.label54.TabIndex = 53;
            this.label54.Text = ": تاریخ اولین قسط";
            this.label54.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // first_installment_date_lb
            // 
            this.first_installment_date_lb.AutoSize = true;
            this.first_installment_date_lb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.first_installment_date_lb.Location = new System.Drawing.Point(1046, 160);
            this.first_installment_date_lb.Name = "first_installment_date_lb";
            this.first_installment_date_lb.Size = new System.Drawing.Size(143, 32);
            this.first_installment_date_lb.TabIndex = 52;
            this.first_installment_date_lb.Text = "0";
            this.first_installment_date_lb.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label45.Location = new System.Drawing.Point(1195, 128);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(148, 32);
            this.label45.TabIndex = 44;
            this.label45.Text = ": مبلغ کل اقساط";
            this.label45.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // full_installment_price_lb
            // 
            this.full_installment_price_lb.AutoSize = true;
            this.full_installment_price_lb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.full_installment_price_lb.Location = new System.Drawing.Point(1046, 128);
            this.full_installment_price_lb.Name = "full_installment_price_lb";
            this.full_installment_price_lb.Size = new System.Drawing.Size(143, 32);
            this.full_installment_price_lb.TabIndex = 43;
            this.full_installment_price_lb.Text = "0";
            this.full_installment_price_lb.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label43.Location = new System.Drawing.Point(897, 128);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(143, 32);
            this.label43.TabIndex = 42;
            this.label43.Text = ": وضعیت";
            this.label43.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // status_lb
            // 
            this.status_lb.AutoSize = true;
            this.status_lb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.status_lb.Location = new System.Drawing.Point(748, 128);
            this.status_lb.Name = "status_lb";
            this.status_lb.Size = new System.Drawing.Size(143, 32);
            this.status_lb.TabIndex = 41;
            this.status_lb.Text = "0";
            this.status_lb.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label36.Location = new System.Drawing.Point(1195, 96);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(148, 32);
            this.label36.TabIndex = 35;
            this.label36.Text = ": شماره فاکتور";
            this.label36.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // factor_id_lb
            // 
            this.factor_id_lb.AutoSize = true;
            this.factor_id_lb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.factor_id_lb.Location = new System.Drawing.Point(1046, 96);
            this.factor_id_lb.Name = "factor_id_lb";
            this.factor_id_lb.Size = new System.Drawing.Size(143, 32);
            this.factor_id_lb.TabIndex = 34;
            this.factor_id_lb.Text = "0";
            this.factor_id_lb.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label34.Location = new System.Drawing.Point(897, 96);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(143, 32);
            this.label34.TabIndex = 33;
            this.label34.Text = ": یاداوری";
            this.label34.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // reminder_lb
            // 
            this.reminder_lb.AutoSize = true;
            this.reminder_lb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reminder_lb.Location = new System.Drawing.Point(748, 96);
            this.reminder_lb.Name = "reminder_lb";
            this.reminder_lb.Size = new System.Drawing.Size(143, 32);
            this.reminder_lb.TabIndex = 32;
            this.reminder_lb.Text = "0";
            this.reminder_lb.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label27.Location = new System.Drawing.Point(1195, 64);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(148, 32);
            this.label27.TabIndex = 26;
            this.label27.Text = ": نام کاربر";
            this.label27.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // client_name_lb
            // 
            this.client_name_lb.AutoSize = true;
            this.client_name_lb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.client_name_lb.Location = new System.Drawing.Point(1046, 64);
            this.client_name_lb.Name = "client_name_lb";
            this.client_name_lb.Size = new System.Drawing.Size(143, 32);
            this.client_name_lb.TabIndex = 25;
            this.client_name_lb.Text = "0";
            this.client_name_lb.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label25.Location = new System.Drawing.Point(897, 64);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(143, 32);
            this.label25.TabIndex = 24;
            this.label25.Text = ": اتمام اقساط";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // end_installment_lb
            // 
            this.end_installment_lb.AutoSize = true;
            this.end_installment_lb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.end_installment_lb.Location = new System.Drawing.Point(748, 64);
            this.end_installment_lb.Name = "end_installment_lb";
            this.end_installment_lb.Size = new System.Drawing.Size(143, 32);
            this.end_installment_lb.TabIndex = 23;
            this.end_installment_lb.Text = "0";
            this.end_installment_lb.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label18.Location = new System.Drawing.Point(1195, 32);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(148, 32);
            this.label18.TabIndex = 17;
            this.label18.Text = ": شماره کاربر";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // client_id_lb
            // 
            this.client_id_lb.AutoSize = true;
            this.client_id_lb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.client_id_lb.Location = new System.Drawing.Point(1046, 32);
            this.client_id_lb.Name = "client_id_lb";
            this.client_id_lb.Size = new System.Drawing.Size(143, 32);
            this.client_id_lb.TabIndex = 16;
            this.client_id_lb.Text = "0";
            this.client_id_lb.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label16.Location = new System.Drawing.Point(897, 32);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(143, 32);
            this.label16.TabIndex = 15;
            this.label16.Text = ": تعداد پرداختی";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // installment_payed_count_lb
            // 
            this.installment_payed_count_lb.AutoSize = true;
            this.installment_payed_count_lb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.installment_payed_count_lb.Location = new System.Drawing.Point(748, 32);
            this.installment_payed_count_lb.Name = "installment_payed_count_lb";
            this.installment_payed_count_lb.Size = new System.Drawing.Size(143, 32);
            this.installment_payed_count_lb.TabIndex = 14;
            this.installment_payed_count_lb.Text = "0";
            this.installment_payed_count_lb.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // installment_id_lb
            // 
            this.installment_id_lb.AutoSize = true;
            this.installment_id_lb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.installment_id_lb.Location = new System.Drawing.Point(1046, 0);
            this.installment_id_lb.Name = "installment_id_lb";
            this.installment_id_lb.Size = new System.Drawing.Size(143, 32);
            this.installment_id_lb.TabIndex = 8;
            this.installment_id_lb.Text = "0";
            this.installment_id_lb.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Location = new System.Drawing.Point(897, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(143, 32);
            this.label8.TabIndex = 7;
            this.label8.Text = ": تعداد اقساط";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // installment_count_lb
            // 
            this.installment_count_lb.AutoSize = true;
            this.installment_count_lb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.installment_count_lb.Location = new System.Drawing.Point(748, 0);
            this.installment_count_lb.Name = "installment_count_lb";
            this.installment_count_lb.Size = new System.Drawing.Size(143, 32);
            this.installment_count_lb.TabIndex = 6;
            this.installment_count_lb.Text = "0";
            this.installment_count_lb.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(1195, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = ": شماره اقساط";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 13;
            this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel3, 2);
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.tableLayoutPanel3.Controls.Add(this.glassButton2, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.glassButton1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.glassButton3, 12, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 711);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1346, 34);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.installment_list);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(389, 233);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(960, 472);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "لیست اقساط";
            // 
            // installment_list
            // 
            this.installment_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.installment_list.Dock = System.Windows.Forms.DockStyle.Fill;
            this.installment_list.Location = new System.Drawing.Point(3, 18);
            this.installment_list.Name = "installment_list";
            this.installment_list.RowHeadersWidth = 51;
            this.installment_list.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.installment_list.Size = new System.Drawing.Size(954, 451);
            this.installment_list.TabIndex = 1;
            // 
            // glassButton2
            // 
            this.glassButton2.BackAlpha = 120;
            this.glassButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.glassButton2.CornerRadius = 20;
            this.glassButton2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.glassButton2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.glassButton2.ForeColor = System.Drawing.Color.Black;
            this.glassButton2.Location = new System.Drawing.Point(106, 3);
            this.glassButton2.Name = "glassButton2";
            this.glassButton2.Size = new System.Drawing.Size(97, 28);
            this.glassButton2.TabIndex = 1;
            this.glassButton2.Text = "پرداخت";
            this.glassButton2.Click += new System.EventHandler(this.glassButton2_Click);
            // 
            // glassButton1
            // 
            this.glassButton1.BackAlpha = 120;
            this.glassButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.glassButton1.CornerRadius = 20;
            this.glassButton1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.glassButton1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.glassButton1.ForeColor = System.Drawing.Color.Black;
            this.glassButton1.Location = new System.Drawing.Point(3, 3);
            this.glassButton1.Name = "glassButton1";
            this.glassButton1.Size = new System.Drawing.Size(97, 28);
            this.glassButton1.TabIndex = 0;
            this.glassButton1.Text = "ثبت";
            this.glassButton1.Click += new System.EventHandler(this.glassButton1_Click);
            // 
            // glassButton3
            // 
            this.glassButton3.BackAlpha = 120;
            this.glassButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.glassButton3.CornerRadius = 20;
            this.glassButton3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.glassButton3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.glassButton3.ForeColor = System.Drawing.Color.Black;
            this.glassButton3.Location = new System.Drawing.Point(1239, 3);
            this.glassButton3.Name = "glassButton3";
            this.glassButton3.Size = new System.Drawing.Size(104, 28);
            this.glassButton3.TabIndex = 2;
            this.glassButton3.Text = "چاپ";
            // 
            // Installment_Detailes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1352, 748);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Installment_Detailes";
            this.Text = "جزئیات اقاسط";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.payments_list)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.installment_list)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView payments_list;
        private System.Windows.Forms.DataGridView installment_list;
        private GlassButton glassButton2;
        private GlassButton glassButton1;
        private GlassButton glassButton3;
        private System.Windows.Forms.Label label63;
        private System.Windows.Forms.Label one_installment_price_lb;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.Label first_installment_date_lb;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Label full_installment_price_lb;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Label status_lb;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label factor_id_lb;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label reminder_lb;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label client_name_lb;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label end_installment_lb;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label client_id_lb;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label installment_payed_count_lb;
        private System.Windows.Forms.Label installment_id_lb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label installment_count_lb;
        private System.Windows.Forms.Label label1;
    }
}