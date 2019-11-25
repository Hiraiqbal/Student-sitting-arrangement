using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studentSittingArrangement
{
    class Student
    {
        private string sections = "";
        private string RowNum = "-1";
        private string ColumnNum = "-1";

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
