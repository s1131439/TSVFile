using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TSVFile
{
    public partial class frmTSVFile : Form
    {

        /// <summary>
        /// 關於視窗
        /// </summary>
        frmAbout about = new frmAbout();

        /// <summary>
        /// 單字清單
        /// </summary>
        WordCollection _WordList = new WordCollection();

        public frmTSVFile()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 更新 ListView 的內容
        /// </summary>
        /*
        private void UpdateListView()
        {
            lvwWord.BeginUpdate(); //暫停重繪
            // 清除 ListView 的所有項目
            lvwWord.Items.Clear();
            // 將 WordCollection 物件中的資料載入到 ListView 中
            foreach (WordItem item in _WordList)
            {
                // 建立 ListViewItem 物件
                ListViewItem lvi = new ListViewItem(item.Word);
                lvi.SubItems.Add(item.Phonogram);
                lvi.SubItems.Add(item.SoundPath);
                lvi.SubItems.Add(item.Explain);
                // 將 ListViewItem 物件加入到 ListView 中
                lvwWord.Items.Add(lvi);
            }
            lvwWord.EndUpdate(); //重繪;
        }
        */
        private void UpdateListView(IEnumerable<WordItem> items = null)
        {
            lvwWord.BeginUpdate();

            lvwWord.Items.Clear();

            // 如果沒有傳入資料，就顯示全部
            if (items == null)
            {
                items = _WordList;
            }
            /*
            foreach (WordItem item in items)
            {
                ListViewItem lvi = new ListViewItem(item.Word);

                lvi.SubItems.Add(item.Phonogram);
                lvi.SubItems.Add(item.SoundPath);
                lvi.SubItems.Add(item.Explain);

                lvwWord.Items.Add(lvi);
            }
            */
            foreach (WordItem item in items)
            {
                ListViewItem lvi = new ListViewItem(item.Word);

                lvi.SubItems.Add(item.Phonogram);
                lvi.SubItems.Add(item.SoundPath);
                lvi.SubItems.Add(item.Explain);

                // 把 WordItem 存進 Tag
                lvi.Tag = item;

                lvwWord.Items.Add(lvi);
            }
            lvwWord.EndUpdate();
        }
        private void tsmiAbout_Click(object sender, EventArgs e)
        {
            // 顯示關於視窗
            about.ShowDialog(this);
        }

        private void tsmiOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            //設定檔案類型過濾器,讓使用者只能選擇 TSV 或 TXT 檔
            ofd.Filter = "TSV files (*.tsv)|*.tsv|Text files (*.txt)|*.txt|All files(*.*) | *.* ";
            //設定對話框的標題
            ofd.Title = "開啟檔案";
            // 設定初始目錄為應用程式的啟動路徑
            ofd.InitialDirectory = Application.StartupPath;
            DialogResult dr = ofd.ShowDialog(this);
            if (dr == DialogResult.OK)
            {
                // 讀取檔案並且將每一行的資料放入字串陣列
                string[] lines = File.ReadAllLines(ofd.FileName, Encoding.UTF8);
                // 將字串陣列的資料載入到 WordCollection 物件中
                _WordList.LoadFromStringArray(lines);
                // 將 WordCollection 物件中的資料載入到 ListView 中
                UpdateListView();
                this.tsslMessage.Text = $"{_WordList.Count}單字已成功載入";
            }
        }

        private void tsmiExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmTSVFile_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("確定要離開嗎?", "離開", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No)
            {
                e.Cancel = true; // 取消關閉
            }
        }

        private void frmTSVFile_Load(object sender, EventArgs e)
        {
            this.tsslMessage.Text = "";
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            // 取得搜尋文字
            string keyword = txtSearch.Text.ToLower();

            // 如果是空白，顯示全部
            if (keyword == "")
            {
                UpdateListView();
                return;
            }

            // 前綴搜尋
            var result = _WordList.Where(x =>
                x.Word.ToLower().StartsWith(keyword)
            );

            // 更新 ListView
            UpdateListView(result);
            tsslMessage.Text = $"找到 {result.Count()} 筆";
        }
        private void PlayWordSound(WordItem item)
        {
            if (item == null)
            {
                return;
            }

            // bin\Debug\Sound
            string soundFolder = Path.Combine(
                Application.StartupPath,
                "Sound"
            );

            // 完整路徑
            string soundPath = Path.Combine(
                soundFolder,
                item.SoundPath
            );

            // 檢查檔案
            if (!File.Exists(soundPath))
            {
                MessageBox.Show(
                    $"找不到音檔\n{soundPath}"
                );

                return;
            }

            // 播放
            axWindowsMediaPlayer1.URL = soundPath;
            axWindowsMediaPlayer1.Ctlcontrols.play();

            tsslMessage.Text = $"播放：{item.Word}";
        }

        private void lvwWord_DoubleClick(object sender, EventArgs e)
        {
            // 沒選取
            if (lvwWord.SelectedItems.Count == 0)
            {
                return;
            }

            // 取出 WordItem
            WordItem item =
                lvwWord.SelectedItems[0].Tag as WordItem;

            // 播放
            PlayWordSound(item);
        }
    }
}
