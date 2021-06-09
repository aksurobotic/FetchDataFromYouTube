using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace DbUpadte
{
    class addVideo
    {
        public string SqlString { get; set; }
        public string Url { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public addVideo(string name, string url,string tableName="VideoY", string description = null,
            string sqlConnectionString="Server=sqloledb;Data Source=SQL5097.site4now.net,1433;Initial Catalog=db_a753b9_aksuabdullah;User Id=db_a753b9_aksuabdullah_admin;Password=adaturk2578")
        {
            SqlString = sqlConnectionString;
            Name = name;
            Description = description;
            
            // sql string must be defined by creating a sqlConnection object.
            //System.Data.SqlClient.SqlConnection sqlConnection1 =
            //new System.Data.SqlClient.SqlConnection(sqlConnectionString);
            
            //System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            string targetString = url;
            //seperating the YouTubeId from the Url. 
            int lastSlashIndex = targetString.LastIndexOf('=');
            string ytid = targetString.Substring(lastSlashIndex + 1);

            url = $"https://www.youtube.com/embed/{ytid}";



            //string tableName = "Video"; // this is the nabe of table in the above routed databe.Incase it was not set as parameter in the constructor. 

            using (SqlConnection connection = new SqlConnection(sqlConnectionString))
            {
                connection.Open();
                string sql;
                if (description == null) { sql = $"INSERT INTO {tableName} (Name,Url,YTId) VALUES(@Name,@Url,@YTId)"; }
                else
                {
                    sql = $"INSERT INTO {tableName} (Name,Description,Url,YTId) VALUES(@Name,@Description,@Url,@YTId)";
                }
              
                using (SqlCommand cmd = new SqlCommand(sql,connection))
                {
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@Url", url);
                    cmd.Parameters.AddWithValue("@YTId", ytid);
                    if (description != null){cmd.Parameters.AddWithValue("@Description", description);}
                    cmd.ExecuteNonQuery();
                }
            }

            //cmd.CommandType = System.Data.CommandType.Text;
            //cmd.CommandText = $"INSERT  {tableName} (Name,Description,Url,YTId) VALUES ('{name}','{description}','{url}', '{ytid}')";
            //cmd.Parameters.AddWithValue("@Name", name);
            //cmd.Connection = sqlConnection1;
            //sqlConnection1.Open();
            //cmd.ExecuteNonQuery();
            //sqlConnection1.Close();

        }
       

    }
}
