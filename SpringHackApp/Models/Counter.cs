using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SpringHackApp.Models
{
    public class Counter
    {
        private int _num = 0;
        public int Number
        {
            get
            {
                int prev = _num;
                _num = (_num + 1) % 100;
                return prev;
            }
        }
    }
}