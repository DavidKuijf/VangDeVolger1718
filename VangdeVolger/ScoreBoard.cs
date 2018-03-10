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
        //make the dictionary for the runtime leaderboard
        SortedDictionary<int, string> _scoreDic = new SortedDictionary<int, string>();
        void readFromFile()
        {
            //TODO add a function that reads the current local high scores from a file
        }

        void addScore(int score,string name)
        {
            //add a score to the list
            _scoreDic.Add(score, name);


        }
        ScoreBoard()
        {
            //get the current user
            string username = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            //get the location of the scoreboard
            string path = String.Format("C:\\Users\\{0}\\Documents\\VangDeVolger\\Scoreboard.txt",username);

            //check if the file exists
            if (!File.Exists(path))
            {
                //if it doesnt exist make it and fill it
                File.Create(path);
                for (int i = 0; i < 5; i++)
                {
                    File.AppendAllText(path, "0 reee");
                }
                
            }

            //then read the file into the Dictionary
            String[] lines = File.ReadAllLines(path);
            foreach (string line in lines)
            {
                String[] splitString = line.Split(' ');
                _scoreDic.Add(Int32.Parse(splitString[0]),splitString[1]);

            }
        }
    }
}
