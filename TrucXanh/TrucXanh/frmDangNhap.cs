using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TrucXanh
{
    public partial class frmDangNhap : Form
    {
        static string user, pass;

        static int KiemTraDangNhap(string user, string pass)
        {
            int rt = 0;
            string strsql = "sp_KiemTraTonTai";

            Provider p = new Provider();
            p.Connect();

            SqlParameter kq = new SqlParameter("@kq", SqlDbType.Int);
            kq.Direction = ParameterDirection.ReturnValue;

            p.ExecuteNonQuery(CommandType.StoredProcedure, strsql,
                new SqlParameter { ParameterName = "@user", Value = user },
                new SqlParameter { ParameterName = "@pass", Value = pass }, kq); 

            if (int.Parse(kq.Value.ToString()) == 1)
                rt = 1;

            p.Disconnect();

            return rt;
        }

        static int GetScore(string user)
        {
            string strsql = "sp_GetScore";

            Provider p = new Provider();
            p.Connect();

            SqlParameter kq = new SqlParameter("@kq", SqlDbType.Int);
            kq.Direction = ParameterDirection.ReturnValue;

            p.ExecuteNonQuery(CommandType.StoredProcedure, strsql,
                new SqlParameter { ParameterName = "@user", Value = user }, kq);

            int diem = int.Parse(kq.Value.ToString());

            p.Disconnect();

            return diem;
        }

        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            lblError.Visible = false;
            user = txtUser.Text.ToString();
            pass = txtPass.Text.ToString();

            if (string.IsNullOrEmpty(user) || string.IsNullOrEmpty(pass))
            {
                MessageBox.Show("Không được để trống các trường");
            }
            else
            {
                int check = KiemTraDangNhap(user, pass);
                if (check == 0)
                {
                    lblError.Visible = true;
                }
                else
                {
                    frmTrucXanh tx = new frmTrucXanh(GetScore(user), user);
                    tx.ShowDialog();
                }
            }
        }

        private void lblDangKy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmDangKy frm = new frmDangKy();
            frm.ShowDialog();
        }

        private void lblGuest_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmTrucXanh trx = new frmTrucXanh();
            trx.Show();
        }


    }
}
