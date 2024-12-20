namespace ContactManagement
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            newMailToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            viewToolStripMenuItem = new ToolStripMenuItem();
            searchToolStripMenuItem = new ToolStripMenuItem();
            sLATaskSearchToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            incomingToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            workQueueToolStripMenuItem = new ToolStripMenuItem();
            complaintsToolStripMenuItem = new ToolStripMenuItem();
            adminToolStripMenuItem = new ToolStripMenuItem();
            addUserToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            createTaskToolStripMenuItem = new ToolStripMenuItem();
            createCategoryToolStripMenuItem = new ToolStripMenuItem();
            createQueueToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator4 = new ToolStripSeparator();
            settingsToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            detailsPanel = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            label2 = new Label();
            viewFilePanel = new Panel();
            toolStrip2 = new ToolStrip();
            zoomOutToolStripButton = new ToolStripButton();
            zoomInToolStripButton = new ToolStripButton();
            strecthToolStripButton = new ToolStripButton();
            panel4 = new Panel();
            label3 = new Label();
            toolStrip1 = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            toolStripButton2 = new ToolStripButton();
            searchToolStripButton = new ToolStripButton();
            panel5 = new Panel();
            label4 = new Label();
            actionPanel = new Panel();
            workQueuePanel = new Panel();
            otherPanel = new Panel();
            menuStrip1.SuspendLayout();
            detailsPanel.SuspendLayout();
            panel2.SuspendLayout();
            viewFilePanel.SuspendLayout();
            toolStrip2.SuspendLayout();
            panel4.SuspendLayout();
            toolStrip1.SuspendLayout();
            panel5.SuspendLayout();
            actionPanel.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, viewToolStripMenuItem, adminToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1184, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newMailToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // newMailToolStripMenuItem
            // 
            newMailToolStripMenuItem.Name = "newMailToolStripMenuItem";
            newMailToolStripMenuItem.Size = new Size(178, 22);
            newMailToolStripMenuItem.Text = "New Incoming Mail";
            newMailToolStripMenuItem.Click += newMailToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(39, 20);
            editToolStripMenuItem.Text = "Edit";
            // 
            // viewToolStripMenuItem
            // 
            viewToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { searchToolStripMenuItem, sLATaskSearchToolStripMenuItem, toolStripSeparator1, incomingToolStripMenuItem, toolStripSeparator3, workQueueToolStripMenuItem, complaintsToolStripMenuItem });
            viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            viewToolStripMenuItem.Size = new Size(44, 20);
            viewToolStripMenuItem.Text = "View";
            // 
            // searchToolStripMenuItem
            // 
            searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            searchToolStripMenuItem.Size = new Size(170, 22);
            searchToolStripMenuItem.Text = "Search";
            // 
            // sLATaskSearchToolStripMenuItem
            // 
            sLATaskSearchToolStripMenuItem.Name = "sLATaskSearchToolStripMenuItem";
            sLATaskSearchToolStripMenuItem.Size = new Size(170, 22);
            sLATaskSearchToolStripMenuItem.Text = "Task Search";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(167, 6);
            // 
            // incomingToolStripMenuItem
            // 
            incomingToolStripMenuItem.Name = "incomingToolStripMenuItem";
            incomingToolStripMenuItem.Size = new Size(170, 22);
            incomingToolStripMenuItem.Text = "Incoming Contact";
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(167, 6);
            // 
            // workQueueToolStripMenuItem
            // 
            workQueueToolStripMenuItem.Name = "workQueueToolStripMenuItem";
            workQueueToolStripMenuItem.Size = new Size(170, 22);
            workQueueToolStripMenuItem.Text = "Work Queue";
            // 
            // complaintsToolStripMenuItem
            // 
            complaintsToolStripMenuItem.Name = "complaintsToolStripMenuItem";
            complaintsToolStripMenuItem.Size = new Size(170, 22);
            complaintsToolStripMenuItem.Text = "Complaints";
            // 
            // adminToolStripMenuItem
            // 
            adminToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addUserToolStripMenuItem, toolStripSeparator2, createTaskToolStripMenuItem, createCategoryToolStripMenuItem, createQueueToolStripMenuItem, toolStripSeparator4, settingsToolStripMenuItem });
            adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            adminToolStripMenuItem.Size = new Size(55, 20);
            adminToolStripMenuItem.Text = "Admin";
            // 
            // addUserToolStripMenuItem
            // 
            addUserToolStripMenuItem.Name = "addUserToolStripMenuItem";
            addUserToolStripMenuItem.Size = new Size(159, 22);
            addUserToolStripMenuItem.Text = "Add User";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(156, 6);
            // 
            // createTaskToolStripMenuItem
            // 
            createTaskToolStripMenuItem.Name = "createTaskToolStripMenuItem";
            createTaskToolStripMenuItem.Size = new Size(159, 22);
            createTaskToolStripMenuItem.Text = "Create Task";
            // 
            // createCategoryToolStripMenuItem
            // 
            createCategoryToolStripMenuItem.Name = "createCategoryToolStripMenuItem";
            createCategoryToolStripMenuItem.Size = new Size(159, 22);
            createCategoryToolStripMenuItem.Text = "Create Category";
            // 
            // createQueueToolStripMenuItem
            // 
            createQueueToolStripMenuItem.Name = "createQueueToolStripMenuItem";
            createQueueToolStripMenuItem.Size = new Size(159, 22);
            createQueueToolStripMenuItem.Text = "Create Queue";
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(156, 6);
            // 
            // settingsToolStripMenuItem
            // 
            settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            settingsToolStripMenuItem.Size = new Size(159, 22);
            settingsToolStripMenuItem.Text = "Settings";
            // 
            // statusStrip1
            // 
            statusStrip1.Location = new Point(0, 639);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1184, 22);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // detailsPanel
            // 
            detailsPanel.Controls.Add(label1);
            detailsPanel.Location = new Point(0, 103);
            detailsPanel.Name = "detailsPanel";
            detailsPanel.Size = new Size(581, 343);
            detailsPanel.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 9);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 0;
            label1.Text = "Details";
            // 
            // panel2
            // 
            panel2.Controls.Add(label2);
            panel2.Location = new Point(0, 452);
            panel2.Name = "panel2";
            panel2.Size = new Size(581, 93);
            panel2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 13);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 0;
            label2.Text = "Work Tasks";
            // 
            // viewFilePanel
            // 
            viewFilePanel.Controls.Add(toolStrip2);
            viewFilePanel.Dock = DockStyle.Right;
            viewFilePanel.Location = new Point(584, 24);
            viewFilePanel.Name = "viewFilePanel";
            viewFilePanel.Size = new Size(600, 615);
            viewFilePanel.TabIndex = 4;
            viewFilePanel.MouseClick += ViewPanel_MouseClick;
            // 
            // toolStrip2
            // 
            toolStrip2.BackColor = SystemColors.InactiveBorder;
            toolStrip2.Items.AddRange(new ToolStripItem[] { zoomOutToolStripButton, zoomInToolStripButton, strecthToolStripButton });
            toolStrip2.Location = new Point(0, 0);
            toolStrip2.Name = "toolStrip2";
            toolStrip2.Size = new Size(600, 25);
            toolStrip2.TabIndex = 0;
            toolStrip2.Text = "toolStrip2";
            // 
            // zoomOutToolStripButton
            // 
            zoomOutToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            zoomOutToolStripButton.Image = (Image)resources.GetObject("zoomOutToolStripButton.Image");
            zoomOutToolStripButton.ImageTransparentColor = Color.Magenta;
            zoomOutToolStripButton.Name = "zoomOutToolStripButton";
            zoomOutToolStripButton.Size = new Size(23, 22);
            zoomOutToolStripButton.Text = "toolStripButton3";
            zoomOutToolStripButton.Click += zoomOutToolStripButton_Click;
            // 
            // zoomInToolStripButton
            // 
            zoomInToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            zoomInToolStripButton.Image = (Image)resources.GetObject("zoomInToolStripButton.Image");
            zoomInToolStripButton.ImageTransparentColor = Color.Magenta;
            zoomInToolStripButton.Name = "zoomInToolStripButton";
            zoomInToolStripButton.Size = new Size(23, 22);
            zoomInToolStripButton.Text = "toolStripButton4";
            zoomInToolStripButton.Click += zoomInToolStripButton_Click;
            // 
            // strecthToolStripButton
            // 
            strecthToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            strecthToolStripButton.Image = (Image)resources.GetObject("strecthToolStripButton.Image");
            strecthToolStripButton.ImageTransparentColor = Color.Magenta;
            strecthToolStripButton.Name = "strecthToolStripButton";
            strecthToolStripButton.Size = new Size(23, 22);
            strecthToolStripButton.Text = "toolStripButton5";
            // 
            // panel4
            // 
            panel4.Controls.Add(label3);
            panel4.Location = new Point(0, 551);
            panel4.Name = "panel4";
            panel4.Size = new Size(581, 83);
            panel4.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 25);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 0;
            label3.Text = "Actions";
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1, toolStripButton2, searchToolStripButton });
            toolStrip1.Location = new Point(0, 24);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(584, 25);
            toolStrip1.TabIndex = 5;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(67, 22);
            toolStripButton1.Text = "Backwards";
            // 
            // toolStripButton2
            // 
            toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton2.Image = (Image)resources.GetObject("toolStripButton2.Image");
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(54, 22);
            toolStripButton2.Text = "Forward";
            // 
            // searchToolStripButton
            // 
            searchToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            searchToolStripButton.Image = (Image)resources.GetObject("searchToolStripButton.Image");
            searchToolStripButton.ImageTransparentColor = Color.Magenta;
            searchToolStripButton.Name = "searchToolStripButton";
            searchToolStripButton.Size = new Size(46, 22);
            searchToolStripButton.Text = "Search";
            searchToolStripButton.Click += searchToolStripButton_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(label4);
            panel5.Location = new Point(3, 56);
            panel5.Name = "panel5";
            panel5.Size = new Size(578, 41);
            panel5.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 11);
            label4.Name = "label4";
            label4.Size = new Size(306, 15);
            label4.TabIndex = 0;
            label4.Text = "Alerts, SLA/Unaction Correspondence/Complaints/Verify";
            // 
            // actionPanel
            // 
            actionPanel.Controls.Add(panel5);
            actionPanel.Controls.Add(detailsPanel);
            actionPanel.Controls.Add(panel4);
            actionPanel.Controls.Add(panel2);
            actionPanel.Dock = DockStyle.Fill;
            actionPanel.Location = new Point(0, 0);
            actionPanel.Name = "actionPanel";
            actionPanel.Size = new Size(1184, 661);
            actionPanel.TabIndex = 6;
            // 
            // workQueuePanel
            // 
            workQueuePanel.Dock = DockStyle.Fill;
            workQueuePanel.Location = new Point(0, 0);
            workQueuePanel.Name = "workQueuePanel";
            workQueuePanel.Size = new Size(1184, 661);
            workQueuePanel.TabIndex = 7;
            workQueuePanel.Visible = false;
            // 
            // otherPanel
            // 
            otherPanel.Dock = DockStyle.Fill;
            otherPanel.Location = new Point(0, 0);
            otherPanel.Name = "otherPanel";
            otherPanel.Size = new Size(1184, 661);
            otherPanel.TabIndex = 8;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 661);
            Controls.Add(toolStrip1);
            Controls.Add(viewFilePanel);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            Controls.Add(actionPanel);
            Controls.Add(otherPanel);
            Controls.Add(workQueuePanel);
            MainMenuStrip = menuStrip1;
            Name = "Main";
            Text = "Form2";
            Load += Form2_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            detailsPanel.ResumeLayout(false);
            detailsPanel.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            viewFilePanel.ResumeLayout(false);
            viewFilePanel.PerformLayout();
            toolStrip2.ResumeLayout(false);
            toolStrip2.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            actionPanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private StatusStrip statusStrip1;
        private Panel panel4;
        private Label label1;
        private Label label2;
        private Label label3;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem viewToolStripMenuItem;
        private ToolStrip toolStrip1;
        private ToolStripMenuItem searchToolStripMenuItem;
        private ToolStripMenuItem sLATaskSearchToolStripMenuItem;
        private ToolStrip toolStrip2;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem incomingToolStripMenuItem;
        private ToolStripMenuItem adminToolStripMenuItem;
        private ToolStripMenuItem addUserToolStripMenuItem;
        private ToolStripButton toolStripButton1;
        private ToolStripMenuItem newMailToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem createTaskToolStripMenuItem;
        private ToolStripMenuItem createCategoryToolStripMenuItem;
        private ToolStripButton toolStripButton2;
        private ToolStripButton searchToolStripButton;
        private Label label4;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem workQueueToolStripMenuItem;
        private ToolStripMenuItem createQueueToolStripMenuItem;
        private ToolStripMenuItem complaintsToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripMenuItem settingsToolStripMenuItem;
        public Panel actionPanel;
        public Panel workQueuePanel;
        public Panel otherPanel;
        public Panel detailsPanel;
        public Panel panel2;
        public Panel panel5;
        public Panel viewFilePanel;
        private ToolStripButton zoomOutToolStripButton;
        private ToolStripButton zoomInToolStripButton;
        private ToolStripButton strecthToolStripButton;
    }
}