//
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 人臉辨識打卡系統
{
    class Database
    {
        string connString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=" + Directory.GetCurrentDirectory() +  "\\人臉辨識系統.mdf;Integrated Security = True; Connect Timeout = 30";
        SqlConnection sqlConnection;
        SqlDataAdapter dataAdapter;
        public DataTable dataTable = new DataTable();
        string label = "";
        public Database()
        {
            sqlConnection = new SqlConnection(connString);
            sqlConnection.Open();
            if (sqlConnection.State == ConnectionState.Open)
            {
                Console.WriteLine("資料庫連接成功");
                getData();
            }
            else
            {
                Console.WriteLine("資料庫連接失敗");
            }
        }
        public void getData()
        {
            search("員工");
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                label += (dataTable.Rows[i]["ID"].ToString() + " " + dataTable.Rows[i]["姓名"].ToString() + " " + dataTable.Rows[i]["職位"].ToString() + " " + dataTable.Rows[i]["部門"].ToString() + " " + dataTable.Rows[i]["UID"].ToString() + "\n");                
            }
            Console.WriteLine("dbo.員工");
            Console.WriteLine(label);

            label = "";
            search("打卡紀錄");
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                label += dataTable.Rows[i]["ID"].ToString() + " " + dataTable.Rows[i]["時間"].ToString() + " " + dataTable.Rows[i]["上下班"].ToString() + "\n";
            }
            Console.WriteLine("dbo.打卡紀錄");
            Console.WriteLine(label);
        }
        public void exec(string cmd)
        {
            Console.WriteLine(cmd);
            try
            {
                dataAdapter = new SqlDataAdapter(cmd, connString);
                dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                dataAdapter.Update(dataTable);
                Console.WriteLine("執行成功");
            }
            catch(Exception e)
            {
                Console.WriteLine("執行失敗");
                Console.WriteLine(e.ToString());
            }
        }

        public void close()
        {
            sqlConnection.Close();
            Console.WriteLine("資料庫關閉成功");
        }
        public void add(int id, string name, string position, string apartment, string uid)
        {
            //exec(String.Format("insert into dbo.員工(ID, 姓名, 職位, 部門, UID) values({0}, '{1}', '{2}', '{3}', '{4}')", id, name, position, apartment, uid));
            SqlCommand s = new SqlCommand("insert into dbo.員工(ID, 姓名, 職位, 部門, UID) values(@value1, @value2, @value3, @value4, @value5)", sqlConnection);
            s.Parameters.AddWithValue("@value1",id);
            s.Parameters.AddWithValue("@value2",name);
            s.Parameters.AddWithValue("@value3",position);
            s.Parameters.AddWithValue("@value4",apartment);
            s.Parameters.AddWithValue("@value5",uid);
            try
            {
                s.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            search("員工");
        }
        public void record(int id, DateTime datetime, string workorhome)
        {
            //exec(String.Format("insert into dbo.員工(ID, 姓名, 職位, 部門, UID) values({0}, '{1}', '{2}', '{3}', '{4}')", id, name, position, apartment, uid));
            SqlCommand sr = new SqlCommand("insert into dbo.打卡紀錄(ID, 時間, 上下班) values(@value1, @value2, @value3)", sqlConnection);
            sr.Parameters.AddWithValue("@value1", id);
            sr.Parameters.Add("@value2", SqlDbType.DateTime).Value = datetime;
            sr.Parameters.AddWithValue("@value3", workorhome);
            sr.ExecuteNonQuery();
        }
        public void search(string table)
        {
            exec(String.Format("select * from dbo.{0}", table));
        }
        public void search(string table, string where)
        {
            exec(String.Format("select * from dbo.{0} where {1}", table, where));
        }
        public void del(string table, string where)
        {
            exec(String.Format("delete from {0} where {1}", table, where));
        }

        public string getName(int id)
        {
            Console.WriteLine();
            search("員工", "id=" + id.ToString());
            try
            {
                return dataTable.Rows[0]["姓名"].ToString();
            }
            catch
            {
                return "NOTHING";
            }
        }
    }
}
