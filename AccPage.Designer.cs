
namespace WindowsFormapdemo
{
    partial class AccPage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccPage));
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddAccount = new System.Windows.Forms.Button();
            this.btnAccumulate = new System.Windows.Forms.Button();
            this.btnSaveMoney = new System.Windows.Forms.Button();
            this.btnBank = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnTransaction = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnOther = new System.Windows.Forms.Button();
            this.btnCategory = new System.Windows.Forms.Button();
            this.btnAcc = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(312, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 22);
            this.label2.TabIndex = 13;
            this.label2.Text = "Tổng tiền";
            // 
            // btnAddAccount
            // 
            this.btnAddAccount.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAccount.Location = new System.Drawing.Point(877, 413);
            this.btnAddAccount.Name = "btnAddAccount";
            this.btnAddAccount.Size = new System.Drawing.Size(75, 23);
            this.btnAddAccount.TabIndex = 12;
            this.btnAddAccount.Text = "+";
            this.btnAddAccount.UseVisualStyleBackColor = true;
            this.btnAddAccount.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnAccumulate
            // 
            this.btnAccumulate.BackColor = System.Drawing.Color.Cyan;
            this.btnAccumulate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccumulate.Location = new System.Drawing.Point(650, 53);
            this.btnAccumulate.Name = "btnAccumulate";
            this.btnAccumulate.Size = new System.Drawing.Size(109, 35);
            this.btnAccumulate.TabIndex = 10;
            this.btnAccumulate.Text = "Tích lũy";
            this.btnAccumulate.UseVisualStyleBackColor = false;
            this.btnAccumulate.Click += new System.EventHandler(this.btnAccumulate_Click);
            // 
            // btnSaveMoney
            // 
            this.btnSaveMoney.BackColor = System.Drawing.Color.Cyan;
            this.btnSaveMoney.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveMoney.Location = new System.Drawing.Point(517, 53);
            this.btnSaveMoney.Name = "btnSaveMoney";
            this.btnSaveMoney.Size = new System.Drawing.Size(103, 35);
            this.btnSaveMoney.TabIndex = 9;
            this.btnSaveMoney.Text = "Sổ tiết kiệm";
            this.btnSaveMoney.UseVisualStyleBackColor = false;
            this.btnSaveMoney.Click += new System.EventHandler(this.btnSaveMoney_Click);
            // 
            // btnBank
            // 
            this.btnBank.BackColor = System.Drawing.Color.Cyan;
            this.btnBank.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBank.Location = new System.Drawing.Point(396, 53);
            this.btnBank.Name = "btnBank";
            this.btnBank.Size = new System.Drawing.Size(89, 35);
            this.btnBank.TabIndex = 8;
            this.btnBank.Text = "Tài khoản";
            this.btnBank.UseVisualStyleBackColor = false;
            this.btnBank.Click += new System.EventHandler(this.btnBank_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(502, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 31);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tài khoản";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Cyan;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnTransaction);
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Controls.Add(this.btnReport);
            this.panel1.Controls.Add(this.btnOther);
            this.panel1.Controls.Add(this.btnCategory);
            this.panel1.Controls.Add(this.btnAcc);
            this.panel1.Location = new System.Drawing.Point(166, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(121, 478);
            this.panel1.TabIndex = 30;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Cyan;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(16, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(93, 92);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // btnTransaction
            // 
            this.btnTransaction.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransaction.Image = ((System.Drawing.Image)(resources.GetObject("btnTransaction.Image")));
            this.btnTransaction.Location = new System.Drawing.Point(0, 170);
            this.btnTransaction.Name = "btnTransaction";
            this.btnTransaction.Size = new System.Drawing.Size(121, 57);
            this.btnTransaction.TabIndex = 16;
            this.btnTransaction.Text = "Ghi chép";
            this.btnTransaction.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTransaction.UseVisualStyleBackColor = true;
            this.btnTransaction.Click += new System.EventHandler(this.btnTransaction_Click);
            // 
            // btnHome
            // 
            this.btnHome.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.Location = new System.Drawing.Point(0, 101);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(121, 63);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "Tổng quan";
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnReport
            // 
            this.btnReport.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.Image = ((System.Drawing.Image)(resources.GetObject("btnReport.Image")));
            this.btnReport.Location = new System.Drawing.Point(0, 233);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(121, 54);
            this.btnReport.TabIndex = 15;
            this.btnReport.Text = "Báo cáo";
            this.btnReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnOther
            // 
            this.btnOther.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOther.Image = ((System.Drawing.Image)(resources.GetObject("btnOther.Image")));
            this.btnOther.Location = new System.Drawing.Point(0, 418);
            this.btnOther.Name = "btnOther";
            this.btnOther.Size = new System.Drawing.Size(121, 57);
            this.btnOther.TabIndex = 12;
            this.btnOther.Text = "Khác";
            this.btnOther.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOther.UseVisualStyleBackColor = true;
            this.btnOther.Click += new System.EventHandler(this.btnOther_Click);
            // 
            // btnCategory
            // 
            this.btnCategory.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategory.Image = ((System.Drawing.Image)(resources.GetObject("btnCategory.Image")));
            this.btnCategory.Location = new System.Drawing.Point(0, 293);
            this.btnCategory.Name = "btnCategory";
            this.btnCategory.Size = new System.Drawing.Size(121, 56);
            this.btnCategory.TabIndex = 14;
            this.btnCategory.Text = "Phân loại thu chi";
            this.btnCategory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCategory.UseVisualStyleBackColor = true;
            this.btnCategory.Click += new System.EventHandler(this.btnCategory_Click);
            // 
            // btnAcc
            // 
            this.btnAcc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcc.Image = ((System.Drawing.Image)(resources.GetObject("btnAcc.Image")));
            this.btnAcc.Location = new System.Drawing.Point(0, 355);
            this.btnAcc.Name = "btnAcc";
            this.btnAcc.Size = new System.Drawing.Size(121, 57);
            this.btnAcc.TabIndex = 13;
            this.btnAcc.Text = "Tài khoản";
            this.btnAcc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAcc.UseVisualStyleBackColor = true;
            this.btnAcc.Click += new System.EventHandler(this.btnAcc_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(316, 122);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(555, 366);
            this.listView1.TabIndex = 31;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // AccPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAddAccount);
            this.Controls.Add(this.btnAccumulate);
            this.Controls.Add(this.btnSaveMoney);
            this.Controls.Add(this.btnBank);
            this.Controls.Add(this.label1);
            this.Name = "AccPage";
            this.Size = new System.Drawing.Size(1266, 605);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddAccount;
        private System.Windows.Forms.Button btnAccumulate;
        private System.Windows.Forms.Button btnSaveMoney;
        private System.Windows.Forms.Button btnBank;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnTransaction;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnOther;
        private System.Windows.Forms.Button btnCategory;
        private System.Windows.Forms.Button btnAcc;
        private System.Windows.Forms.ListView listView1;
    }
}
