using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsTest
{
    public partial class Form1 : Form
    {
        private List<TestModel> details;

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Form Load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            // データを追加
            details = new List<TestModel>() {
                new TestModel { Subject="国語", Points=90, Name="田中　一郎", RankName="A" },
                new TestModel { Subject="国語", Points=80, Name="鈴木　二郎", RankName="A" },
                new TestModel { Subject="国語", Points=60, Name="佐藤　三郎", RankName="B" },
                new TestModel { Subject="数学", Points=90, Name="田中　一郎", RankName="A" },
                new TestModel { Subject="数学", Points=85, Name="鈴木　二郎", RankName="A" },
                new TestModel { Subject="数学", Points=90, Name="佐藤　三郎", RankName="A" },
                new TestModel { Subject="英語", Points=90, Name="田中　一郎", RankName="A" },
                new TestModel { Subject="英語", Points=100, Name="鈴木　二郎", RankName="A" },
                new TestModel { Subject="英語", Points=40, Name="佐藤　三郎", RankName="C" }
            };

            dataGridView1.DataSource = details;

            // カラム名を指定
            dataGridView1.Columns[0].HeaderText = "教科";
            dataGridView1.Columns[1].HeaderText = "点数";
            dataGridView1.Columns[2].HeaderText = "氏名";
            dataGridView1.Columns[3].HeaderText = "ランク";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var result = details.Where(row => row.Subject == this.textBoxSubject.Text).ToList();

            dataGridView1.DataSource = result;
        }
    }
}
