using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mandarin
{
    public partial class MainGame : Form
    {

        BeginGame begingame = new BeginGame();
        public MainGame(BeginGame form1)
        {
            InitializeComponent();
            begingame = form1;
        }

        public MainGame()
        {
            InitializeComponent();
        }

        private void MainGame_Load(object sender, MouseEventArgs e)
        {

        }

        private void Start_lb_MouseClick(object sender, MouseEventArgs e)
        {
            begingame.Show();
            this.Close();
        }


        private void quan25_MouseEnter(object sender, EventArgs e)
        {
            
            //left.Image = Image.FromFile(@"C:\Users\Minh Chau\OneDrive\Desktop\Mandarin\images\arrowleft.png");
            //right.Image = Image.FromFile(@"C:\Users\Minh Chau\OneDrive\Desktop\Mandarin\images\arrowright.png");
            //left.Show();
            //right.Show();
        }

        private void quan25_MouseLeave(object sender, EventArgs e)
        {
            //left.Visible = false;
            //right.Visible = false;
        }

        private void quan25_MouseClick(object sender, MouseEventArgs e)
        {

        }
    }
}
