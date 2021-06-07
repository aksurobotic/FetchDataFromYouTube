using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Text;

namespace DbUpadte
{
    class YtChanell
    {
        public string ChanellName { get; set; }
        public List<string> Ytid { get; set; }

        public YtChanell(string url)
        {

            

            var htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(url);

            var htmlNodes = htmlDoc.DocumentNode.SelectSingleNode("//body");
            string result = htmlNodes.WriteTo();

            Console.WriteLine(result);

            //foreach (var node in htmlNodes)
            //{

            //    Console.WriteLine(node);
            //}


            //ChanellName = chanellName;
            //HtmlAgilityPack.HtmlWeb web = new HtmlAgilityPack.HtmlWeb();
            //HtmlAgilityPack.HtmlDocument doc = web.Load(url);
            //Console.Write(doc.ToString());
            //Console.ReadLine();


            //foreach (var item in doc.DocumentNode.SelectNodes("//a[@id='video-title']"))
            //{
            //    Console.Write(item.InnerText);
            //    Ytid.Add(item.InnerText);
            //}
        }
    }

  
}
