using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLQueriesConsoleApplication
{
    class Trainers
    {
        #region TrainersPropertyDeclaration
        private int _trainerId;
        private string _firstName;
        private string _lastName;
        private string _subject;
        public int TrainerId
        {
            get { return _trainerId; }
            set { _trainerId = value; }//na to bgalo teleios logo id;
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
        public string Subject
        {
            get { return _subject; }
            set { _subject = value; }
        }
        #endregion
    }
}
