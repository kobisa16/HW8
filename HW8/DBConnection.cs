using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Protocols.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace HW8
{
    internal class DBConnection
    {
        string strCon = @"Data Source=kobi\SQLEXPRESS;Initial Catalog=TBItem;Integrated Security=True;Trust Server Certificate=True";
        string strCmd;

        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader reader;

        public DBConnection()
        {
            con = new SqlConnection(strCon);
        }


        public string ReadItemsTable()
        {
            cmd = new SqlCommand(" SELECT *" +
                                 " FROM Items", con);
            string result = "";
            con.Open();
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                result += reader["Code"].ToString() + "--" +
                          reader["Name"].ToString() + "--" +
                          reader["Price"].ToString() + "--" +
                          reader["Description"].ToString() + "\n";
            }

            con.Close();
            return result;
        }

        public int AddItemToDB(Item item)
        {
            SqlCommand cmd1 = new SqlCommand(" INSERT INTO TBItem (Name) " +
                                             " VALUES (@name, @price, @desc)", con);

            cmd1.Parameters.AddWithValue("@name", item.Name);
            cmd1.Parameters.AddWithValue("@price", item.Price);
            cmd1.Parameters.AddWithValue("@desc", item.Description);
            con.Open();
            int res = cmd1.ExecuteNonQuery();
            con.Close();

            if (res == 1)
            {
                Console.WriteLine("its works");
            }

            else
            {
                Console.WriteLine("something went wrong");
            }

            return res;
        }

        public int DeleteItemFromDB(int code)
        {
            SqlCommand cmd3 = new SqlCommand(" DELETE FROM TBItem " +
                                             " WHERE Code = @code", con);
            cmd3.Parameters.AddWithValue("@code", code);
            int delRes = 0;
            con.Open();
            delRes = cmd3.ExecuteNonQuery();
            con.Close();

            if (delRes == 1)
            {
                Console.WriteLine("its works");
            }
            else
            {
                Console.WriteLine("something went wrong");
            }
            return delRes;
        }




    }
}
