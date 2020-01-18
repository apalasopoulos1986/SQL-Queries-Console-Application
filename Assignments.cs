using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLQueriesConsoleApplication
{
    class Assignments
    {
        #region AssignmentsPropertyDeclaration
        private int _courseId;//erase if it does not work
        private int _assignmentId;
        private string _assignmentTitle;
        private string _description;
        private decimal _oralMark;
        private decimal _totalMark;
        private DateTime _subDateTime;



        public int CourseId//erase if it does not work
        {
            get { return _courseId; }
            set { _courseId = value; }
        }
        public int AssignmentId
        {
            get { return _assignmentId; }
            set { _assignmentId = value; }
        }
        public string AssignmentTitle
        {
            get { return _assignmentTitle; }
            set { _assignmentTitle = value; }
        }
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }
        public decimal OralMark
        {
            get { return _oralMark; }
            set { _oralMark = value; }
        }
        public decimal TotalMark
        {
            get { return _totalMark; }
            set { _totalMark = value; }
        }

        public DateTime SubDateTime
        {
            get { return _subDateTime; }
            set { _subDateTime = value; }
        }
        #endregion

    }
}
