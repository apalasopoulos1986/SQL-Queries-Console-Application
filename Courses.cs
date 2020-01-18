using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLQueriesConsoleApplication
{
    class Courses
    {
        #region CoursesPropertyDeclaration
        private int _courseId;
        private string _courseTitle;
        private string _stream;
        private DateTime _startDate;
        private DateTime _endDate;
        public int CourseId
        {
            get { return _courseId; }
            set { _courseId = value; }
        }
        public string CourseTitle
        {
            get { return _courseTitle; }
            set { _courseTitle = value; }
        }
        public string Stream
        {
            get { return _stream; }
            set { _stream = value; }
        }
        public DateTime StartDate
        {
            get { return _startDate; }
            set { _startDate = value; }
        }
        public DateTime EndDate
        {
            get { return _endDate; }
            set { _endDate = value; }
        }
        #endregion
    }
}
