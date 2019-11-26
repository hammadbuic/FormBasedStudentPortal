using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentPortal
{
    class Student
    {
        private String _id;
        private String _name;
        private double _gpa;
        private string _department;
        private string _university;
        private bool _attendance;
        public String id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }
        public String name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        public double gpa
        {

            get
            {
                return _gpa;
            }
            set
            {
                _gpa = value;
            }
        }
        public string department
        {
            get
            {
                return _department;
            }
            set
            {
                _department = value;
            }
        }
        public string university
        {
            get
            {
                return _university;
            }
            set
            {
                _university = value;
            }
        }
        public bool attendance
        {
            get
            {
                return _attendance;
            }
            set
            {
                _attendance = value;
            }
        }
    }
}
