using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Imaging;

namespace Basic_Image_Filter
{
    public partial class FormBIF : Form
    {
        string imageFile;
        Bitmap image;
        string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        public FormBIF()
        {
            InitializeComponent();
        }
        private string CallGuid()
        {
            return Guid.NewGuid().ToString();
        }
        private void buttonSelect_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.InitialDirectory = desktop;
            dialog.Title = "Select";
            dialog.Filter = "|*.jpg; *.jpeg; *.png; *.gif; *.bmp; *.heif; *.heic; *.tiff;";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imageFile = dialog.FileName;
                image = new Bitmap(imageFile);
                pictureBoxOriginal.Image = image;
            }
        }
        private void buttonFilter_Click(object sender, EventArgs e)
        {
            try
            {
                Bitmap imageR = new Bitmap(imageFile);
                Bitmap imageG = new Bitmap(imageFile);
                Bitmap imageB = new Bitmap(imageFile);
                Bitmap imageRG = new Bitmap(imageFile);
                Bitmap imageRB = new Bitmap(imageFile);
                Bitmap imageGB = new Bitmap(imageFile);
                Bitmap imageBlackWhite = new Bitmap(imageFile);

                int r, g, b, a, bw;

                Color pixel;

                int height = image.Height;
                int width = image.Width;

                for (int x = 0; x < width; x++)
                {
                    for (int y = 0; y < height; y++)
                    {
                        pixel = image.GetPixel(x, y);

                        r = pixel.R;
                        g = pixel.G;
                        b = pixel.B;
                        a = pixel.A;
                        bw = (r + g + b) / 3;

                        imageR.SetPixel(x, y, Color.FromArgb(a, r, 0, 0));
                        imageG.SetPixel(x, y, Color.FromArgb(a, 0, g, 0));
                        imageB.SetPixel(x, y, Color.FromArgb(a, 0, 0, b));
                        imageRG.SetPixel(x, y, Color.FromArgb(a, r, g, 0));
                        imageRB.SetPixel(x, y, Color.FromArgb(a, r, 0, b));
                        imageGB.SetPixel(x, y, Color.FromArgb(a, 0, g, b));
                        imageBlackWhite.SetPixel(x, y, Color.FromArgb(a, bw, bw, bw));
                    }
                }

                pictureBoxR.Image = imageR;
                pictureBoxG.Image = imageG;
                pictureBoxB.Image = imageB;
                pictureBoxRG.Image = imageRG;
                pictureBoxRB.Image = imageRB;
                pictureBoxGB.Image = imageGB;
                pictureBoxBlackWhite.Image = imageBlackWhite;
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("Select an image.");
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string path = desktop + "\\BIFimages\\";
            System.IO.Directory.CreateDirectory(path);

            try
            {
                pictureBoxOriginal.Image.Save(path + CallGuid() + ".jpg", ImageFormat.Jpeg);
                pictureBoxR.Image.Save(path + CallGuid() + ".jpg", ImageFormat.Jpeg);
                pictureBoxG.Image.Save(path + CallGuid() + ".jpg", ImageFormat.Jpeg);
                pictureBoxB.Image.Save(path + CallGuid() + ".jpg", ImageFormat.Jpeg);
                pictureBoxRG.Image.Save(path + CallGuid() + ".jpg", ImageFormat.Jpeg);
                pictureBoxRB.Image.Save(path + CallGuid() + ".jpg", ImageFormat.Jpeg);
                pictureBoxGB.Image.Save(path + CallGuid() + ".jpg", ImageFormat.Jpeg);
                pictureBoxBlackWhite.Image.Save(path + CallGuid() + ".jpg", ImageFormat.Jpeg);
                MessageBox.Show("Filtered images have been created in BIFimages folder in desktop");
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Select an image and/or use filter button.");
            }
        }
    }
}
