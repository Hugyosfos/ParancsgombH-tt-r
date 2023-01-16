using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParancsgombHáttér
{
    public partial class Form1 : Form
    {
        int sorokSzama = 3;
        int oszlopokSzama = 6;
        int kepSize = 60;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < sorokSzama; i++)
            {
                for (int j = 0; j < oszlopokSzama; j++)
                {
                    PictureBox kep = new PictureBox();
                    kep.SetBounds(j * kepSize, i * kepSize, kepSize, kepSize);
                    kep.Text = (i * oszlopokSzama + j.ToString());
                    kep.BackColor = Color.Black;
                    kep.Click += (o, ev) =>
                    {
                        PictureBox pic = (PictureBox)o;
                        pic.BackgroundImage = Properties.Resources.FMoHrRcX0AE5L4n;
                        pic.BackgroundImageLayout = ImageLayout.Zoom;
                    };
                    Tároló.Controls.Add(kep);
                }
            }
        }
    }
}
