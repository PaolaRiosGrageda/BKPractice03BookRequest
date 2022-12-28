using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jalasoft.DevLEvel1.Practice03
{
    internal class Novel : Book
    {
        public Novel() : base()
        {
            this.TypeOfBook = TypeBook.Novel;
        }
    }
}
