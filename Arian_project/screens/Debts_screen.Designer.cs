namespace Arian_project.screens
{
    partial class Debts_screen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Debts_screen));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.prices_lb = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.power_lb = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.water_lb = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.gas_lb = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.count_lb = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.internet_lb = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.date_lb = new Atf.UI.DateTimeSelector();
            this.debts_list = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.rent_lb = new System.Windows.Forms.Label();
            this.save_bt = new GlassButton();
            this.add_item_bt = new GlassButton();
            this.previce_day_bt = new GlassButton();
            this.next_day_bt = new GlassButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.debts_list)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.debts_list, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(733, 541);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 6;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.Controls.Add(this.save_bt, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.add_item_bt, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label1, 5, 1);
            this.tableLayoutPanel2.Controls.Add(this.prices_lb, 4, 1);
            this.tableLayoutPanel2.Controls.Add(this.label3, 5, 2);
            this.tableLayoutPanel2.Controls.Add(this.power_lb, 4, 2);
            this.tableLayoutPanel2.Controls.Add(this.label5, 5, 3);
            this.tableLayoutPanel2.Controls.Add(this.water_lb, 4, 3);
            this.tableLayoutPanel2.Controls.Add(this.label7, 5, 4);
            this.tableLayoutPanel2.Controls.Add(this.gas_lb, 4, 4);
            this.tableLayoutPanel2.Controls.Add(this.label9, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.count_lb, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.label11, 5, 5);
            this.tableLayoutPanel2.Controls.Add(this.internet_lb, 4, 5);
            this.tableLayoutPanel2.Controls.Add(this.label2, 5, 6);
            this.tableLayoutPanel2.Controls.Add(this.rent_lb, 4, 6);
            this.tableLayoutPanel2.Controls.Add(this.date_lb, 1, 6);
            this.tableLayoutPanel2.Controls.Add(this.label13, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.next_day_bt, 2, 6);
            this.tableLayoutPanel2.Controls.Add(this.previce_day_bt, 0, 6);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 7;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(727, 156);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(608, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = ": مبلغ هزینه ها";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // prices_lb
            // 
            this.prices_lb.AutoSize = true;
            this.prices_lb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.prices_lb.Location = new System.Drawing.Point(487, 22);
            this.prices_lb.Name = "prices_lb";
            this.prices_lb.Size = new System.Drawing.Size(115, 22);
            this.prices_lb.TabIndex = 6;
            this.prices_lb.Text = "0";
            this.prices_lb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(608, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 22);
            this.label3.TabIndex = 7;
            this.label3.Text = ": هزینه برق";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // power_lb
            // 
            this.power_lb.AutoSize = true;
            this.power_lb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.power_lb.Location = new System.Drawing.Point(487, 44);
            this.power_lb.Name = "power_lb";
            this.power_lb.Size = new System.Drawing.Size(115, 22);
            this.power_lb.TabIndex = 8;
            this.power_lb.Text = "0";
            this.power_lb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(608, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 22);
            this.label5.TabIndex = 9;
            this.label5.Text = ": هزینه اب";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // water_lb
            // 
            this.water_lb.AutoSize = true;
            this.water_lb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.water_lb.Location = new System.Drawing.Point(487, 66);
            this.water_lb.Name = "water_lb";
            this.water_lb.Size = new System.Drawing.Size(115, 22);
            this.water_lb.TabIndex = 10;
            this.water_lb.Text = "0";
            this.water_lb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(608, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 22);
            this.label7.TabIndex = 11;
            this.label7.Text = ": هزینه گاز";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gas_lb
            // 
            this.gas_lb.AutoSize = true;
            this.gas_lb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gas_lb.Location = new System.Drawing.Point(487, 88);
            this.gas_lb.Name = "gas_lb";
            this.gas_lb.Size = new System.Drawing.Size(115, 22);
            this.gas_lb.TabIndex = 12;
            this.gas_lb.Text = "0";
            this.gas_lb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Location = new System.Drawing.Point(608, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(116, 22);
            this.label9.TabIndex = 13;
            this.label9.Text = ": تعداد";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // count_lb
            // 
            this.count_lb.AutoSize = true;
            this.count_lb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.count_lb.Location = new System.Drawing.Point(487, 0);
            this.count_lb.Name = "count_lb";
            this.count_lb.Size = new System.Drawing.Size(115, 22);
            this.count_lb.TabIndex = 14;
            this.count_lb.Text = "0";
            this.count_lb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Location = new System.Drawing.Point(608, 110);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(116, 22);
            this.label11.TabIndex = 15;
            this.label11.Text = ": هزینه اینترنت ";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // internet_lb
            // 
            this.internet_lb.AutoSize = true;
            this.internet_lb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.internet_lb.Location = new System.Drawing.Point(487, 110);
            this.internet_lb.Name = "internet_lb";
            this.internet_lb.Size = new System.Drawing.Size(115, 22);
            this.internet_lb.TabIndex = 16;
            this.internet_lb.Text = "0";
            this.internet_lb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label13.Location = new System.Drawing.Point(124, 110);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(115, 22);
            this.label13.TabIndex = 17;
            this.label13.Text = ":تاریخ ماه";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // date_lb
            // 
            this.date_lb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.date_lb.Location = new System.Drawing.Point(124, 135);
            this.date_lb.Name = "date_lb";
            this.date_lb.Size = new System.Drawing.Size(115, 23);
            this.date_lb.TabIndex = 4;
            this.date_lb.UsePersianFormat = true;
            // 
            // debts_list
            // 
            this.debts_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.debts_list.Dock = System.Windows.Forms.DockStyle.Fill;
            this.debts_list.Location = new System.Drawing.Point(3, 165);
            this.debts_list.Name = "debts_list";
            this.debts_list.RowHeadersWidth = 51;
            this.debts_list.RowTemplate.Height = 24;
            this.debts_list.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.debts_list.Size = new System.Drawing.Size(727, 373);
            this.debts_list.TabIndex = 1;
            this.debts_list.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.debts_list_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(608, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 24);
            this.label2.TabIndex = 18;
            this.label2.Text = ":هزینه اجاره";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rent_lb
            // 
            this.rent_lb.AutoSize = true;
            this.rent_lb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rent_lb.Location = new System.Drawing.Point(487, 132);
            this.rent_lb.Name = "rent_lb";
            this.rent_lb.Size = new System.Drawing.Size(115, 24);
            this.rent_lb.TabIndex = 19;
            this.rent_lb.Text = "0";
            this.rent_lb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // save_bt
            // 
            this.save_bt.BackAlpha = 120;
            this.save_bt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.save_bt.CornerRadius = 20;
            this.save_bt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.save_bt.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.save_bt.ForeColor = System.Drawing.Color.Black;
            this.save_bt.Location = new System.Drawing.Point(3, 3);
            this.save_bt.Name = "save_bt";
            this.save_bt.Size = new System.Drawing.Size(115, 16);
            this.save_bt.TabIndex = 0;
            this.save_bt.Text = "ثبت";
            // 
            // add_item_bt
            // 
            this.add_item_bt.BackAlpha = 120;
            this.add_item_bt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.add_item_bt.CornerRadius = 20;
            this.add_item_bt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.add_item_bt.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.add_item_bt.ForeColor = System.Drawing.Color.Black;
            this.add_item_bt.Location = new System.Drawing.Point(3, 47);
            this.add_item_bt.Name = "add_item_bt";
            this.add_item_bt.Size = new System.Drawing.Size(115, 16);
            this.add_item_bt.TabIndex = 1;
            this.add_item_bt.Text = "افزودن مورد";
            this.add_item_bt.Click += new System.EventHandler(this.add_item_bt_Click);
            // 
            // previce_day_bt
            // 
            this.previce_day_bt.BackAlpha = 120;
            this.previce_day_bt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.previce_day_bt.CornerRadius = 20;
            this.previce_day_bt.Dock = System.Windows.Forms.DockStyle.Right;
            this.previce_day_bt.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.previce_day_bt.ForeColor = System.Drawing.Color.Black;
            this.previce_day_bt.Location = new System.Drawing.Point(88, 135);
            this.previce_day_bt.Name = "previce_day_bt";
            this.previce_day_bt.Size = new System.Drawing.Size(30, 18);
            this.previce_day_bt.TabIndex = 2;
            this.previce_day_bt.Text = "<";
            this.previce_day_bt.Click += new System.EventHandler(this.previce_day_bt_Click);
            // 
            // next_day_bt
            // 
            this.next_day_bt.BackAlpha = 120;
            this.next_day_bt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.next_day_bt.CornerRadius = 20;
            this.next_day_bt.Dock = System.Windows.Forms.DockStyle.Left;
            this.next_day_bt.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.next_day_bt.ForeColor = System.Drawing.Color.Black;
            this.next_day_bt.Location = new System.Drawing.Point(245, 135);
            this.next_day_bt.Name = "next_day_bt";
            this.next_day_bt.Size = new System.Drawing.Size(30, 18);
            this.next_day_bt.TabIndex = 3;
            this.next_day_bt.Text = ">";
            this.next_day_bt.Click += new System.EventHandler(this.next_day_bt_Click);
            // 
            // Debts_screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 541);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Debts_screen";
            this.Text = "هزینه ها";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.debts_list)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private GlassButton save_bt;
        private GlassButton add_item_bt;
        private GlassButton previce_day_bt;
        private GlassButton next_day_bt;
        private Atf.UI.DateTimeSelector date_lb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label prices_lb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label power_lb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label water_lb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label gas_lb;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label count_lb;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label internet_lb;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView debts_list;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label rent_lb;
    }
}