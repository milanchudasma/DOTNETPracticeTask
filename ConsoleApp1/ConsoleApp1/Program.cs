using System;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.IO;
using System;
using System.Collections;
using System.Globalization;
using System.Numerics;
using System.Linq;
using System.Net.Http.Json;
using System;
using System.IO;
using System.Data;
using System.Data.SqlTypes;

using System.Runtime.Intrinsics.X86;
using IronXL;
using System.Collections.Concurrent;

namespace OutParameter
{
    class Animal
    {
        public virtual void Makesound()
        {
            Console.WriteLine("Animal sound");
        }

    }
    class Dog : Animal
    {
        public override void Makesound()
        {
            Console.WriteLine("dog sound");
        }
    }
    class Cat : Animal
    {
        public override void Makesound()
        {
            Console.WriteLine("cat sound");
        }
    }
    class System
    {
        public static int countWord(string str)
        {

            string[] s2 = str.Split(" ");

            int count = 0;
            for (int i = 0; i < s2.Length; i++)
            {
                int result = (s2[i].Length == 0) ? 0 : count++;
            }

            return count;
        }
        public static string reversechar()
        {
            ArrayList list = new ArrayList();
            Console.WriteLine("Enter a Total Number");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a One By One Character : ");
            for (int i = 0; i < n; i++)
            {

                list.Add(Convert.ToChar(Console.Read()));

            }
            string res = "";
            for (int i = list.Count-1; i>=0; i--)
            {
                if (i==0 || i==list.Count-1)
                {
                    res += list[i];
                }
                else
                {
                    res += $" {list[i]} ";
                }

            }
            return res;
        }
        public static void order()
        {
            long num = long.Parse(Console.ReadLine());

            string str = num.ToString();

            char[] arr = str.ToCharArray();
            int[] intArr = new int[arr.Length];

            for (int i = 0; i<arr.Length; i++)
            {
                intArr[i] =  (int)Char.GetNumericValue(arr[i]);
            }

            Array.Sort(intArr);
            Console.WriteLine("sorting of array is asceding order");

            foreach (int i in intArr)
            {
                Console.Write(i);

            }
            Console.WriteLine();
            for (int i = intArr.Length-1; i>=0; i--)
            {
                Console.Write(intArr[i]);
            }

            //Array.Reverse(intArr);
            //Console.WriteLine("sorting a array in discending order");
            //foreach (int i in intArr)
            //{
            //    Console.Write(i);
            //}
            Console.WriteLine();

        }

        public static void listPercentage()
        {
            List<string> list = new List<string>();
            list.Add("milan");
            list.Add("bhola bhai");
            list.Add("bhola bhai");
            list.Add("bhola bhai");
            list.Add("bhola bhai");
            list.Add("keval");
            list.Add("adi");
            list.Add("akib");
            list.Add("akib");
            list.Add("akib");
            list.Add("akib");
            list.Add("parth");
            list.Add("viren");
            list.Add("darshil");
            list.Add("pratik");
            list.Add("sidhharth");
            Console.WriteLine("enter value in 10 to 100");
            int userInput = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(list.Count);
            double num = (list.Count*userInput)/100;

            Math.Round(num);
            Console.WriteLine("{0}% value {1} ", userInput, num);

            int sub = list.Count - Convert.ToInt32(num);
            Console.WriteLine("sub {0}", sub);



            int finalNum = sub/2;
            Console.WriteLine("finalsum {0}", finalNum);
            Console.WriteLine("final list");
            for (int i = 0 + finalNum; i<list.Count - finalNum; i++)
            {
                Console.WriteLine($"{i+1} {list[i]}");
            }
            Console.WriteLine("removeble list");
            for (int i = 0; i<finalNum; i++)
            {
                Console.WriteLine($"{i+1} {list[i]}");
            }
            for (int i = list.Count - finalNum; i<list.Count; i++)
            {
                Console.WriteLine($"{i+1} {list[i]}");
            }
        }

