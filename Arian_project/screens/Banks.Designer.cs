namespace Arian_project.screens
{
    partial class Banks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Banks));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.banks_list = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.balance_tb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.name_tb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bank_type_cb = new System.Windows.Forms.ComboBox();
            this.save_bt = new System.Windows.Forms.Button();
            this.edite_bt = new System.Windows.Forms.Button();
            this.delete_bt = new System.Windows.Forms.Button();
            this.reset_bt = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.banks_list)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.66667F));
            this.tableLayoutPanel1.Controls.Add(this.banks_list, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(891, 478);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // banks_list
            // 
            this.banks_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.banks_list.Dock = System.Windows.Forms.DockStyle.Fill;
            this.banks_list.Location = new System.Drawing.Point(4, 4);
            this.banks_list.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.banks_list.Name = "banks_list";
            this.banks_list.RowHeadersWidth = 51;
            this.banks_list.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.banks_list.Size = new System.Drawing.Size(511, 470);
            this.banks_list.TabIndex = 0;
            this.banks_list.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.banks_list_CellClick);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.balance_tb, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label3, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.name_tb, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label1, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label2, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.bank_type_cb, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.save_bt, 0, 11);
            this.tableLayoutPanel2.Controls.Add(this.edite_bt, 1, 11);
            this.tableLayoutPanel2.Controls.Add(this.delete_bt, 0, 12);
            this.tableLayoutPanel2.Controls.Add(this.reset_bt, 1, 12);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(523, 4);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 14;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142857F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142857F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142857F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142857F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142857F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142857F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142857F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142857F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142857F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142857F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142857F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142857F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142857F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142857F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(364, 470);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // balance_tb
            // 
            this.balance_tb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.balance_tb.Location = new System.Drawing.Point(4, 70);
            this.balance_tb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.balance_tb.Name = "balance_tb";
            this.balance_tb.Size = new System.Drawing.Size(174, 22);
            this.balance_tb.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(186, 99);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 33);
            this.label3.TabIndex = 2;
            this.label3.Text = "نوع حساب";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // name_tb
            // 
            this.name_tb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.name_tb.Location = new System.Drawing.Point(4, 37);
            this.name_tb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.name_tb.Name = "name_tb";
            this.name_tb.Size = new System.Drawing.Size(174, 22);
            this.name_tb.TabIndex = 3;
            this.name_tb.TextChanged += new System.EventHandler(this.name_tb_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(186, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "بانک";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(186, 66);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "موجودی";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bank_type_cb
            // 
            this.bank_type_cb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bank_type_cb.FormattingEnabled = true;
            this.bank_type_cb.Location = new System.Drawing.Point(4, 103);
            this.bank_type_cb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bank_type_cb.Name = "bank_type_cb";
            this.bank_type_cb.Size = new System.Drawing.Size(174, 24);
            this.bank_type_cb.TabIndex = 5;
            // 
            // save_bt
            // 
            this.save_bt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.save_bt.Location = new System.Drawing.Point(4, 367);
            this.save_bt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.save_bt.Name = "save_bt";
            this.save_bt.Size = new System.Drawing.Size(174, 25);
            this.save_bt.TabIndex = 6;
            this.save_bt.Text = "افزودن";
            this.save_bt.UseVisualStyleBackColor = true;
            this.save_bt.Click += new System.EventHandler(this.save_bt_Click);
            // 
            // edite_bt
            // 
            this.edite_bt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.edite_bt.Location = new System.Drawing.Point(186, 367);
            this.edite_bt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.edite_bt.Name = "edite_bt";
            this.edite_bt.Size = new System.Drawing.Size(174, 25);
            this.edite_bt.TabIndex = 7;
            this.edite_bt.Text = "ویرایش";
            this.edite_bt.UseVisualStyleBackColor = true;
            this.edite_bt.Click += new System.EventHandler(this.edite_bt_Click);
            // 
            // delete_bt
            // 
            this.delete_bt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.delete_bt.Location = new System.Drawing.Point(4, 400);
            this.delete_bt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.delete_bt.Name = "delete_bt";
            this.delete_bt.Size = new System.Drawing.Size(174, 25);
            this.delete_bt.TabIndex = 8;
            this.delete_bt.Text = "حذف";
            this.delete_bt.UseVisualStyleBackColor = true;
            this.delete_bt.Click += new System.EventHandler(this.delete_bt_Click);
            // 
            // reset_bt
            // 
            this.reset_bt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reset_bt.Location = new System.Drawing.Point(186, 400);
            this.reset_bt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.reset_bt.Name = "reset_bt";
            this.reset_bt.Size = new System.Drawing.Size(174, 25);
            this.reset_bt.TabIndex = 9;
            this.reset_bt.Text = "ریست";
            this.reset_bt.UseVisualStyleBackColor = true;
            this.reset_bt.Click += new System.EventHandler(this.reset_bt_Click);
            // 
            // Banks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 478);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Banks";
            this.Text = "مدیریت حساب ها";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.banks_list)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView banks_list;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox balance_tb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox name_tb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox bank_type_cb;
        private System.Windows.Forms.Button save_bt;
        private System.Windows.Forms.Button edite_bt;
        private System.Windows.Forms.Button delete_bt;
        private System.Windows.Forms.Button reset_bt;
    }
}