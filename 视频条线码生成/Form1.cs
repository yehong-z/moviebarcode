using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace moviecodebar
{
    
    public partial class Form1 : Form
    {

        [DllImportAttribute(@"palette.dll")]
        private extern static void generate_code(string s, string b);

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Multiselect = false;      //该值确定是否可以选择多个文件
            dialog.Title = "请选择视频文件";     //弹窗的标题
            dialog.Filter = "mp4文件(*.mp4)|*.mp4|所有文件(*.*)|*.*";       //筛选文件

            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                textBox1.Text = dialog.FileName;
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text;
            generate_code(s, @"./条形码.jpg");

            MessageBox.Show("生成完毕", "提示");
        }
    }
}
