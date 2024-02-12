using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    // to name private =>  int _dayInMonth, or dayInMonth
    // to name public => int DayInMonth
    public class Student
    {
        
        int student_id;
        string student_name;
        int student_age;
        int class_num;
        string student_phone_num;
        public static int TAX = 4; // the only difference between static and const, i can modify static at runtim
        public Student(int student_id, string student_name, int student_age, int class_num, string student_phone_num)
        {
            this.student_id = student_id;
            this.student_name = student_name;
            this.student_age = student_age;
            this.class_num = class_num;
            this.student_phone_num = student_phone_num;
        }
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public Student() { }
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

        public int get_student_id() { return student_id; }
        public string get_student_name() { return student_name; }
        public int get_student_age()
        {
            return student_age;
#pragma warning disable CS8321 // Local function is declared but never used
            int get_class_num()
            {
                return class_num;
            }
#pragma warning restore CS8321 // Local function is declared but never used
        }
        public int get_class_num() { return class_num; }
        public string get_student_phone_num() { return student_phone_num; }




    }
}
