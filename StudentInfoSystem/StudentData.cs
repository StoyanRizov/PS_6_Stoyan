using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfoSystem
{
    internal class StudentData
    {
        
        private static List<Student> _testStudents = new List<Student>();
        public static List<Student> TestStudents
        {
            get {
                if(_testStudents.Count == 0 )
                studentsData();
                    return _testStudents; }
            set { }
        }

        public static void studentsData()
        {
            _testStudents.Add(new Student());
            _testStudents[0].firstName = "Mariyan";
            _testStudents[0].middleName = "Petrov";
            _testStudents[0].lastName = "Stoilov";
            _testStudents[0].faculty = "FCST";
            _testStudents[0].speciality = "CSE";
            _testStudents[0].degree = "Bachelor's";
            _testStudents[0].status = "shampion";
            _testStudents[0].facultyNumber = "121219109";
            _testStudents[0].course = 3;
            _testStudents[0].stream = 9;
            _testStudents[0].group = 29;

            _testStudents.Add(new Student());
            _testStudents[1].firstName = "Dragana";
            _testStudents[1].middleName = "Belic";
            _testStudents[1].lastName = "Mircovic";
            _testStudents[1].faculty = "FCST";
            _testStudents[1].speciality = "CSE";
            _testStudents[1].degree = "Master's";
            _testStudents[1].status = "engaged";
            _testStudents[1].facultyNumber = "121219101";
            _testStudents[1].course = 4;
            _testStudents[1].stream = 10;
            _testStudents[1].group = 32;

        }
    }
}
