using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form6 : Form
    {
        List<Student> list;


        public Form6()
        {
            InitializeComponent();

            list = new List<Student>();

            Student s = new Student();
            s.Student_Number = 5678;
            s.年級 = 1;
            s.姓名 = "小山";

            Student stud2 = new Student();
            stud2.Student_Number = 8825252;
            stud2.年級 = 2;
            stud2.姓名 = "羊羊";

            Student stud3 = new Student();
            stud3.Student_Number = 23444332;
            stud3.年級 = 4;
            stud3.姓名 = "國國";            

            list.Add(s);
            list.Add(stud2);
            list.Add(stud3);

            list.Sort(SortStudent);


        }

        private int SortStudent(Student s1, Student s2)
        {
            return s2.姓名.CompareTo(s1.姓名);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //foreach (Student stud in list)
            //{
            //    MessageBox.Show(stud.Say());
            //}

            int yy = list.Count;
            for (int x = 0; x < yy; x++)
            {
                Student s = list[x];
                MessageBox.Show(s.你是誰(s));
            }
            //list.Clear();
            //list = new List<Student>();
        }

    }

    class Student
    {
        public int Student_Number;
        public string 姓名;
        public int 年級;

        public Student()
        {

        }

        /// <summary>
        /// 傳入學生學號與姓名
        /// </summary>
        /// <param name="numb">學號</param>
        /// <param name="name">姓名</param>
        public Student(int numb, string name)
        {
            Student_Number = numb;
            姓名 = name;
            年級 = 1;
        }

        public Student(int numb, string name, int gr)
        {
            Student_Number = numb;
            姓名 = name;
            年級 = gr;
        }

        public string Say()
        {
            return "我叫做" + 姓名 + ",我是" + 年級 + "年級,我的學號是" + Student_Number;
        }

        public string Say(string _message)
        {
            return _message;
        }

        public void 升級()
        {
            年級++;
        }

        public string 你是誰(Student s2)
        {
            return "你是" + s2.姓名 + "你的年級是" + s2.年級 + "你的學號是" + s2.Student_Number;

        }
    }
}
