using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace VangdeVolger
{
    class ScoreBoard
    {
        SortedDictionary<int, string> _scoreDic = new SortedDictionary<int, string>();
        void readFromFile()
        {

        }

        void addScore(int score,string name)
        {
            _scoreDic.Add(score, name);


        }
        ScoreBoard()
        {
            string username = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            string path = String.Format("C:\\Users\\{0}\\Documents\\VangDeVolger\\Scoreboard.txt",username);

            if (!File.Exists(path))
            {
                File.Create(path);
                for (int i = 0; i < 5; i++)
                {
                    File.AppendAllText(path, "0 reee");
                }
                
            }

            String[] lines = File.ReadAllLines(path);
            foreach (string line in lines)
            {
                String[] splitString = line.Split(' ');
                _scoreDic.Add(Int32.Parse(splitString[0]),splitString[1]);

            }
        }
    }
}
