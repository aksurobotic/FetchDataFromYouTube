using System;
using HtmlAgilityPack;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

public class Channell
{
    public string ChanellName { get ; set; }
    public List<string> Ytid { get; set; }

    [Required(ErrorMessage = "Chanell Url is required.")]
    public string Url { get; set; }

    //constructor
    public Channell(string url)
    {
        Url = url;
        Ytid = new List<string>();
        GetYtid(this).Wait();
       
    }
    
    public async Task GetYtid(Channell channel)
    {
        var url = channel.Url;
        var list = channel.Ytid;
        var httpClient = new HttpClient();
        var html = await httpClient.GetStringAsync(url);
        

        var htmlDocument = new HtmlDocument();
        htmlDocument.LoadHtml(html);

        var displayString = html.ToString();
        //Regex regex = new Regex("(watch?v=)(.*)(\")$");

        Match match = Regex.Match(displayString, @"(watch\?).+?("")");
        
        if (! match.Success)
        {
            Console.WriteLine("No Match");
            //match = match.NextMatch();
            //Console.WriteLine(match.Value);
        }
        else
        {
            int i = 1;
            while (match.Success)
            {
                var finaltext = match.Value.Remove(match.Value.Length - 1, 1);
                list.Add(finaltext);
                //Console.WriteLine(finaltext);
                //Console.WriteLine("Step number" + i);
                match = match.NextMatch();
                i++;
            }
            
        }
        //channel.Ytid = list; 
    }
}

