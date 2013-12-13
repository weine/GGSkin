using System;
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
        private void setupLolUI(string UIname)
        {
            string targetFolder = lolFolder.Text + @"\";
            string targetFile = lolFolder.Text + @"\GGSkin.zip";
            string sourceFile = System.IO.Path.Combine(this.CurrentPath, @"UI\" + UIname);
            FileInfo UIFile = new FileInfo(sourceFile);

            //判斷是否有面板檔
            if (!UIFile.Exists)
            {
                Console.WriteLine(this.CurrentPath + UIname);
                MessageBox.Show("檔案不存在!");
                return;
                
            }

            //判斷LOL路徑是否為空
            if(String.IsNullOrEmpty(lolFolder.Text))
            {
                Console.WriteLine("未設定LOL目錄!");
                MessageBox.Show("未設定LOL目錄!");
                return;
            }

            //判斷資料夾存在
            if(!Directory.Exists(lolFolder.Text))
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
            UIFile.CopyTo(targetFile, true);

            /*
            using (StreamWriter ClipzipFile = new StreamWriter(targetFolder + "test.TXT"))
            {
                ClipzipFile.WriteLine("GGSkin.zip");

                MessageBox.Show("面板套用成功!");
            }
             * */
        }

        //設定文件
        private void setupDoc(int DocNo)
        {
            string targetFolder = lolFolder.Text + @"\";
            string targetFile = lolFolder.Text + @"\ClientZips.TXT";
            string sourceFile = this.CurrentPath;
            
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
            lolCZ.CopyTo(targetFile, true);
            MessageBox.Show("面板套用成功!");
        }

        //原廠
        private void lolSkinDef_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("功能尚未完成");
            this.setupDoc(1);
        }

        //Foxe UI
        private void lolSkinFoxe_Click(object sender, EventArgs e)
        {
            string FoxeUI = @"Foxe.zip";
            this.setupLolUI(FoxeUI);
            this.setupDoc(2);
        }

        //Peb UI
        private void lolSkinPeb_Click(object sender, EventArgs e)
        {
            string PebUI = @"Peb.zip";
            this.setupLolUI(PebUI);
            this.setupDoc(2);
        }

        //Dean UI
        private void lolSkinDean_Click(object sender, EventArgs e)
        {
            string DeanUI = @"Dean.zip";
            this.setupLolUI(DeanUI);
            this.setupDoc(2);
        }

        //D-Hero UI
        private void lolSkinHero_Click(object sender, EventArgs e)
        {
            string DHeroUI = @"D-Heroes.zip";
            this.setupLolUI(DHeroUI);
            this.setupDoc(2);
        }
    }
}
