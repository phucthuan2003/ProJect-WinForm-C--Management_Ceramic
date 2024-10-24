using System;
<<<<<<< HEAD
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
=======
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;
>>>>>>> old-project/Thuan1

namespace GUI_QuanLy
{
    public partial class SidebarControl : UserControl
    {
        private Timer timerSanPham;
        private Timer timerHoaDon;
        private Timer timerNhanSu;
        private bool menuSanPhamExpand = false;
        private bool menuHoaDonExpand = false;
        private bool menuNhanSuExpand = false;
<<<<<<< HEAD

        public SidebarControl()
        {
            InitializeComponent();
            InitializeTimers();
            ResetMenuHeights();
            resetButton();
        }

        private void SidebarControl_Load(object sender, EventArgs e)
        {
            ResetMenuHeights();
        }

        private void InitializeTimers()
        {
            timerSanPham = new Timer { Interval = 10 };
            timerHoaDon = new Timer { Interval = 10 };
            timerNhanSu = new Timer { Interval = 10 };
            timerSanPham.Tick += timerSanPham_Tick;
            timerHoaDon.Tick += timerHoaDon_Tick;
            timerNhanSu.Tick += timerNhanSu_Tick;
        }

        private void ResetMenuHeights()
        {
            panelSP.Height = 38;
            panelHoaDon.Height = 38;
            panelNhanSu.Height = 38;
            menuSanPhamExpand = false;
            menuHoaDonExpand = false;
            menuNhanSuExpand = false;
        }

        private void timerSanPham_Tick(object sender, EventArgs e)
        {
            ToggleMenu(timerSanPham, panelSP, ref menuSanPhamExpand, 160, 38, MoveButtons1, 110);
        }

        private void timerHoaDon_Tick(object sender, EventArgs e)
        {
            ToggleMenu(timerHoaDon, panelHoaDon, ref menuHoaDonExpand, 120, 38, MoveButtons, 80);
        }

        private void timerNhanSu_Tick(object sender, EventArgs e)
        {
            ToggleMenu(timerNhanSu, panelNhanSu, ref menuNhanSuExpand, 160, 38, MoveButtons2, 110);
        }

        private void ToggleMenu(Timer timer, Panel panel, ref bool isExpanded, int expandedHeight, int collapsedHeight, Action<int> moveButtons, int offsetY)
        {
            int expandSpeed = 10;

            if (!isExpanded)
            {
                if (panel.Height < expandedHeight)
                {
                    panel.Height += expandSpeed;
                    if (panel.Height >= expandedHeight)
                    {
                        panel.Height = expandedHeight;
                        timer.Stop();
                        isExpanded = true;
                        moveButtons(offsetY);
                    }
                }
            }
            else
            {
                if (panel.Height > collapsedHeight)
                {
                    panel.Height -= expandSpeed;
                    if (panel.Height <= collapsedHeight)
                    {
                        panel.Height = collapsedHeight;
                        timer.Stop();
                        isExpanded = false;
                        moveButtons(-offsetY);
                    }
                }
            }
        }


        private void btnSanPham_Click(object sender, EventArgs e)
        {
            timerSanPham.Start();
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            timerHoaDon.Start();
        }

        private void btnNhanSu_Click(object sender, EventArgs e)
        {
            timerNhanSu.Start();
        }

