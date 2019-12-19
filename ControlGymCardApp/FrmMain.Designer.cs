namespace ControlGymCardApp
{
    partial class FrmMain
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
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.اطلاعاتپایهToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.مدیریتکاربرانToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.امنیتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.تغییررمزToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.دربارهToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.خروجToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMngPerson = new System.Windows.Forms.Button();
            this.btnMngGymCards = new System.Windows.Forms.Button();
            this.btnBimehCards = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel6 = new System.Windows.Forms.ToolStripStatusLabel();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.menuStripMain.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripMain
            // 
            this.menuStripMain.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.اطلاعاتپایهToolStripMenuItem,
            this.مدیریتکاربرانToolStripMenuItem,
            this.دربارهToolStripMenuItem,
            this.خروجToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStripMain.Size = new System.Drawing.Size(846, 24);
            this.menuStripMain.TabIndex = 0;
            this.menuStripMain.Text = "menuStrip1";
            this.menuStripMain.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // اطلاعاتپایهToolStripMenuItem
            // 
            this.اطلاعاتپایهToolStripMenuItem.Name = "اطلاعاتپایهToolStripMenuItem";
            this.اطلاعاتپایهToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.اطلاعاتپایهToolStripMenuItem.Text = "اطلاعات پایه";
            // 
            // مدیریتکاربرانToolStripMenuItem
            // 
            this.مدیریتکاربرانToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.امنیتToolStripMenuItem,
            this.تغییررمزToolStripMenuItem});
            this.مدیریتکاربرانToolStripMenuItem.Name = "مدیریتکاربرانToolStripMenuItem";
            this.مدیریتکاربرانToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.مدیریتکاربرانToolStripMenuItem.Text = "مدیریت کاربران";
            // 
            // امنیتToolStripMenuItem
            // 
            this.امنیتToolStripMenuItem.Name = "امنیتToolStripMenuItem";
            this.امنیتToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.امنیتToolStripMenuItem.Text = "کاربران";
            this.امنیتToolStripMenuItem.Click += new System.EventHandler(this.کاربرانToolStripMenuItem_Click);
            // 
            // تغییررمزToolStripMenuItem
            // 
            this.تغییررمزToolStripMenuItem.Name = "تغییررمزToolStripMenuItem";
            this.تغییررمزToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.تغییررمزToolStripMenuItem.Text = "تغییر رمز";
            // 
            // دربارهToolStripMenuItem
            // 
            this.دربارهToolStripMenuItem.Name = "دربارهToolStripMenuItem";
            this.دربارهToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.دربارهToolStripMenuItem.Text = "درباره";
            // 
            // خروجToolStripMenuItem
            // 
            this.خروجToolStripMenuItem.Name = "خروجToolStripMenuItem";
            this.خروجToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.خروجToolStripMenuItem.Text = "خروج";
            // 
            // btnMngPerson
            // 
            this.btnMngPerson.Location = new System.Drawing.Point(531, 20);
            this.btnMngPerson.Name = "btnMngPerson";
            this.btnMngPerson.Size = new System.Drawing.Size(152, 88);
            this.btnMngPerson.TabIndex = 1;
            this.btnMngPerson.UseVisualStyleBackColor = true;
            this.btnMngPerson.Click += new System.EventHandler(this.btnMngPerson_Click);
            // 
            // btnMngGymCards
            // 
            this.btnMngGymCards.Location = new System.Drawing.Point(373, 20);
            this.btnMngGymCards.Name = "btnMngGymCards";
            this.btnMngGymCards.Size = new System.Drawing.Size(152, 88);
            this.btnMngGymCards.TabIndex = 1;
            this.btnMngGymCards.UseVisualStyleBackColor = true;
            // 
            // btnBimehCards
            // 
            this.btnBimehCards.Location = new System.Drawing.Point(215, 20);
            this.btnBimehCards.Name = "btnBimehCards";
            this.btnBimehCards.Size = new System.Drawing.Size(152, 88);
            this.btnBimehCards.TabIndex = 1;
            this.btnBimehCards.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button4.Location = new System.Drawing.Point(573, 19);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(183, 93);
            this.button4.TabIndex = 1;
            this.button4.Text = "کارت باشگاه دارای اعتبار : 12003";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(583, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "اشخاص";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(429, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "کارت باشگاه";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(268, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "کارت بیمه";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(57, 20);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(152, 88);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(110, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "جستجو";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel4,
            this.toolStripStatusLabel5,
            this.toolStripStatusLabel6});
            this.statusStrip1.Location = new System.Drawing.Point(0, 374);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.statusStrip1.Size = new System.Drawing.Size(846, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStripMain";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(71, 17);
            this.toolStripStatusLabel1.Text = "کاربر جاری : ";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(123, 17);
            this.toolStripStatusLabel2.Text = "toolStripStatusLabel2";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(116, 17);
            this.toolStripStatusLabel3.Text = "تاریخ جاری سیستم  :";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(123, 17);
            this.toolStripStatusLabel4.Text = "toolStripStatusLabel4";
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(53, 17);
            this.toolStripStatusLabel5.Text = "ساعت : ";
            // 
            // toolStripStatusLabel6
            // 
            this.toolStripStatusLabel6.Name = "toolStripStatusLabel6";
            this.toolStripStatusLabel6.Size = new System.Drawing.Size(123, 17);
            this.toolStripStatusLabel6.Text = "toolStripStatusLabel6";
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Red;
            this.button6.Location = new System.Drawing.Point(384, 19);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(183, 93);
            this.button6.TabIndex = 1;
            this.button6.Text = "کارت باشگاه فاقد اعتبار : 123";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button7.Location = new System.Drawing.Point(195, 19);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(183, 93);
            this.button7.TabIndex = 1;
            this.button7.Text = "کارت بیمه دارای اعتبار : 123";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Red;
            this.button8.Location = new System.Drawing.Point(6, 19);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(183, 93);
            this.button8.TabIndex = 1;
            this.button8.Text = "کارت بیمه فاقد اعتبار : 123";
            this.button8.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button7);
            this.groupBox1.Controls.Add(this.button8);
            this.groupBox1.Location = new System.Drawing.Point(48, 171);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(763, 120);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "وضعیت کارت ها";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.btnSearch);
            this.groupBox2.Controls.Add(this.btnMngPerson);
            this.groupBox2.Controls.Add(this.btnMngGymCards);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btnBimehCards);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(48, 30);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(763, 135);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "عملیات اصلی";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 396);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStripMain);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStripMain;
            this.Name = "FrmMain";
            this.Text = "مدیریت کارت های باشگاه پرورش اندام پوریای ولی";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem اطلاعاتپایهToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem مدیریتکاربرانToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem امنیتToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem تغییررمزToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem دربارهToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem خروجToolStripMenuItem;
        private System.Windows.Forms.Button btnMngPerson;
        private System.Windows.Forms.Button btnMngGymCards;
        private System.Windows.Forms.Button btnBimehCards;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

