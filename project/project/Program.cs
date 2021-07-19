using System;
using System.Collections.Generic;
using System.IO;

namespace project
{
    class Program
    {
        static void Main(string[] args)
        {
            List<School> schools = new List<School>();
            while (true)
            {
                Console.WriteLine("1-Add new Student \n 2-search for Student  \n 3-Update Data \n 4-exit");
                int item = int.Parse(Console.ReadLine());
                switch (item)
                {
                    case 1:
                        Console.WriteLine("Please enter ID");
                        int id= int.Parse(Console.ReadLine());
                        Console.WriteLine("Please Enter Name");
                        String nam = Console.ReadLine();
                        Console.WriteLine("Class");
                        String clas = Console.ReadLine();
                        Console.WriteLine("Section");
                        String sec= Console.ReadLine();
                        // schools.Add(new School(id, clas, sec));
                        StreamWriter writer = File.AppendText(@"C:\test.txt");
                        writer.Write(id+" "+nam+" "+clas+" "+sec+"\n");
                        writer.Close();

                        break;
                    case 2:
                        Console.WriteLine("ID");
                        int ids = int.Parse(Console.ReadLine());
                        var status = false;
                        
                        //  StreamReader reader = new StreamReader(@"C:\file\test.txt");
                        string[] lines = File.ReadAllLines(@"C:\test.txt");
                        //String data = 
                        bool staus = false;
                        for (int i=0;i< lines.Length; i++)
                        {
                            String [] spl = lines[i].Split(" ");
                           
                            if (int.Parse(spl[0]) == ids)
                            {
                                Console.WriteLine("The id: " + spl[0]+ "\n The name "+spl[1] + "\nThe class: " + spl[2] + "\n the Section: " + spl[3]);

                                staus = true;
                            }
                            
                           
                        }
                        if (!staus)
                        {
                            Console.WriteLine("Nothing ");
                        }
                       



                        break;

                    case 3:
                        Console.WriteLine("Id");
                        int id2 = int.Parse(Console.ReadLine());
                        string[] lines_up = File.ReadAllLines(@"C:\test.txt");
                        for (int i = 0; i < lines_up.Length; i++)
                        {
                            string[] parts = lines_up[i].Split(' ');
                            if (int.Parse(parts[0]) == id2)
                            {
                                Console.WriteLine("The Id: " + parts[0] + "\n Class: " + parts[1] + "\n Section: " + parts[2]);
                                Console.WriteLine("ID");
                                int idss = int.Parse(Console.ReadLine());
                                Console.WriteLine("Class");
                                String clasq = Console.ReadLine();
                                Console.WriteLine("Section");
                                String secs = Console.ReadLine();

                                lines_up[i] = idss+" "+clasq+" "+secs;
                            }
                        }
                        File.WriteAllLines(@"C:\test.txt", lines_up);
                        break;
                    
                }
                if (item == 4)
                {
                    break;
                }
                
            }
            Console.WriteLine("Hello World!");

        }
    }
}
