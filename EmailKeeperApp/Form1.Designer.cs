namespace EmailKeeperApp
{
    partial class Form1
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
            this.emailToAddTextBox = new System.Windows.Forms.TextBox();
            this.emailToSearchTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.addedEmailListBox = new System.Windows.Forms.ListBox();
            this.searchEmailListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // emailToAddTextBox
            // 
            this.emailToAddTextBox.Location = new System.Drawing.Point(133, 34);
            this.emailToAddTextBox.Name = "emailToAddTextBox";
            this.emailToAddTextBox.Size = new System.Drawing.Size(163, 20);
            this.emailToAddTextBox.TabIndex = 0;
            // 
            // emailToSearchTextBox
            // 
            this.emailToSearchTextBox.Location = new System.Drawing.Point(461, 34);
            this.emailToSearchTextBox.Name = "emailToSearchTextBox";
            this.emailToSearchTextBox.Size = new System.Drawing.Size(137, 20);
            this.emailToSearchTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Email to Add";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(347, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Email To Search";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(221, 75);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 4;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(523, 75);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 5;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // addedEmailListBox
            // 
            this.addedEmailListBox.FormattingEnabled = true;
            this.addedEmailListBox.Location = new System.Drawing.Point(169, 129);
            this.addedEmailListBox.Name = "addedEmailListBox";
            this.addedEmailListBox.Size = new System.Drawing.Size(127, 173);
            this.addedEmailListBox.TabIndex = 6;
            // 
            // searchEmailListBox
            // 
            this.searchEmailListBox.FormattingEnabled = true;
            this.searchEmailListBox.Location = new System.Drawing.Point(469, 129);
            this.searchEmailListBox.Name = "searchEmailListBox";
            this.searchEmailListBox.Size = new System.Drawing.Size(129, 173);
            this.searchEmailListBox.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 428);
            this.Controls.Add(this.searchEmailListBox);
            this.Controls.Add(this.addedEmailListBox);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.emailToSearchTextBox);
            this.Controls.Add(this.emailToAddTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox emailToAddTextBox;
        private System.Windows.Forms.TextBox emailToSearchTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.ListBox addedEmailListBox;
        private System.Windows.Forms.ListBox searchEmailListBox;
    }
}

