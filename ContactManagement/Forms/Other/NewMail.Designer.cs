namespace ContactManagement.Forms.Other
{
    partial class NewMail
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
            correspondenceTextBox = new TextBox();
            getCorrespondenceButton = new Button();
            label1 = new Label();
            taskTypeComboBox = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            referenceIdTextBox = new TextBox();
            createTaskButton = new Button();
            SuspendLayout();
            // 
            // correspondenceTextBox
            // 
            correspondenceTextBox.Location = new Point(110, 50);
            correspondenceTextBox.Name = "correspondenceTextBox";
            correspondenceTextBox.Size = new Size(419, 23);
            correspondenceTextBox.TabIndex = 0;
            // 
            // getCorrespondenceButton
            // 
            getCorrespondenceButton.Location = new Point(535, 50);
            getCorrespondenceButton.Name = "getCorrespondenceButton";
            getCorrespondenceButton.Size = new Size(35, 23);
            getCorrespondenceButton.TabIndex = 1;
            getCorrespondenceButton.Text = "Get";
            getCorrespondenceButton.UseVisualStyleBackColor = true;
            getCorrespondenceButton.Click += getCorrespondenceButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 54);
            label1.Name = "label1";
            label1.Size = new Size(94, 15);
            label1.TabIndex = 2;
            label1.Text = "Correspondence";
            // 
            // taskTypeComboBox
            // 
            taskTypeComboBox.FormattingEnabled = true;
            taskTypeComboBox.Location = new Point(110, 112);
            taskTypeComboBox.Name = "taskTypeComboBox";
            taskTypeComboBox.Size = new Size(196, 23);
            taskTypeComboBox.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 115);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 4;
            label2.Text = "Task Type";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 86);
            label3.Name = "label3";
            label3.Size = new Size(73, 15);
            label3.TabIndex = 5;
            label3.Text = "Reference ID";
            // 
            // referenceIdTextBox
            // 
            referenceIdTextBox.Location = new Point(110, 83);
            referenceIdTextBox.Name = "referenceIdTextBox";
            referenceIdTextBox.Size = new Size(196, 23);
            referenceIdTextBox.TabIndex = 6;
            // 
            // createTaskButton
            // 
            createTaskButton.Location = new Point(495, 140);
            createTaskButton.Name = "createTaskButton";
            createTaskButton.Size = new Size(75, 23);
            createTaskButton.TabIndex = 7;
            createTaskButton.Text = "Create Task";
            createTaskButton.UseVisualStyleBackColor = true;
            createTaskButton.Click += createTaskButton_Click;
            // 
            // NewMail
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 198);
            Controls.Add(createTaskButton);
            Controls.Add(referenceIdTextBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(taskTypeComboBox);
            Controls.Add(label1);
            Controls.Add(getCorrespondenceButton);
            Controls.Add(correspondenceTextBox);
            Name = "NewMail";
            Text = "NewMail";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox correspondenceTextBox;
        private Button getCorrespondenceButton;
        private Label label1;
        private ComboBox taskTypeComboBox;
        private Label label2;
        private Label label3;
        private TextBox referenceIdTextBox;
        private Button createTaskButton;
    }
}