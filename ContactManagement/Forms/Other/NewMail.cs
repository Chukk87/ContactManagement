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
using PdfiumViewer;

namespace ContactManagement.Forms.Other
{
    public partial class NewMail : Form
    {
        private Main _mainForm;

        public NewMail(Main mainForm)
        {
            _mainForm = mainForm;

            InitializeComponent();
        }

        private void getCorrespondenceButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "All Files (*.*)|*.*";
                openFileDialog.Title = "Select Files";
                openFileDialog.Multiselect = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Get the selected files
                    string[] selectedFiles = openFileDialog.FileNames;

                    //Validate the extension is all the same
                    string commonExtension = Path.GetExtension(selectedFiles[0]).ToLower();
                    bool allSameExtension = selectedFiles.All(file => Path.GetExtension(file).ToLower() == commonExtension);

                    foreach (Control control in _mainForm.viewFilePanel.Controls)
                    {
                        if (control is PdfViewer)
                        {
                            control.Dispose(); // Dispose of the old PdfViewer
                        }
                    }

                    foreach (string file in selectedFiles)
                    {
                        //Add documents to screen
                        PdfViewer pdfViewer = new PdfViewer();
                        pdfViewer.Dock = DockStyle.Fill;  // Fill the panel with the PDF viewer
                        pdfViewer.MouseClick += PdfViewer_MouseClick;
                        _mainForm.viewFilePanel.Controls.Add(pdfViewer);  // Add PdfViewer to the panel

                        // Load the selected PDF file
                        pdfViewer.Document = PdfDocument.Load(file);

                        Console.WriteLine($"Selected file: {file}");
                    }
                }
            }
        }

        private void PdfViewer_MouseClick(object sender, MouseEventArgs e)
        {
            if (sender is PdfViewer pdfViewer)
            {
                if (e.Button == MouseButtons.Left)
                {
                    pdfViewer.Renderer.Zoom += 0.1f; // Zoom in
                    Console.WriteLine($"Zoom in: {pdfViewer.Renderer.Zoom}");
                }
                else if (e.Button == MouseButtons.Right)
                {
                    if (pdfViewer.Renderer.Zoom > 0.1f)
                    {
                        pdfViewer.Renderer.Zoom -= 0.1f; // Zoom out
                        Console.WriteLine($"Zoom out: {pdfViewer.Renderer.Zoom}");
                    }
                }
            }
        }

        private void createTaskButton_Click(object sender, EventArgs e)
        {

        }
    }
}