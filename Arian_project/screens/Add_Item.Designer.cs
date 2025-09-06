namespace Arian_project.screens
{
    partial class Add_Item
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.DataGridView items_list;
        private System.Windows.Forms.TableLayoutPanel rightPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelFields;
        private System.Windows.Forms.Label label_store_id;
        private System.Windows.Forms.TextBox store_id_tb;
        private System.Windows.Forms.Label label_item_name;
        private System.Windows.Forms.TextBox item_name_tb;
        private System.Windows.Forms.Label label_buy_price;
        private System.Windows.Forms.TextBox buy_price_tb;
        private System.Windows.Forms.Label label_cell_price;
        private System.Windows.Forms.TextBox cell_price_tb;
        private System.Windows.Forms.Label label_count;
        private System.Windows.Forms.TextBox count_tb;
        private System.Windows.Forms.Label label_buy_date;
        private System.Windows.Forms.TextBox buy_date_tb;
        private System.Windows.Forms.Label label_cell_date;
        private System.Windows.Forms.TextBox cell_date_tb;
        private System.Windows.Forms.CheckBox service_item_cb;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelButtons;
        private System.Windows.Forms.Button save_item_bt;
        private System.Windows.Forms.Button edit_item_bt;
        private System.Windows.Forms.Button delete_item_bt;
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
            this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.titleLabel = new System.Windows.Forms.Label();
            this.items_list = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.rightPanel = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelFields = new System.Windows.Forms.TableLayoutPanel();
            this.store_id_tb = new System.Windows.Forms.TextBox();
            this.label_store_id = new System.Windows.Forms.Label();
            this.item_name_tb = new System.Windows.Forms.TextBox();
            this.label_item_name = new System.Windows.Forms.Label();
            this.buy_price_tb = new System.Windows.Forms.TextBox();
            this.label_buy_price = new System.Windows.Forms.Label();
            this.cell_price_tb = new System.Windows.Forms.TextBox();
            this.label_cell_price = new System.Windows.Forms.Label();
            this.count_tb = new System.Windows.Forms.TextBox();
            this.label_count = new System.Windows.Forms.Label();
            this.buy_date_tb = new System.Windows.Forms.TextBox();
            this.label_buy_date = new System.Windows.Forms.Label();
            this.cell_date_tb = new System.Windows.Forms.TextBox();
            this.label_cell_date = new System.Windows.Forms.Label();
            this.service_item_cb = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanelButtons = new System.Windows.Forms.TableLayoutPanel();
            this.edit_item_bt = new System.Windows.Forms.Button();
            this.save_item_bt = new System.Windows.Forms.Button();
            this.delete_item_bt = new System.Windows.Forms.Button();
            this.Reset_bt = new System.Windows.Forms.Button();
            this.tableLayoutPanelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.items_list)).BeginInit();
            this.rightPanel.SuspendLayout();
            this.tableLayoutPanelFields.SuspendLayout();
            this.tableLayoutPanelButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelMain
            // 
            this.tableLayoutPanelMain.ColumnCount = 2;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanelMain.Controls.Add(this.titleLabel, 0, 0);
            this.tableLayoutPanelMain.Controls.Add(this.items_list, 0, 1);
            this.tableLayoutPanelMain.Controls.Add(this.rightPanel, 1, 1);
            this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMain.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            this.tableLayoutPanelMain.RowCount = 2;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(900, 600);
            this.tableLayoutPanelMain.TabIndex = 0;
            // 
            // titleLabel
            // 
            this.tableLayoutPanelMain.SetColumnSpan(this.titleLabel, 2);
            this.titleLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.titleLabel.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold);
            this.titleLabel.Location = new System.Drawing.Point(3, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(894, 50);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "مدیریت ایتم ها";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // items_list
            // 
            this.items_list.AllowUserToAddRows = false;
            this.items_list.AllowUserToDeleteRows = false;
            this.items_list.AllowUserToResizeRows = false;
            this.items_list.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.items_list.ColumnHeadersHeight = 29;
            this.items_list.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewCheckBoxColumn1});
            this.items_list.Dock = System.Windows.Forms.DockStyle.Fill;
            this.items_list.Location = new System.Drawing.Point(3, 53);
            this.items_list.MultiSelect = false;
            this.items_list.Name = "items_list";
            this.items_list.ReadOnly = true;
            this.items_list.RowHeadersVisible = false;
            this.items_list.RowHeadersWidth = 51;
            this.items_list.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.items_list.Size = new System.Drawing.Size(489, 544);
            this.items_list.TabIndex = 1;
            this.items_list.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.items_list_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.MinimumWidth = 6;
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            // 
            // rightPanel
            // 
            this.rightPanel.ColumnCount = 1;
            this.rightPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.rightPanel.Controls.Add(this.tableLayoutPanelFields, 0, 0);
            this.rightPanel.Controls.Add(this.tableLayoutPanelButtons, 0, 1);
            this.rightPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rightPanel.Location = new System.Drawing.Point(498, 53);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.RowCount = 2;
            this.rightPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.rightPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.rightPanel.Size = new System.Drawing.Size(399, 544);
            this.rightPanel.TabIndex = 2;
            // 
            // tableLayoutPanelFields
            // 
            this.tableLayoutPanelFields.ColumnCount = 2;
            this.tableLayoutPanelFields.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanelFields.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanelFields.Controls.Add(this.store_id_tb, 0, 0);
            this.tableLayoutPanelFields.Controls.Add(this.label_store_id, 1, 0);
            this.tableLayoutPanelFields.Controls.Add(this.item_name_tb, 0, 1);
            this.tableLayoutPanelFields.Controls.Add(this.label_item_name, 1, 1);
            this.tableLayoutPanelFields.Controls.Add(this.buy_price_tb, 0, 2);
            this.tableLayoutPanelFields.Controls.Add(this.label_buy_price, 1, 2);
            this.tableLayoutPanelFields.Controls.Add(this.cell_price_tb, 0, 3);
            this.tableLayoutPanelFields.Controls.Add(this.label_cell_price, 1, 3);
            this.tableLayoutPanelFields.Controls.Add(this.count_tb, 0, 4);
            this.tableLayoutPanelFields.Controls.Add(this.label_count, 1, 4);
            this.tableLayoutPanelFields.Controls.Add(this.buy_date_tb, 0, 5);
            this.tableLayoutPanelFields.Controls.Add(this.label_buy_date, 1, 5);
            this.tableLayoutPanelFields.Controls.Add(this.cell_date_tb, 0, 6);
            this.tableLayoutPanelFields.Controls.Add(this.label_cell_date, 1, 6);
            this.tableLayoutPanelFields.Controls.Add(this.service_item_cb, 0, 7);
            this.tableLayoutPanelFields.Controls.Add(this.label1, 1, 7);
            this.tableLayoutPanelFields.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelFields.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelFields.Name = "tableLayoutPanelFields";
            this.tableLayoutPanelFields.RowCount = 8;
            this.tableLayoutPanelFields.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanelFields.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanelFields.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanelFields.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanelFields.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanelFields.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanelFields.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanelFields.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanelFields.Size = new System.Drawing.Size(393, 429);
            this.tableLayoutPanelFields.TabIndex = 0;
            // 
            // store_id_tb
            // 
            this.store_id_tb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.store_id_tb.Location = new System.Drawing.Point(3, 3);
            this.store_id_tb.Name = "store_id_tb";
            this.store_id_tb.Size = new System.Drawing.Size(269, 20);
            this.store_id_tb.TabIndex = 0;
            // 
            // label_store_id
            // 
            this.label_store_id.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_store_id.Location = new System.Drawing.Point(278, 0);
            this.label_store_id.Name = "label_store_id";
            this.label_store_id.Size = new System.Drawing.Size(112, 53);
            this.label_store_id.TabIndex = 1;
            this.label_store_id.Text = "شماره انبار";
            this.label_store_id.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // item_name_tb
            // 
            this.item_name_tb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.item_name_tb.Location = new System.Drawing.Point(3, 56);
            this.item_name_tb.Name = "item_name_tb";
            this.item_name_tb.Size = new System.Drawing.Size(269, 20);
            this.item_name_tb.TabIndex = 2;
            // 
            // label_item_name
            // 
            this.label_item_name.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_item_name.Location = new System.Drawing.Point(278, 53);
            this.label_item_name.Name = "label_item_name";
            this.label_item_name.Size = new System.Drawing.Size(112, 53);
            this.label_item_name.TabIndex = 3;
            this.label_item_name.Text = "نام آیتم";
            this.label_item_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buy_price_tb
            // 
            this.buy_price_tb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buy_price_tb.Location = new System.Drawing.Point(3, 109);
            this.buy_price_tb.Name = "buy_price_tb";
            this.buy_price_tb.Size = new System.Drawing.Size(269, 20);
            this.buy_price_tb.TabIndex = 4;
            // 
            // label_buy_price
            // 
            this.label_buy_price.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_buy_price.Location = new System.Drawing.Point(278, 106);
            this.label_buy_price.Name = "label_buy_price";
            this.label_buy_price.Size = new System.Drawing.Size(112, 53);
            this.label_buy_price.TabIndex = 5;
            this.label_buy_price.Text = "قیمت خرید";
            this.label_buy_price.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cell_price_tb
            // 
            this.cell_price_tb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cell_price_tb.Location = new System.Drawing.Point(3, 162);
            this.cell_price_tb.Name = "cell_price_tb";
            this.cell_price_tb.Size = new System.Drawing.Size(269, 20);
            this.cell_price_tb.TabIndex = 6;
            // 
            // label_cell_price
            // 
            this.label_cell_price.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_cell_price.Location = new System.Drawing.Point(278, 159);
            this.label_cell_price.Name = "label_cell_price";
            this.label_cell_price.Size = new System.Drawing.Size(112, 53);
            this.label_cell_price.TabIndex = 7;
            this.label_cell_price.Text = "قیمت فروش";
            this.label_cell_price.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // count_tb
            // 
            this.count_tb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.count_tb.Location = new System.Drawing.Point(3, 215);
            this.count_tb.Name = "count_tb";
            this.count_tb.Size = new System.Drawing.Size(269, 20);
            this.count_tb.TabIndex = 8;
            // 
            // label_count
            // 
            this.label_count.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_count.Location = new System.Drawing.Point(278, 212);
            this.label_count.Name = "label_count";
            this.label_count.Size = new System.Drawing.Size(112, 53);
            this.label_count.TabIndex = 9;
            this.label_count.Text = "تعداد";
            this.label_count.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buy_date_tb
            // 
            this.buy_date_tb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buy_date_tb.Location = new System.Drawing.Point(3, 268);
            this.buy_date_tb.Name = "buy_date_tb";
            this.buy_date_tb.Size = new System.Drawing.Size(269, 20);
            this.buy_date_tb.TabIndex = 10;
            // 
            // label_buy_date
            // 
            this.label_buy_date.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_buy_date.Location = new System.Drawing.Point(278, 265);
            this.label_buy_date.Name = "label_buy_date";
            this.label_buy_date.Size = new System.Drawing.Size(112, 53);
            this.label_buy_date.TabIndex = 11;
            this.label_buy_date.Text = "تاریخ خرید";
            this.label_buy_date.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cell_date_tb
            // 
            this.cell_date_tb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cell_date_tb.Location = new System.Drawing.Point(3, 321);
            this.cell_date_tb.Name = "cell_date_tb";
            this.cell_date_tb.Size = new System.Drawing.Size(269, 20);
            this.cell_date_tb.TabIndex = 12;
            // 
            // label_cell_date
            // 
            this.label_cell_date.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_cell_date.Location = new System.Drawing.Point(278, 318);
            this.label_cell_date.Name = "label_cell_date";
            this.label_cell_date.Size = new System.Drawing.Size(112, 53);
            this.label_cell_date.TabIndex = 13;
            this.label_cell_date.Text = "تاریخ فروش";
            this.label_cell_date.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // service_item_cb
            // 
            this.service_item_cb.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.service_item_cb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.service_item_cb.Location = new System.Drawing.Point(3, 374);
            this.service_item_cb.Name = "service_item_cb";
            this.service_item_cb.Size = new System.Drawing.Size(269, 52);
            this.service_item_cb.TabIndex = 14;
            this.service_item_cb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label1.Location = new System.Drawing.Point(278, 371);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 58);
            this.label1.TabIndex = 15;
            this.label1.Text = "ایتم خدماتی";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanelButtons
            // 
            this.tableLayoutPanelButtons.ColumnCount = 3;
            this.tableLayoutPanelButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelButtons.Controls.Add(this.edit_item_bt, 1, 1);
            this.tableLayoutPanelButtons.Controls.Add(this.save_item_bt, 0, 1);
            this.tableLayoutPanelButtons.Controls.Add(this.delete_item_bt, 2, 1);
            this.tableLayoutPanelButtons.Controls.Add(this.Reset_bt, 0, 2);
            this.tableLayoutPanelButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelButtons.Location = new System.Drawing.Point(3, 438);
            this.tableLayoutPanelButtons.Name = "tableLayoutPanelButtons";
            this.tableLayoutPanelButtons.RowCount = 3;
            this.tableLayoutPanelButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelButtons.Size = new System.Drawing.Size(393, 103);
            this.tableLayoutPanelButtons.TabIndex = 1;
            // 
            // edit_item_bt
            // 
            this.edit_item_bt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.edit_item_bt.Location = new System.Drawing.Point(134, 37);
            this.edit_item_bt.Name = "edit_item_bt";
            this.edit_item_bt.Size = new System.Drawing.Size(125, 28);
            this.edit_item_bt.TabIndex = 1;
            this.edit_item_bt.Text = "ویرایش";
            this.edit_item_bt.Click += new System.EventHandler(this.edit_item_bt_Click);
            // 
            // save_item_bt
            // 
            this.save_item_bt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.save_item_bt.Location = new System.Drawing.Point(3, 37);
            this.save_item_bt.Name = "save_item_bt";
            this.save_item_bt.Size = new System.Drawing.Size(125, 28);
            this.save_item_bt.TabIndex = 0;
            this.save_item_bt.Text = "ذخیره";
            this.save_item_bt.Click += new System.EventHandler(this.save_item_bt_Click);
            // 
            // delete_item_bt
            // 
            this.delete_item_bt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.delete_item_bt.Location = new System.Drawing.Point(265, 37);
            this.delete_item_bt.Name = "delete_item_bt";
            this.delete_item_bt.Size = new System.Drawing.Size(125, 28);
            this.delete_item_bt.TabIndex = 2;
            this.delete_item_bt.Text = "حذف";
            this.delete_item_bt.Click += new System.EventHandler(this.delete_item_bt_Click);
            // 
            // Reset_bt
            // 
            this.Reset_bt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Reset_bt.Location = new System.Drawing.Point(3, 71);
            this.Reset_bt.Name = "Reset_bt";
            this.Reset_bt.Size = new System.Drawing.Size(125, 29);
            this.Reset_bt.TabIndex = 3;
            this.Reset_bt.Text = "ریست";
            this.Reset_bt.UseVisualStyleBackColor = true;
            this.Reset_bt.Click += new System.EventHandler(this.Reset_bt_Click);
            // 
            // Add_Item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.tableLayoutPanelMain);
            this.Name = "Add_Item";
            this.Text = "مدیریت ایتم ها";
            this.tableLayoutPanelMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.items_list)).EndInit();
            this.rightPanel.ResumeLayout(false);
            this.tableLayoutPanelFields.ResumeLayout(false);
            this.tableLayoutPanelFields.PerformLayout();
            this.tableLayoutPanelButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Reset_bt;
    }
}
