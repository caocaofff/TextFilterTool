using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Two_way_screening_tool
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonChooseSourceTextFile_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog
                {
                    Multiselect = true,//该值确定是否可以选择多个文件
                    Title = "请选择文本文件",
                    Filter = "文本文件(*.txt)|*.txt"
                };
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    string file = dialog.FileName;
                    textBoxSourceTextFile.Text = file;
                    textBoxSource.Text = "";
                    //ArrayList lstSource = new ArrayList();
                    StreamReader srSource = new StreamReader(textBoxSourceTextFile.Text.Trim(), (Encoding)GetEncoding(comboBoxEncoding.Text.ToString()));
                    while (!srSource.EndOfStream)
                    {
                        string str = srSource.ReadLine().Trim();
                        if (str != "")
                        {
                            //lstSource.Add(str);
                            textBoxSource.Text += str + "\r\n";
                        }

                    }
                    textBoxLog.Text += "源文本行数：" + textBoxSource.Lines.GetUpperBound(0) + "\r\n";
                    srSource.Close();
                }
            }
            catch
            {
                MessageBox.Show(e.ToString(), "Error");
            }
        }

        private void buttonChooesTargetTextFile_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Multiselect = true;//该值确定是否可以选择多个文件
                dialog.Title = "请选择文本文件";
                dialog.Filter = "文本文件(*.txt)|*.txt";
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    string file = dialog.FileName;
                    textBoxTargetTextFile.Text = file;
                    textBoxTarget.Text = "";
                    //ArrayList lstTarget = new ArrayList();
                    StreamReader srTarget = new StreamReader(textBoxTargetTextFile.Text.Trim(), (Encoding)GetEncoding(comboBoxEncoding.Text.ToString()));
                    while (!srTarget.EndOfStream)
                    {
                        string str = srTarget.ReadLine().Trim();
                        if (str != "")
                        {
                            //lstTarget.Add(str);
                            textBoxTarget.Text += str + "\r\n";
                        }

                    }
                    textBoxLog.Text += "目标文本行数：" + textBoxTarget.Lines.GetUpperBound(0) + "\r\n";
                    srTarget.Close();
                }
            }
            catch
            {
                MessageBox.Show(e.ToString(), "Error");
            }
        }

        private void buttonFilter_Click(object sender, EventArgs e)
        {
            try
            {
                buttonFilter.Enabled = false;
                textBoxFound.Text = "";
                textBoxNotFound.Text = "";
                //textBoxLog.Text += "开始筛选\r\n";

                //获取文本到动态数组
                ArrayList arrSource = new ArrayList();
                foreach (string str in textBoxSource.Lines)
                {
                    arrSource.Add(str);
                }
                ArrayList arrTarget = new ArrayList();
                foreach (string str in textBoxTarget.Lines)
                {
                    arrTarget.Add(str);
                }


                //交叉比较文本
                int j = 0;
                foreach (object o in arrTarget)
                {

                    for (int i = 0; i < arrSource.Count; i++)
                    {
                        object c = arrSource[i];
                        if (c.ToString() == o.ToString() && o.ToString() != "")
                        {

                            textBoxFound.Text += o.ToString() + "\r\n";
                            j++;

                        }
                    }
                }
                textBoxLog.Text += "已发现目标数：" + j.ToString() + "\r\n";

                //列出未找到的文本

                ArrayList arrFound = new ArrayList();
                foreach (string str in textBoxFound.Lines)
                {
                    arrFound.Add(str);
                }
                int l = textBoxTarget.Lines.GetUpperBound(0);
                for (int i = 0; i < textBoxFound.Lines.GetUpperBound(0); i++)
                {
                    //if (arrTarget.Count == arrFound.Count)
                    //{
                    //break;
                    //}
                    string strFound = arrFound[i].ToString();

                    for (int k = 0; k < l; k++)
                    {

                        string strTarget = arrTarget[k].ToString();

                        if (strTarget == strFound)
                        {
                            arrTarget.RemoveAt(k);
                            l--;
                            k--;
                        }
                    }
                }

                for (int i = 0; i < arrTarget.Count; i++)
                {
                    textBoxNotFound.Text += arrTarget[i].ToString() + "\r\n";
                }
                textBoxLog.Text += "未发现目标数：" + (arrTarget.Count - 1).ToString() + "\r\n";


                buttonFilter.Enabled = true;
            }
            catch
            {
                MessageBox.Show(e.ToString(), "Error");
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            object[] encoding = { "Default", "UTF-7", "UTF-8", "Unicode", "UTF-32", "GB2312","ASCII" };
            comboBoxEncoding.Items.AddRange(encoding);
            comboBoxEncoding.SelectedIndex = 2;
        }

        private object  GetEncoding(string coding)
        {
            object  ret;
            switch (coding)
            {
                case "Default":
                    ret = Encoding.Default;
                    break;
                case "UTF-7":
                    ret = Encoding.UTF7;
                    break;
                case "UTF-8":
                    ret = Encoding.UTF8;
                    break;
                case "Unicode":
                    ret = Encoding.Unicode;
                    break;
                case "UTF-32":
                    ret = Encoding.UTF32;
                    break;
                case "GB2312":
                    ret = Encoding.GetEncoding("GB2312");
                    break;
                default:ret = Encoding.UTF8;
                    break;
            }

            return ret;
        }

        private void textBoxLog_TextChanged(object sender, EventArgs e)
        {
            textBoxLog.Select(textBoxLog.Text.Length - 1, 0);
            textBoxLog.ScrollToCaret();
        }
    }
}
