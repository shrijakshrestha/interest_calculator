using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlTypes;

namespace WindowsFormsApplication7
{
    class IntrestCalculator
    {
        private double _principle;
        private double _rate;
        private double _time;



        public double principle
        {
            get { return this._principle; }

            set { this._principle = value; }
        }

        public double rate
        {
            get {  return this._rate; }

            set { this._rate = value;  }

        }

        public double time
        {
            get { return this._time; }
            set { this._time = value;  }
        }

        public double totalIntrest()
        {
 
            return ((_principle*_rate*_time)/100);      }
    }

}