        public static void upperlower()
        {
            string str = Console.ReadLine();
            StringBuilder sb = new StringBuilder(str);

            for (int i = 0; i<sb.Length; i++)
            {
                if (Char.IsUpper(sb[i]))
                {

                    sb[i] = Char.ToLower(sb[i]);

                }
                else if (Char.IsLower(sb[i]))
                {

                    sb[i] = Char.ToUpper(sb[i]);
                }
            }
            for (int i = 0; i<sb.Length; i++)
            {
                Console.Write((sb[i]));
            }
        }
        public static void secondHighest()
        {
            Console.WriteLine("enter the array length");
            int arrLength = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[arrLength];
            Console.WriteLine("enter the array element");
            for (int i = 0; i<arrLength; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            int current = arr[0];
            int temp = 0;
            for (int i = 0; i<arr.Length; i++)
            {
                Console.WriteLine(current);
                if (current < arr[i])
                {
                    temp = current;
                    current = arr[i];
                    Console.WriteLine($"second-highest : {temp} , highest : {current}");
                }
                else if (current > arr[i] && temp < arr[i])
                {
                    Console.WriteLine("enter in else if");
                    temp = arr[i];
                    Console.WriteLine($"temp ");
                }
            }
            Console.WriteLine($"second-highest : {temp} , highest : {current}");
            for (int i = 0; i<arr.Length; i++)
            {
                if (temp == arr[i])
                {
                    Console.WriteLine($"element index {i}");
                }
            }
            //with clone array
            //int[] arr1 = (int[])arr.Clone();
            //ArrayList list = new ArrayList();

            //with sorting of array abd ckone the array
            //Array.Sort(arr);
            //Console.WriteLine($"array length {arr.Length}");
            //int secondLast = 0;
            //for (int i = arr.Length-1; i>=0; i--)
            //{
            //    if (arr[arr.Length-1] > arr[i])
            //    {
            //        Console.WriteLine($"index is {i} and element is {arr[i]}");
            //        secondLast = arr[i];
            //        for (int j = 0; j<arr1.Length; j++)
            //        {
            //            if (arr1[j] == secondLast)
            //            {
            //                list.Add(j);
            //            }
            //        }

            //        break;
            //    }
            //}
            //Console.WriteLine(secondLast);

            //Console.WriteLine("element index");
            //foreach (int i in list)
            //{
            //    Console.WriteLine(i);
            //}

        }

        //duplicate element check in array
        public static void duplicatEleCheck()
        {
            int[] arr = { 9, 2, 3, 10, 3, 78, 9, 9, 3, 1, 2, 78, 9, 78, 9, 10 };
            HashSet<int> set = new HashSet<int>();

            for (int i = 0; i<arr.Length; i++)
            {
                set.Add(arr[i]);
            }

            int[] newArr = new int[set.Count];
            int arridxcount = 0;

            foreach (int i in set)
            {
                if (arridxcount <= set.Count-1)
                {
                    newArr[arridxcount++] = i;
                }
                else
                {
                    break;

                }
            }
            int current = 0;
            int count = 0;
            for (int i = 0; i<newArr.Length; i++)
            {
                current = newArr[i];
                for (int j = 0; j<arr.Length; j++)
                {
                    if (current == arr[j])
                    {
                        count++;

                    }
                }
                //Console.WriteLine($"element : {current} , count : {count}");
                if (count!=1)
                {
                    Console.WriteLine(current);
                }
                count = 0;
            }
        }

        public static void givemsg()
        {
            Console.WriteLine("you are not eligible for admission");
        }

        public static void admissionEligible()
        {
            Console.WriteLine("enter maths marks:");
            int maths = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter physics marks:");
            int phy = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter chemistry marks:");
            int chem = Convert.ToInt32(Console.ReadLine());

            if (maths >= 65)
            {
                if (phy>=55)
                {
                    if (chem>=50)
                    {
                        if ((phy+maths+chem)>=180 || (maths+phy)>=140)
                        {
                            Console.WriteLine("you are eligible for admission");
                        }
                        else
                        {
                            givemsg();
                        }

                    }
                    else
                    {
                        givemsg();
                    }
                }
                else
                {
                    givemsg();
                }
            }
            else
            {
                givemsg();
            }

        }
        public static void digitElmentSum()
        {
            Console.WriteLine("enter a number");
            string digit = Console.ReadLine();
            char[] arr = new char[digit.Length];
            arr = digit.ToCharArray();
            int sum = 0;
            for (int i = 0; i<arr.Length; i++)
            {
                sum += (int)Char.GetNumericValue(arr[i]);
            }
            Console.WriteLine(sum);
        }

        public static void sunstringCheck()
        {
            Console.WriteLine("enter a string");
            string str = Console.ReadLine();

            Console.WriteLine("enter a sub string");
            string substr = Console.ReadLine();

            if (str.Contains(substr))
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }

        }

