using day4.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day4.Students
{
    internal class Student(int id, string name) : Identity(id, name)
    {
        public Action<Student> OnLowGrade;

        public int AbsenceDays { get; set; } = 0;

        public void IncreaseAbsence(int days = 1)
        {
            AbsenceDays += days;
            if (AbsenceDays >= 3)
            {
                OnLowGrade.Invoke(this);
            }
        }
        
    }
}
