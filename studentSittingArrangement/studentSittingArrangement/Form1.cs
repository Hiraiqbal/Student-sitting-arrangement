using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace studentSittingArrangement
{
    public partial class Form1 : Form
    {
        int columns =-1, rows =-1;
        int  NoOfSctns=4;
        List<Student> [] Arraystore;

        int mainSection = 0;
        //Student[,] SittingAlotmnet;
        // functions
        //functions
        private void seatAlocator()
        {
            int studNo;
            int temp = mainSection;
            for(int i=0;i<rows;i++)
            {
                studNo = i;
                for(int j=0;j<columns;j++)
                {

                    Arraystore[temp][studNo].RowNum1 = Convert.ToString(i);
                    Arraystore[temp][studNo].ColumnNum1 = Convert.ToString(j);
                    
                    //jb tk rows complete ni hoti
                    if (temp < 4)//4 kio k section 4 h A,B,C,D
                        temp++;
                    else
                    {
                        temp = 0;
                        studNo = studNo + 1;
                    }
                }
                //jb tk rows complete ni hoti
                if (mainSection < 4)//4 kio k section 4 h A,B,C,D
                    mainSection++;
                else
                    mainSection = 0;
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void GenrteListS_Click(object sender, EventArgs e)
        {
            seatAlocator();
            dataGridView1.DataSource = Arraystore[0];
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            NoOfSctns = Convert.ToInt32(txtNoOfSecS.Text="4");
            txtNoOfSecS.ReadOnly = true;
            Arraystore = new List<Student>[NoOfSctns];
            for(int i=0;i<NoOfSctns; i++)
            {
                Arraystore[i] = new List<Student>();
            }
        }

        private void ADD_Click(object sender, EventArgs e)
        {
            if (columns == - 1 && rows == -1)
            {
                columns = Convert.ToInt32(txtNoOfColC.Text);
                rows = Convert.ToInt32(txtNoOfRowsC.Text);

                //SittingAlotmnet = new Student[columns,rows];
                txtNoOfColC.ReadOnly = true;
                txtNoOfRowsC.ReadOnly = true;

            }
            Student std = new Student();
            std.Sections = txtsection.Text;
            if (txtsection.Text.Trim().ToUpper() == "A")
            {
                //sec A
                Arraystore[0].Add(std);
            }
            else if (txtsection.Text.Trim().ToUpper() == "B")
            {
                //sec B
                Arraystore[1].Add(std);
            }
            else if (txtsection.Text.Trim().ToUpper() == "C")
            {
                //sec C
                Arraystore[2].Add(std);
            }
            else if (txtsection.Text.Trim().ToUpper() == "D")
            {
                //sec D
                Arraystore[3].Add(std);
            }
            else
            {
                MessageBox.Show("invalid section");
            }
            //datastore.Add(std);
            
        }
    }
}
