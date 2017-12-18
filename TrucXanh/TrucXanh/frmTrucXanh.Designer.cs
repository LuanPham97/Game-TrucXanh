namespace TrucXanh
{
    partial class frmTrucXanh
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTrucXanh));
            this.label1 = new System.Windows.Forms.Label();
            this.nmrRow = new System.Windows.Forms.NumericUpDown();
            this.nmrCol = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            this.imagelist = new System.Windows.Forms.ImageList(this.components);
            this.timerCheck = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nmrRow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrCol)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rows";
            // 
            // nmrRow
            // 
            this.nmrRow.Location = new System.Drawing.Point(74, 11);
            this.nmrRow.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nmrRow.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmrRow.Name = "nmrRow";
            this.nmrRow.Size = new System.Drawing.Size(120, 20);
            this.nmrRow.TabIndex = 1;
            this.nmrRow.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // nmrCol
            // 
            this.nmrCol.Location = new System.Drawing.Point(298, 13);
            this.nmrCol.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nmrCol.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmrCol.Name = "nmrCol";
            this.nmrCol.Size = new System.Drawing.Size(120, 20);
            this.nmrCol.TabIndex = 3;
            this.nmrCol.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(240, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Columns";
            // 
            // btnCreate
            // 
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.Location = new System.Drawing.Point(481, 8);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(143, 34);
            this.btnCreate.TabIndex = 4;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // panel
            // 
            this.panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel.AutoScroll = true;
            this.panel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel.Location = new System.Drawing.Point(13, 52);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(906, 471);
            this.panel.TabIndex = 5;
            // 
            // imagelist
            // 
            this.imagelist.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imagelist.ImageStream")));
            this.imagelist.TransparentColor = System.Drawing.Color.Transparent;
            this.imagelist.Images.SetKeyName(0, "56686a11160f3.jpg");
            this.imagelist.Images.SetKeyName(1, "20170716-025156-19989495_1396428013768648_4947556134138689171_n_600x900.jpg");
            this.imagelist.Images.SetKeyName(2, "20170830-023101-seolhyun_732x427.png");
            this.imagelist.Images.SetKeyName(3, "23707217093_c77f222543_o.jpg");
            this.imagelist.Images.SetKeyName(4, "201303121701_evidence_diamond_gold.jpg");
            this.imagelist.Images.SetKeyName(5, "asiimov.png");
            this.imagelist.Images.SetKeyName(6, "cay-canh-650.jpg");
            this.imagelist.Images.SetKeyName(7, "chuyen-cay-canh-khi-chuyen-nha-1.jpg");
            this.imagelist.Images.SetKeyName(8, "csgo market prices.jpg");
            this.imagelist.Images.SetKeyName(9, "dong-ho-thuy-si-cao-cap-004.jpg");
            this.imagelist.Images.SetKeyName(10, "dong-ho-thuy-sy-noi-tieng-Patek-Philippe.jpg");
            this.imagelist.Images.SetKeyName(11, "jkv1449929815.jpg");
            this.imagelist.Images.SetKeyName(12, "SHOHIN.jpg");
            this.imagelist.Images.SetKeyName(13, "steamworkshop_webupload_previewfile_398814889_preview.jpg");
            this.imagelist.Images.SetKeyName(14, "Thor-Ragnarok-banner-3-1-600x372.jpg");
            this.imagelist.Images.SetKeyName(15, "wired_up-close-and-personal-with-the-new-iphone-x.jpg");
            this.imagelist.Images.SetKeyName(16, "ztb1446358447.jpg");
            // 
            // timerCheck
            // 
            this.timerCheck.Interval = 1000;
            this.timerCheck.Tick += new System.EventHandler(this.timerCheck_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(762, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Score:";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblScore.Location = new System.Drawing.Point(839, 17);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(18, 20);
            this.lblScore.TabIndex = 7;
            this.lblScore.Text = "0";
            // 
            // frmTrucXanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 535);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.nmrCol);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nmrRow);
            this.Controls.Add(this.label1);
            this.Name = "frmTrucXanh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTrucXanh";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.nmrRow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrCol)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nmrRow;
        private System.Windows.Forms.NumericUpDown nmrCol;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Timer timerCheck;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.ImageList imagelist;
    }
}