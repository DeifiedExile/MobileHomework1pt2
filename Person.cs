using System;
using System.Collections.Generic;
using System.Text;

namespace MobileHomework1pt2
{
    interface Person
    {
        string Name { get; set; }
        int Age { get; set; }
        int Id { get; set; }
        Subject Program { get; set; }

        void setPerformance(int value);


    }
}
