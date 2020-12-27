using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureFileOrganizer
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonGetSourceFolder_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            textBoxSourceFolder.Text = folderBrowserDialog1.SelectedPath;
        }

        private void buttonGetDestinationFolder_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            textBoxDestinationFolder.Text = folderBrowserDialog1.SelectedPath;
        }

        private void buttonSortFiles_Click(object sender, EventArgs e)
        {
            var directoryInfo = new DirectoryInfo(textBoxSourceFolder.Text);

            var fileList = directoryInfo.GetFiles("*.jpg").ToList();

            fileList.ForEach(_ =>
            {
                var creation = File.GetCreationTime(_.FullName);
                //GetPathFromDestination(creation.Year.ToString(), creation.Month.ToString());
                File.Move(_.FullName, Path.Combine(GetPathFromDestination(creation.Year.ToString(), creation.Month.ToString()).FullName, _.Name));

            });
        }

        private DirectoryInfo GetPathFromDestination(string year, string month)
        {
            return Directory.CreateDirectory(Path.Combine(textBoxDestinationFolder.Text, year, month));
        }

    }
}
