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
    public partial class frmTrucXanh : Form
    {
        static void CapNhatDiemKhiWin(int diem, string user)
        {
            string strsql = string.Format("update Account set score = {0} where username = '{1}'", diem, user);

            Provider prov = new Provider();
            prov.Connect();

            prov.ExecuteNonQuery(CommandType.Text, strsql);

            prov.Disconnect();
        }

        int Score = 0;
        string User = null;

        //tao delegate cap nhap score
        public delegate void ScoreChanged(int score);
        //tao event cap nhat score
        public event ScoreChanged Changed;

        public frmTrucXanh()
        {
            InitializeComponent();
            Changed += new ScoreChanged(Update_Score);
        }

        public frmTrucXanh(int diem, string user)
        {
            InitializeComponent();

            Score = diem;

            User = user;

            lblScore.Text = Score.ToString();

            Changed += new ScoreChanged(Update_Score);
        }


        /*Khu vực khai báo biến*/
        int btnsize = 130, padding = 3;

        int numImage = 0;

        Random rd = new Random();
        Random rd2 = new Random();

        //List<int> lCheck = new List<int>();
        
        int checkWin = 0;

        Button preButton = null;
        Button curButton = null;
        int curImage = -1;
        const int totalImage = 17;

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (timerCheck.Enabled == false)
            {
                if ((nmrCol.Value * nmrRow.Value) % 2 != 0)
                {
                    MessageBox.Show("Tổng số ô phải chẵn!, mời nhập lại");
                }
                else
                {
                    ResetGame();

                    // dùng dictionary để kiểm tra cặp hình ảnh duy nhất
                    Dictionary<int, int> lCheck = new Dictionary<int, int>();

                    int row = (int)nmrRow.Value, col = (int)nmrCol.Value;

                    numImage = (row * col) / 2;

                    Button btn = null;

                    int rdm2 = rd2.Next(0, totalImage - numImage);

                    for (int i = 0; i < row; i++)
                        for (int j = 0; j < col; j++)
                        {
                            btn = new Button();

                            btn.BackColor = Color.LightBlue;

                            //int rdImage = rd.Next(0, numImage);

                            int rdImage = rd.Next(rdm2, rdm2 + numImage);

                            if (lCheck.ContainsKey(rdImage) == false)
                            {
                                lCheck.Add(rdImage, 0);
                            }
                            else
                            {
                                while (lCheck[rdImage] >= 2)
                                {
                                    rdImage = rd.Next(rdm2, rdm2 + numImage);
                                    if (lCheck.ContainsKey(rdImage) == false)
                                    {
                                        lCheck.Add(rdImage, 0);
                                        break;
                                    }
                                }
                            }

                            lCheck[rdImage]++;

                            btn.Tag = rdImage;

                            btn.Size = new Size(btnsize, btnsize);

                            btn.Location = new Point(j * (btnsize + padding), i * (btnsize + padding));

                            btn.Click += new EventHandler(btn_Click);

                            panel.Controls.Add(btn);
                        }
                }
            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            if (curButton == null)
            {
                curButton = sender as Button;
                curImage = (int)curButton.Tag;

                curButton.Image = imagelist.Images[curImage];
                if (preButton == null)
                {
                    preButton = curButton;
                    curButton = null;
                }
                else
                {
                    timerCheck.Enabled = true;
                }
            }
        }

        private void timerCheck_Tick(object sender, EventArgs e)
        {
            if ((int)preButton.Tag == curImage && preButton.Location != curButton.Location)
            {
                preButton.Visible = false;
                curButton.Visible = false;
                checkWin++;
                Score += 20;
            }
            else
            {
                preButton.Image = null;
                curButton.Image = null;
                Score -= 5;
            }

            preButton = null;
            curButton = null;

            Changed(Score);

            timerCheck.Enabled = false;


            // Kiểm tra đã hết ô chưa
            if (checkWin == numImage)
            {
                MessageBox.Show(string.Format("Win !!!\n" + "Điểm số hiện tại: {0}", Score));
                if(User!=null)
                    CapNhatDiemKhiWin(Score, User);
            }
        }

        private void Update_Score(int Score)
        {
            lblScore.Text = Score.ToString();
        }

        private void ResetGame()
        {
            panel.Controls.Clear();
            checkWin = 0;
            curImage = -1;

            preButton = null;
            curButton = null;
        }

    }
}
