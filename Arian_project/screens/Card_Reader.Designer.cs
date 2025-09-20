namespace Arian_project.screens
{
    partial class Card_Readers
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.name_tb = new System.Windows.Forms.TextBox();
            this.bank_id_cb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.save_bt = new System.Windows.Forms.Button();
            this.edite_bt = new System.Windows.Forms.Button();
            this.delete_bt = new System.Windows.Forms.Button();
            this.reset_bt = new System.Windows.Forms.Button();
            this.card_reader_list = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.card_reader_list)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.61793F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.38208F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.card_reader_list, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1051, 770);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel2.Controls.Add(this.name_tb, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.bank_id_cb, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label1, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label2, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.save_bt, 0, 8);
            this.tableLayoutPanel2.Controls.Add(this.edite_bt, 1, 8);
            this.tableLayoutPanel2.Controls.Add(this.delete_bt, 0, 9);
            this.tableLayoutPanel2.Controls.Add(this.reset_bt, 1, 9);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(735, 4);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 10;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(312, 762);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // name_tb
            // 
            this.name_tb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.name_tb.Location = new System.Drawing.Point(4, 80);
            this.name_tb.Margin = new System.Windows.Forms.Padding(4);
            this.name_tb.Name = "name_tb";
            this.name_tb.Size = new System.Drawing.Size(148, 22);
            this.name_tb.TabIndex = 0;
            this.name_tb.TextChanged += new System.EventHandler(this.name_tb_TextChanged);
            // 
            // bank_id_cb
            // 
            this.bank_id_cb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bank_id_cb.FormattingEnabled = true;
            this.bank_id_cb.Location = new System.Drawing.Point(4, 156);
            this.bank_id_cb.Margin = new System.Windows.Forms.Padding(4);
            this.bank_id_cb.Name = "bank_id_cb";
            this.bank_id_cb.Size = new System.Drawing.Size(148, 24);
            this.bank_id_cb.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(160, 76);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 76);
            this.label1.TabIndex = 2;
            this.label1.Text = "نام";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(160, 152);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 76);
            this.label2.TabIndex = 3;
            this.label2.Text = "بانک متصل";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // save_bt
            // 
            this.save_bt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.save_bt.Location = new System.Drawing.Point(4, 612);
            this.save_bt.Margin = new System.Windows.Forms.Padding(4);
            this.save_bt.Name = "save_bt";
            this.save_bt.Size = new System.Drawing.Size(148, 68);
            this.save_bt.TabIndex = 4;
            this.save_bt.Text = "ذخیره";
            this.save_bt.UseVisualStyleBackColor = true;
            this.save_bt.Click += new System.EventHandler(this.save_bt_Click);
            // 
            // edite_bt
            // 
            this.edite_bt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.edite_bt.Location = new System.Drawing.Point(160, 612);
            this.edite_bt.Margin = new System.Windows.Forms.Padding(4);
            this.edite_bt.Name = "edite_bt";
            this.edite_bt.Size = new System.Drawing.Size(148, 68);
            this.edite_bt.TabIndex = 5;
            this.edite_bt.Text = "ویرایش";
            this.edite_bt.UseVisualStyleBackColor = true;
            this.edite_bt.Click += new System.EventHandler(this.edite_bt_Click);
            // 
            // delete_bt
            // 
            this.delete_bt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.delete_bt.Location = new System.Drawing.Point(4, 688);
            this.delete_bt.Margin = new System.Windows.Forms.Padding(4);
            this.delete_bt.Name = "delete_bt";
            this.delete_bt.Size = new System.Drawing.Size(148, 70);
            this.delete_bt.TabIndex = 6;
            this.delete_bt.Text = "حذف";
            this.delete_bt.UseVisualStyleBackColor = true;
            this.delete_bt.Click += new System.EventHandler(this.delete_bt_Click);
            // 
            // reset_bt
            // 
            this.reset_bt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reset_bt.Location = new System.Drawing.Point(160, 688);
            this.reset_bt.Margin = new System.Windows.Forms.Padding(4);
            this.reset_bt.Name = "reset_bt";
            this.reset_bt.Size = new System.Drawing.Size(148, 70);
            this.reset_bt.TabIndex = 7;
            this.reset_bt.Text = "ریست";
            this.reset_bt.UseVisualStyleBackColor = true;
            this.reset_bt.Click += new System.EventHandler(this.reset_bt_Click);
            // 
            // card_reader_list
            // 
            this.card_reader_list.AccessibleRole = System.Windows.Forms.AccessibleRole.Equation;
            this.card_reader_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.card_reader_list.Dock = System.Windows.Forms.DockStyle.Fill;
            this.card_reader_list.Location = new System.Drawing.Point(4, 4);
            this.card_reader_list.Margin = new System.Windows.Forms.Padding(4);
            this.card_reader_list.Name = "card_reader_list";
            this.card_reader_list.RowHeadersWidth = 51;
            this.card_reader_list.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.card_reader_list.ShowCellErrors = false;
            this.card_reader_list.ShowCellToolTips = false;
            this.card_reader_list.ShowEditingIcon = false;
            this.card_reader_list.ShowRowErrors = false;
            this.card_reader_list.Size = new System.Drawing.Size(723, 762);
            this.card_reader_list.TabIndex = 1;
            this.card_reader_list.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.card_reader_list_CellClick);
            // 
            // Card_Readers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 770);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Card_Readers";
            this.Text = "Card_Reader";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.card_reader_list)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox name_tb;
        private System.Windows.Forms.ComboBox bank_id_cb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button save_bt;
        private System.Windows.Forms.Button edite_bt;
        private System.Windows.Forms.Button delete_bt;
        private System.Windows.Forms.Button reset_bt;
        private System.Windows.Forms.DataGridView card_reader_list;
    }
}