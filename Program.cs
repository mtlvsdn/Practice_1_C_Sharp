using System;
using System.Diagnostics;
using System.Numerics;

internal enum OccupationEnum
{
    Child = 0,
    Student,
    Employee
}

namespace NameSpaceProgram
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            OccupationEnum ocupation = OccupationEnum.Student;
            Console.WriteLine("Hello World");
            Console.WriteLine("Say Something!: ");
            //string a = Console.ReadLine();
            //int b = int.Parse(a);
            //Console.WriteLine(b);
            //TestMethod();
            //fibo();
            //SystemDataTypes();
            //StringMethod();
            //AnotherClass.method1();
            //AnotherClass.method2();
            //AnotherClass.MatrixMethod();
            //AnotherClass.JaggedArray();
            ValueTypeAssignment();
        }

        private static void TestMethod()
        {
            int foo = 10;
            int bar = 20;
            Console.WriteLine("foo: {0} bar: {1}", foo, bar);
            Console.WriteLine("foo: " + foo + " bar: " + bar);
            Console.WriteLine($"{foo}!={bar}");
            Console.WriteLine("c format: {0:c}", foo);
        }

        private static void fibo()
        {
            string n;
            n = Console.ReadLine();
            int count = int.Parse(n);
            List<int> arr = new List<int>();
            arr.Add(0);
            arr.Add(1);
            for (int i = 2; i < 10; i++)
            {
                int a1 = arr[i - 1];
                int a2 = arr[i -2];
                int sum = a1 + a2;
                arr.Add(sum);
            }
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }

        private static void SystemDataTypes()
        {
            Console.Write("First Name: ");
            string firstName = Console.ReadLine();
            DateTime currentTime = DateTime.Now;
            Console.WriteLine("Hello {0}! Today is {1}.", firstName, currentTime);
        }

        private static void StringMethod()
        {
            String s1 = "abc";
            String s2 = s1;
            s1 = s1.Replace("abc", "ba");
            Console.WriteLine(s1);
            Console.WriteLine(s2);

            String s3 = "abc";
            String s4 = s3;
            s3 += "d";
            Console.WriteLine(s3);
            Console.WriteLine(s4);
        } 
        
        internal struct PersonStruct
        {
            public int Age;
            public string Name;
            public OccupationEnum Occupation;
            
            public PersonStruct(int age, string name,  OccupationEnum occupation)
            {
                this.Age = age;
                this.Name = name;
                this.Occupation = occupation;
            }
            public override string ToString()
            {
                return string.Format("Name: {0}, Age: {1}, Occupation: {2}", this.Name, this.Age, this.Occupation);
            }
        }
        private static void ValueTypeAssignment()
        {
            Console.WriteLine("###Assigning value types\n");
            var personStruct1 = new PersonStruct(21, "Mihai Ion", OccupationEnum.Student);
            var personStruct2 = new PersonStruct(24, "Gabriel Iglesias", OccupationEnum.Employee);
            var personStruct3 = personStruct1;

            Console.WriteLine(personStruct1);
            Console.WriteLine(personStruct2);
            Console.WriteLine(personStruct3);

            personStruct1.Name = "Matei Popescu";
            Console.WriteLine(personStruct1);
            Console.WriteLine(personStruct2);
        }
    }

    class AnotherClass
    {
        public static void method1()
        {
            string a = "hello";
            string b = "h";
            b += "ello";

            Console.WriteLine(a == b);
            Console.WriteLine((object)a == b);
        }

        public static void method2()
        {
            int[] intArray;
            intArray = new int[3];
            var doubleArray = new[] { 34.23, 10.2, 23.2 };
            var arrayElement = doubleArray[0];
            doubleArray[1] = 5.55;
            for (var i = 0; i < intArray.Length; i++)
            {
                Console.WriteLine(intArray[i]);
            }
            foreach (var value in doubleArray)
            {
                Console.WriteLine(value);
            }
            Array.Sort(doubleArray);
            for (var i = 0; i < doubleArray.Length; i++)
                Console.WriteLine("doubleArray[{0}] = {1}", i, doubleArray[i]);
        }

        public static void MatrixMethod()
        {
            var cub = new int[5, 2, 7];
            var matrix = new[,]
            {
                {4, 23, 5, 2}, {1, 6, 13, 29}
            };
            for (var i = 0; i < matrix.GetLength(0); i++)
            {
                for (var j = 0; j < matrix.GetLength(1); j++)
                    Console.Write(" {0}", matrix[i, j]);
                Console.WriteLine();
            }
        }

        public static void JaggedArray()
        {
            int[][] jaggedArray =
            {
                new int[] {0, 1, 3 },
                new int[] {3, 4 },
                new int[] {6, 7, 8, 9 }
            };

            for (var i = 0; i < jaggedArray.Length; i++)
            {
                for (var j = 0;j < jaggedArray[i].Length; j++)
                {
                    Console.Write(" {0}", jaggedArray[i][j]);   
                }
                Console.WriteLine();
            }
        }
    }
}