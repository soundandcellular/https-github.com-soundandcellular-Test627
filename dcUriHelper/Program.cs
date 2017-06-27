using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace dcUriHelper
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string[] ProgramArgs = args[0].Split(':');

                if (ProgramArgs[0] == "winbox") {
                    //string[] PassthroughArgs = ProgramArgs[1].Split(',');
                    Process winBox = new Process();
                    winBox.StartInfo.FileName = @"C:\winbox.exe";
                    winBox.StartInfo.Arguments = ProgramArgs[1] + " DrillCommNOC mvgp97c";
                    winBox.Start();
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                System.Threading.Thread.Sleep(1000);
            }
        }
    }
}
