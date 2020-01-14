using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;//数据库命名空间
using System.Security.Cryptography;
using System.IO;
namespace newdemo
{
    public partial class demo1 : Form
    {
        public SqlConnection con1; //sql数据库连接
        public DataSet date1;//SQL数据库查询返回的本地数据
        public SqlConnection con;//数据库连接
        public SqlDataAdapter myda;//sql数据库查询
        public DataTable dt1;
        public string tabname;
        public string colname;
        public string pkey = "123456";
        public int ppkey;
        public int attribute_index = 11;
        public int position_index;
        public int bit_index;
        public int chosse;
        public int pk = 1;
        public int MAC;
        public string temp;
        public int lidu;
        //public string key;
        public string select;
        public demo1()
        {
            InitializeComponent();
        }

        private void connect_Click(object sender, EventArgs e)
        {
            DateTime beforDT = DateTime.Now;
            string con;
            //获取数据库信息
            con = "Server=" + server.Text.ToString()
                + ";Database=" + database.Text.ToString()
                + ";user id=" + username.Text.ToString()
                + ";password=" + passwd.Text.ToString() + ";";
            //获取数据库信息
            con1 = new SqlConnection(con);//连接数据库
            try//连接异常处理
            {
                con1.Open();           
            }
            catch
            {
                MessageBox.Show("Error!");               
                return;
            }
            tabname = tablename.Text.ToString();//获取目标表名
            select = "select * from " + tabname + ";";//构造查询
            //Console.WriteLine("123");
            myda = new SqlDataAdapter(select, con);//查询所有数据
            date1 = new DataSet();
            myda.Fill(date1, tabname);

            DataColumn[] keys = new DataColumn[1];
            keys[0] = date1.Tables[0].Columns["id"];
            date1.Tables[0].PrimaryKey = keys;

            dataGridView1.DataSource = date1.Tables[0];//将dt的第 0 个表显示到 datagridview1
            ROW.Text = date1.Tables[0].Rows.Count.ToString();//显示最大行数
            COL.Text = date1.Tables[0].Columns.Count.ToString();//显示最大列数
            ROW.Show(); COL.Show();
            DateTime afterDT = DateTime.Now;
            TimeSpan ts = afterDT.Subtract(beforDT);
            //MessageBox.Show("水印添加完成！");
            Console.WriteLine("DateTime总共花费{0}ms.", ts.TotalMilliseconds);
        }

