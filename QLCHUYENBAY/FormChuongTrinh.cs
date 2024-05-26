using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCHUYENBAY
{
    public partial class FormChuongTrinh : Form
    {

        SqlConnection connection;
        SqlCommand command;
        string str = "Data Source=DESKTOP-P63LUAV;Initial Catalog=QLCHUYENBAY;Integrated Security=True;Encrypt=False";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        void loaddata()
        {
            command = connection.CreateCommand();//khởi tạo xử lý kết nối
            command.CommandText = "select * from Chuyen_Bay";
            adapter.SelectCommand = command;//thực thi câu truy vấn
            table.Clear();
            adapter.Fill(table);//truyền dữu liệu từ adater vào table
            dgv.DataSource = table;
        }

        public FormChuongTrinh()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void FormChuongTrinh_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);// truyền chuỗi kết nối vào
            connection.Open();
            loaddata();//gọi hàm load dữu liệu vào
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txb_MaChuyenBay.ReadOnly = true;
            int i;
            i = dgv.CurrentRow.Index;
            txb_MaChuyenBay.Text = dgv.Rows[i].Cells[0].Value.ToString();
            cbb_SanBayDi.Text = dgv.Rows[i].Cells[1].Value.ToString();
            cbb_SanBayDen.Text = dgv.Rows[i].Cells[2].Value.ToString();
            dtime_NgayBay.Text = dgv.Rows[i].Cells[3].Value.ToString();
            txb_ThoiGianBay.Text = dgv.Rows[i].Cells[4].Value.ToString();
            txb_SoGheVip.Text = dgv.Rows[i].Cells[5].Value.ToString();
            txb_SoGheThuong.Text = dgv.Rows[i].Cells[6].Value.ToString();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem các trường có trống không
            if (string.IsNullOrWhiteSpace(txb_MaChuyenBay.Text) ||
                string.IsNullOrWhiteSpace(cbb_SanBayDi.Text) ||
                string.IsNullOrWhiteSpace(cbb_SanBayDen.Text) ||
                string.IsNullOrWhiteSpace(dtime_NgayBay.Text) ||
                string.IsNullOrWhiteSpace(txb_ThoiGianBay.Text) ||
                string.IsNullOrWhiteSpace(txb_SoGheVip.Text) ||
                string.IsNullOrWhiteSpace(txb_SoGheThuong.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra định dạng ngày
            DateTime ngayBay;
            if (!DateTime.TryParse(dtime_NgayBay.Text, out ngayBay))
            {
                MessageBox.Show("Ngày bay không hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra rằng sân bay đi và sân bay đến không giống nhau
            if (cbb_SanBayDi.Text == cbb_SanBayDen.Text)
            {
                MessageBox.Show("Sân bay đi và sân bay đến không được giống nhau.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int soGheVip, soGheThuong;
            if (!int.TryParse(txb_SoGheVip.Text, out soGheVip) || soGheVip <= 0 ||
                !int.TryParse(txb_SoGheThuong.Text, out soGheThuong) || soGheThuong <= 0)
            {
                MessageBox.Show("Số ghế phải là số nguyên dương.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //Thực hiện thêm dữ liệu vào cơ sở dữ liệu nếu tất cả các trường đã được nhập
            command = connection.CreateCommand();
            command.CommandText = "insert into Chuyen_Bay values(N'" + txb_MaChuyenBay.Text + "', N'" + cbb_SanBayDi.Text + "', N'" + cbb_SanBayDen.Text + "', N'" + dtime_NgayBay.Text + "', N'" + txb_ThoiGianBay.Text + "', N'" + txb_SoGheVip.Text + "', N'" + txb_SoGheThuong.Text + "')";
            command.ExecuteNonQuery();
            loaddata();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "update Chuyen_Bay set SanBayDI = N'" + cbb_SanBayDi.Text+ "', SanBayDen = N'" + cbb_SanBayDen.Text + "', NgayBay = N'" + dtime_NgayBay.Text + "', ThoiGianBay = N'" + txb_ThoiGianBay.Text + "', SoGheVIP =  N'" + txb_SoGheVip.Text + "', SoGheThuong = N'" + txb_SoGheThuong.Text + "' where MaChuyenBay = N'" + txb_MaChuyenBay.Text + "' ";
            command.ExecuteNonQuery();
            loaddata();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "delete from Chuyen_Bay where MaChuyenBay = '" + txb_MaChuyenBay.Text + "'";
        }

        private void FormChuongTrinh_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
