using System;
<<<<<<< HEAD
using System.Drawing;
=======
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
>>>>>>> old-project/Thuan1
using System.Windows.Forms;

namespace GUI_QuanLy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
<<<<<<< HEAD
            LoadHomePage();
        }

        private void LoadHomePage()
        {
            HomePage homePage = new HomePage();
            LoadFormIntoPanel(homePage);
        }
=======
        }


>>>>>>> old-project/Thuan1

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
<<<<<<< HEAD

        public void LoadFormIntoPanel(Form childForm)
        {
            // Xóa các control hiện tại trong panel
            panelAll.Controls.Clear();

            // Thiết lập form con
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            panelAll.Controls.Add(childForm);
            childForm.Show();
        }

        
    }
}
=======
    }
}
>>>>>>> old-project/Thuan1
