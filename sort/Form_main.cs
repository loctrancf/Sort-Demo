using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace sort
{
    public partial class Form_main : Form
    {
        public Thread t1;
        public static Button[] node1;   // Biến minh họa mảng
        public static int so_phan_tu;   // Số phần tử của mảng
        public static Label[] chiSo;   // Chỉ số vị trí của mảng
        public static int[] a;         // Mảng a
        int toc_Do = 4;                  // Tốc độ, tối đa 10 cấp
        Boolean tang = true;     // Kiểu sắp xếp
        Boolean da_Tao_Mang = false;
        Boolean da_Tao_GT = false;
        Boolean ktTam_dung = false;     //Biến kiểm tra tạm dừng
        Boolean sap_Xep_Tung_Buoc = true;        // Biến kiểm tra sắp xếp từng bước hay nhanh
        List_Code list_Code = new List_Code();       // Code C/C++ cho thuật toán
        int i;    // Biến này dùng nhiều
        bool is_run = false;
        // Các biến thiết lập cho node
        int khoang_Cach;            // Khoảng cách hai node
        int kich_Thuoc;             // Kích thước node
        int co_Chu;                 // Cỡ chữ node
        int le_Node;                // Căn lề node
        int le_tren;                // Lề trên cho node
        public Form_main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnTao_Click(object sender, EventArgs e)
        {
            lbl_bienj.Visible = false;
            lbl_bieni.Visible = false;
            lbl_bienx.Visible = false;
            da_Tao_GT = false;
            if (da_Tao_Mang)
                xoa_Mang(node1);
            lbl_code.ResetText();
            nmrSophantu.Focus();
            try
            {
                so_phan_tu = Convert.ToInt32(nmrSophantu.Value);
            }
            catch
            {
                MessageBox.Show("Số phần tử vừa nhập vào không hợp lệ!");
                nmrSophantu.Value = 8;
                return;
            }
            a = new int[so_phan_tu];
            tao_Mang(150, Properties.Resources.Image_nut);
        }

        //tạo mảng
        public void tao_Mang(int kc, System.Drawing.Image img_nen)
        {
            if (so_phan_tu < 2 || so_phan_tu > 15)
            {
                MessageBox.Show(" Số phần tử >1 và <=15");
                da_Tao_Mang = false;
                nmrSophantu.Value = 5;   // Mặc định cho nó bằng 5 cho đẹp
                return;
            }
            kich_Thuoc = 70;
            co_Chu = 15;
            khoang_Cach = 25;
            le_Node = (1350 - kich_Thuoc * so_phan_tu - khoang_Cach * (so_phan_tu - 1)) / 2;

            // KHởi tạo mảng node
            node1 = new Button[so_phan_tu];
            chiSo = new Label[so_phan_tu];
            lbl_Index.Visible = true;
            lbl_MangA.Visible = true;
            for (int i = 0; i < so_phan_tu; i++)
            {
                node1[i] = new Button();
                node1[i].Text = a[i].ToString();
                node1[i].TextAlign = ContentAlignment.MiddleCenter;
                node1[i].Width = kich_Thuoc;
                node1[i].Height = kich_Thuoc;
                node1[i].Location = new Point(le_Node + (kich_Thuoc + khoang_Cach) * i, kc);
                node1[i].ForeColor = Color.Black;
                node1[i].Font = new Font(this.Font, FontStyle.Bold);
                node1[i].Font = new System.Drawing.Font("Arial", co_Chu, FontStyle.Bold);
                node1[i].FlatStyle = FlatStyle.Flat;
                node1[i].BackgroundImage = img_nen;
                node1[i].BackgroundImageLayout = ImageLayout.Stretch;
                node1[i].FlatAppearance.BorderSize = 0;
                this.Controls.Add(node1[i]);

                // Tạo nhãn chỉ sổ
                chiSo[i] = new Label();
                chiSo[i].TextAlign = ContentAlignment.MiddleCenter;
                chiSo[i].Text = i.ToString();
                chiSo[i].Width = kich_Thuoc;
                chiSo[i].Height = kich_Thuoc;
                chiSo[i].ForeColor = Color.Black;

                chiSo[i].Location = new Point(le_Node + (kich_Thuoc + khoang_Cach) * i, 270 + khoang_Cach * 3);
                chiSo[i].Font = new System.Drawing.Font("Arial", co_Chu - 4, FontStyle.Bold);
                this.Controls.Add(chiSo[i]);
            }
            da_Tao_Mang = true; //Xác nhận đã tạo mảng                                        
            btn_Nhaptay.Enabled = true; //Cho phép các nút điều khiển có tác dụng khi đã tạo mảng
            btn_Random.Enabled = true;
            btn_Docfile.Enabled = true;

            rad_Bubble.Enabled = true;
            rad_Insertion.Enabled = true;
            rad_Merge.Enabled = true;
            rad_Quick.Enabled = true;
            rad_Heap.Enabled = true;
            rad_Selection.Enabled = true;

            rad_Tang.Enabled = true;
            rad_Giam.Enabled = true;

            lbl_code.Visible = true;
            lbl_code.Text = "Đã tạo mảng";
        }

        //Xóa mảng
        public void xoa_Mang(Button[] Node)
        {
            Application.DoEvents();
            this.Invoke((MethodInvoker)delegate
            {
                btn_Nhaptay.Enabled = false;
                btn_Random.Enabled = false;
                btn_start.Enabled = false;
                btn_Docfile.Enabled = false;
                if (da_Tao_Mang == true)
                {
                    for (i = 0; i < so_phan_tu; i++)
                    {
                        this.Controls.Remove(Node[i]);
                        this.Controls.Remove(chiSo[i]);

                    }
                    da_Tao_Mang = false;
                    lbl_MangA.Visible = false;
                    lbl_Index.Visible = false;
                }
            });

        }

        //reset node về 0
        public void reset_node()
        {
            for (int i = 0; i < so_phan_tu; i++)
            {
                a[i] = 0;
                node1[i].Text = a[i].ToString();
            }
        }
            
        private void grbDieukhien_Enter(object sender, EventArgs e)
        {

        }

        private void nmrSophantu_ValueChanged(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            MessageBox.Show("Tốc độ:" + Zoomcode.Value.ToString());
        }

        private void lbListCode_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblTaogt_Click(object sender, EventArgs e)
        {

        }

        private void chkChaytungbuoc_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lblIndex_Click(object sender, EventArgs e)
        {

        }

        private void Form_main_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult Result = MessageBox.Show(
                "Bạn có chắc muốn thoát??? :((",
                "Thông báo",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (Result == DialogResult.Yes)
            {
                e.Cancel = false;
                MessageBox.Show(
                "Cảm ơn bạn đã dùng phần mềm!! :))");
            }
            else
                e.Cancel = true;
                
        }
    }
}
