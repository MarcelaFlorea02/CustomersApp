namespace CustomersApp
{
    partial class UpdateScreen
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
            saveButton = new Button();
            phoneInput = new TextBox();
            emailInput = new TextBox();
            lastNameInput = new TextBox();
            firstNameInput = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // saveButton
            // 
            saveButton.BackColor = Color.FromArgb(192, 255, 192);
            saveButton.Location = new Point(486, 696);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(188, 58);
            saveButton.TabIndex = 19;
            saveButton.Text = "SAVE";
            saveButton.UseVisualStyleBackColor = false;
            // 
            // phoneInput
            // 
            phoneInput.Location = new Point(293, 558);
            phoneInput.Name = "phoneInput";
            phoneInput.Size = new Size(381, 47);
            phoneInput.TabIndex = 18;
            // 
            // emailInput
            // 
            emailInput.Location = new Point(293, 467);
            emailInput.Name = "emailInput";
            emailInput.Size = new Size(381, 47);
            emailInput.TabIndex = 17;
            // 
            // lastNameInput
            // 
            lastNameInput.Location = new Point(293, 356);
            lastNameInput.Name = "lastNameInput";
            lastNameInput.Size = new Size(381, 47);
            lastNameInput.TabIndex = 16;
            // 
            // firstNameInput
            // 
            firstNameInput.Location = new Point(293, 259);
            firstNameInput.Name = "firstNameInput";
            firstNameInput.Size = new Size(381, 47);
            firstNameInput.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(93, 558);
            label5.Name = "label5";
            label5.Size = new Size(103, 41);
            label5.TabIndex = 14;
            label5.Text = "Phone";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(93, 467);
            label4.Name = "label4";
            label4.Size = new Size(88, 41);
            label4.TabIndex = 13;
            label4.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(93, 356);
            label3.Name = "label3";
            label3.Size = new Size(157, 41);
            label3.TabIndex = 12;
            label3.Text = "Last Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(93, 259);
            label2.Name = "label2";
            label2.Size = new Size(160, 41);
            label2.TabIndex = 11;
            label2.Text = "First Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 15.9000006F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(93, 85);
            label1.Name = "label1";
            label1.Size = new Size(542, 67);
            label1.TabIndex = 10;
            label1.Text = "Update Customer";
            // 
            // UpdateScreen
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(774, 825);
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
            Name = "UpdateScreen";
            Text = "UpdateScreen";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button saveButton;
        private TextBox phoneInput;
        private TextBox emailInput;
        private TextBox lastNameInput;
        private TextBox firstNameInput;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}