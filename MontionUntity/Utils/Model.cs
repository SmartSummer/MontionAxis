using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MontionUntity.MontionManager;

namespace MontionUntity.Utils
{
    class Model
    {
        public double distance { get; set; }
        public SpeedInfoStuct SpeeedInfo;
        public int SpeedMode { get; set; }
        public int MoveMode { get; set;}
        public int MoveAbsRel{get;set;}
        }
    public struct SpeedInfoStuct
    {

        public double Acc { get; set; }
        public double Dec { get; set; }
        public double VelLow { get; set; }
        public double VelHigh { get; set; }
        public bool flag { get; set; }
    }
    }

