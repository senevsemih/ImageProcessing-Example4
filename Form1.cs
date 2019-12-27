using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace görüntüIslemeO4
{
    public partial class Form1 : Form
    {
        Bitmap resim = new Bitmap(300, 300);
        Bitmap resim_grayScale = new Bitmap(300, 300);
        Bitmap resim_bitMap = new Bitmap(300, 300);
        Bitmap resim_erosion = new Bitmap(300, 300);


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(openFileDialog1.FileName);
            }
            Graphics.FromImage(resim).DrawImage(pictureBox1.Image, 0, 0, pictureBox1.Width, pictureBox1.Height);
            Graphics.FromImage(resim_grayScale).DrawImage(pictureBox1.Image, 0, 0, pictureBox1.Width, pictureBox1.Height);
            Graphics.FromImage(resim_bitMap).DrawImage(pictureBox1.Image, 0, 0, pictureBox1.Width, pictureBox1.Height);
            Graphics.FromImage(resim_erosion).DrawImage(pictureBox1.Image, 0, 0, pictureBox1.Width, pictureBox1.Height);
        }

        private void bnt_gray_Click(object sender, EventArgs e)
        {
            Color renk;
            int r, g, b;
            int gray;
            for (int x = 0; x < 300; x++)
            {
                for (int y = 0; y < 300; y++)
                {
                    renk = resim.GetPixel(x, y);
                    r = Convert.ToInt32(renk.R);
                    g = Convert.ToInt32(renk.G);
                    b = Convert.ToInt32(renk.B);

                    gray = (r + g + b) / 3;
                    resim_grayScale.SetPixel(x, y, Color.FromArgb(gray, gray, gray));
                }
                pictureBox1.Image = resim_grayScale;
                this.Refresh();
            }
        }

        private void btn_bitmap_Click(object sender, EventArgs e)
        {
            double bit = 0;
            for (int y = 0; y < resim_bitMap.Height; y++)
            {
                for (int x = 0; x < resim_bitMap.Width; x++)
                {
                    bit += resim_bitMap.GetPixel(x, y).GetBrightness();
                }
            }

            bit = bit / (resim_bitMap.Width * resim_bitMap.Height);
            bit = bit < .3 ? .3 : bit;
            bit = bit > .7 ? .7 : bit;

            for (int y = 0; y < resim_bitMap.Height; y++)
            {
                for (int x = 0; x < resim_bitMap.Width; x++)
                {
                    if (resim_bitMap.GetPixel(x, y).GetBrightness() > bit) resim_bitMap.SetPixel(x, y, Color.White);
                    else resim_bitMap.SetPixel(x, y, Color.Black);
                }
            }
            pictureBox1.Image = resim_bitMap;
            this.Refresh();
        }

        private void setpix1_Click(object sender, EventArgs e)
        {
            Color c;
            int r, g, b;
            int anti_renk;
            anti_renk = Convert.ToInt32(textBox1.Text);
            for (int i = 0; i < 300; i++)
            {
                for (int j = 0; j < 300; j++)
                {
                    c = resim_grayScale.GetPixel(i, j);
                    r = c.R + anti_renk;
                    if (r > 255) r = 255;
                    g = c.R + anti_renk;
                    if (g > 255) g = 255;
                    b = c.R + anti_renk;
                    if (b > 255) b = 255;
                    resim_grayScale.SetPixel(i, j, Color.FromArgb(r, g, b));

                }
            }
            pictureBox1.Image = resim_grayScale;
            this.Refresh();
        }

        private void setpix2_Click(object sender, EventArgs e)
        {
            Color c;
            int r, g, b;
            int anti_renk;
            anti_renk = Convert.ToInt32(textBox1.Text);
            for (int i = 0; i < 300; i++)
            {
                for (int j = 0; j < 300; j++)
                {
                    c = resim_grayScale.GetPixel(i, j);
                    r = c.R - anti_renk;
                    if (r < 0) r = 0;
                    g = c.R - anti_renk;
                    if (g < 0) g = 0;
                    b = c.R - anti_renk;
                    if (b < 0) b = 0;
                    resim_grayScale.SetPixel(i, j, Color.FromArgb(r, g, b));

                }
            }
            pictureBox1.Image = resim_grayScale;
            this.Refresh();
        }

        private void tersSim_Click(object sender, EventArgs e)
        {
            Color c;
            for (int i = 0; i < 300; i++)
            {
                for (int j = 0; j < 300; j++)
                {
                    c = resim_grayScale.GetPixel(i,j);
                    Color tmp = resim_grayScale.GetPixel(300 - i - 1, j);
                    resim_grayScale.SetPixel(i, j, tmp);
                    resim_grayScale.SetPixel(300 - i - 1, j, c);
                }
            }
            pictureBox1.Image = resim_grayScale;
            this.Refresh();
        }

        private void btn_erosion_Click(object sender, EventArgs e)
        {
            int x1, x2, x3;
            x1 = 255;
            x2 = 255; 
            x3 = 255;
            Color cl;
            int b1, b2, b3;
            for (int y = 1; y < 299 - 1; y++)
            {
                for (int x = 1; x < 299 - 1; x++)
                {
                    cl = resim_bitMap.GetPixel(x, y);
                    b1 = cl.R;
                    cl = resim_bitMap.GetPixel(x - 1, y);
                    b2 = cl.R;
                    cl = resim_bitMap.GetPixel(x + 1, y);
                    b3 = cl.R;
                    if (b1 == x1 && b2 == x2 && b3 == x3)
                    {
                        resim_erosion.SetPixel(x, y, Color.FromArgb(255, 255, 255));
                    }
                    else
                    {
                        resim_erosion.SetPixel(x, y, Color.FromArgb(0, 0, 0));
                    }

                }
            }
            pictureBox1.Image = resim_erosion;
            this.Refresh();

        }
    }
}
