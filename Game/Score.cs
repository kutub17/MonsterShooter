using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Reflection;

namespace Game
{
    public class Score
    {
        public int currentScore=0;

        public Score()
        {
           this.Read();
        }
        
      
        public void Read()
        {
            //string result;
            //var assembly = Assembly.GetExecutingAssembly();
            //StreamReader reader = new StreamReader(assembly.GetManifestResourceStream("Game.score.txt"));

            //result = reader.ReadToEnd();
            //currentScore = Convert.ToInt32(result);

            //MessageBox.Show("Current High Score is: " + result.ToString(), "High Score");
            FileStream fs = new FileStream(@"C:\Users\fahim\Downloads\MonsterShooter_25-4_1310\MonsterShooter\Game\score.txt",
                        FileMode.OpenOrCreate,
                        FileAccess.ReadWrite,
                        FileShare.ReadWrite);
            using (StreamReader r = new StreamReader(fs))
            {
                string t = r.ReadLine();
                currentScore = Convert.ToInt32(t);
                r.Close();
                //MessageBox.Show("Current High Score is: " + t.ToString(), "High Score");
            }

        }

        public void Write(int score)
        {
           // this.Read(); //checking the last value first

            if (currentScore >= score)
                return;

            //var assembly = Assembly.GetExecutingAssembly();
            //StreamWriter writer = new StreamWriter(assembly.GetManifestResourceStream("Game.score.txt"));

            //string newScore = score.ToString();


            //writer.WriteLine(newScore);


            FileStream fs = new FileStream(@"C:\Users\fahim\Downloads\MonsterShooter_25-4_1310\MonsterShooter\Game\score.txt",
            FileMode.OpenOrCreate,
            FileAccess.ReadWrite,
            FileShare.ReadWrite);

            using (StreamWriter w = new StreamWriter(fs))
            {
                string s = score.ToString();
                w.WriteLine(s);
                w.Flush();
                w.Close();
            }
            fs.Close();
            MessageBox.Show("New Highscore!");

            //MessageBox.Show("Current High Score is: " + result.ToString(), "High Score");
        }
    }
}
