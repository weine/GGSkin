﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace GGSkin
{
    public partial class GGSkin : Form
    {

        public string CurrentPath;
        public string lolExe;
        public GGSkin()
        {
            InitializeComponent();

            this.CurrentPath = System.AppDomain.CurrentDomain.SetupInformation.ApplicationBase;
            this.lolExe = "League of Legends.exe";
        }

        private void lolBtn_Click(object sender, EventArgs e)
        {
            string lolGameFolder = @"C:\GarenaLoLTW\GameData\Apps\LoLTW\Game";
            FolderBrowserDialog folderSelector = new FolderBrowserDialog();
            
            folderSelector.ShowDialog();

            if (String.IsNullOrEmpty(folderSelector.SelectedPath))
            {
                lolFolder.Text = lolGameFolder;
            }
            else
            {
                lolFolder.Text = folderSelector.SelectedPath;
            }
            
        }


        //安裝面板
        private int setupLolUI(string UIname)
        {
            string targetFolder = lolFolder.Text + @"\";
            string targetFile = lolFolder.Text + @"\GGSkin.zip";
            string sourceFile = System.IO.Path.Combine(this.CurrentPath, @"UI\" + UIname);
            int UIresult = 0;
            FileInfo UIFile = new FileInfo(sourceFile);

            //判斷是否有面板檔
            if (!UIFile.Exists)
            {
                Console.WriteLine(this.CurrentPath + UIname);
                UIresult = 1;
                
            }

            //判斷LOL路徑是否為空
            if(String.IsNullOrEmpty(lolFolder.Text))
            {
                Console.WriteLine("未設定LOL目錄!");
                UIresult = 2;
            }

            //判斷資料夾存在
            if(!Directory.Exists(lolFolder.Text))
            {
                Console.WriteLine("資料夾未存在!");
                UIresult = 3;
            }

            //判斷是否為LOL執行檔目錄下
            if (!File.Exists(System.IO.Path.Combine(targetFolder, this.lolExe)))
            {
                Console.WriteLine("不正確的LOL目錄!");
                UIresult = 4;
            }

            //檔案複製
            try
            {
                UIFile.CopyTo(targetFile, true);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                UIresult = 5;
            }

            return UIresult;
            /*
            using (StreamWriter ClipzipFile = new StreamWriter(targetFolder + "test.TXT"))
            {
                ClipzipFile.WriteLine("GGSkin.zip");

                MessageBox.Show("面板套用成功!");
            }
             * */
        }

        //設定文件
        private void setupDoc(int DocNo, int UIcode)
        {
            string targetFolder = lolFolder.Text + @"\";
            string targetFile = lolFolder.Text + @"\ClientZips.TXT";
            string sourceFile = this.CurrentPath;
            
            if(UIcode != 0)
            {
                Console.WriteLine(UIcode);
                MessageBox.Show("面板套用失敗!");
                return;
            }

            //依文件編號判斷
            switch(DocNo)
            {
                case 1:
                    sourceFile += @"zDoc\Default.TXT";
                    break;
                
                case 2:
                    sourceFile += @"zDoc\GGSkin.TXT";
                    break;
                
                default:
                    sourceFile += @"zDoc\Default.TXT";
                    break;
            }

            FileInfo lolCZ = new FileInfo(sourceFile);

            //判斷zDoc是否有檔
            if(!lolCZ.Exists)
            {
                Console.WriteLine(sourceFile);
                Console.WriteLine("zDoc資料夾內無源檔");
                MessageBox.Show("面板套用失敗!");
                return;
            }

            //判斷LOL路徑是否為空
            if (String.IsNullOrEmpty(lolFolder.Text))
            {
                Console.WriteLine("未設定LOL目錄!");
                MessageBox.Show("未設定LOL目錄!");
                return;
            }

            //判斷資料夾存在
            if (!Directory.Exists(lolFolder.Text))
            {
                MessageBox.Show("資料夾未存在!");
                return;
            }

            //判斷是否為LOL執行檔目錄下
            if (!File.Exists(System.IO.Path.Combine(targetFolder, this.lolExe)))
            {
                MessageBox.Show("不正確的LOL目錄!");
                return;
            }

            //檔案複製
            try
            {
                lolCZ.CopyTo(targetFile, true);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("無法複製檔案");
                MessageBox.Show("面板套用失敗!");
                return;
            }

            MessageBox.Show("面板套用成功!");
        }

        //原廠
        private void lolSkinDef_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("功能尚未完成");
            this.setupDoc(1, 0);
        }

        //Foxe UI
        private void lolSkinFoxe_Click(object sender, EventArgs e)
        {
            string FoxeUI = @"Foxe.zip";

            this.setupDoc(2, this.setupLolUI(FoxeUI));
        }

        //Peb UI
        private void lolSkinPeb_Click(object sender, EventArgs e)
        {
            string PebUI = @"Peb.zip";
            this.setupDoc(2, this.setupLolUI(PebUI));
        }

        //Dean UI
        private void lolSkinDean_Click(object sender, EventArgs e)
        {
            string DeanUI = @"Dean.zip";
            this.setupDoc(2, this.setupLolUI(DeanUI));
        }

        //D-Hero UI
        private void lolSkinHero_Click(object sender, EventArgs e)
        {
            string DHeroUI = @"D-Heroes.zip";
            this.setupDoc(2, this.setupLolUI(DHeroUI));
        }

        //安裝字型
        private void setupFont(string fontType)
        {
            string sourceFont = String.Format(@"{0}Fonts\{1}.ttf", this.CurrentPath, fontType);
            string targetFont = String.Format(@"{0}\DATA\Fonts\FZXHYSZK.ttf", lolFolder);

            FileInfo lolfont = new FileInfo(sourceFont);

            //驗證
            if(!File.Exists(sourceFont))
            {
                Console.WriteLine("沒有字型檔!");
                Console.WriteLine(sourceFont);
                MessageBox.Show("字型變更失敗!");
                return;
            }

            if (!Directory.Exists(lolFolder.Text))
            {
                Console.WriteLine("找不到LOL的FontS目錄");
                Console.WriteLine(lolFolder.Text);
                MessageBox.Show("字型變更失敗!");
                return;
            }

            try
            {
                lolfont.CopyTo(targetFont, true);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                MessageBox.Show("字型變更失敗!");
                return;
            }

            if (!File.Exists(targetFont))
            {
                Console.WriteLine("無法複製字型至目標資料夾!");
                MessageBox.Show("字型變更失敗!");
                return;
            }

            
            MessageBox.Show("字型變更成功!");
            
            
        }

        //原廠字型
        private void fontBtn1_Click(object sender, EventArgs e)
        {
            this.setupFont("default");
        }

        //華康彩帶體
        private void fontBtn2_Click(object sender, EventArgs e)
        {
            this.setupFont("font2");
        }

        //華康皮皮體
        private void fontBtn3_Click(object sender, EventArgs e)
        {
            this.setupFont("font3");
        }

        //王漢宗綜藝體
        private void fontBtn4_Click(object sender, EventArgs e)
        {
            this.setupFont("font4");
        }

        //方正蘭亭粗黑
        private void fontBtn5_Click(object sender, EventArgs e)
        {
            this.setupFont("font5");
        }
    }
}
