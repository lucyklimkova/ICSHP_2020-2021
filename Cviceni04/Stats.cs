using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Cviceni04
{
    class Stats
    {
        public Stats()
        {
 
        }
        public int Correct { get; private set; }
        public int Missed { get; private set; }
        public double Accuracy { get; private set; }

        public delegate void UpdatedStatsEventHandler(object sender, EventArgs e);

        public event UpdatedStatsEventHandler UpdatedStats;

        private void OnUpdatedStats()
        {
            UpdatedStatsEventHandler handler = UpdatedStats;
            if (handler != null)
                handler(this, new EventArgs());
        }

        public void Update(bool correctKey)
        {
            if (correctKey)
            {
                Correct++;
            } else
            {
                Missed++;
            }

            Accuracy = Math.Round((double) Correct / (Correct + Missed) * 100, 2);

            OnUpdatedStats();
        }

        public void clearStats() {
            Correct = 0;
            Missed = 0;
            Accuracy = 0;
        }
    }
}
