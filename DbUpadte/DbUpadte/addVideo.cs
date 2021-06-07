using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace DbUpadte
{
    class addVideo
    {
        public addVideo(string name,string description, string url)
        {
            System.Data.SqlClient.SqlConnection sqlConnection1 =
            new System.Data.SqlClient.SqlConnection("Server=sqloledb;Data Source=SQL5097.site4now.net,1433;Initial Catalog=db_a753b9_aksuabdullah;User Id=db_a753b9_aksuabdullah_admin;Password=adaturk2578");
            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            string targetString = url;
            int lastSlashIndex = targetString.LastIndexOf('/');
            string ytid = targetString.Substring(lastSlashIndex + 1);

            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = $"INSERT  Video (Name,Description,Url,YTId) VALUES ('{name}','{description}','{url}', '{ytid}')";
            cmd.Connection = sqlConnection1;
            sqlConnection1.Open();
            cmd.ExecuteNonQuery();
            sqlConnection1.Close();

        }
       

    }
}
