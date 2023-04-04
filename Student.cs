using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace HW_25._03._23
{
    internal class Student
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string FatherName { get; set; }
        public string Group { get; set; }
        public int Age { get; set; }
        public int[]ProgrammMark { get; set; }
        public int[] AdminMark { get; set; }
        public int[] DesignMark { get; set; }

        public void SetProgrammMark(int index, int mark)
        {
            ProgrammMark[index] = mark;
        }

        public float GetProgrammAverage()
        {
            return (float)ProgrammMark.Average();
        }

        public void SetAdminMark(int index, int mark)
        {
            AdminMark[index] = mark;
        }

        public float GetAdminAverage()
        {
            return (float)AdminMark.Average();
        }

        public void SetDesignMark(int index, int mark)
        {
            DesignMark[index] = mark;
        }

        public float GetDesignAverage()
        {
            return (float)DesignMark.Average();
        }

        public override string ToString()
        {
            return $"\n\tФамилия:{LastName} \n\tИмя: {FirstName} \n\tОтчество:{FatherName} " +
                $"\n\tГруппа: {Group} \n\t Возраст: {Age} \n\tСредний бал по программированию: {GetProgrammAverage()}" +
                $"\n\tСредний бал по администрированию: {GetAdminAverage()} \n\tСредний бал по дизайну: {GetDesignAverage()}";
        }
    }
}
