using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            panel3.Height = Bmenu.Height;
            menu1.BringToFront();
        }

        private void Balarms_Click(object sender, EventArgs e)
        {

            panel3.Top = Balarms.Top;
            panel3.Height = Balarms.Height;
            interface_alarms1.BringToFront();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Bmenu_Click(object sender, EventArgs e)
        {
            menu1.BringToFront();
            
            panel3.Height = Bmenu.Height;
            panel3.Top = Bmenu.Top;

        }

        private void Btransformer_Click(object sender, EventArgs e)
        {
            interface_transformer1.BringToFront();
            panel3.Height = Btransformer.Height;
            panel3.Top = Btransformer.Top;
        }

        private void Bdisconnector_Click(object sender, EventArgs e)
        {
            interface_disconnector1.BringToFront();
            panel3.Height = Bdisconnector.Height;
            panel3.Top = Bdisconnector.Top;
        }

        private void Bcircuitbreaker_Click(object sender, EventArgs e)
        {
            interface_circuit_breakers1.BringToFront();
            panel3.Height = Bcircuitbreaker.Height;
            panel3.Top = Bcircuitbreaker.Top;
        }
    }
}
