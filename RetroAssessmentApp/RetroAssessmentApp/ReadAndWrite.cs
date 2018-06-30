using System;
using System.IO;
using System.Collections.Generic;

namespace RetroAssessmentApp
{
    public class ReadAndWrite
    {
        public List<string> Read(string path, FileMode fm = FileMode.Open)
        {
            List<string> Words = new List<string>();

            int count;
            string line;
            FileStream fs = new FileStream(path, fm);
            StreamReader sr = new StreamReader(fs);

            try
            {
                line = sr.ReadLine();
                count = line.Length;
                while (line != string.Empty && line != null)
                {
                    Words.Add(line.Substring(0, line.Length - 1));
                    line = sr.ReadLine();

                    if (line.Length != count)
                    {
                        Console.WriteLine("Words are not the same length the application will now terminate");
                        Console.ReadLine();
                        break;
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Please make sure that text file is correct");
            }

            return Words;
        }
    }
}
