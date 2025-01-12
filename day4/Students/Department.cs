using day4.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utils;

namespace day4.Students
{
    internal class Department: List<Student>
    {

        public new void Add(Student s)
        {
            base.Add(s);
            s.OnLowGrade += Remove;
        }

        public new void Remove(Student s)
        {
            base.Remove(s);
            s.OnLowGrade -= Remove;
            Console.WriteLine($"removed student ({s.Id}:{s.Name})");
        }


        public override string ToString() => string.Join(", ", this);

    }
}
