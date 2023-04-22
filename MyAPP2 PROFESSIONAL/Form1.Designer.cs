namespace MyAPP2_PROFESSIONAL
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            a = new DataGridViewTextBoxColumn();
            b = new DataGridViewTextBoxColumn();
            c = new DataGridViewTextBoxColumn();
            d = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { a, b, c, d, Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column8 });
            dataGridView1.Location = new Point(-3, -2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1270, 507);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // a
            // 
            a.HeaderText = "A";
            a.Name = "a";
            // 
            // b
            // 
            b.HeaderText = "B";
            b.Name = "b";
            // 
            // c
            // 
            c.HeaderText = "C";
            c.Name = "c";
            // 
            // d
            // 
            d.HeaderText = "D";
            d.Name = "d";
            // 
            // Column1
            // 
            Column1.HeaderText = "E";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "F";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "G";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "a";
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "b";
            Column5.Name = "Column5";
            // 
            // Column6
            // 
            Column6.HeaderText = "c";
            Column6.Name = "Column6";
            // 
            // Column7
            // 
            Column7.HeaderText = "d";
            Column7.Name = "Column7";
            // 
            // Column8
            // 
            Column8.HeaderText = "e";
            Column8.Name = "Column8";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1267, 503);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "TableEditor PROFESSIONAL";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn a;
        private DataGridViewTextBoxColumn b;
        private DataGridViewTextBoxColumn c;
        private DataGridViewTextBoxColumn d;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
    }
}