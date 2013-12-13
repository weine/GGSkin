namespace GGSkin
{
    partial class GGSkin
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GGSkin));
            this.lolFolder = new System.Windows.Forms.TextBox();
            this.lolFolderLb = new System.Windows.Forms.Label();
            this.lolBtn = new System.Windows.Forms.Button();
            this.msgLb = new System.Windows.Forms.Label();
            this.lolLb = new System.Windows.Forms.Label();
            this.lolSkinDef = new System.Windows.Forms.Button();
            this.lolSkinFoxe = new System.Windows.Forms.Button();
            this.lolSkinPeb = new System.Windows.Forms.Button();
            this.lolSkinDean = new System.Windows.Forms.Button();
            this.lolSkinHero = new System.Windows.Forms.Button();
            this.lolLb2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.lolLb3 = new System.Windows.Forms.Label();
            this.fontBtn1 = new System.Windows.Forms.Button();
            this.fontBtn2 = new System.Windows.Forms.Button();
            this.fontBtn3 = new System.Windows.Forms.Button();
            this.fontBtn4 = new System.Windows.Forms.Button();
            this.fontBtn5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lolFolder
            // 
            this.lolFolder.Location = new System.Drawing.Point(103, 22);
            this.lolFolder.Name = "lolFolder";
            this.lolFolder.Size = new System.Drawing.Size(278, 22);
            this.lolFolder.TabIndex = 0;
            this.lolFolder.Text = "C:\\Program Files\\GarenaLoLTW\\GameData\\Apps\\LoLTW\\Game";
            // 
            // lolFolderLb
            // 
            this.lolFolderLb.AutoSize = true;
            this.lolFolderLb.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lolFolderLb.Location = new System.Drawing.Point(28, 25);
            this.lolFolderLb.Name = "lolFolderLb";
            this.lolFolderLb.Size = new System.Drawing.Size(69, 12);
            this.lolFolderLb.TabIndex = 1;
            this.lolFolderLb.Text = "LOL主目錄 :";
            // 
            // lolBtn
            // 
            this.lolBtn.Location = new System.Drawing.Point(387, 22);
            this.lolBtn.Name = "lolBtn";
            this.lolBtn.Size = new System.Drawing.Size(75, 23);
            this.lolBtn.TabIndex = 2;
            this.lolBtn.Text = "選擇";
            this.lolBtn.UseVisualStyleBackColor = true;
            this.lolBtn.Click += new System.EventHandler(this.lolBtn_Click);
            // 
            // msgLb
            // 
            this.msgLb.AutoSize = true;
            this.msgLb.Location = new System.Drawing.Point(78, 58);
            this.msgLb.Name = "msgLb";
            this.msgLb.Size = new System.Drawing.Size(347, 12);
            this.msgLb.TabIndex = 3;
            this.msgLb.Text = "(如不是預設安裝路徑，請選擇LOL的安裝路徑下執行檔的資料夾)";
            // 
            // lolLb
            // 
            this.lolLb.AutoSize = true;
            this.lolLb.Location = new System.Drawing.Point(46, 101);
            this.lolLb.Name = "lolLb";
            this.lolLb.Size = new System.Drawing.Size(77, 12);
            this.lolLb.TabIndex = 4;
            this.lolLb.Text = "【面板選擇】";
            // 
            // lolSkinDef
            // 
            this.lolSkinDef.Location = new System.Drawing.Point(80, 129);
            this.lolSkinDef.Name = "lolSkinDef";
            this.lolSkinDef.Size = new System.Drawing.Size(75, 23);
            this.lolSkinDef.TabIndex = 5;
            this.lolSkinDef.Text = "原廠";
            this.lolSkinDef.UseVisualStyleBackColor = true;
            this.lolSkinDef.Click += new System.EventHandler(this.lolSkinDef_Click);
            // 
            // lolSkinFoxe
            // 
            this.lolSkinFoxe.Location = new System.Drawing.Point(80, 168);
            this.lolSkinFoxe.Name = "lolSkinFoxe";
            this.lolSkinFoxe.Size = new System.Drawing.Size(75, 23);
            this.lolSkinFoxe.TabIndex = 6;
            this.lolSkinFoxe.Text = "FoxeUI";
            this.lolSkinFoxe.UseVisualStyleBackColor = true;
            this.lolSkinFoxe.Click += new System.EventHandler(this.lolSkinFoxe_Click);
            // 
            // lolSkinPeb
            // 
            this.lolSkinPeb.Location = new System.Drawing.Point(80, 210);
            this.lolSkinPeb.Name = "lolSkinPeb";
            this.lolSkinPeb.Size = new System.Drawing.Size(75, 23);
            this.lolSkinPeb.TabIndex = 7;
            this.lolSkinPeb.Text = "PebUI";
            this.lolSkinPeb.UseVisualStyleBackColor = true;
            this.lolSkinPeb.Visible = false;
            this.lolSkinPeb.Click += new System.EventHandler(this.lolSkinPeb_Click);
            // 
            // lolSkinDean
            // 
            this.lolSkinDean.Location = new System.Drawing.Point(80, 249);
            this.lolSkinDean.Name = "lolSkinDean";
            this.lolSkinDean.Size = new System.Drawing.Size(75, 23);
            this.lolSkinDean.TabIndex = 8;
            this.lolSkinDean.Text = "DeanUI";
            this.lolSkinDean.UseVisualStyleBackColor = true;
            this.lolSkinDean.Visible = false;
            this.lolSkinDean.Click += new System.EventHandler(this.lolSkinDean_Click);
            // 
            // lolSkinHero
            // 
            this.lolSkinHero.Location = new System.Drawing.Point(80, 288);
            this.lolSkinHero.Name = "lolSkinHero";
            this.lolSkinHero.Size = new System.Drawing.Size(75, 23);
            this.lolSkinHero.TabIndex = 9;
            this.lolSkinHero.Text = "D-HeroesUI";
            this.lolSkinHero.UseVisualStyleBackColor = true;
            this.lolSkinHero.Visible = false;
            this.lolSkinHero.Click += new System.EventHandler(this.lolSkinHero_Click);
            // 
            // lolLb2
            // 
            this.lolLb2.AutoSize = true;
            this.lolLb2.Location = new System.Drawing.Point(202, 101);
            this.lolLb2.Name = "lolLb2";
            this.lolLb2.Size = new System.Drawing.Size(77, 12);
            this.lolLb2.TabIndex = 10;
            this.lolLb2.Text = "【字體大小】";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(226, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 11;
            this.label1.Text = "金錢";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(261, 129);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(39, 22);
            this.textBox1.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(225, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 13;
            this.label2.Text = "物攻";
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(260, 157);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(39, 22);
            this.textBox2.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(226, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 15;
            this.label3.Text = "魔攻";
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(260, 185);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(39, 22);
            this.textBox3.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(226, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 17;
            this.label4.Text = "爆擊";
            // 
            // textBox4
            // 
            this.textBox4.Enabled = false;
            this.textBox4.Location = new System.Drawing.Point(260, 213);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(39, 22);
            this.textBox4.TabIndex = 18;
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(228, 288);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 19;
            this.saveBtn.Text = "儲存";
            this.saveBtn.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(202, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 20;
            this.label5.Text = "真實傷害";
            // 
            // textBox5
            // 
            this.textBox5.Enabled = false;
            this.textBox5.Location = new System.Drawing.Point(260, 242);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(40, 22);
            this.textBox5.TabIndex = 21;
            // 
            // lolLb3
            // 
            this.lolLb3.AutoSize = true;
            this.lolLb3.Location = new System.Drawing.Point(344, 101);
            this.lolLb3.Name = "lolLb3";
            this.lolLb3.Size = new System.Drawing.Size(77, 12);
            this.lolLb3.TabIndex = 22;
            this.lolLb3.Text = "【字型變更】";
            // 
            // fontBtn1
            // 
            this.fontBtn1.Location = new System.Drawing.Point(364, 129);
            this.fontBtn1.Name = "fontBtn1";
            this.fontBtn1.Size = new System.Drawing.Size(75, 23);
            this.fontBtn1.TabIndex = 23;
            this.fontBtn1.Text = "原廠";
            this.fontBtn1.UseVisualStyleBackColor = true;
            this.fontBtn1.Click += new System.EventHandler(this.fontBtn1_Click);
            // 
            // fontBtn2
            // 
            this.fontBtn2.Location = new System.Drawing.Point(364, 168);
            this.fontBtn2.Name = "fontBtn2";
            this.fontBtn2.Size = new System.Drawing.Size(75, 23);
            this.fontBtn2.TabIndex = 24;
            this.fontBtn2.Text = "華康彩帶體";
            this.fontBtn2.UseVisualStyleBackColor = true;
            this.fontBtn2.Click += new System.EventHandler(this.fontBtn2_Click);
            // 
            // fontBtn3
            // 
            this.fontBtn3.Location = new System.Drawing.Point(364, 205);
            this.fontBtn3.Name = "fontBtn3";
            this.fontBtn3.Size = new System.Drawing.Size(75, 23);
            this.fontBtn3.TabIndex = 25;
            this.fontBtn3.Text = "華康皮皮體";
            this.fontBtn3.UseVisualStyleBackColor = true;
            this.fontBtn3.Click += new System.EventHandler(this.fontBtn3_Click);
            // 
            // fontBtn4
            // 
            this.fontBtn4.Location = new System.Drawing.Point(364, 245);
            this.fontBtn4.Name = "fontBtn4";
            this.fontBtn4.Size = new System.Drawing.Size(75, 23);
            this.fontBtn4.TabIndex = 26;
            this.fontBtn4.Text = "王漢宗綜藝體";
            this.fontBtn4.UseVisualStyleBackColor = true;
            this.fontBtn4.Click += new System.EventHandler(this.fontBtn4_Click);
            // 
            // fontBtn5
            // 
            this.fontBtn5.Location = new System.Drawing.Point(364, 288);
            this.fontBtn5.Name = "fontBtn5";
            this.fontBtn5.Size = new System.Drawing.Size(75, 23);
            this.fontBtn5.TabIndex = 27;
            this.fontBtn5.Text = "方正蘭亭";
            this.fontBtn5.UseVisualStyleBackColor = true;
            this.fontBtn5.Click += new System.EventHandler(this.fontBtn5_Click);
            // 
            // GGSkin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 335);
            this.Controls.Add(this.fontBtn5);
            this.Controls.Add(this.fontBtn4);
            this.Controls.Add(this.fontBtn3);
            this.Controls.Add(this.fontBtn2);
            this.Controls.Add(this.fontBtn1);
            this.Controls.Add(this.lolLb3);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lolLb2);
            this.Controls.Add(this.lolSkinHero);
            this.Controls.Add(this.lolSkinDean);
            this.Controls.Add(this.lolSkinPeb);
            this.Controls.Add(this.lolSkinFoxe);
            this.Controls.Add(this.lolSkinDef);
            this.Controls.Add(this.lolLb);
            this.Controls.Add(this.msgLb);
            this.Controls.Add(this.lolBtn);
            this.Controls.Add(this.lolFolderLb);
            this.Controls.Add(this.lolFolder);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GGSkin";
            this.Text = "GGSkin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox lolFolder;
        private System.Windows.Forms.Label lolFolderLb;
        private System.Windows.Forms.Button lolBtn;
        private System.Windows.Forms.Label msgLb;
        private System.Windows.Forms.Label lolLb;
        private System.Windows.Forms.Button lolSkinDef;
        private System.Windows.Forms.Button lolSkinFoxe;
        private System.Windows.Forms.Button lolSkinPeb;
        private System.Windows.Forms.Button lolSkinDean;
        private System.Windows.Forms.Button lolSkinHero;
        private System.Windows.Forms.Label lolLb2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label lolLb3;
        private System.Windows.Forms.Button fontBtn1;
        private System.Windows.Forms.Button fontBtn2;
        private System.Windows.Forms.Button fontBtn3;
        private System.Windows.Forms.Button fontBtn4;
        private System.Windows.Forms.Button fontBtn5;
    }
}

