using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW8_GUI
{
    class DBConnection
    {
        string strCon = @"Data Source=kobi\SQLEXPRESS;Initial Catalog=TBItem;Integrated Security=True;Trust Server Certificate=True";
        string strCmd;


        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adtr;
        DataSet ds;
        DataTable dt;


        public DBConnection()
        {
            con = new SqlConnection(strCon);
            adtr = new SqlDataAdapter(" SELECT * " +
                                      " FROM tbItem ", con);
            ds = new DataSet();
            adtr.Fill(ds, "T1");

        }

        public DataTable ItemsTable()
        {
            return ds.Tables["T1"];
        }

        public DataTable FilterByAbovePrice(int price)
        {
            SqlCommandBuilder comb = new SqlCommandBuilder(adtr);
            if (price >)

        }

        public DataTable InsertItem(Item item)
        {
            if (item == null)
            {
                return null;
            }
            DataRow dr = dt.NewRow();
            dr["Name"] = item.Name;
            dr["Price"] = item.Price;
            dr["Description"] = item.Description;

            dt.Rows.Add(dr);
            return dt;
        }

        public DataTable DeleteItem(int code)
        {
            DataTable dt = ds.Tables["T1"];

            foreach (DataRow row in dt.Rows)
            {
                if (row["Code"].ToString() == code.ToString())
                {
                    row.Delete();
                    return dt;
                }
            }

            return null;
        }

        public void UpdateItem(DataTable table)
        {
            SqlCommandBuilder builder = new SqlCommandBuilder(adtr);
            adtr.Update(table);
        }

        internal void UpdateDB(DataTable table)
        {
            throw new NotImplementedException();
        }
    }

}

