using ContactManagement.Forms.Other;
using ContactManagerLibrary.Class;
using ContactManagerLibrary.Services.Interfaces;
using PdfiumViewer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactManagement
{
    public partial class Main : Form
    {
        private readonly IDataCollector _dataCollector;
        internal List<CustomerAddress> addresses;

        private bool isZoomModeActive = false;

        public Main(IDataCollector dataCollector)
        {
            _dataCollector = dataCollector;

            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        internal void LoadFormIntoDetailsPanel(Form form)
        {
            detailsPanel.Controls.Clear();

            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;

            detailsPanel.Controls.Add(form);

            detailsPanel.Visible = true;
            form.Show();
        }

        internal void LoadFormIntoOtherPanel(Form form)
        {
            otherPanel.Controls.Clear();

            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;

            otherPanel.Controls.Add(form);

            otherPanel.Visible = true;
            form.Show();
        }

        // =================================
        // Menustrip Buttons
        // =================================

        private void newMailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            actionPanel.Visible = false;
            otherPanel.Visible = true;
            workQueuePanel.Visible = false;

            var newMailForm = new NewMail(this);

            LoadFormIntoOtherPanel(newMailForm);
        }

        // =================================
        // Main Toolstrip Buttons
        // =================================

        private void searchToolStripButton_Click(object sender, EventArgs e)
        {
            actionPanel.Visible = false;
            otherPanel.Visible = true;
            workQueuePanel.Visible = false;

            var searchForm = new Search(_dataCollector, this);

            LoadFormIntoOtherPanel(searchForm);
        }

        // =================================
        // Document Viewer Toolstrip Buttons
        // =================================

        private void zoomOutToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void zoomInToolStripButton_Click(object sender, EventArgs e)
        {
            // Toggle zoom mode on or off
            isZoomModeActive = !isZoomModeActive;

            // Update the cursor based on zoom mode status
            viewFilePanel.Cursor = isZoomModeActive ? Cursors.Cross : Cursors.Default;
        }

        private void ViewPanel_MouseClick(object sender, MouseEventArgs e)
        {
            // Check if zoom mode is active
            if (!isZoomModeActive) return;

            // Find the PdfViewer within the viewFilePanel
            var pdfViewer = viewFilePanel.Controls.OfType<PdfViewer>().FirstOrDefault();
            if (pdfViewer == null) return;

            // Ensure the click is within the PdfViewer bounds
            Point clickLocation = viewFilePanel.PointToClient(Cursor.Position);
            if (!pdfViewer.Bounds.Contains(clickLocation)) return;

            // Perform zoom in or zoom out based on the mouse button
            if (e.Button == MouseButtons.Left)
            {
                // Zoom in
                pdfViewer.Renderer.Zoom += 0.1f; // Increase zoom by 10%
            }
            else if (e.Button == MouseButtons.Right)
            {
                // Zoom out
                if (pdfViewer.Renderer.Zoom > 0.1f) // Prevent zooming out too far
                {
                    pdfViewer.Renderer.Zoom -= 0.1f; // Decrease zoom by 10%
                }
            }
        }
    }
}