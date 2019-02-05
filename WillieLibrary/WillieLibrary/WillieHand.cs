using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WillieLibrary
{
    public partial class WillieHand
    {
        private int _CardOne;
        private int _CardTwo;
        //Commented out redundant private field
        //private int _Willie;

        //Made second arguement nullable to allow for part B
        public WillieHand(int CardOne, int? CardTwo = null)
        {
            _CardOne = CardOne;
            _CardTwo = (int)(CardTwo ?? 0);
        }

        //Bugged code provided
        //public int Willie
        //{
        //    get
        //    {
        //        if (_CardOne > 10)
        //            _Willie = 10;
        //        else
        //            _Willie = _CardOne;
        //        if (_CardTwo > 10)
        //            _Willie = 10;
        //        else
        //            _Willie = _CardTwo;
        //        return _Willie;
        //    }
        //}

        //Actual Code
        public int Willie
        {
            get
            {
                return (_CardOne > 10 ? 10 : _CardOne) + (_CardTwo > 10 ? 10 : _CardTwo);
            }
        }

        public int CardOne
        {
            get
            {
                return _CardOne;
            }
        }

        public int CardTwo
        {
            get
            {
                return _CardTwo;
            }
        }
    }
}
