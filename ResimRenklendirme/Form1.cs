using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Imaging.Filters;
namespace ResimRenklendirme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Image srcimg;
        private void pictureBox1_Click(object sender, EventArgs e)
        {
             srcimg = System.Drawing.Image.FromFile("Gül.png");//Burada Debug Klasörümüzün İçine Gül Resmi Koyduk ve çağırıyoruz Form Açıldığında PictureBox1'e bir kere Tıklamamız Yetiyor
             pictureBox1.Image = srcimg;
        }



        private void pictureBox2_Click(object sender, EventArgs e)
        {
           // GrayscaleBT709 gr = new GrayscaleBT709();
          //  pictureBox2.Image = gr.Apply((Bitmap)srcimg);

            //Sepia sp = new Sepia();
           // pictureBox2.Image = sp.Apply((Bitmap)srcimg);

            //HueModifier hue = new HueModifier();
            //pictureBox2.Image = hue.Apply((Bitmap)srcimg);                SIRAYLA DENEYEBİLİRSİN

            


            RotateChannels rt = new RotateChannels();
            pictureBox2.Image = rt.Apply((Bitmap)srcimg);
            
        }
    }
}
