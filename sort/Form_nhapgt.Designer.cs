namespace sort
{
    partial class Form_nhapgt
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
            this.btn_Nhap = new System.Windows.Forms.Button();
            this.txt_phantu = new System.Windows.Forms.TextBox();
            this.txt_giatri = new System.Windows.Forms.TextBox();
            this.lbl_ = new System.Windows.Forms.Label();
            this.lbl_giatri = new System.Windows.Forms.Label();
            this.lblTieude = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Nhap
            // 
            this.btn_Nhap.BackColor = System.Drawing.Color.LightCoral;
            this.btn_Nhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Nhap.Location = new System.Drawing.Point(137, 231);
            this.btn_Nhap.Name = "btn_Nhap";
            this.btn_Nhap.Size = new System.Drawing.Size(108, 58);
            this.btn_Nhap.TabIndex = 0;
            this.btn_Nhap.Text = "Nhập";
            this.btn_Nhap.UseVisualStyleBackColor = false;
            // 
            // txt_phantu
            // 
            this.txt_phantu.Location = new System.Drawing.Point(209, 98);
            this.txt_phantu.Name = "txt_phantu";
            this.txt_phantu.Size = new System.Drawing.Size(150, 20);
            this.txt_phantu.TabIndex = 1;
            // 
            // txt_giatri
            // 
            this.txt_giatri.Location = new System.Drawing.Point(209, 168);
            this.txt_giatri.Name = "txt_giatri";
            this.txt_giatri.Size = new System.Drawing.Size(150, 20);
            this.txt_giatri.TabIndex = 2;
            // 
            // lbl_
            // 
            this.lbl_.BackColor = System.Drawing.Color.LightSkyBlue;
            this.lbl_.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_.Location = new System.Drawing.Point(34, 91);
            this.lbl_.Name = "lbl_";
            this.lbl_.Size = new System.Drawing.Size(112, 33);
            this.lbl_.TabIndex = 3;
            this.lbl_.Text = "Phần tử thứ:";
            this.lbl_.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_.Click += new System.EventHandler(this.lbl__Click);
            // 
            // lbl_giatri
            // 
            this.lbl_giatri.BackColor = System.Drawing.Color.LightSkyBlue;
            this.lbl_giatri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_giatri.Location = new System.Drawing.Point(34, 160);
            this.lbl_giatri.Name = "lbl_giatri";
            this.lbl_giatri.Size = new System.Drawing.Size(109, 35);
            this.lbl_giatri.TabIndex = 4;
            this.lbl_giatri.Text = "Giá trị:";
            this.lbl_giatri.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_giatri.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblTieude
            // 
            this.lblTieude.BackColor = System.Drawing.Color.SandyBrown;
            this.lblTieude.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTieude.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieude.Location = new System.Drawing.Point(0, 0);
            this.lblTieude.Name = "lblTieude";
            this.lblTieude.Size = new System.Drawing.Size(414, 55);
            this.lblTieude.TabIndex = 5;
            this.lblTieude.Text = "Nhập giá trị cho từng phần tử trong Mảng A";
            this.lblTieude.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form_nhapgt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(414, 312);
            this.Controls.Add(this.lblTieude);
            this.Controls.Add(this.lbl_giatri);
            this.Controls.Add(this.lbl_);
            this.Controls.Add(this.txt_giatri);
            this.Controls.Add(this.txt_phantu);
            this.Controls.Add(this.btn_Nhap);
            this.Name = "Form_nhapgt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form_nhapgt_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Nhap;
        private System.Windows.Forms.TextBox txt_phantu;
        private System.Windows.Forms.TextBox txt_giatri;
        private System.Windows.Forms.Label lbl_;
        private System.Windows.Forms.Label lbl_giatri;
        private System.Windows.Forms.Label lblTieude;
    }
}