using System;

namespace CSharp_Ex
{
    public class Ex3
    {
        //* Nhập vào  tên, tuổi ,email,cân nặng, chiều cao, rồi in ra màn hình những thông tin đó,
        //và bao gồm  cả chỉ số bmi=(cân nặng (kg)/(chiều cao(cm))^2)*10000,
        //và đang trong mối quan hệ hay không (true/false)
        public static void Ex3_main()
        {
            string name, email;
            int weight, height, age;
            float bmi;
            bool relationship;
            Console.WriteLine("Enter the Name: ");
            name = Console.ReadLine();
            Console.WriteLine("Enter the Age: ");
            age = int.Parse(Console.ReadLine());//cach gan gia tri (moi)
            Console.WriteLine("Enter the Email: ");
            email = Console.ReadLine();
            Console.WriteLine("Enter the Weight (kg): ");
            weight = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Height (cm): ");
            height = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Relationship: ");
            relationship = bool.Parse(Console.ReadLine());
            bmi = (float)weight / (height * height) * 10000;
            
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Email: " + email);
            Console.WriteLine("Age : " + age);
            Console.WriteLine("Weight (kg): " + weight );
            Console.WriteLine("height (cm) : " + height );
            Console.WriteLine("bmi : " + bmi );
            Console.WriteLine("In a Relationship "+ relationship);
            Console.ReadKey();
        }
    }
}