namespace HW8_GUI
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
            dgvItems = new DataGridView();
            btnFilter = new TextBox();
            btnCancel = new Button();
            btnInsert = new Button();
            btnUpdateDB = new Button();
            txtInsertName = new TextBox();
            txtInsertDescription = new TextBox();
            txtInsertPrice = new TextBox();
            btnDelete = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            txtPrice = new TextBox();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvItems).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // dgvItems
            // 
            dgvItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvItems.Location = new Point(33, 40);
            dgvItems.Name = "dgvItems";
            dgvItems.Size = new Size(572, 210);
            dgvItems.TabIndex = 0;
            // 
            // btnFilter
            // 
            btnFilter.Location = new Point(792, 65);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(100, 23);
            btnFilter.TabIndex = 1;
            btnFilter.Text = "Filter";
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(682, 65);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "Cancel Filter";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(50, 62);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(75, 23);
            btnInsert.TabIndex = 3;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            // 
            // btnUpdateDB
            // 
            btnUpdateDB.Location = new Point(699, 121);
            btnUpdateDB.Name = "btnUpdateDB";
            btnUpdateDB.Size = new Size(143, 23);
            btnUpdateDB.TabIndex = 5;
            btnUpdateDB.Text = "Update Data Base";
            btnUpdateDB.UseVisualStyleBackColor = true;
            btnUpdateDB.Click += btnUpdateDB_Click;
            // 
            // txtInsertName
            // 
            txtInsertName.Location = new Point(162, 22);
            txtInsertName.Name = "txtInsertName";
            txtInsertName.Size = new Size(100, 23);
            txtInsertName.TabIndex = 7;
            txtInsertName.Text = "Description";
            // 
            // txtInsertDescription
            // 
            txtInsertDescription.Location = new Point(35, 22);
            txtInsertDescription.Name = "txtInsertDescription";
            txtInsertDescription.Size = new Size(100, 23);
            txtInsertDescription.TabIndex = 8;
            txtInsertDescription.Text = "Name";
            // 
            // txtInsertPrice
            // 
            txtInsertPrice.Location = new Point(44, 22);
            txtInsertPrice.Name = "txtInsertPrice";
            txtInsertPrice.Size = new Size(100, 23);
            txtInsertPrice.TabIndex = 9;
            txtInsertPrice.Text = "Code";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(56, 62);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 10;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtInsertPrice);
            groupBox1.Controls.Add(btnDelete);
            groupBox1.Location = new Point(563, 314);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(289, 100);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Delete Item";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtPrice);
            groupBox2.Controls.Add(txtInsertDescription);
            groupBox2.Controls.Add(btnInsert);
            groupBox2.Controls.Add(txtInsertName);
            groupBox2.Location = new Point(81, 314);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(385, 100);
            groupBox2.TabIndex = 12;
            groupBox2.TabStop = false;
            groupBox2.Text = "Insert Item";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(279, 22);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(100, 23);
            txtPrice.TabIndex = 9;
            txtPrice.Text = "Price";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(699, 22);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(183, 23);
            textBox1.TabIndex = 13;
            textBox1.Text = "Above the price for filtering";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(954, 450);
            Controls.Add(textBox1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btnUpdateDB);
            Controls.Add(btnCancel);
            Controls.Add(btnFilter);
            Controls.Add(dgvItems);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvItems).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvItems;
        private TextBox btnFilter;
        private Button btnCancel;
        private Button btnInsert;
        private Button btnUpdateDB;
        private TextBox txtInsertName;
        private TextBox txtInsertDescription;
        private TextBox txtInsertPrice;
        private Button btnDelete;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox txtPrice;
        private TextBox textBox1;
    }
}
