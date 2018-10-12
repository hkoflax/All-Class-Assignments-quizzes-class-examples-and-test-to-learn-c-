using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyPhotoLibrary;
using System.Drawing.Imaging;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                txtSource.Text = Path.GetDirectoryName(openFileDialog1.FileName);
            }else
            {
                txtSource.Text = "";
            }
        }

        private void Btnresize_Click(object sender, EventArgs e)
        {
            string directoryName;
            string[] listOfFiles;
            string[] listOfdirectories;
            directoryName = txtSource.Text;
            if (Directory.Exists(directoryName))
            {
                listOfFiles = Directory.GetFiles(directoryName);
                listOfdirectories = Directory.GetDirectories(directoryName);
                lblResult.Text = "In " + directoryName + " Folder";
                ResizeAll(listOfFiles);
                lblResult.Text = "Success";
                for (int i = 0; i < listOfdirectories.Length; i++)
                {
                    string[] fileList = Directory.GetFiles(listOfdirectories[i]);
                    lblResult.Text = "In " + listOfdirectories[i] + " Folder";
                    ResizeAll(fileList);
                    lblResult.BackColor = Color.LimeGreen;
                    lblResult.Text = "Success";
                }
            }
            else
            {
                lblResult.BackColor = Color.Red;
                lblResult.Text = "No Directory Entered";
            }
        }

        public void ResizeAll(string[] listOfFiles)
        {
            for (int x = 0; x < listOfFiles.Length; x++)
            {
                if (listOfFiles[x].Contains(".jpg") || listOfFiles[x].Contains(".JPG") || 
                    listOfFiles[x].Contains(".png") || listOfFiles[x].Contains(".PNG"))
                {
                    int imageheight = Convert.ToInt32(txtHeight.Text);
                    Image image = Image.FromFile(listOfFiles[x]);
                    using (var newImage = ScaleImage(image, imageheight))
                    {
                        image.Dispose();
                        File.Delete(listOfFiles[x]);
                        newImage.Save(listOfFiles[x], ImageFormat.Jpeg);
                        image.Dispose();
                    }
                }
            }
        }
        public Image ScaleImage(Image image, int maxHeight)
        {
            if (CbMaintainRatio.Checked == false)
            {
                int width = Convert.ToInt32(txtWidth.Text);
                int height = Convert.ToInt32(txtHeight.Text);
                var newImage = new Bitmap(width, height);

                using (var graphics = Graphics.FromImage(newImage)) graphics.DrawImage(image, 0, 0, width, height);

                return newImage;
            }
            else
            {
                Double ratio = (double)(image.Width) / (double)(image.Height);
                var newWidth = (int)(maxHeight * ratio);

                var newImage = new Bitmap(newWidth, maxHeight);

                using (var graphics = Graphics.FromImage(newImage)) graphics.DrawImage(image, 0, 0, newWidth, maxHeight);

                return newImage;
            }
        }

        private void CbMaintainRatio_CheckedChanged(object sender, EventArgs e)
        {
            if (CbMaintainRatio.Checked)
            {
                txtWidth.Enabled = false;
            }
            else
            {
                txtWidth.Enabled = true;
            }
        }
    }
}
