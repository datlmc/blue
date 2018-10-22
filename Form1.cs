using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace giautintronganh
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image file(*.png,*.jpg)|*.png;*.jpg";
            openFileDialog.InitialDirectory = @"C:\Users\thanhdat\Dowloads";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxFilePath.Text = openFileDialog.FileName.ToString();
                pictureBox1.ImageLocation = textBoxFilePath.Text;
            }


        }

        private void buttonEncode_Click(object sender, EventArgs e)
        {
            Bitmap img = new Bitmap(textBoxFilePath.Text);
            for (int i = 0; i < img.Width; i++)
            {
                for (int j = 0; j < img.Height; j++)
                {
                    Color pixel = img.GetPixel(i, j);

                    if (i < 1 && j < 10)
                    {
                        Console.WriteLine("R=[" + i + "][" + j + "]=" + pixel.R);
                        Console.WriteLine("G=[" + i + "][" + j + "]=" +pixel.G);
                        Console.WriteLine("B=[" + i + "][" + j + "]="+pixel.B);
    
                        char letter = Convert.ToChar(textBoxMessage.Text.Substring(j, 1));
                        int value = Convert.ToInt32(letter);
                        Console.WriteLine("letter :" + letter +    "value :" + value );

                       img.SetPixel(i, j, Color.FromArgb(pixel.R, pixel.G, value));
                    }
                
                }
            }
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.Filter= "Image file(*.png,*.jpg)|*.png;*.jpg";
            savefile.InitialDirectory = @"C:\Users\thanhdat\Dowloads";

            if (savefile.ShowDialog() == DialogResult.OK)
            {
                textBoxFilePath.Text = savefile.FileName.ToString();
                pictureBox1.ImageLocation = textBoxFilePath.Text;
                img.Save(textBoxFilePath.Text);
                //xin chao tat ca moi nguoi
            }
            //wwwwwwwwwwwwwwwww
                
        }

      

        }
    }