        private void addmas_Click(object sender, EventArgs e)
        {
            string con, tem2;
            double tem1, tem3;
            int tem4;
            //获取数据库信息
            con = "Server=" + server.Text.ToString()
                + ";Database=" + database.Text.ToString()
                + ";user id=" + username.Text.ToString()
                + ";password=" + passwd.Text.ToString() + ";";
            //获取数据库信息
            tabname = tablename.Text.ToString();//获取目标表名
            con1 = new SqlConnection(con);//连接数据库
            DateTime beforDT = DateTime.Now;
            for (int i = 0; i < date1.Tables[0].Rows.Count; i++)
            {
                if (string.Compare(date1.Tables[0].Rows[i][0].ToString(), "", true) == 0)//if the main key doesn't exits
                    continue;
                long MAC = GetMAC(date1.Tables[0].Rows[i][0].ToString());
                lidu = int.Parse(granularity.Text);
                if ((MAC % lidu) != 0)//select the row you want to mark
                {
                    int temmac = (int)MAC;
                    // attribute_index = temmac % lidu + 1;//the attribute we choose
                    //if (attribute_index == 0)
                    tem2 = jiamilie.Text.ToString();
                    attribute_index = Int32.Parse(tem2);
                    bit_index = temmac % lidu;//添加水印的位置 the position adds watermarking
                                              // bit_index = 3;
                    string tem = mark(date1.Tables[0].Rows[i][attribute_index].ToString(), date1.Tables[0].Rows[i][0].ToString(), bit_index);
                    //tem2 = Convert.ToString(date1.Tables[0].Rows[i][attribute_index]);
                    // tem1 = double.Parse(tem2);
                    // tem = tem.Substring(0, 8);
                    //tem4 = System.Convert.ToInt32(tem, 2);
                    // tem3 = tem4 * 0.001;
                    // tem1 = tem1 + tem3;
                    //+ System.Convert.ToInt32(tem, 4) * 0.001;
                    date1.Tables[0].Rows[i][attribute_index] = tem;
                }
                progressBar1.Visible = true;//进度条
                progressBar1.Show();
                progressBar1.Value = (i * 100 / date1.Tables[0].Rows.Count + 1) % 101;
            }
            DateTime afterDT = DateTime.Now;
            TimeSpan ts = afterDT.Subtract(beforDT);
            MessageBox.Show("水印添加完成！");
            Console.WriteLine("DateTime总共花费{0}ms.", ts.TotalMilliseconds);
            dataGridView1.DataSource = date1.Tables[0];//将dt的第 0 个表显示到 datagridview1

        }
        int GetMAC(string key)
        {
            string first_hash1 = GetMd5Hash(key);
            first_hash1 = GetMd5Hash(first_hash1).Substring(0, 2);
            int first_hash2 = System.Int32.Parse(first_hash1, System.Globalization.NumberStyles.HexNumber);
            //int second_hash = Int32.Parse(first_hash2);
            return first_hash2;
            //.Substring(0, 2);
        }
        string GetMd5Hash(String input)//hash函数
        {
            if (input == null)
            {
                return null;
            }

            MD5 md5Hash = MD5.Create();

            // 将输入字符串转换为字节数组并计算哈希数据 
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            // 创建一个 Stringbuilder 来收集字节并创建字符串 
            StringBuilder sBuilder = new StringBuilder();

            // 循环遍历哈希数据的每一个字节并格式化为十六进制字符串 
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x"));
            }
            // 返回十六进制字符串 
            return sBuilder.ToString();
        }
        string mark(string str, string pk, int pos)
        {           
            string temp = str;//转二进制
            string temp1 = temp;
            string key;
            //string temp2
            int a;
            a = Int32.Parse(pk);
            key = (a * pos).ToString();
            //key = key.Substring(0, 2);
            string first_hash = GetMd5Hash(key);
            first_hash = GetMd5Hash(first_hash).Substring(0, 2);
            int first_hash3 = Int32.Parse(first_hash, System.Globalization.NumberStyles.HexNumber);//StringHex turn into int
            String st = str;
            String[] sArray = st.Split('.');
            int temp111 = Convert.ToInt32(sArray[1]);//小数点后数变十进制整数
            string temp2 = Convert.ToString(temp111, 2);//小数点后十进制数转二进制字符串
            string temp22 = temp111.ToString();//十进制小数点后数字符串
            string str3;
            string str4;
            int temp33;
            string temp3;
            if (pos == 0) pos += 2;
            if (temp2.Length < 2) temp2 += "111";
            while (temp2.Length <= pos)
            {
                pos = (pos % temp2.Length);
                if (pos == 0) pos = pos+1;
            }
            string str1 = temp2.Substring(0, temp2.Length - pos);
            string str2 = temp2.Substring(temp2.Length - pos - 1, pos - 1);
            if (first_hash3 % 2 == 0)
                str3 = str1 + "1" + str2;
            else
                str3 = str1 + "0" + str2;
            temp33 = Convert.ToInt32(str3, 2);
            temp3 = temp33.ToString();
            /*}
            else
            {
                pos = pos % 
                str3 = temp2 + "101";
                temp33 = Convert.ToInt32(str3, 2);
                temp3 = temp33.ToString();
                for (int i = 0; i < sArray[1].Length - temp22.Length; i++)
                {
                    temp3 = "0" + temp3;
                }
            }*/
            str4 = sArray[0] + '.' + temp3;
            return str4;
        }
        /*string StringToBinary(string str)//str转二进制
        {
            byte[] data = Encoding.Unicode.GetBytes(str);
            StringBuilder sb = new StringBuilder(data.Length * 8);
            foreach (byte item in data)
            {
                sb.Append(Convert.ToString(item, 2).PadLeft(8, '0'));
            }
            return sb.ToString();
        }*/
        int match(string str, string pk, int pos)
        {
            
            string key;
            int a;
            a = Int32.Parse(pk);
            key = (a * pos).ToString();
            string first_hash = GetMd5Hash(key);
            first_hash = GetMd5Hash(first_hash).Substring(0, 2);
            int first_hash1 = System.Int32.Parse(first_hash, System.Globalization.NumberStyles.HexNumber);
            String st = str;
            String[] sArray = st.Split('.');
            int temp111 = Convert.ToInt32(sArray[1]);//小数点后数变十进制整数
            string temp2 = Convert.ToString(temp111, 2);//小数点后十进制数转二进制字符串
            string temp22 = temp111.ToString();//十进制小数点后数字符串

            string str3;
            string str4;
            int temp33;
            string temp3;
            if (pos == 0) pos += 2;
            if (temp2.Length < 2) temp2 += "111";
            while (temp2.Length <= pos)
            {
                pos = pos % temp2.Length;
                if (pos == 0) pos = pos+1;
            }
            //if (temp2.Length > pos)


            string str1 = temp2.Remove(0, temp2.Length - pos);
            string str2 = str1.Remove(1, str1.Length - 1);

            if (first_hash1 % 2 == 0)
            {
                if (str2.CompareTo("1") == 0)
                    return 1;
                else
                    return 0;

            }
            else
            {
                if (str2.CompareTo("0") == 0)
                    return 1;
                else
                    return 0;

            }
           
        }

