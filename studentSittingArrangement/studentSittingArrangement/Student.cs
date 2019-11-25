using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studentSittingArrangement
{
    class Student
    {
        private string sections=""; // user will enter number of sections 
        private string ColumnNum="-1"; // datatype for number of columns 
        private string RowNum="-1"; //datatype for number of rows

        public string Sections
        {
            get
            {
                return sections;
            }

            set
            {
                sections = value;
            }
        }

        public string ColumnNum1
        {
            get
            {
                return ColumnNum;
            }

            set
            {
                ColumnNum = value;
            }
        }

        public string RowNum1
        {
            get
            {
                return RowNum;
            }

            set
            {
                RowNum = value;
            }
        }
    }
}
