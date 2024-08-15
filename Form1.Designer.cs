namespace CustomerAutomatization
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
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            panel2 = new Panel();
            buttonAdd = new Button();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBoxCity = new TextBox();
            textBoxEligible = new TextBox();
            textBoxSalary = new TextBox();
            textBoxSurname = new TextBox();
            textBoxName = new TextBox();
            textBoxCustomerId = new TextBox();
            buttonclear = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(dataGridView1);
            panel1.Location = new Point(12, 27);
            panel1.Name = "panel1";
            panel1.Size = new Size(928, 285);
            panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(928, 285);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(buttonclear);
            panel2.Controls.Add(buttonAdd);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(textBoxCity);
            panel2.Controls.Add(textBoxEligible);
            panel2.Controls.Add(textBoxSalary);
            panel2.Controls.Add(textBoxSurname);
            panel2.Controls.Add(textBoxName);
            panel2.Controls.Add(textBoxCustomerId);
            panel2.Location = new Point(12, 318);
            panel2.Name = "panel2";
            panel2.Size = new Size(928, 154);
            panel2.TabIndex = 1;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(715, 23);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(119, 35);
            buttonAdd.TabIndex = 12;
            buttonAdd.Text = "Add Customer";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(36, 82);
            label6.Name = "label6";
            label6.Size = new Size(70, 20);
            label6.TabIndex = 11;
            label6.Text = "Surname:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(404, 89);
            label5.Name = "label5";
            label5.Size = new Size(37, 20);
            label5.TabIndex = 10;
            label5.Text = "City:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(334, 52);
            label4.Name = "label4";
            label4.Size = new Size(143, 20);
            label4.TabIndex = 9;
            label4.Text = "Is Customer Eligible:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(389, 23);
            label3.Name = "label3";
            label3.Size = new Size(52, 20);
            label3.TabIndex = 8;
            label3.Text = "Salary:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 52);
            label2.Name = "label2";
            label2.Size = new Size(52, 20);
            label2.TabIndex = 7;
            label2.Text = "Name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 23);
            label1.Name = "label1";
            label1.Size = new Size(88, 20);
            label1.TabIndex = 6;
            label1.Text = "CustomerId:";
            // 
            // textBoxCity
            // 
            textBoxCity.Location = new Point(483, 82);
            textBoxCity.Name = "textBoxCity";
            textBoxCity.Size = new Size(125, 27);
            textBoxCity.TabIndex = 5;
            // 
            // textBoxEligible
            // 
            textBoxEligible.Enabled = false;
            textBoxEligible.Location = new Point(483, 49);
            textBoxEligible.Name = "textBoxEligible";
            textBoxEligible.Size = new Size(125, 27);
            textBoxEligible.TabIndex = 4;
            // 
            // textBoxSalary
            // 
            textBoxSalary.Location = new Point(483, 16);
            textBoxSalary.Name = "textBoxSalary";
            textBoxSalary.Size = new Size(125, 27);
            textBoxSalary.TabIndex = 3;
            // 
            // textBoxSurname
            // 
            textBoxSurname.Location = new Point(130, 82);
            textBoxSurname.Name = "textBoxSurname";
            textBoxSurname.Size = new Size(125, 27);
            textBoxSurname.TabIndex = 2;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(130, 49);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(125, 27);
            textBoxName.TabIndex = 1;
            // 
            // textBoxCustomerId
            // 
            textBoxCustomerId.Enabled = false;
            textBoxCustomerId.Location = new Point(130, 16);
            textBoxCustomerId.Name = "textBoxCustomerId";
            textBoxCustomerId.Size = new Size(125, 27);
            textBoxCustomerId.TabIndex = 0;
            // 
            // buttonclear
            // 
            buttonclear.Location = new Point(715, 74);
            buttonclear.Name = "buttonclear";
            buttonclear.Size = new Size(119, 35);
            buttonclear.TabIndex = 13;
            buttonclear.Text = "ClearBox";
            buttonclear.UseVisualStyleBackColor = true;
            buttonclear.Click += buttonclear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(952, 477);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private DataGridView dataGridView1;
        private TextBox textBoxCity;
        private TextBox textBoxEligible;
        private TextBox textBoxSalary;
        private TextBox textBoxSurname;
        private TextBox textBoxName;
        private TextBox textBoxCustomerId;
        private Label label2;
        private Label label1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button buttonAdd;
        private Button buttonclear;
    }
}
