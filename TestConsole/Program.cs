using System;
using System.Linq;
using System.IO;
using Files;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] sr = File.ReadAllLines(MyFiles.MyFilesInfo + "English.srt");
            var sub = (from s in sr
                       where s.ToString().StartsWith('[') && s.ToString().EndsWith(']')
                       select s).Distinct().ToList();
            foreach (var X in sub)
            {
                //Console.WriteLine(X.Replace('[', ' ').Replace(']', ' '));
                //Console.WriteLine(X.TrimStart('[').TrimEnd(']'));
                Console.WriteLine(X.Trim('[', ']'));
            }
        }
    }
}
