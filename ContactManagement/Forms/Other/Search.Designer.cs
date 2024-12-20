namespace ContactManagement.Forms.Other
{
    partial class Search
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
            idSearchTextBox = new TextBox();
            idSearchLabel = new Label();
            refSearchLabel = new Label();
            refSearchTextBox = new TextBox();
            taskSearchLabel = new Label();
            taskSearchTextBox = new TextBox();
            idSearchBtn = new Button();
            refSearchBtn = new Button();
            taskSearchBtn = new Button();
            label4 = new Label();
            SuspendLayout();
            // 
            // idSearchTextBox
            // 
            idSearchTextBox.Location = new Point(120, 47);
            idSearchTextBox.Name = "idSearchTextBox";
            idSearchTextBox.Size = new Size(188, 23);
            idSearchTextBox.TabIndex = 0;
            // 
            // idSearchLabel
            // 
            idSearchLabel.AutoSize = true;
            idSearchLabel.Location = new Point(12, 55);
            idSearchLabel.Name = "idSearchLabel";
            idSearchLabel.Size = new Size(56, 15);
            idSearchLabel.TabIndex = 1;
            idSearchLabel.Text = "ID Search";
            // 
            // refSearchLabel
            // 
            refSearchLabel.AutoSize = true;
            refSearchLabel.Location = new Point(12, 88);
            refSearchLabel.Name = "refSearchLabel";
            refSearchLabel.Size = new Size(97, 15);
            refSearchLabel.TabIndex = 2;
            refSearchLabel.Text = "Reference Search";
            // 
            // refSearchTextBox
            // 
            refSearchTextBox.Location = new Point(120, 80);
            refSearchTextBox.Name = "refSearchTextBox";
            refSearchTextBox.Size = new Size(188, 23);
            refSearchTextBox.TabIndex = 3;
            // 
            // taskSearchLabel
            // 
            taskSearchLabel.AutoSize = true;
            taskSearchLabel.Location = new Point(12, 120);
            taskSearchLabel.Name = "taskSearchLabel";
            taskSearchLabel.Size = new Size(67, 15);
            taskSearchLabel.TabIndex = 4;
            taskSearchLabel.Text = "Task Search";
            // 
            // taskSearchTextBox
            // 
            taskSearchTextBox.Location = new Point(120, 112);
            taskSearchTextBox.Name = "taskSearchTextBox";
            taskSearchTextBox.Size = new Size(188, 23);
            taskSearchTextBox.TabIndex = 5;
            // 
            // idSearchBtn
            // 
            idSearchBtn.Location = new Point(314, 46);
            idSearchBtn.Name = "idSearchBtn";
            idSearchBtn.Size = new Size(75, 23);
            idSearchBtn.TabIndex = 6;
            idSearchBtn.Text = "Search";
            idSearchBtn.UseVisualStyleBackColor = true;
            // 
            // refSearchBtn
            // 
            refSearchBtn.Location = new Point(314, 79);
            refSearchBtn.Name = "refSearchBtn";
            refSearchBtn.Size = new Size(75, 23);
            refSearchBtn.TabIndex = 7;
            refSearchBtn.Text = "Search";
            refSearchBtn.UseVisualStyleBackColor = true;
            refSearchBtn.Click += refSearchBtn_Click;
            // 
            // taskSearchBtn
            // 
            taskSearchBtn.Location = new Point(314, 112);
            taskSearchBtn.Name = "taskSearchBtn";
            taskSearchBtn.Size = new Size(75, 23);
            taskSearchBtn.TabIndex = 8;
            taskSearchBtn.Text = "Search";
            taskSearchBtn.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 9);
            label4.Name = "label4";
            label4.Size = new Size(69, 25);
            label4.TabIndex = 9;
            label4.Text = "Search";
            // 
            // Search
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 161);
            Controls.Add(label4);
            Controls.Add(taskSearchBtn);
            Controls.Add(refSearchBtn);
            Controls.Add(idSearchBtn);
            Controls.Add(taskSearchTextBox);
            Controls.Add(taskSearchLabel);
            Controls.Add(refSearchTextBox);
            Controls.Add(refSearchLabel);
            Controls.Add(idSearchLabel);
            Controls.Add(idSearchTextBox);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Search";
            Text = "Search";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox idSearchTextBox;
        private Label idSearchLabel;
        private Label refSearchLabel;
        private TextBox refSearchTextBox;
        private Label taskSearchLabel;
        private TextBox taskSearchTextBox;
        private Button idSearchBtn;
        private Button refSearchBtn;
        private Button taskSearchBtn;
        private Label label4;
    }
}