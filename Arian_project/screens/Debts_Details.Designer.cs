namespace Arian_project.screens
{
    partial class Debts_Details
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Debts_Details));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.save_bt = new GlassButton();
            this.cancel_bt = new GlassButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.debt_types_cb = new System.Windows.Forms.ComboBox();
            this.price_bt = new System.Windows.Forms.TextBox();
            this.desciption_tb = new System.Windows.Forms.RichTextBox();
            this.date_lb = new Atf.UI.DateTimeSelector();
            this.banks_cb = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label5, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.save_bt, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.cancel_bt, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.debt_types_cb, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.price_bt, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.desciption_tb, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.date_lb, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.banks_cb, 0, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(355, 444);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(180, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(172, 55);
            this.label5.TabIndex = 14;
            this.label5.Text = "پرداخت";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // save_bt
            // 
            this.save_bt.BackAlpha = 120;
            this.save_bt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.save_bt.CornerRadius = 20;
            this.save_bt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.save_bt.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.save_bt.ForeColor = System.Drawing.Color.Black;
            this.save_bt.Location = new System.Drawing.Point(3, 388);
            this.save_bt.Name = "save_bt";
            this.save_bt.Size = new System.Drawing.Size(171, 53);
            this.save_bt.TabIndex = 0;
            this.save_bt.Text = "ذخیره";
            this.save_bt.Click += new System.EventHandler(this.save_bt_Click);
            // 
            // cancel_bt
            // 
            this.cancel_bt.BackAlpha = 120;
            this.cancel_bt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cancel_bt.CornerRadius = 20;
            this.cancel_bt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cancel_bt.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.cancel_bt.ForeColor = System.Drawing.Color.Black;
            this.cancel_bt.Location = new System.Drawing.Point(180, 388);
            this.cancel_bt.Name = "cancel_bt";
            this.cancel_bt.Size = new System.Drawing.Size(172, 53);
            this.cancel_bt.TabIndex = 1;
            this.cancel_bt.Text = "لغو";
            this.cancel_bt.Click += new System.EventHandler(this.cancel_bt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(180, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 55);
            this.label1.TabIndex = 2;
            this.label1.Text = "نوع هزینه";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(180, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 55);
            this.label2.TabIndex = 3;
            this.label2.Text = "مبلغ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(180, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 55);
            this.label3.TabIndex = 4;
            this.label3.Text = "تاریخ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(180, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 55);
            this.label4.TabIndex = 5;
            this.label4.Text = "توضیحات";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // debt_types_cb
            // 
            this.debt_types_cb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.debt_types_cb.FormattingEnabled = true;
            this.debt_types_cb.Location = new System.Drawing.Point(3, 3);
            this.debt_types_cb.Name = "debt_types_cb";
            this.debt_types_cb.Size = new System.Drawing.Size(171, 24);
            this.debt_types_cb.TabIndex = 9;
            // 
            // price_bt
            // 
            this.price_bt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.price_bt.Location = new System.Drawing.Point(3, 58);
            this.price_bt.Name = "price_bt";
            this.price_bt.Size = new System.Drawing.Size(171, 22);
            this.price_bt.TabIndex = 10;
            // 
            // desciption_tb
            // 
            this.desciption_tb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.desciption_tb.Location = new System.Drawing.Point(3, 168);
            this.desciption_tb.Name = "desciption_tb";
            this.desciption_tb.Size = new System.Drawing.Size(171, 49);
            this.desciption_tb.TabIndex = 11;
            this.desciption_tb.Text = "";
            // 
            // date_lb
            // 
            this.date_lb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.date_lb.Location = new System.Drawing.Point(3, 113);
            this.date_lb.Name = "date_lb";
            this.date_lb.Size = new System.Drawing.Size(171, 23);
            this.date_lb.TabIndex = 12;
            this.date_lb.UsePersianFormat = true;
            // 
            // banks_cb
            // 
            this.banks_cb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.banks_cb.FormattingEnabled = true;
            this.banks_cb.Location = new System.Drawing.Point(3, 223);
            this.banks_cb.Name = "banks_cb";
            this.banks_cb.Size = new System.Drawing.Size(171, 24);
            this.banks_cb.TabIndex = 13;
            // 
            // Debts_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 444);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Debts_Details";
            this.Text = "هزینه";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private GlassButton save_bt;
        private GlassButton cancel_bt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox debt_types_cb;
        private System.Windows.Forms.TextBox price_bt;
        private System.Windows.Forms.RichTextBox desciption_tb;
        private Atf.UI.DateTimeSelector date_lb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox banks_cb;
    }
}