using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KalkulatorKrokow
{
    public partial class Form1 : Form
    {
        Farmer farmer;

        public Form1()
        {
            InitializeComponent();
            farmer = new Farmer() { NumberOfCows = 15 };
        }

        private void numericUpDown1_ValueChanged_1(object sender, EventArgs e)
        {
            farmer.NumberOfCows = (int)numericUpDown1.Value;
        }



        private void calculate_Click_1(object sender, EventArgs e)
        {
            Console.WriteLine("Potrzebuję {0} worków paszy do wykarmienia {1} krów!", farmer.BagsOfFeed, farmer.NumberOfCows);
            
        }

        
    }

}
