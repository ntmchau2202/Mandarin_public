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
    public partial class BeginGame : Form
    {
        public BeginGame()
        {
            InitializeComponent();
        }

        private void BeginGame_Load(object sender, EventArgs e)
        {
        }

        private void Start_lb_MouseEnter(object sender, EventArgs e)
        {
            Start_lb.Font = new Font(Start_lb.Font.Name, 26, FontStyle.Bold);
        }

        private void Start_lb_MouseLeave(object sender, EventArgs e)
        {
            Start_lb.Font = new Font(Start_lb.Font.Name, 24, FontStyle.Regular);
        }

        private void Instruction_lb_MouseEnter(object sender, EventArgs e)
        {
            Instruction_lb.Font = new Font(Instruction_lb.Font.Name, 25, FontStyle.Bold);
        }

        private void Instruction_lb_MouseLeave(object sender, EventArgs e)
        {
            Instruction_lb.Font = new Font(Instruction_lb.Font.Name, 24, FontStyle.Regular);
        }

        private void Exit_lb_MouseEnter(object sender, EventArgs e)
        {
            Exit_lb.Font = new Font(Exit_lb.Font.Name, 26, FontStyle.Bold);
        }

        private void Exit_lb_MouseLeave(object sender, EventArgs e)
        {
            Exit_lb.Font = new Font(Exit_lb.Font.Name, 24, FontStyle.Regular); 
        }

        private void Start_lb_MouseClick(object sender, MouseEventArgs e)
        {
            MainGame maingame = new MainGame();
            maingame.Show();
            this.Hide();
        }

        private void Exit_lb_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Instruction_lb_Click(object sender, EventArgs e)
        {
           MessageBox.Show("This is an instruction for the game blablabla","Instructions");
        }

        private void Start_lb_Click(object sender, EventArgs e)
        {
            MainGame main = new MainGame();
            main.Show();
            this.Hide();
        }

        /* prototype hàm xử lý ảnh sỏi
         * Note: mỗi một ô ảnh sẽ đi kèm 1 ô số lượng sỏi
         * 
         * Hàm phụ phải (int vt) (truyền vào vị trí hiện tại)
         *      nếu (nút == phải)
         *          temp = số sỏi hiện tại;
         *          số sỏi hiện tại = 0;
         *          xoá hình ảnh trong ô sỏi;
         *          for (i= temp; i>0; i--)
         *              vt++;
         *              if (vt==-1) vt = 11;
         *              ô [vt] ++;
         *          for (i= temp; i>0; i--)
         *              vẽ ảnh tay (đè lên ảnh sỏi cũ);
         *              xoá ảnh tay;
         *              switch(sỏi): vẽ ảnh sỏi mới theo từng trường hợp số sỏi còn lại (0-7);
         *          
         * Hàm phụ trái (int vt) (tương tự) 
         * 
         * Switch case
         *  case: ô 1:
         *      if (nút == trái) 
         *          hàm phụ trái;
         *      else if (nút == phải)
         *          hàm phụ phải;
         *          break;
         *  tương tự cho 4 ô còn lại;
         *      
         * */

        /* prototype hàm xử lý cờ đánh dấu
         * 
         * cờ (int gamer)
         *      if (gamer = người)
         *          humanflag.Visible = true;
         *          comflag.Visible = false;
         *      if (gamer = máy)
         *          humanflag.Visible = false;
         *          comflag.Visible = true;
         */
    }
}