        private void username_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string tem2;
            int totalcount = 0;
            int matchcount = 0;
            double result;
            DateTime beforDT = DateTime.Now;
            for (int i = 0; i < date1.Tables[0].Rows.Count; i++)
            {
                if (string.Compare(date1.Tables[0].Rows[i][0].ToString(), "", true) == 0)//if the main key doesn't exits
                    continue;
                MAC = GetMAC(date1.Tables[0].Rows[i][0].ToString());
                lidu = int.Parse(granularity.Text);
                if ((MAC % lidu) != 0)//lect the row you want to mark
                {
                    int temmac = (int)MAC;
                    tem2 = jiamilie.Text.ToString();
                    attribute_index = Int32.Parse(tem2);
                    //attribute_index = 11;
                    bit_index = temmac % lidu;//添加水印的位置 the position adds watermarking
                    totalcount =totalcount + 1;
                    matchcount = matchcount + match(date1.Tables[0].Rows[i][attribute_index].ToString(), date1.Tables[0].Rows[i][0].ToString(), bit_index);//
                }

            }
            result = matchcount * 1.0 / totalcount;
            MessageBox.Show("水印检测完成！");
            MessageBox.Show(Convert.ToString(result));
            DateTime afterDT = DateTime.Now;
            TimeSpan ts = afterDT.Subtract(beforDT);
            // MessageBox.Show("水印添加完成！");
            Console.WriteLine("DateTime总共花费{0}ms.", ts.TotalMilliseconds);
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //DataTable dt1 = date1.Tables[0];
            SqlCommandBuilder bu = new SqlCommandBuilder(myda);
            //dt1.PrimaryKey = new DataColumn[] { dt1.Columns["id"] };
            myda.Update(date1, "weather");
            MessageBox.Show("保存完成！");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string con, tem2;
            double tem1, tem3;
            int tem4;
            //获取数据库信息
            con = "Server=" + server.Text.ToString()
                + ";Database=" + database.Text.ToString()
                + ";user id=" + username.Text.ToString()
                + ";password=" + passwd.Text.ToString() + ";";
            //获取数据库信息
            tabname = tablename.Text.ToString();//获取目标表名
            con1 = new SqlConnection(con);//连接数据库
            int attribute_index_test = attribute_index;
            DateTime beforDT = DateTime.Now;
            for (int i = 0; i < date1.Tables[0].Rows.Count; i++)
            {
                if (string.Compare(date1.Tables[0].Rows[i][0].ToString(), "", true) == 0)//if the main key doesn't exits
                    continue;

                string tem = Reversal(date1.Tables[0].Rows[i][attribute_index_test].ToString());

                date1.Tables[0].Rows[i][attribute_index_test] = tem;
                progressBar1.Visible = true;//进度条
                progressBar1.Show();
                progressBar1.Value = (i * 100 / date1.Tables[0].Rows.Count + 1) % 101;
            }
            MessageBox.Show("攻击完成！");
            DateTime afterDT = DateTime.Now;
            TimeSpan ts = afterDT.Subtract(beforDT);
            // MessageBox.Show("水印添加完成！");
            Console.WriteLine("DateTime总共花费{0}ms.", ts.TotalMilliseconds);

        }
        string Reversal(string input)
        {
            String[] sArray = input.Split('.');
            int t1 = Convert.ToInt32(sArray[1]);
            string t2 = Convert.ToString(t1, 2);
            string result = "";
            for (int i = t2.Length - 1; i >= 0; i--)
            {
                result += t2[i];
            }
            int t3 = Convert.ToInt32(result, 2);
            string t4 = t3.ToString();
            string t5 = sArray[0] + "."+ t4;
            return t5;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void demo1_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void passwd_TextChanged(object sender, EventArgs e)
        {

        }
    }
}