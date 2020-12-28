using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureFileOrganizer
{
    public partial class FormMain : Form
    {
        private static Regex r = new Regex(":");

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
            var errorList = new List<string>();

            var fileList = directoryInfo.GetFiles("*.jpg", SearchOption.AllDirectories).ToList();
            fileList.AddRange(directoryInfo.GetFiles("*.jpeg", SearchOption.AllDirectories));
            fileList.AddRange(directoryInfo.GetFiles("*.png", SearchOption.AllDirectories));
            fileList.AddRange(directoryInfo.GetFiles("*.mp4", SearchOption.AllDirectories));
            fileList.AddRange(directoryInfo.GetFiles("*.mov", SearchOption.AllDirectories));

            fileList.ForEach(_ =>
            {
                var creation = GetDateTakenFromImage(_.FullName);
                if (creation == null) creation = File.GetLastWriteTime(_.FullName);
                //GetPathFromDestination(creation.Year, creation.Month);

                try
                {
                    var destination = Path.Combine(GetPathFromDestination(creation.Value.Year, creation.Value.Month).FullName, _.Name);
                    if (File.Exists(destination))
                    {
                        errorList.Add($"{_.FullName}: File Already Exists");
                    }
                    else
                    {
                        File.Move(_.FullName, destination);
                    }
                }
                catch (Exception exception)
                {
                    errorList.Add($"{_.FullName}: {exception.Message}");
                }

            });

            listBoxErrors.Items.AddRange(errorList.ToArray());
        }

        private DirectoryInfo GetPathFromDestination(int year, int month)
        {
            return Directory.CreateDirectory(Path.Combine(textBoxDestinationFolder.Text, $"{year}" , $"{year}.{month.ToString("00")}"));
        }


        public static DateTime? GetDateTakenFromImage(string path)
        {
            using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
                try
                {
                    using (Image myImage = Image.FromStream(fs, false, false))
                    {
                        PropertyItem propItem = myImage.GetPropertyItem(36867);
                        string dateTaken = r.Replace(Encoding.UTF8.GetString(propItem.Value), "-", 2);
                        return DateTime.Parse(dateTaken);
                    }
                }
                catch (Exception)
                {
                    return null;
                }
        }

    }
}
