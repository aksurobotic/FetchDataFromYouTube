using HtmlAgilityPack;
using System;
using System.Linq;
using System.Net.Http;
using System.Text.RegularExpressions;

namespace DbUpadte
{
    class Program
    {
        static void Main(string[] args)
        {
            //var TransAlm = new Channell(url: "https://www.youtube.com/channel/UCkdHml_djw05xjm7ceRJreQ/videos");
            //TransAlm.Ytid.ForEach(i => Console.Write("{0}\t", i));

            var test = new scrollToButtom("https://www.youtube.com/c/Freecodecamp/videos");
            int totalLink = 0;

            for (int i = 0; i < test.ScrollRead.Count; i++)
            {
                Console.Write("{0}\t", test.ScrollRead[i].GetAttribute("href"));
                totalLink = i;
            }
            Console.WriteLine("extract copmlated");
            Console.WriteLine($"{test.ScrollRead.Count} this is total detected container");
            Console.WriteLine($"{totalLink + 1} this is total detected link");
            test.driver.Close();
            Console.Read();





            //TransAlm.GetYtid(TransAlm);


            //GetHtmlAsyn();



            //Console.WriteLine(TransAlm.Ytid.ToString());

            //TransAlm.Ytid.ForEach(Console.WriteLine);

            Console.ReadLine();

            //YtChanell guldur = new YtChanell(url:"https://www.haberler.com");

            //addVideo newVideo = new addVideo(name:"Michael Jackson",description:"They do not care about us !",url: "https://www.youtube.com/embed/QNJL6nfu__Q");

            //System.Data.SqlClient.SqlConnection sqlConnection1 =
            //new System.Data.SqlClient.SqlConnection("Server=sqloledb;Data Source=SQL5097.site4now.net,1433;Initial Catalog=db_a753b9_aksuabdullah;User Id=db_a753b9_aksuabdullah_admin;Password=adaturk2578");
            //System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            //cmd.CommandType = System.Data.CommandType.Text;
            //cmd.CommandText = "INSERT  Video (Name,Description,Url,YTId) VALUES ('TestName','TestDescription','https://www.youtube.com/embed/qeMFqkcPYcg', 'qeMFqkcPYcg')";
            //cmd.Connection = sqlConnection1;

            //sqlConnection1.Open();
            //cmd.ExecuteNonQuery();
            //sqlConnection1.Close();

            //Console.WriteLine(guldur.ToString());

            //var html =
            //@"https://www.haberler.com/";

            //var htmlDoc = new HtmlDocument();
            //htmlDoc.LoadHtml(html);


            //var node = htmlDoc.DocumentNode.SelectSingleNode("//body");

            //string result = node.WriteTo();

            //Console.WriteLine(result);

            //var html = @"https://www.youtube.com/user/guldurguldurtv/videos";

            //HtmlWeb web = new HtmlWeb();

            //var htmlDoc = web.Load(html);

            //var node = htmlDoc.DocumentNode.SelectSingleNode("//html");

            //Console.WriteLine("Node Name: " + node.Name + "\n" + node.OuterHtml);
        }

        //private static async void GetHtmlAsyn()
        //{
        //    var url = "https://www.youtube.com/channel/UCkdHml_djw05xjm7ceRJreQ/videos";
        //    var httpClient = new HttpClient();
        //    var html = await httpClient.GetStringAsync(url);

        //    var htmlDocument = new HtmlDocument();
        //    htmlDocument.LoadHtml(html);

        //    var displayString = html.ToString();
        //    Regex regex = new Regex("(watch?v=)(.*)(\")$");

        //    Match match = Regex.Match(displayString, @"(watch\?).+?("")");
        //    if (! match.Success)
        //    {
        //        Console.WriteLine("No Match");
        //        //match = match.NextMatch();
        //        //Console.WriteLine(match.Value);
        //    }
        //    else
        //    {
        //        int i = 1;
        //        while (match.Success)
        //        {

        //            Console.WriteLine(match.Value);
        //            Console.WriteLine("Step number" + i);
        //            match = match.NextMatch();
        //            i++;
        //        }
        //    }
        //match = match.NextMatch();



        //var VideoList = htmlDocument.DocumentNode.Descendants("a")
        //    .Where(node => node.GetAttributeValue("id", "")
        //    .Equals("video-title")).ToList();

        //Console.WriteLine(html.ToString());
        //}

    }

}
