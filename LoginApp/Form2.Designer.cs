namespace AddressBookApp
{
    partial class Form2
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox nameTextBox;
        private TextBox emailTextBox;
        private TextBox phoneTextBox;
        private Button saveButton;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.nameTextBox = new TextBox();
            this.emailTextBox = new TextBox();
            this.phoneTextBox = new TextBox();
            this.saveButton = new Button();
            this.SuspendLayout();
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(12, 12);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(260, 20);
            this.nameTextBox.TabIndex = 0;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(12, 38);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(260, 20);
            this.emailTextBox.TabIndex = 1;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Location = new System.Drawing.Point(12, 64);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(260, 20);
            this.phoneTextBox.TabIndex = 2;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(197, 90);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 3;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 125);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Name = "Form2";
            this.Text = "Address Book";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
