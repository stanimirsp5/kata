using System;
namespace KataCSharp.Sandbox
{
    public class Indexers
    {
        public void MyMain()
        {
            var st = new Student("Tosho", 29);
            st[0] = "Math";
            st[1] = "CS";
            st[2] = "Biology";
            st.StudentData = "Misho 19";
            var t = st.StudentData;
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(st[i]);
                
                   
            }

        }
    }

    class Student
    {
        string Name;
        int Age;
        string[] subject = new string[10];
        string studentData;

        public string StudentData { get => studentData; set { studentData = value; } }

        public Student(string Name, int Age)
        {
            this.Name = Name;
            this.Age = Age;
        }

        public string this[int index]
        {
            get
            {
                return subject[index];
            }
            set
            {
                subject[index] = value;
            }

        }


    }

}