        public static void inputCheck(int temp, int[] arr, bool check, int i)
        {
            for (int j = 0; j<i; j++)
            {
                if (temp == arr[j])
                {
                    Console.WriteLine($"this is already enter {temp}");
                    check = true;

                }
                if (check == false)
                {
                    //Console.WriteLine("enter in second if");
                    arr[i] = temp;
                }
                else
                {
                    check = true;
                    temp =  Convert.ToInt32(Console.ReadLine());
                    inputCheck(temp, arr, check=false, i);
                }
            }
        }

        public static void excelMoreData(WorkSheet workSheet, int count)
        {
            Console.WriteLine("enter no row that you want to insert");
            int num = Convert.ToInt32(Console.ReadLine());
            int start = 1 + count;
            int end = num  + count;
            for (int i = start; i<=end; i++)
            {
                Console.WriteLine("enter a name");
                workSheet[$"A{i}"].Value = Console.ReadLine();
                Console.WriteLine("enter a city");
                workSheet[$"B{i}"].Value = Console.ReadLine();
                Console.WriteLine("enter a phone");
                workSheet[$"C{i}"].Value = Console.ReadLine();
                count++;
            }
            Console.WriteLine("yes/no");
            string op = Console.ReadLine().ToString();
            if (op == "yes")
            {
                excelMoreData(workSheet, count);
            }


        }
        public static void excelInsert()
        {
            string filepath = "C:\\keval\\demo.xls";

            WorkBook workBook = WorkBook.Load(filepath);
            WorkSheet workSheet = workBook.DefaultWorkSheet;

            Console.WriteLine("enter no row that you want to insert");
            int num = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            for (int i = 1; i<=num; i++)
            {
                Console.WriteLine("enter a name");
                workSheet[$"A{i}"].Value = Console.ReadLine();
                Console.WriteLine("enter a city");
                workSheet[$"B{i}"].Value = Console.ReadLine();
                Console.WriteLine("enter a phone");
                workSheet[$"C{i}"].Value = Console.ReadLine();
                count++;
            }
            Console.WriteLine("yes/no");
            string op = Console.ReadLine().ToString();
            if (op == "yes")
            {
                excelMoreData(workSheet, count);
            }
            workBook.SaveAs(filepath);
            Console.WriteLine("data inserted");
        }

