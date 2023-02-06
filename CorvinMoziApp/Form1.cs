using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CorvinMoziApp
{
    public partial class Form1 : Form
    {
        Mozi Mozi=new Mozi(@"CorvinMozi.csv");
        int semmi = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Terem_Load(object sender, EventArgs e)
        {
            PanelUpdate();
        }
        void PanelUpdate()
        {
            this.Text = Mozi.termek[semmi].Nev + " lakópark";
        }
        private void jobb_Click(object sender, EventArgs e)
        {

        }
        private void baloldal_Click(object sender, EventArgs e)
        {

        }
    }
}
