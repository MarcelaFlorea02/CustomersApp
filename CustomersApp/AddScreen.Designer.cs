namespace CustomersApp
{
    partial class AddScreen
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            firstNameInput = new TextBox();
            lastNameInput = new TextBox();
            emailInput = new TextBox();
            phoneInput = new TextBox();
            saveButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 15.9000006F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(23, 29);
            label1.Margin = new Padding(1, 0, 1, 0);
            label1.Name = "label1";
            label1.Size = new Size(323, 33);
            label1.TabIndex = 0;
            label1.Text = "Add a new Customer";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 103);
            label2.Margin = new Padding(1, 0, 1, 0);
            label2.Name = "label2";
            label2.Size = new Size(80, 20);
            label2.TabIndex = 1;
            label2.Text = "First Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 150);
            label3.Margin = new Padding(1, 0, 1, 0);
            label3.Name = "label3";
            label3.Size = new Size(79, 20);
            label3.TabIndex = 2;
            label3.Text = "Last Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 204);
            label4.Margin = new Padding(1, 0, 1, 0);
            label4.Name = "label4";
            label4.Size = new Size(46, 20);
            label4.TabIndex = 3;
            label4.Text = "Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 249);
            label5.Margin = new Padding(1, 0, 1, 0);
            label5.Name = "label5";
            label5.Size = new Size(50, 20);
            label5.TabIndex = 4;
            label5.Text = "Phone";
            // 
            // firstNameInput
            // 
            firstNameInput.Location = new Point(117, 103);
            firstNameInput.Margin = new Padding(1, 1, 1, 1);
            firstNameInput.Name = "firstNameInput";
            firstNameInput.Size = new Size(181, 27);
            firstNameInput.TabIndex = 5;
            // 
            // lastNameInput
            // 
            lastNameInput.Location = new Point(117, 150);
            lastNameInput.Margin = new Padding(1, 1, 1, 1);
            lastNameInput.Name = "lastNameInput";
            lastNameInput.Size = new Size(181, 27);
            lastNameInput.TabIndex = 6;
            // 
            // emailInput
            // 
            emailInput.Location = new Point(117, 204);
            emailInput.Margin = new Padding(1, 1, 1, 1);
            emailInput.Name = "emailInput";
            emailInput.Size = new Size(181, 27);
            emailInput.TabIndex = 7;
            // 
            // phoneInput
            // 
            phoneInput.Location = new Point(117, 249);
            phoneInput.Margin = new Padding(1, 1, 1, 1);
            phoneInput.Name = "phoneInput";
            phoneInput.Size = new Size(181, 27);
            phoneInput.TabIndex = 8;
            // 
            // saveButton
            // 
            saveButton.BackColor = Color.FromArgb(192, 255, 192);
            saveButton.Location = new Point(208, 316);
            saveButton.Margin = new Padding(1, 1, 1, 1);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(88, 28);
            saveButton.TabIndex = 9;
            saveButton.Text = "SAVE";
            saveButton.UseVisualStyleBackColor = false;
            saveButton.Click += saveButton_Click;
            // 
            // AddScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(340, 374);
            Controls.Add(saveButton);
            Controls.Add(phoneInput);
            Controls.Add(emailInput);
            Controls.Add(lastNameInput);
            Controls.Add(firstNameInput);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(1, 1, 1, 1);
            Name = "AddScreen";
            Text = "AddScreen";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox firstNameInput;
        private TextBox lastNameInput;
        private TextBox emailInput;
        private TextBox phoneInput;
        private Button saveButton;
    }
}