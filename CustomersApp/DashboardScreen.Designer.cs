namespace CustomersApp
{
    partial class DashboardScreen
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
            label1 = new Label();
            addButton = new Button();
            updateButton = new Button();
            deleteButton = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 27.9000015F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(40, 38);
            label1.Name = "label1";
            label1.Size = new Size(531, 125);
            label1.TabIndex = 0;
            label1.Text = "Dashboard";
            // 
            // addButton
            // 
            addButton.BackColor = Color.FromArgb(128, 255, 128);
            addButton.Location = new Point(78, 548);
            addButton.Name = "addButton";
            addButton.Size = new Size(188, 58);
            addButton.TabIndex = 1;
            addButton.Text = "ADD";
            addButton.UseVisualStyleBackColor = false;
            addButton.Click += addButton_Click;
            // 
            // updateButton
            // 
            updateButton.BackColor = Color.FromArgb(255, 255, 128);
            updateButton.Location = new Point(78, 663);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(188, 58);
            updateButton.TabIndex = 2;
            updateButton.Text = "UPDATE";
            updateButton.UseVisualStyleBackColor = false;
            updateButton.Click += updateButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.BackColor = Color.Red;
            deleteButton.Location = new Point(78, 785);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(188, 58);
            deleteButton.TabIndex = 3;
            deleteButton.Text = "DELETE";
            deleteButton.UseVisualStyleBackColor = false;
            deleteButton.Click += deleteButton_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(352, 202);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 102;
            dataGridView1.Size = new Size(2100, 1065);
            dataGridView1.TabIndex = 4;
            // 
            // DashboardScreen
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2573, 1390);
            Controls.Add(dataGridView1);
            Controls.Add(deleteButton);
            Controls.Add(updateButton);
            Controls.Add(addButton);
            Controls.Add(label1);
            Name = "DashboardScreen";
            Text = "DashboardScreen";
            Load += DashboardScreen_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button addButton;
        private Button updateButton;
        private Button deleteButton;
        private DataGridView dataGridView1;
    }
}