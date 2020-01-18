using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLQueriesConsoleApplication
{
    class Students
    {
        #region StudentsPropertyDeclaration
        private int _studentId;
        private string _firstName;
        private string _lastName;
        private DateTime _dateOfBirth;
        private decimal _tuitionFees;
        public int StudentId
        {
            get { return _studentId; }
            set { _studentId = value; }
        }
        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }
        public DateTime DateOfBirth
        {
            get { return _dateOfBirth; }
            set { _dateOfBirth = value; }
        }
        public decimal TuitionFees
        {
            get { return _tuitionFees; }
            set { _tuitionFees = value; }
        }
        #endregion

    }
}
