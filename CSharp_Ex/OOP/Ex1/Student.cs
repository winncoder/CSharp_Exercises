using System;

namespace CSharp_Ex.OOP.Ex1
{
    //(Encapsulation) Tạo một danh sách quản lý sinh viên bao gồm những thông tin:
    //Id, tên,tuổi,giới tính(nam/nữ), chuyên ngành, điểm giữa,cuối kì, điểm asm ,điểm trung bình và trạng thái.
    //Điểm trung bình= (asm + giữa kì*2+ cuối kì *3)/6, và trạng thái: điểm trung bình >=5 passed,  nếu không thì failed.
    abstract class Student
    {
        // private int id, age;
        // private float midGrade, lastGrade, asmGrade, GPA;
        // private string name, sex, specialized, status;
        
        public string id { get; set; }
        public string name { get; set; }
        public int age { get; set; }
        public string sex { get; set; }
        public string specialized { get; set; }
        protected float midGrade { get; set; }
        protected float lastGrade { get; set; }
        protected float asmGrade { get; set; }
        protected float gpa { get; set; }
        protected string status { get; set; }

        public abstract void InputInfor();
        public abstract float GPA();
        public abstract void Status();
    }

    class InforStudent : Student
    {
        public override void InputInfor()
        {
            Console.Write("ID: ");
            id = Console.ReadLine();
            Console.Write(("Name: "));
            name = Console.ReadLine();
            Console.Write(("Age: "));
            age = int.Parse(Console.ReadLine());
            Console.Write(("Sex: "));
            sex = Console.ReadLine();
            Console.Write(("Specialized: "));
            specialized = Console.ReadLine();
            Console.Write(("Mid Grade: "));
            midGrade = float.Parse(Console.ReadLine());
            Console.Write(("Last Grade: "));
            lastGrade = float.Parse(Console.ReadLine());
            Console.Write(("Asm Grade: "));
            asmGrade = float.Parse(Console.ReadLine());
            
            Console.WriteLine("--------------------------------------");
            // Console.WriteLine($"ID: {id}");
            // Console.WriteLine(($"Name: {name}"));
            // Console.WriteLine(($"Age: {age}"));
            // Console.WriteLine(($"Sex: {sex}"));
            // Console.WriteLine(($"Specialized: {specialized}"));
            // Console.WriteLine(($"Mid Grade: {midGrade}"));
            // Console.WriteLine(($"Last Grade: {lastGrade}"));
            // Console.WriteLine(($"Asm Grade: {asmGrade}"));
        }
        public override float GPA()
        {
            gpa = (asmGrade + midGrade * 2 + lastGrade * 3) / 6;
            Console.WriteLine($"Average grade: {gpa}");
            return gpa;
        }

        public override void Status()
        {
            status = (gpa >= 5) ? "Passed" : "Failed";
            Console.WriteLine(status);
        }
    }

    public class Ex1
    {
        public static void Main()
        {
            InforStudent student1 = new InforStudent();
            student1.InputInfor();
            student1.GPA();
            student1.Status();
        }
    }
}