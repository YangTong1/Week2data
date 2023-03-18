using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2data
{
    internal class Student
    {
        private string _address;
        private string _dob;
        private string _fname;
        private string _gender;
        private string _lname;
        public Student()
        {
            //Console.WriteLine("create a new stuudent without parameters");
        }
        public Student(string StudentID)
        {
            //Console.WriteLine("create a new student with ID :" + StudentID );
        }
        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }
        public string DOB
        {
            get { return _dob; }
            set { _dob = value; }
        }
        public string FirstNames
        {
            get { return _fname; }
            set { _fname = value; }
        }
        public string Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }
        public string Lastname
        {
            get { return _lname; }
            set { _lname = value; }
        }
       
        public void RegisterPaper(string PaperID)
        {
            Console.WriteLine(PaperID);
        }
        public void RegisterPaper(int PaperCode)
        {

        }
        public bool AttendClass()
        {
           return false;
        }
        public string studentinfo()
        {
            
            string infomation = "student address is " + _address + " ," + "DOB is" +_dob + " ," + "Firstname is " +_fname + " ," + "Gender is " +  _gender + " ," + "Lastname is " + _lname;
            return infomation;
        }
    }
}
