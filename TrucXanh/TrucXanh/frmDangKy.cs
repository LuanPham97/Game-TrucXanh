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

namespace TrucXanh
{
    public partial class frmDangKy : Form
    {
        static string user;

        /// <summary>
        /// kiểm tra tồn tại username
        /// </summary>
        /// <param name="user"></param>
        /// <returns>nếu tồn tại return 1</returns>
        static int KiemTraUser(string user)
        {
            int rt = 0;
            string strsql = "sp_KiemTraTonTai";

            Provider p = new Provider();
            p.Connect();

            SqlParameter kq = new SqlParameter("@kq", SqlDbType.Int);
            kq.Direction = ParameterDirection.ReturnValue;

            p.ExecuteNonQuery(CommandType.StoredProcedure, strsql,
                new SqlParameter { ParameterName = "@user", Value = user },
                new SqlParameter { ParameterName = "@pass", Value = "" }, kq);

            int t = int.Parse(kq.Value.ToString());

            if (t == 0 || t==1)
                rt = 1;

            p.Disconnect();

            return rt;
        }

        static void ThemUserVaoDB(string user, string pass)
        {
            int diem = 100;
            string strsql = string.Format("insert into Account values('{0}', '{1}', {2})", user, pass, diem);

            Provider prov = new Provider();
            prov.Connect();

            prov.ExecuteNonQuery(CommandType.Text, strsql);

            prov.Disconnect();
        }

        public frmDangKy()
        {
            InitializeComponent();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            lblUserError.Visible = false;
            lblPassError.Visible = false;
            if (string.IsNullOrEmpty(txtUser.Text) || string.IsNullOrEmpty(txtPass.Text) || string.IsNullOrEmpty(txtRePass.Text))
            {
                MessageBox.Show("Không được để trống các trường");
            }
            else
            {
                user = txtUser.Text.ToString();

                if (KiemTraUser(user) == 1)
                {
                    lblUserError.Visible = true;
                }
                else
                {
                    if (txtPass.Text != txtRePass.Text)
                    {
                        lblPassError.Visible = true;
                    }
                    else
                    {
                        ThemUserVaoDB(user, txtPass.Text.ToString());
                        MessageBox.Show("Đăng ký thành công!!!");
                        this.Close();
                    }
                }
            }
        }


    }
}
