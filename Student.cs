using System;
using System.Collections.Generic;
using System.Text;

namespace MobileHomework1pt2
{
    class Student : Person
    {
        public int Credits { get; set; }
        

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("{0:D6} {1, -20} {2, 3} {3, 20} - {4, 3} Credits Earned", this.Id, this.Name, this.Age,
                this.Program, this.Credits);


            return sb.ToString();
        }


        public string Name { get; set; }
        public int Age { get; set; }
        public int Id { get; set; }
        public Subject Program { get; set; }
        public void setPerformance(int value)
        {
            Credits = value;
        }
    }
}
