namespace EntityFrameworkSqlite2
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
            label1 = new Label();
            tbSearch = new TextBox();
            label2 = new Label();
            tbStudId = new TextBox();
            tbFirstName = new TextBox();
            label3 = new Label();
            tbLastName = new TextBox();
            label4 = new Label();
            label5 = new Label();
            tbWeight = new TextBox();
            label6 = new Label();
            tbHeight = new TextBox();
            label7 = new Label();
            dtpDob = new DateTimePicker();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            tbStudAddId = new TextBox();
            label8 = new Label();
            tbAddress = new TextBox();
            label9 = new Label();
            tbCity = new TextBox();
            label10 = new Label();
            tbState = new TextBox();
            label11 = new Label();
            tbCountry = new TextBox();
            label12 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 45);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(842, 629);
            dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 12);
            label1.Name = "label1";
            label1.Size = new Size(56, 20);
            label1.TabIndex = 1;
            label1.Text = "Search:";
            // 
            // tbSearch
            // 
            tbSearch.Location = new Point(74, 12);
            tbSearch.Name = "tbSearch";
            tbSearch.Size = new Size(780, 27);
            tbSearch.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(874, 45);
            label2.Name = "label2";
            label2.Size = new Size(27, 20);
            label2.TabIndex = 3;
            label2.Text = "ID:";
            // 
            // tbStudId
            // 
            tbStudId.Location = new Point(874, 68);
            tbStudId.Name = "tbStudId";
            tbStudId.ReadOnly = true;
            tbStudId.Size = new Size(373, 27);
            tbStudId.TabIndex = 4;
            // 
            // tbFirstName
            // 
            tbFirstName.Location = new Point(874, 121);
            tbFirstName.Name = "tbFirstName";
            tbFirstName.Size = new Size(373, 27);
            tbFirstName.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(874, 98);
            label3.Name = "label3";
            label3.Size = new Size(83, 20);
            label3.TabIndex = 5;
            label3.Text = "First Name:";
            // 
            // tbLastName
            // 
            tbLastName.Location = new Point(874, 174);
            tbLastName.Name = "tbLastName";
            tbLastName.Size = new Size(373, 27);
            tbLastName.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(874, 151);
            label4.Name = "label4";
            label4.Size = new Size(82, 20);
            label4.TabIndex = 7;
            label4.Text = "Last Name:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(874, 204);
            label5.Name = "label5";
            label5.Size = new Size(97, 20);
            label5.TabIndex = 9;
            label5.Text = "Date of Birth:";
            // 
            // tbWeight
            // 
            tbWeight.Location = new Point(874, 280);
            tbWeight.Name = "tbWeight";
            tbWeight.Size = new Size(180, 27);
            tbWeight.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(874, 257);
            label6.Name = "label6";
            label6.Size = new Size(59, 20);
            label6.TabIndex = 11;
            label6.Text = "Weight:";
            // 
            // tbHeight
            // 
            tbHeight.Location = new Point(1067, 280);
            tbHeight.Name = "tbHeight";
            tbHeight.Size = new Size(180, 27);
            tbHeight.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(1067, 257);
            label7.Name = "label7";
            label7.Size = new Size(57, 20);
            label7.TabIndex = 13;
            label7.Text = "Height:";
            // 
            // dtpDob
            // 
            dtpDob.Format = DateTimePickerFormat.Short;
            dtpDob.Location = new Point(874, 227);
            dtpDob.Name = "dtpDob";
            dtpDob.Size = new Size(373, 27);
            dtpDob.TabIndex = 15;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(1160, 625);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 49);
            btnAdd.TabIndex = 16;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(1060, 625);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 49);
            btnUpdate.TabIndex = 17;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(960, 625);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 49);
            btnDelete.TabIndex = 18;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // tbStudAddId
            // 
            tbStudAddId.Location = new Point(874, 356);
            tbStudAddId.Name = "tbStudAddId";
            tbStudAddId.ReadOnly = true;
            tbStudAddId.Size = new Size(373, 27);
            tbStudAddId.TabIndex = 20;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(874, 333);
            label8.Name = "label8";
            label8.Size = new Size(139, 20);
            label8.TabIndex = 19;
            label8.Text = "Student Address ID:";
            // 
            // tbAddress
            // 
            tbAddress.Location = new Point(874, 409);
            tbAddress.Name = "tbAddress";
            tbAddress.Size = new Size(373, 27);
            tbAddress.TabIndex = 22;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(874, 386);
            label9.Name = "label9";
            label9.Size = new Size(65, 20);
            label9.TabIndex = 21;
            label9.Text = "Address:";
            // 
            // tbCity
            // 
            tbCity.Location = new Point(874, 462);
            tbCity.Name = "tbCity";
            tbCity.Size = new Size(373, 27);
            tbCity.TabIndex = 24;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(874, 439);
            label10.Name = "label10";
            label10.Size = new Size(37, 20);
            label10.TabIndex = 23;
            label10.Text = "City:";
            // 
            // tbState
            // 
            tbState.Location = new Point(874, 515);
            tbState.Name = "tbState";
            tbState.Size = new Size(373, 27);
            tbState.TabIndex = 26;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(874, 492);
            label11.Name = "label11";
            label11.Size = new Size(46, 20);
            label11.TabIndex = 25;
            label11.Text = "State:";
            // 
            // tbCountry
            // 
            tbCountry.Location = new Point(872, 568);
            tbCountry.Name = "tbCountry";
            tbCountry.Size = new Size(373, 27);
            tbCountry.TabIndex = 28;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(872, 545);
            label12.Name = "label12";
            label12.Size = new Size(63, 20);
            label12.TabIndex = 27;
            label12.Text = "Country:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1268, 685);
            Controls.Add(tbCountry);
            Controls.Add(label12);
            Controls.Add(tbState);
            Controls.Add(label11);
            Controls.Add(tbCity);
            Controls.Add(label10);
            Controls.Add(tbAddress);
            Controls.Add(label9);
            Controls.Add(tbStudAddId);
            Controls.Add(label8);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(dtpDob);
            Controls.Add(tbHeight);
            Controls.Add(label7);
            Controls.Add(tbWeight);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(tbLastName);
            Controls.Add(label4);
            Controls.Add(tbFirstName);
            Controls.Add(label3);
            Controls.Add(tbStudId);
            Controls.Add(label2);
            Controls.Add(tbSearch);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Student Information";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private TextBox tbSearch;
        private Label label2;
        private TextBox tbStudId;
        private TextBox tbFirstName;
        private Label label3;
        private TextBox tbLastName;
        private Label label4;
        private Label label5;
        private TextBox tbWeight;
        private Label label6;
        private TextBox tbHeight;
        private Label label7;
        private DateTimePicker dtpDob;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private TextBox tbStudAddId;
        private Label label8;
        private TextBox tbAddress;
        private Label label9;
        private TextBox tbCity;
        private Label label10;
        private TextBox tbState;
        private Label label11;
        private TextBox tbCountry;
        private Label label12;
    }
}
