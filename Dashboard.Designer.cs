namespace loginapp
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.lbl_Tableno = new System.Windows.Forms.Label();
            this.lbl_Displaymessage = new System.Windows.Forms.Label();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.datetime = new System.Windows.Forms.DateTimePicker();
            this.combobox_tableselect = new System.Windows.Forms.ComboBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printdialog = new System.Windows.Forms.PrintPreviewDialog();
            this.print = new System.Windows.Forms.Button();
            this.btn_totalsales = new System.Windows.Forms.Button();
            this.lbl_totalsales = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Tableno
            // 
            this.lbl_Tableno.AutoSize = true;
            this.lbl_Tableno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Tableno.Location = new System.Drawing.Point(39, 147);
            this.lbl_Tableno.Name = "lbl_Tableno";
            this.lbl_Tableno.Size = new System.Drawing.Size(134, 20);
            this.lbl_Tableno.TabIndex = 0;
            this.lbl_Tableno.Text = "TABLE NUMBER";
            // 
            // lbl_Displaymessage
            // 
            this.lbl_Displaymessage.AutoSize = true;
            this.lbl_Displaymessage.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Displaymessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Displaymessage.ForeColor = System.Drawing.Color.ForestGreen;
            this.lbl_Displaymessage.Location = new System.Drawing.Point(231, 9);
            this.lbl_Displaymessage.Name = "lbl_Displaymessage";
            this.lbl_Displaymessage.Size = new System.Drawing.Size(412, 31);
            this.lbl_Displaymessage.TabIndex = 1;
            this.lbl_Displaymessage.Text = "Welcome to Earth  Billing System";
            // 
            // dgv1
            // 
            this.dgv1.BackgroundColor = System.Drawing.Color.White;
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Location = new System.Drawing.Point(406, 114);
            this.dgv1.Name = "dgv1";
            this.dgv1.Size = new System.Drawing.Size(550, 262);
            this.dgv1.TabIndex = 5;
            this.dgv1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // datetime
            // 
            this.datetime.Location = new System.Drawing.Point(666, 9);
            this.datetime.Name = "datetime";
            this.datetime.Size = new System.Drawing.Size(200, 20);
            this.datetime.TabIndex = 6;
            this.datetime.Value = new System.DateTime(2020, 4, 27, 10, 39, 33, 0);
            // 
            // combobox_tableselect
            // 
            this.combobox_tableselect.BackColor = System.Drawing.SystemColors.ControlLight;
            this.combobox_tableselect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combobox_tableselect.ForeColor = System.Drawing.Color.Black;
            this.combobox_tableselect.FormattingEnabled = true;
            this.combobox_tableselect.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.combobox_tableselect.Location = new System.Drawing.Point(202, 147);
            this.combobox_tableselect.Name = "combobox_tableselect";
            this.combobox_tableselect.Size = new System.Drawing.Size(169, 24);
            this.combobox_tableselect.TabIndex = 10;
            this.combobox_tableselect.Text = "              Select";
            this.combobox_tableselect.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage_1);
            // 
            // printdialog
            // 
            this.printdialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printdialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printdialog.ClientSize = new System.Drawing.Size(400, 300);
            this.printdialog.Enabled = true;
            this.printdialog.Icon = ((System.Drawing.Icon)(resources.GetObject("printdialog.Icon")));
            this.printdialog.Name = "printdialog";
            this.printdialog.Visible = false;
            // 
            // print
            // 
            this.print.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.print.Location = new System.Drawing.Point(881, 397);
            this.print.Name = "print";
            this.print.Size = new System.Drawing.Size(75, 30);
            this.print.TabIndex = 11;
            this.print.Text = "PRINT";
            this.print.UseVisualStyleBackColor = true;
            this.print.Click += new System.EventHandler(this.print_Click);
            // 
            // btn_totalsales
            // 
            this.btn_totalsales.Location = new System.Drawing.Point(43, 388);
            this.btn_totalsales.Name = "btn_totalsales";
            this.btn_totalsales.Size = new System.Drawing.Size(90, 39);
            this.btn_totalsales.TabIndex = 12;
            this.btn_totalsales.Text = "Total Sales";
            this.btn_totalsales.UseVisualStyleBackColor = true;
            this.btn_totalsales.Click += new System.EventHandler(this.btn_totalsales_Click);
            // 
            // lbl_totalsales
            // 
            this.lbl_totalsales.AutoSize = true;
            this.lbl_totalsales.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_totalsales.Location = new System.Drawing.Point(173, 403);
            this.lbl_totalsales.Name = "lbl_totalsales";
            this.lbl_totalsales.Size = new System.Drawing.Size(0, 24);
            this.lbl_totalsales.TabIndex = 13;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 661);
            this.Controls.Add(this.lbl_totalsales);
            this.Controls.Add(this.btn_totalsales);
            this.Controls.Add(this.print);
            this.Controls.Add(this.combobox_tableselect);
            this.Controls.Add(this.datetime);
            this.Controls.Add(this.dgv1);
            this.Controls.Add(this.lbl_Displaymessage);
            this.Controls.Add(this.lbl_Tableno);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Earth Co. Japan   ::  Version 1.0.0 by Team VEX";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Tableno;
        private System.Windows.Forms.Label lbl_Displaymessage;
        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.DateTimePicker datetime;
        private System.Windows.Forms.ComboBox combobox_tableselect;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printdialog;
        private System.Windows.Forms.Button print;
        private System.Windows.Forms.Button btn_totalsales;
        private System.Windows.Forms.Label lbl_totalsales;
    }
}