        public static void nestedDirecory(string dir)
        {
            string dirpath =   dir;
            

            // If directory does not exist, create it
            if (!Directory.Exists(dirpath))
            {
                Directory.CreateDirectory(dirpath);
                Console.WriteLine("you want to carete other direcotry yes:no ");
                string ans = Console.ReadLine();
                if (ans == "yes")
                {
                    Console.WriteLine("enter a directory name");
                    string dir1 = Console.ReadLine();
                    dirpath += "\\" +  dir1;
                    Console.WriteLine($"dirpath : {dirpath}");
                    nestedDirecory(dirpath);
                }
            }
            else
            {
                Console.WriteLine(" this is alredy exist : you want to carete other direcotry yes:no");
                string ans = Console.ReadLine();
                if (ans == "yes")
                {
                    Console.WriteLine("enter a directory name");
                    string dir1 = Console.ReadLine();
                    dirpath += "\\" +  dir1;
                    Console.WriteLine($"dirpath : {dirpath}");
                    nestedDirecory(dirpath);
                }
            }
         
        }
        static void Main(string[] args)
        {

            Console.WriteLine("enter a directory name");
            string dir = Console.ReadLine();
            string directoryPathDefault = $"C:";
            string dirpath = directoryPathDefault + "\\" + dir;
            nestedDirecory(dirpath);

            //string task1 = Console.ReadLine();
            //Console.WriteLine(countWord(task1));

            //string task2 = reversechar();
            //Console.WriteLine(task2);

            //task3
            //order();

            //task4 :: 80% value show
            //listPercentage();

            //task5
            //upperlower();

            //task6
            //secondHighest();

            //task7
            //duplicatEleCheck();

            //task8
            //admissionEligible();

            //task9
            //digitElmentSum();

            //task10
            //sunstringCheck();

            //Animal a = new Animal();
            //a.Makesound();
            //Dog dog = new Dog();
            //dog.Makesound();
            //Cat cat = new Cat();
            //cat.Makesound();

            //Animal ac = new Cat();
            //ac.Makesound();
            //Animal ad = new Dog();
            //ad.Makesound();

            //create xls file and insert a data
            //excelInsert();

            //adi mca
            //Console.WriteLine("enter the number");
            //int num = Convert.ToInt32(Console.ReadLine());
            //int[] arr = new int[num];
            //Console.WriteLine("enter array element");
            //int temp = 0;
            //bool check = false;
            //for (int i = 0; i<num; i++)
            //{
            //    if (i==0)
            //    {
            //        arr[i] = Convert.ToInt32(Console.ReadLine());

            //    }
            //    else
            //    {
            //        temp =   Convert.ToInt32(Console.ReadLine());
            //        inputCheck(temp,arr,check=false,i);
            //    }

            //}
            //Console.WriteLine("Array:");
            //for (int i = 0; i<arr.Length; i++)
            //{
            //    Console.Write(arr[i] + " ");
            //}
            ///////////////////////////////////////////////////////////

            //create file
            //Console.WriteLine("enter a file name : ");
            //string fileName = Console.ReadLine();
            //FileStream f = new FileStream($"C:\\keval\\{fileName}.txt", FileMode.Create);
            //f.Close();

            //writeFile
            //FileStream f1 = new FileStream($"C:\\keval\\{fileName}.txt", FileMode.OpenOrCreate);
            //StreamWriter s1 = new StreamWriter(f1);

            //Console.WriteLine("how many number you enter in file");
            //int a = Convert.ToInt32(Console.ReadLine());
            //for (int i = 0; i < a; i++)
            //{
            //    s1.WriteLine(Convert.ToInt32(Console.ReadLine()));
            //}
            //s1.Close();
            //f1.Close();

            //readFile
            //FileStream f2 = new FileStream($"C:\\keval\\keval.txt", FileMode.OpenOrCreate);
            //StreamReader sr = new StreamReader(f2);
            //string line = "";
            //int sum = 0;
            //int count = 0;
            //while ((line = sr.ReadLine()) != null)
            //{
            //    sum += Convert.ToInt32(line);
            //    count++;
            //}
            //Console.WriteLine($" total sum :{sum}");
            //Console.WriteLine($"toital count  : {count}");
            //int res = sum/count;
            //Console.WriteLine($"average is : {res}");
            //sr.Close();
            //f2.Close();

            ////result file
            //Console.WriteLine("enter a file result  name : ");
            //string fileName1 = Console.ReadLine();
            //FileStream f3 = new FileStream($"C:\\keval\\{fileName1}.txt", FileMode.Create);
            //StreamWriter s3 = new StreamWriter(f3);

            //string twoDecimal = res.ToString("N2");
            //s3.WriteLine($"avreage is {twoDecimal}");


            //s3.Close();
            //f3.Close();


            //FILE CONTENT CHECKING
            //    string filePath = "C:\\keval\\test.pdf"; // Change the file path here

            //    byte[] fileSignature = new byte[8];
            //    using (FileStream fileStream = new FileStream(filePath, FileMode.Open))
            //    {
            //        fileStream.Read(fileSignature, 0, 8);
            //    }

            //    if (IsPdf(fileSignature))
            //    {
            //        Console.WriteLine("PDF file detected.");
            //    }
            //    else if (IsImage(fileSignature))
            //    {
            //        Console.WriteLine("Image file detected.");
            //    }
            //    else if (IsVideo(fileSignature))
            //    {
            //        Console.WriteLine("Video file detected.");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Unknown file format.");
            //    }
            //}

            //static bool IsPdf(byte[] fileSignature)
            //{
            //    return fileSignature[0] == 0x25 && // %
            //           fileSignature[1] == 0x50 && // P
            //           fileSignature[2] == 0x44 && // D
            //           fileSignature[3] == 0x46 && // F
            //           fileSignature[4] == 0x2D && // -
            //           fileSignature[5] == 0x31 && // 1
            //           fileSignature[6] == 0x2E && // .
            //           fileSignature[7] == 0x37;   // 7
            //}

            //static bool IsImage(byte[] fileSignature)
            //{
            //    return (fileSignature[0] == 0xFF && fileSignature[1] == 0xD8) || // JPEG/JFIF
            //           (fileSignature[0] == 0x89 && fileSignature[1] == 0x50 && fileSignature[2] == 0x4E && fileSignature[3] == 0x47 && fileSignature[4] == 0x0D && fileSignature[5] == 0x0A && fileSignature[6] == 0x1A && fileSignature[7] == 0x0A) || // PNG
            //           (fileSignature[0] == 0x47 && fileSignature[1] == 0x49 && fileSignature[2] == 0x46 && fileSignature[3] == 0x38 && (fileSignature[4] == 0x37 || fileSignature[4] == 0x39) && fileSignature[5] == 0x61); // GIF
            //}

            //static bool IsVideo(byte[] fileSignature)
            //{
            //    return (fileSignature[0] == 0x52 && fileSignature[1] == 0x49 && fileSignature[2] == 0x46 && fileSignature[3] == 0x46 && fileSignature[8] == 0x56 && fileSignature[9] == 0x69 && fileSignature[10] == 0x64 && fileSignature[11] == 0x65 && fileSignature[12] == 0x6F) || // AVI
            //           (fileSignature[4] == 0x66 && fileSignature[5] == 0x74 && fileSignature[6] == 0x79 && fileSignature[7] == 0x70 && fileSignature[8] == 0x71 && fileSignature[9] == 0x74); // MP4

            //}

            //file format checking
            //string filepath = "C:\\keval\\csv.csv";

            //string fileExtension = Path.GetExtension(filepath);
            //Console.WriteLine($"a file in {fileExtension.ToLower()}");


            //byte[] pdfbyts = new byte[] { 0x25, 0x50, 0x44, 0x46 };
            //byte[] imgbytes = new byte[] { 0xFF, 0xD8, 0xFF, 0xE0 };
            //byte[] pngformate = new byte[] { 0x89, 0x50, 0x4E, 0x47 };
            //byte[] mp4Formate = new byte[] { 0x00, 0x00, 0x00, 0x18, 0x66, 0x74, 0x79, 0x70, 0x69, 0x73, 0x6F, 0x6D };
            //byte[] docxBytes = new byte[] { 0x50, 0x4B, 0x03, 0x04, 0x14, 0x00, 0x06, 0x00 };
            //byte[] csvBytes = new byte[] { 0x43, 0x6F, 0x6C, 0x75, 0x6D, 0x6E, 0x20, 0x4E };
            //byte[] pptBytes = new byte[] { 0xD0, 0xCF, 0x11, 0xE0, 0xA1, 0xB1, 0x1A, 0xE1 };

            //byte[] filecontent = File.ReadAllBytes(filepath);

            //if (filecontent.Take(pdfbyts.Length).SequenceEqual(pdfbyts))
            //{
            //    Console.WriteLine(".pdf");
            //}
            //if (filecontent.Take(mp4Formate.Length).SequenceEqual(mp4Formate))
            //{
            //    Console.WriteLine(".mp4");
            //}
            //if (filecontent.Take(imgbytes.Length).SequenceEqual(imgbytes))
            //{
            //    Console.WriteLine(".jpg");
            //}
            //if (filecontent.Take(pngformate.Length).SequenceEqual(pngformate))
            //{
            //    Console.WriteLine(".png");
            //}
            //if (filecontent.Take(docxBytes.Length).SequenceEqual(docxBytes))
            //{
            //    Console.WriteLine(".docx");
            //}
            //if (filecontent.Take(csvBytes.Length).SequenceEqual(csvBytes))
            //{
            //    Console.WriteLine(".csv");
            //}
            //if (filecontent.Take(pptBytes.Length).SequenceEqual(pptBytes))
            //{
            //    Console.WriteLine(".ppt");
            //}

            //txt to csv
            // string sourceFilePath = "C:\\keval\\input.txt";  
            //string destFilePath = "C:\\keval\\demo12.csv"; 
            //FileStream f1 = new FileStream(sourceFilePath, FileMode.OpenOrCreate);
            //FileStream f2 = new FileStream(destFilePath, FileMode.OpenOrCreate);

            //StreamReader s = new StreamReader(f1);
            //string line = "";

            //string str = "";

            //while ((line = s.ReadLine()) != null)
            //{
            //    str  += line;
            //}
            ////Console.WriteLine(str);

            //string[] strArr = str.Split(",");
            //foreach( string strArr2 in strArr )
            //{
            //    Console.WriteLine(strArr2);
            //}
            //StreamWriter s2 = new StreamWriter(f2);

            //for(int i = 0;i<strArr.Length;i++)
            //{
            //    s2.WriteLine(strArr[i]);
            //}

            //s2.Close();
            //s.Close();
            //f2.Close();
            //f1.Close();
            //string line = s.ReadLine();
            //Console.WriteLine(line);

            //txt data to csv data  : coma separated value
            //string sourceFilePath = "C:\\keval\\input.txt";
            //string destFilePath = "C:\\keval\\demo12.csv";

            //string[] lines = File.ReadAllLines(sourceFilePath);
            //FileStream fs = new FileStream(destFilePath, FileMode.OpenOrCreate);
            //fs.Close();
            //StreamWriter writer = new StreamWriter(destFilePath);

            //foreach (string line in lines)
            //{
            //    writer.WriteLine(line);
            //}
            //writer.Close();

            //carete a directory




        }
    }
}
