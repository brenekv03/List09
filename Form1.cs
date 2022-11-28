using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace List09
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Bitmap> seznamObrazku = new List<Bitmap>();
        int index;
        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            //ověřit že tam jsou stale obrazky
            int pocet = imageList1.Images.Count-1;
            index = random.Next(0, pocet);
            if (pocet >= 0)
            {
                for(int i =0;i< pocet; i++)
                {
                    pictureBox1.Image = seznamObrazku[index];
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Projít kolekci v imageList1 a obrázky přidat do ListObrazku
            foreach(Bitmap obrazek in imageList1.Images)
            {
                seznamObrazku.Add(obrazek);
            }

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            //smazat obrázek v picture box(null)
            seznamObrazku.Remove(seznamObrazku[index]);
            pictureBox1.Image = null;
            //smazat obrázek v seznamObrazku
        }
    }
}
