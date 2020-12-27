
namespace PictureFileOrganizer
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonSortFiles = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.textBoxSourceFolder = new System.Windows.Forms.TextBox();
            this.buttonGetSourceFolder = new System.Windows.Forms.Button();
            this.buttonGetDestinationFolder = new System.Windows.Forms.Button();
            this.textBoxDestinationFolder = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonSortFiles
            // 
            this.buttonSortFiles.Location = new System.Drawing.Point(167, 166);
            this.buttonSortFiles.Name = "buttonSortFiles";
            this.buttonSortFiles.Size = new System.Drawing.Size(327, 59);
            this.buttonSortFiles.TabIndex = 0;
            this.buttonSortFiles.Text = "Sort";
            this.buttonSortFiles.UseVisualStyleBackColor = true;
            this.buttonSortFiles.Click += new System.EventHandler(this.buttonSortFiles_Click);
            // 
            // textBoxSourceFolder
            // 
            this.textBoxSourceFolder.Location = new System.Drawing.Point(102, 72);
            this.textBoxSourceFolder.Name = "textBoxSourceFolder";
            this.textBoxSourceFolder.Size = new System.Drawing.Size(443, 23);
            this.textBoxSourceFolder.TabIndex = 1;
            // 
            // buttonGetSourceFolder
            // 
            this.buttonGetSourceFolder.Location = new System.Drawing.Point(552, 72);
            this.buttonGetSourceFolder.Name = "buttonGetSourceFolder";
            this.buttonGetSourceFolder.Size = new System.Drawing.Size(30, 23);
            this.buttonGetSourceFolder.TabIndex = 2;
            this.buttonGetSourceFolder.Text = "...";
            this.buttonGetSourceFolder.UseVisualStyleBackColor = true;
            this.buttonGetSourceFolder.Click += new System.EventHandler(this.buttonGetSourceFolder_Click);
            // 
            // buttonGetDestinationFolder
            // 
            this.buttonGetDestinationFolder.Location = new System.Drawing.Point(552, 101);
            this.buttonGetDestinationFolder.Name = "buttonGetDestinationFolder";
            this.buttonGetDestinationFolder.Size = new System.Drawing.Size(30, 23);
            this.buttonGetDestinationFolder.TabIndex = 4;
            this.buttonGetDestinationFolder.Text = "...";
            this.buttonGetDestinationFolder.UseVisualStyleBackColor = true;
            this.buttonGetDestinationFolder.Click += new System.EventHandler(this.buttonGetDestinationFolder_Click);
            // 
            // textBoxDestinationFolder
            // 
            this.textBoxDestinationFolder.Location = new System.Drawing.Point(102, 101);
            this.textBoxDestinationFolder.Name = "textBoxDestinationFolder";
            this.textBoxDestinationFolder.Size = new System.Drawing.Size(443, 23);
            this.textBoxDestinationFolder.TabIndex = 3;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonGetDestinationFolder);
            this.Controls.Add(this.textBoxDestinationFolder);
            this.Controls.Add(this.buttonGetSourceFolder);
            this.Controls.Add(this.textBoxSourceFolder);
            this.Controls.Add(this.buttonSortFiles);
            this.Name = "FormMain";
            this.Text = "Let\'s Sort Some Photos :)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSortFiles;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox textBoxSourceFolder;
        private System.Windows.Forms.Button buttonGetSourceFolder;
        private System.Windows.Forms.Button buttonGetDestinationFolder;
        private System.Windows.Forms.TextBox textBoxDestinationFolder;
    }
}