        private void btnThongTin_Click(object sender, EventArgs e)
        {
            LoadForm(new InfoProduct());
        }

        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            LoadForm(new HomePage());
        }
        private void btnTraCuu_Click(object sender, EventArgs e)
        {
            LoadForm(new Lookup());
        }
        private void btnDanhMuc_Click(object sender, EventArgs e)
        {
            LoadForm(new Category());
        }
        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            LoadForm(new TkKhach());
        }
        private void btnDanhSach_Click(object sender, EventArgs e)
        {
            LoadForm(new TKNhanVien());
        }
        private void btnLuong_Click(object sender, EventArgs e)
        {
            LoadForm(new LuongNV());
        }
        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {
            LoadForm(new TaiKhoan());
        }

        private void btnNhaCungCap_Click(object sender, EventArgs e)
        {
            LoadForm(new TKNhaCC());
        }
        private void LoadForm(Form childForm)
        {
            Form1 parentForm = (Form1)this.FindForm();
            if (parentForm != null)
            {
                parentForm.LoadFormIntoPanel(childForm);
            }
        }


        private void MoveButtons(int offsetY)
        {
            AdjustButtonPositions(offsetY, btnKhachHang, panelNhanSu, btnNhaCungCap, btnThongKe, picTK, picKH, picNCC, btnThoat);
        }

        private void MoveButtons1(int offsetY)
        {
            AdjustButtonPositions(offsetY, panelHoaDon, btnKhachHang, panelNhanSu, btnNhaCungCap, btnThongKe, picTK, picKH, picNCC, btnThoat);
        }

        private void MoveButtons2(int offsetY)
        {
            AdjustButtonPositions(offsetY, btnNhaCungCap, picNCC, btnThongKe, picTK, btnThoat);
        }

        private void AdjustButtonPositions(int offsetY, params Control[] controls)
        {
            foreach (var control in controls)
            {
                control.Location = new Point(control.Location.X, control.Location.Y + offsetY);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void resetButton()
        {
=======
        public SidebarControl()
        {
            InitializeComponent();
>>>>>>> old-project/Thuan1
            btnTrangChu.Refresh();
            btnNhanSu.Refresh();
            btnSanPham.Refresh();
            btnThongTin.Refresh();
            btnDanhMuc.Refresh();
            btnTraCuu.Refresh();
            btnHoaDon.Refresh();
            btnNhaCungCap.Refresh();
            btnKhachHang.Refresh();
            btnHoaDonBan.Refresh();
            btnHoaDonNhap.Refresh();
            btnLuong.Refresh();
            btnDanhSach.Refresh();
            btnTaiKhoan.Refresh();
            btnThongKe.Refresh();
<<<<<<< HEAD
        }

       
    }
}
=======
            timerSanPham = new Timer();
            timerSanPham.Interval = 10;
            timerHoaDon = new Timer();
            timerHoaDon.Interval = 10;
            timerNhanSu = new Timer();
            timerNhanSu.Interval = 10;
            timerSanPham.Tick += new EventHandler(timerSanPham_Tick);
            timerHoaDon.Tick += new EventHandler(timerHoaDon_Tick);
            timerNhanSu.Tick += new EventHandler(timerNhanSu_Tick);
        }
        private void SidebarControl_Load(object sender, EventArgs e)
        {
            panelSP.Height = 38;
            panelHoaDon.Height = 38;
            panelNhanSu.Height = 38;
            menuSanPhamExpand = false;
            menuHoaDonExpand = false;
            menuNhanSuExpand = false;
        }
        private void timerSanPham_Tick(object sender, EventArgs e)
            {
                int expandSpeed = 10;
                int menuExpandedHeight = 160;
                int panelHoaDonollapsedHeight = 38;

                if (!menuSanPhamExpand)
                {
                    if (panelSP.Height < menuExpandedHeight)
                    {
                        panelSP.Height += expandSpeed;
                        if (panelSP.Height >= menuExpandedHeight)
                        {
                            panelSP.Height = menuExpandedHeight;
                            timerSanPham.Stop();
                            menuSanPhamExpand = true;
                        MoveButtons1(110);
                    }
                }
                }
                else
                {
                    if (panelSP.Height > panelHoaDonollapsedHeight)
                    {
                        panelSP.Height -= expandSpeed;
                        if (panelSP.Height <= panelHoaDonollapsedHeight)
                        {
                            panelSP.Height = panelHoaDonollapsedHeight;
                            timerSanPham.Stop();
                            menuSanPhamExpand = false;
                        MoveButtons1(-110);
                    }
                }
                }
            }

        private void timerHoaDon_Tick(object sender, EventArgs e)
        {
            int expandSpeed = 10;
            int menuExpandedHeight = 120;
            int panelHoaDonollapsedHeight = 38;

            if (!menuHoaDonExpand)
            {
                if (panelHoaDon.Height < menuExpandedHeight)
                {
                    panelHoaDon.Height += expandSpeed;
                    if (panelHoaDon.Height >= menuExpandedHeight)
                    {
                        panelHoaDon.Height = menuExpandedHeight;
                        timerHoaDon.Stop();
                        menuHoaDonExpand = true;
                        MoveButtons(80);
                    }
                }
            }
            else
            {
                if (panelHoaDon.Height > panelHoaDonollapsedHeight)
                {
                    panelHoaDon.Height -= expandSpeed;
                    if (panelHoaDon.Height <= panelHoaDonollapsedHeight)
                    {
                        panelHoaDon.Height = panelHoaDonollapsedHeight;
                        timerHoaDon.Stop();
                        menuHoaDonExpand = false;
                        MoveButtons(-80);
                    }
                }
            }
        }
        private void timerNhanSu_Tick(object sender, EventArgs e)
        {
            int expandSpeed = 10;
            int menuExpandedHeight = 160;
            int panelHoaDonollapsedHeight = 38;

            if (!menuNhanSuExpand)
            {
                if (panelNhanSu.Height < menuExpandedHeight)
                {
                    panelNhanSu.Height += expandSpeed;
                    if (panelNhanSu.Height >= menuExpandedHeight)
                    {
                        panelNhanSu.Height = menuExpandedHeight;
                        timerNhanSu.Stop();
                        menuNhanSuExpand = true;
                        MoveButtons2(110);
                    }
                }
            }
            else
            {
                if (panelNhanSu.Height > panelHoaDonollapsedHeight)
                {
                    panelNhanSu.Height -= expandSpeed;
                    if (panelNhanSu.Height <= panelHoaDonollapsedHeight)
                    {
                        panelNhanSu.Height = panelHoaDonollapsedHeight;
                        timerNhanSu.Stop();
                        menuNhanSuExpand = false;
                        MoveButtons2(-110);
                    }
                }
            }
        }

        private void btnSanPham_Click(object sender, EventArgs e)
            {
                timerSanPham.Start();
            }

            private void btnHoaDon_Click(object sender, EventArgs e)
            {
                timerHoaDon.Start();
            }
           private void btnNhanSu_Click(object sender, EventArgs e)
           {
            timerNhanSu.Start();
           }
        private void MoveButtons(int offsetY)
        {
            btnKhachHang.Location = new Point(btnKhachHang.Location.X, btnKhachHang.Location.Y + offsetY);
            panelNhanSu.Location = new Point(panelNhanSu.Location.X, panelNhanSu.Location.Y + offsetY);
            btnNhaCungCap.Location = new Point(btnNhaCungCap.Location.X, btnNhaCungCap.Location.Y + offsetY);
            btnThongKe.Location = new Point(btnThongKe.Location.X, btnThongKe.Location.Y + offsetY);
            picTK.Location = new Point(picTK.Location.X, picTK.Location.Y + offsetY);
            picKH.Location = new Point(picKH.Location.X, picKH.Location.Y + offsetY);
            picNCC.Location = new Point(picNCC.Location.X, picNCC.Location.Y + offsetY);
            btnThoat.Location = new Point(btnThoat.Location.X, btnThoat.Location.Y + offsetY);

        }
        private void MoveButtons1(int offsetY)
        {
            panelHoaDon.Location = new Point(panelHoaDon.Location.X, panelHoaDon.Location.Y + offsetY);
            btnKhachHang.Location = new Point(btnKhachHang.Location.X, btnKhachHang.Location.Y + offsetY);
            panelNhanSu.Location = new Point(panelNhanSu.Location.X, panelNhanSu.Location.Y + offsetY);
            btnNhaCungCap.Location = new Point(btnNhaCungCap.Location.X, btnNhaCungCap.Location.Y + offsetY);
            btnThongKe.Location = new Point(btnThongKe.Location.X, btnThongKe.Location.Y + offsetY);
            picTK.Location = new Point(picTK.Location.X, picTK.Location.Y + offsetY);
            picKH.Location = new Point(picKH.Location.X, picKH.Location.Y + offsetY);
            btnThoat.Location = new Point(btnThoat.Location.X, btnThoat.Location.Y + offsetY);
            picNCC.Location = new Point(picNCC.Location.X, picNCC.Location.Y + offsetY);
        }
        private void MoveButtons2(int offsetY)
        {
            btnNhaCungCap.Location = new Point(btnNhaCungCap.Location.X, btnNhaCungCap.Location.Y + offsetY);
            picNCC.Location = new Point(picNCC.Location.X, picNCC.Location.Y + offsetY);
            btnThongKe.Location = new Point(btnThongKe.Location.X, btnThongKe.Location.Y + offsetY);
            picTK.Location = new Point(picTK.Location.X,picTK.Location.Y + offsetY);
            btnThoat.Location = new Point(btnThoat.Location.X, btnThoat.Location.Y + offsetY);
        }
    }
    }

>>>>>>> old-project/Thuan1
