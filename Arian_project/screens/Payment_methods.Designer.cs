namespace Arian_project.screens
{
    partial class Payment_methods
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Payment_methods));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.payment_methods_cb = new System.Windows.Forms.ComboBox();
            this.banks_cb = new System.Windows.Forms.ComboBox();
            this.glassButton1 = new GlassButton();
            this.label1 = new System.Windows.Forms.Label();
            this.price_tb = new System.Windows.Forms.TextBox();
            this.date_lb = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.payment_methods_cb, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.banks_cb, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.glassButton1, 0, 11);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.price_tb, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.date_lb, 0, 7);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 12;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(250, 347);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(2, 168);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(246, 28);
            this.label4.TabIndex = 9;
            this.label4.Text = "تاریخ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(2, 112);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(246, 28);
            this.label3.TabIndex = 8;
            this.label3.Text = "مبلغ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(2, 56);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(246, 28);
            this.label2.TabIndex = 7;
            this.label2.Text = "بانک";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // payment_methods_cb
            // 
            this.payment_methods_cb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.payment_methods_cb.FormattingEnabled = true;
            this.payment_methods_cb.Location = new System.Drawing.Point(2, 30);
            this.payment_methods_cb.Margin = new System.Windows.Forms.Padding(2);
            this.payment_methods_cb.Name = "payment_methods_cb";
            this.payment_methods_cb.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.payment_methods_cb.Size = new System.Drawing.Size(246, 21);
            this.payment_methods_cb.TabIndex = 0;
            this.payment_methods_cb.SelectedIndexChanged += new System.EventHandler(this.payment_methods_cb_SelectedIndexChanged);
            // 
            // banks_cb
            // 
            this.banks_cb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.banks_cb.FormattingEnabled = true;
            this.banks_cb.Location = new System.Drawing.Point(2, 86);
            this.banks_cb.Margin = new System.Windows.Forms.Padding(2);
            this.banks_cb.Name = "banks_cb";
            this.banks_cb.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.banks_cb.Size = new System.Drawing.Size(246, 21);
            this.banks_cb.TabIndex = 1;
            // 
            // glassButton1
            // 
            this.glassButton1.BackAlpha = 120;
            this.glassButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.glassButton1.CornerRadius = 20;
            this.glassButton1.Dock = System.Windows.Forms.DockStyle.Left;
            this.glassButton1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.glassButton1.ForeColor = System.Drawing.Color.Black;
            this.glassButton1.Location = new System.Drawing.Point(2, 310);
            this.glassButton1.Margin = new System.Windows.Forms.Padding(2);
            this.glassButton1.Name = "glassButton1";
            this.glassButton1.Size = new System.Drawing.Size(90, 35);
            this.glassButton1.TabIndex = 5;
            this.glassButton1.Text = "ثبت";
            this.glassButton1.Click += new System.EventHandler(this.glassButton1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(2, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 28);
            this.label1.TabIndex = 6;
            this.label1.Text = "شیوه پردخت";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // price_tb
            // 
            this.price_tb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.price_tb.Location = new System.Drawing.Point(2, 142);
            this.price_tb.Margin = new System.Windows.Forms.Padding(2);
            this.price_tb.Name = "price_tb";
            this.price_tb.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.price_tb.Size = new System.Drawing.Size(246, 20);
            this.price_tb.TabIndex = 10;
            // 
            // date_lb
            // 
            this.date_lb.AutoSize = true;
            this.date_lb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.date_lb.Location = new System.Drawing.Point(2, 196);
            this.date_lb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.date_lb.Name = "date_lb";
            this.date_lb.Size = new System.Drawing.Size(246, 28);
            this.date_lb.TabIndex = 11;
            this.date_lb.Text = "label5";
            this.date_lb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Payment_methods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 347);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Payment_methods";
            this.Text = "نحوه پرداخت";
            this.Load += new System.EventHandler(this.Payment_methods_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox banks_cb;
        private System.Windows.Forms.ComboBox payment_methods_cb;
        private GlassButton glassButton1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox price_tb;
        private System.Windows.Forms.Label date_lb;
    }
}