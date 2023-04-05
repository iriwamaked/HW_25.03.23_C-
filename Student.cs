using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace HW_25._03._23
{
    internal class Student
    {
        string _lastName;
        public string LastName
        {
            get
            { return _lastName!=null? _lastName:"Не указана"; }
            set 
            {
                _lastName= value.ToUpper();
            }
        }
        string _firstName;
        public string FirstName 
        {
            get
            { return _firstName != null ? _firstName : "Не указано"; }
            set
            {
                _firstName = value.ToUpper();
            }
        }
        string _fatherName;
        public string FatherName {
            get
            { return _fatherName != null ? _fatherName : "Не указано"; }
            set
            {
                _fatherName = value.ToUpper();
            }
        }
        public string _group { get; set; }
        int _age;
        public int Age 
        { 
            get { return _age; }
            set 
            {
                _age = (value > 65 || value < 1) ? 0 : value;
            }
        }

        public int[]ProgrammMark { get; set; }
        public int[] AdminMark { get; set; }
        public int[] DesignMark { get; set; }

        public Student() 
        {
            Console.Write("\n\tВведите фамилию студента: ");
            _lastName = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(Console.ReadLine());
            Console.Write("\n\tВведите имя студента: ");
            _firstName = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(Console.ReadLine());
            Console.Write("\n\tВведите отчество студента: ");
            _fatherName = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(Console.ReadLine());
            Console.Write("\n\tВведите группу студента: ");
            _group = Console.ReadLine();
            Console.Write("\n\tВведите возраст студента: ");
            _age = int.Parse(Console.ReadLine());
            Console.Write("\n\tВведите оценки по программированию: ");
            ProgrammMark = new int[] { int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()) };
            Console.Write("\n\tВведите оценки по администрированию: ");
            AdminMark = new int[] { int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()) };
            Console.Write("\n\tВведите оценки по дизайну: ");
            DesignMark = new int[] { int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()) };
        }

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
            return $"\n\tФамилия: {_lastName} \n\tИмя:  {_firstName} \n\tОтчество: {_fatherName} " +
                $"\n\tГруппа: {_group} \n\t Возраст: {_age} \n\tСредний бал по программированию: {GetProgrammAverage()}" +
                $"\n\tСредний бал по администрированию: {GetAdminAverage()} \n\tСредний бал по дизайну: {GetDesignAverage()}";
        }
    }
}
