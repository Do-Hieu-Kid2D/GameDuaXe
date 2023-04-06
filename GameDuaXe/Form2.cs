using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GameDuaXe
{   
  
    public partial class ChaoMung : Form
    {
        public static Form1 fo;
      public ChaoMung()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
             fo = new Form1();
             this.Hide();
             fo.Show();
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {   
            DialogResult luaCHon = MessageBox.Show("Bạn Muốn thoát?","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if(luaCHon == DialogResult.Yes) {
                this.Close();
            }
            else
            {
                return;
            }
            
        }
    }
}
