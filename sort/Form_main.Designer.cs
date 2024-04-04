namespace sort
{
    partial class Form_main
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.grbControl = new System.Windows.Forms.GroupBox();
            this.btn_start = new System.Windows.Forms.Button();
            this.chk_Tungbuoc = new System.Windows.Forms.CheckBox();
            this.rad_Giam = new System.Windows.Forms.RadioButton();
            this.rad_Tang = new System.Windows.Forms.RadioButton();
            this.grbThuattoan = new System.Windows.Forms.GroupBox();
            this.rad_Merge = new System.Windows.Forms.RadioButton();
            this.rad_Heap = new System.Windows.Forms.RadioButton();
            this.rad_Quick = new System.Windows.Forms.RadioButton();
            this.rad_Insertion = new System.Windows.Forms.RadioButton();
            this.rad_Selection = new System.Windows.Forms.RadioButton();
            this.rad_Bubble = new System.Windows.Forms.RadioButton();
            this.grbCodeC = new System.Windows.Forms.GroupBox();
            this.Zoomcode = new System.Windows.Forms.TrackBar();
            this.lbList_Code = new System.Windows.Forms.ListBox();
            this.grbDulieu = new System.Windows.Forms.GroupBox();
            this.grb_Taogiatri = new System.Windows.Forms.GroupBox();
            this.lblDieukien = new System.Windows.Forms.Label();
            this.btn_Docfile = new System.Windows.Forms.Button();
            this.btn_Nhaptay = new System.Windows.Forms.Button();
            this.btn_Random = new System.Windows.Forms.Button();
            this.grbKhoitaomang = new System.Windows.Forms.GroupBox();
            this.btn_Tao = new System.Windows.Forms.Button();
            this.nmrSophantu = new System.Windows.Forms.NumericUpDown();
            this.lblSophantu = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lbl_MangA = new System.Windows.Forms.Label();
            this.lbl_Index = new System.Windows.Forms.Label();
            this.lbl_bieni = new System.Windows.Forms.Label();
            this.lbl_code = new System.Windows.Forms.Label();
            this.lbl_bienj = new System.Windows.Forms.Label();
            this.lbl_bienx = new System.Windows.Forms.Label();
            this.Tocdo = new System.Windows.Forms.TrackBar();
            this.trackBar3 = new System.Windows.Forms.TrackBar();
            this.panel1.SuspendLayout();
            this.grbControl.SuspendLayout();
            this.grbThuattoan.SuspendLayout();
            this.grbCodeC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Zoomcode)).BeginInit();
            this.grbDulieu.SuspendLayout();
            this.grb_Taogiatri.SuspendLayout();
            this.grbKhoitaomang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrSophantu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tocdo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.grbControl);
            this.panel1.Controls.Add(this.grbThuattoan);
            this.panel1.Controls.Add(this.grbCodeC);
            this.panel1.Controls.Add(this.grbDulieu);
            this.panel1.Location = new System.Drawing.Point(0, 339);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1072, 259);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // grbControl
            // 
            this.grbControl.BackColor = System.Drawing.Color.Thistle;
            this.grbControl.Controls.Add(this.trackBar3);
            this.grbControl.Controls.Add(this.Tocdo);
            this.grbControl.Controls.Add(this.btn_start);
            this.grbControl.Controls.Add(this.chk_Tungbuoc);
            this.grbControl.Controls.Add(this.rad_Giam);
            this.grbControl.Controls.Add(this.rad_Tang);
            this.grbControl.Location = new System.Drawing.Point(879, 11);
            this.grbControl.Name = "grbControl";
            this.grbControl.Size = new System.Drawing.Size(187, 247);
            this.grbControl.TabIndex = 3;
            this.grbControl.TabStop = false;
            this.grbControl.Text = "Điều khiển";
            this.grbControl.Enter += new System.EventHandler(this.grbDieukhien_Enter);
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(19, 134);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(49, 29);
            this.btn_start.TabIndex = 3;
            this.btn_start.Text = "button1";
            this.btn_start.UseVisualStyleBackColor = true;
            // 
            // chk_Tungbuoc
            // 
            this.chk_Tungbuoc.AutoSize = true;
            this.chk_Tungbuoc.Checked = true;
            this.chk_Tungbuoc.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_Tungbuoc.Location = new System.Drawing.Point(19, 97);
            this.chk_Tungbuoc.Name = "chk_Tungbuoc";
            this.chk_Tungbuoc.Size = new System.Drawing.Size(101, 17);
            this.chk_Tungbuoc.TabIndex = 2;
            this.chk_Tungbuoc.Text = "Chạy từng bước";
            this.chk_Tungbuoc.UseVisualStyleBackColor = true;
            this.chk_Tungbuoc.CheckedChanged += new System.EventHandler(this.chkChaytungbuoc_CheckedChanged);
            // 
            // rad_Giam
            // 
            this.rad_Giam.AutoSize = true;
            this.rad_Giam.Location = new System.Drawing.Point(19, 61);
            this.rad_Giam.Name = "rad_Giam";
            this.rad_Giam.Size = new System.Drawing.Size(91, 17);
            this.rad_Giam.TabIndex = 1;
            this.rad_Giam.TabStop = true;
            this.rad_Giam.Text = "Sắp xếp Giảm";
            this.rad_Giam.UseVisualStyleBackColor = true;
            // 
            // rad_Tang
            // 
            this.rad_Tang.AutoSize = true;
            this.rad_Tang.Location = new System.Drawing.Point(19, 28);
            this.rad_Tang.Name = "rad_Tang";
            this.rad_Tang.Size = new System.Drawing.Size(92, 17);
            this.rad_Tang.TabIndex = 0;
            this.rad_Tang.TabStop = true;
            this.rad_Tang.Text = "Sắp xếp Tăng";
            this.rad_Tang.UseVisualStyleBackColor = true;
            // 
            // grbThuattoan
            // 
            this.grbThuattoan.BackColor = System.Drawing.Color.CornflowerBlue;
            this.grbThuattoan.Controls.Add(this.rad_Merge);
            this.grbThuattoan.Controls.Add(this.rad_Heap);
            this.grbThuattoan.Controls.Add(this.rad_Quick);
            this.grbThuattoan.Controls.Add(this.rad_Insertion);
            this.grbThuattoan.Controls.Add(this.rad_Selection);
            this.grbThuattoan.Controls.Add(this.rad_Bubble);
            this.grbThuattoan.Location = new System.Drawing.Point(707, 11);
            this.grbThuattoan.Name = "grbThuattoan";
            this.grbThuattoan.Size = new System.Drawing.Size(166, 247);
            this.grbThuattoan.TabIndex = 2;
            this.grbThuattoan.TabStop = false;
            this.grbThuattoan.Text = "Thuật toán";
            // 
            // rad_Merge
            // 
            this.rad_Merge.AutoSize = true;
            this.rad_Merge.Location = new System.Drawing.Point(29, 191);
            this.rad_Merge.Name = "rad_Merge";
            this.rad_Merge.Size = new System.Drawing.Size(77, 17);
            this.rad_Merge.TabIndex = 5;
            this.rad_Merge.TabStop = true;
            this.rad_Merge.Text = "Merge Sort";
            this.rad_Merge.UseVisualStyleBackColor = true;
            // 
            // rad_Heap
            // 
            this.rad_Heap.AutoSize = true;
            this.rad_Heap.Location = new System.Drawing.Point(29, 162);
            this.rad_Heap.Name = "rad_Heap";
            this.rad_Heap.Size = new System.Drawing.Size(76, 17);
            this.rad_Heap.TabIndex = 4;
            this.rad_Heap.TabStop = true;
            this.rad_Heap.Text = "Heap Sort ";
            this.rad_Heap.UseVisualStyleBackColor = true;
            // 
            // rad_Quick
            // 
            this.rad_Quick.AutoSize = true;
            this.rad_Quick.Location = new System.Drawing.Point(29, 133);
            this.rad_Quick.Name = "rad_Quick";
            this.rad_Quick.Size = new System.Drawing.Size(75, 17);
            this.rad_Quick.TabIndex = 3;
            this.rad_Quick.TabStop = true;
            this.rad_Quick.Text = "Quick Sort";
            this.rad_Quick.UseVisualStyleBackColor = true;
            // 
            // rad_Insertion
            // 
            this.rad_Insertion.AutoSize = true;
            this.rad_Insertion.Location = new System.Drawing.Point(29, 97);
            this.rad_Insertion.Name = "rad_Insertion";
            this.rad_Insertion.Size = new System.Drawing.Size(90, 17);
            this.rad_Insertion.TabIndex = 2;
            this.rad_Insertion.TabStop = true;
            this.rad_Insertion.Text = "Inserttion Sort";
            this.rad_Insertion.UseVisualStyleBackColor = true;
            // 
            // rad_Selection
            // 
            this.rad_Selection.AutoSize = true;
            this.rad_Selection.Location = new System.Drawing.Point(29, 61);
            this.rad_Selection.Name = "rad_Selection";
            this.rad_Selection.Size = new System.Drawing.Size(91, 17);
            this.rad_Selection.TabIndex = 1;
            this.rad_Selection.TabStop = true;
            this.rad_Selection.Text = "Selection Sort";
            this.rad_Selection.UseVisualStyleBackColor = true;
            // 
            // rad_Bubble
            // 
            this.rad_Bubble.AutoSize = true;
            this.rad_Bubble.Location = new System.Drawing.Point(29, 28);
            this.rad_Bubble.Name = "rad_Bubble";
            this.rad_Bubble.Size = new System.Drawing.Size(80, 17);
            this.rad_Bubble.TabIndex = 0;
            this.rad_Bubble.TabStop = true;
            this.rad_Bubble.Text = "Bubble Sort";
            this.rad_Bubble.UseVisualStyleBackColor = true;
            // 
            // grbCodeC
            // 
            this.grbCodeC.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.grbCodeC.Controls.Add(this.Zoomcode);
            this.grbCodeC.Controls.Add(this.lbList_Code);
            this.grbCodeC.Location = new System.Drawing.Point(260, 11);
            this.grbCodeC.Name = "grbCodeC";
            this.grbCodeC.Size = new System.Drawing.Size(444, 247);
            this.grbCodeC.TabIndex = 1;
            this.grbCodeC.TabStop = false;
            this.grbCodeC.Text = "Code C/C++";
            // 
            // Zoomcode
            // 
            this.Zoomcode.AutoSize = false;
            this.Zoomcode.BackColor = System.Drawing.Color.PaleVioletRed;
            this.Zoomcode.Location = new System.Drawing.Point(59, 17);
            this.Zoomcode.Name = "Zoomcode";
            this.Zoomcode.Size = new System.Drawing.Size(315, 22);
            this.Zoomcode.TabIndex = 10;
            this.Zoomcode.Value = 5;
            this.Zoomcode.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // lbList_Code
            // 
            this.lbList_Code.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbList_Code.FormattingEnabled = true;
            this.lbList_Code.Location = new System.Drawing.Point(3, 45);
            this.lbList_Code.Name = "lbList_Code";
            this.lbList_Code.Size = new System.Drawing.Size(438, 199);
            this.lbList_Code.TabIndex = 0;
            this.lbList_Code.SelectedIndexChanged += new System.EventHandler(this.lbListCode_SelectedIndexChanged);
            // 
            // grbDulieu
            // 
            this.grbDulieu.BackColor = System.Drawing.Color.BurlyWood;
            this.grbDulieu.Controls.Add(this.grb_Taogiatri);
            this.grbDulieu.Controls.Add(this.grbKhoitaomang);
            this.grbDulieu.Location = new System.Drawing.Point(3, 11);
            this.grbDulieu.Name = "grbDulieu";
            this.grbDulieu.Size = new System.Drawing.Size(254, 247);
            this.grbDulieu.TabIndex = 0;
            this.grbDulieu.TabStop = false;
            this.grbDulieu.Text = "Nhập Dữ Liệu";
            // 
            // grb_Taogiatri
            // 
            this.grb_Taogiatri.Controls.Add(this.lblDieukien);
            this.grb_Taogiatri.Controls.Add(this.btn_Docfile);
            this.grb_Taogiatri.Controls.Add(this.btn_Nhaptay);
            this.grb_Taogiatri.Controls.Add(this.btn_Random);
            this.grb_Taogiatri.Location = new System.Drawing.Point(0, 118);
            this.grb_Taogiatri.Name = "grb_Taogiatri";
            this.grb_Taogiatri.Size = new System.Drawing.Size(257, 128);
            this.grb_Taogiatri.TabIndex = 1;
            this.grb_Taogiatri.TabStop = false;
            this.grb_Taogiatri.Text = "Tạo giá trị cho mảng A";
            // 
            // lblDieukien
            // 
            this.lblDieukien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDieukien.Location = new System.Drawing.Point(12, 30);
            this.lblDieukien.Name = "lblDieukien";
            this.lblDieukien.Size = new System.Drawing.Size(71, 44);
            this.lblDieukien.TabIndex = 5;
            this.lblDieukien.Text = "A[i]>=0\r\nA[i]<100\r\n";
            this.lblDieukien.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Docfile
            // 
            this.btn_Docfile.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_Docfile.Location = new System.Drawing.Point(151, 83);
            this.btn_Docfile.Name = "btn_Docfile";
            this.btn_Docfile.Size = new System.Drawing.Size(88, 32);
            this.btn_Docfile.TabIndex = 4;
            this.btn_Docfile.Text = "Đọc file";
            this.btn_Docfile.UseVisualStyleBackColor = false;
            // 
            // btn_Nhaptay
            // 
            this.btn_Nhaptay.AutoSize = true;
            this.btn_Nhaptay.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_Nhaptay.Location = new System.Drawing.Point(151, 7);
            this.btn_Nhaptay.Name = "btn_Nhaptay";
            this.btn_Nhaptay.Size = new System.Drawing.Size(88, 32);
            this.btn_Nhaptay.TabIndex = 2;
            this.btn_Nhaptay.Text = "Nhập tay";
            this.btn_Nhaptay.UseVisualStyleBackColor = false;
            // 
            // btn_Random
            // 
            this.btn_Random.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_Random.Location = new System.Drawing.Point(151, 45);
            this.btn_Random.Name = "btn_Random";
            this.btn_Random.Size = new System.Drawing.Size(88, 32);
            this.btn_Random.TabIndex = 3;
            this.btn_Random.Text = "Ngẫu nhiên";
            this.btn_Random.UseVisualStyleBackColor = false;
            // 
            // grbKhoitaomang
            // 
            this.grbKhoitaomang.Controls.Add(this.btn_Tao);
            this.grbKhoitaomang.Controls.Add(this.nmrSophantu);
            this.grbKhoitaomang.Controls.Add(this.lblSophantu);
            this.grbKhoitaomang.Location = new System.Drawing.Point(0, 28);
            this.grbKhoitaomang.Name = "grbKhoitaomang";
            this.grbKhoitaomang.Size = new System.Drawing.Size(254, 84);
            this.grbKhoitaomang.TabIndex = 0;
            this.grbKhoitaomang.TabStop = false;
            this.grbKhoitaomang.Text = "Khởi tạo mảng A";
            // 
            // btn_Tao
            // 
            this.btn_Tao.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_Tao.Location = new System.Drawing.Point(151, 45);
            this.btn_Tao.Name = "btn_Tao";
            this.btn_Tao.Size = new System.Drawing.Size(88, 32);
            this.btn_Tao.TabIndex = 2;
            this.btn_Tao.Text = "Tạo";
            this.btn_Tao.UseVisualStyleBackColor = false;
            this.btn_Tao.Click += new System.EventHandler(this.btnTao_Click);
            // 
            // nmrSophantu
            // 
            this.nmrSophantu.Location = new System.Drawing.Point(134, 19);
            this.nmrSophantu.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.nmrSophantu.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmrSophantu.Name = "nmrSophantu";
            this.nmrSophantu.Size = new System.Drawing.Size(120, 20);
            this.nmrSophantu.TabIndex = 1;
            this.nmrSophantu.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmrSophantu.ValueChanged += new System.EventHandler(this.nmrSophantu_ValueChanged);
            // 
            // lblSophantu
            // 
            this.lblSophantu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSophantu.Location = new System.Drawing.Point(6, 16);
            this.lblSophantu.Name = "lblSophantu";
            this.lblSophantu.Size = new System.Drawing.Size(132, 22);
            this.lblSophantu.TabIndex = 0;
            this.lblSophantu.Text = "Số phần tử (Max=15):";
            this.lblSophantu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSophantu.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_MangA
            // 
            this.lbl_MangA.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MangA.Location = new System.Drawing.Point(12, 149);
            this.lbl_MangA.Name = "lbl_MangA";
            this.lbl_MangA.Size = new System.Drawing.Size(200, 56);
            this.lbl_MangA.TabIndex = 1;
            this.lbl_MangA.Text = "Mảng A:";
            this.lbl_MangA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Index
            // 
            this.lbl_Index.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Index.Location = new System.Drawing.Point(54, 278);
            this.lbl_Index.Name = "lbl_Index";
            this.lbl_Index.Size = new System.Drawing.Size(100, 23);
            this.lbl_Index.TabIndex = 2;
            this.lbl_Index.Text = "Index:";
            this.lbl_Index.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_Index.Click += new System.EventHandler(this.lblIndex_Click);
            // 
            // lbl_bieni
            // 
            this.lbl_bieni.Location = new System.Drawing.Point(915, 41);
            this.lbl_bieni.Name = "lbl_bieni";
            this.lbl_bieni.Size = new System.Drawing.Size(96, 39);
            this.lbl_bieni.TabIndex = 3;
            this.lbl_bieni.Text = "Ghi chú";
            // 
            // lbl_code
            // 
            this.lbl_code.Location = new System.Drawing.Point(237, 24);
            this.lbl_code.Name = "lbl_code";
            this.lbl_code.Size = new System.Drawing.Size(368, 58);
            this.lbl_code.TabIndex = 4;
            this.lbl_code.Text = "label1";
            // 
            // lbl_bienj
            // 
            this.lbl_bienj.Location = new System.Drawing.Point(916, 100);
            this.lbl_bienj.Name = "lbl_bienj";
            this.lbl_bienj.Size = new System.Drawing.Size(104, 30);
            this.lbl_bienj.TabIndex = 5;
            this.lbl_bienj.Text = "label2";
            // 
            // lbl_bienx
            // 
            this.lbl_bienx.Location = new System.Drawing.Point(918, 136);
            this.lbl_bienx.Name = "lbl_bienx";
            this.lbl_bienx.Size = new System.Drawing.Size(80, 34);
            this.lbl_bienx.TabIndex = 6;
            this.lbl_bienx.Text = "label3";
            // 
            // Tocdo
            // 
            this.Tocdo.BackColor = System.Drawing.Color.MediumOrchid;
            this.Tocdo.Location = new System.Drawing.Point(136, 27);
            this.Tocdo.Name = "Tocdo";
            this.Tocdo.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.Tocdo.Size = new System.Drawing.Size(45, 165);
            this.Tocdo.TabIndex = 4;
            this.Tocdo.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // trackBar3
            // 
            this.trackBar3.Location = new System.Drawing.Point(126, 27);
            this.trackBar3.Name = "trackBar3";
            this.trackBar3.Size = new System.Drawing.Size(8, 45);
            this.trackBar3.TabIndex = 5;
            // 
            // Form_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(1066, 592);
            this.Controls.Add(this.lbl_bienx);
            this.Controls.Add(this.lbl_bienj);
            this.Controls.Add(this.lbl_code);
            this.Controls.Add(this.lbl_bieni);
            this.Controls.Add(this.lbl_Index);
            this.Controls.Add(this.lbl_MangA);
            this.Controls.Add(this.panel1);
            this.Name = "Form_main";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sort App";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_main_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.grbControl.ResumeLayout(false);
            this.grbControl.PerformLayout();
            this.grbThuattoan.ResumeLayout(false);
            this.grbThuattoan.PerformLayout();
            this.grbCodeC.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Zoomcode)).EndInit();
            this.grbDulieu.ResumeLayout(false);
            this.grb_Taogiatri.ResumeLayout(false);
            this.grb_Taogiatri.PerformLayout();
            this.grbKhoitaomang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nmrSophantu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tocdo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox grbCodeC;
        private System.Windows.Forms.GroupBox grbDulieu;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox grbThuattoan;
        private System.Windows.Forms.GroupBox grbControl;
        private System.Windows.Forms.GroupBox grbKhoitaomang;
        private System.Windows.Forms.Label lblSophantu;
        private System.Windows.Forms.Button btn_Tao;
        private System.Windows.Forms.NumericUpDown nmrSophantu;
        private System.Windows.Forms.Button btn_Docfile;
        private System.Windows.Forms.Button btn_Random;
        private System.Windows.Forms.Button btn_Nhaptay;
        private System.Windows.Forms.CheckBox chk_Tungbuoc;
        private System.Windows.Forms.RadioButton rad_Giam;
        private System.Windows.Forms.RadioButton rad_Tang;
        private System.Windows.Forms.RadioButton rad_Merge;
        private System.Windows.Forms.RadioButton rad_Heap;
        private System.Windows.Forms.RadioButton rad_Quick;
        private System.Windows.Forms.RadioButton rad_Insertion;
        private System.Windows.Forms.RadioButton rad_Selection;
        private System.Windows.Forms.RadioButton rad_Bubble;
        private System.Windows.Forms.ListBox lbList_Code;
        private System.Windows.Forms.TrackBar Zoomcode;
        private System.Windows.Forms.Label lbl_MangA;
        private System.Windows.Forms.Label lbl_Index;
        private System.Windows.Forms.Label lbl_bieni;
        private System.Windows.Forms.Label lblDieukien;
        private System.Windows.Forms.Label lbl_code;
        private System.Windows.Forms.Label lbl_bienj;
        private System.Windows.Forms.Label lbl_bienx;
        private System.Windows.Forms.GroupBox grb_Taogiatri;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.TrackBar trackBar3;
        private System.Windows.Forms.TrackBar Tocdo;
    }
}

