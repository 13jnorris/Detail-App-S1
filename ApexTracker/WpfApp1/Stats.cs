using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class Stats
    {
        private double kills;

        public double Kills
        {
            get { return kills; }
            set { kills = value; }
        }
        private double wins;

        public double Wins
        {
            get { return wins; }
            set { wins = value; }
        }
        private double dmgDone;

        public double damageDone
        {
            get { return dmgDone; }
            set { dmgDone = value; }
        }

        private string ImageFilePath;

        public string _ImageFilePath
        {
            get { return ImageFilePath; }
            set { ImageFilePath = value; }
        }



    }
}
