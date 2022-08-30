using Batch1_DET_2022;
using System.Net.Sockets;
using static ConsoleApp4.dateofjoining;

namespace ConsoleApp4
{
    class MyClass
    {
        public static void Main()
        {
            /*
                        try
                        {
                            Console.WriteLine("Enter age");
                            int age = Convert.ToInt32(Console.ReadLine());
                            if (age > 100)
                                throw new InvalidEmpIdException("Entered age is invalid");
                        }
                        catch(InvalidEmpIdException e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        catch(Exception e)
                        { }
                         employee1 m = new Manager(4671, "Karthika", new DateTime(2005, 5, 10), "techtrng", 10);  //default constructor
                                                                                                            // Console.WriteLine(m.Print());

                         employee1 m1 = new Manager(2345, "Jeeva", new DateTime(2010, 1, 14), "PEMS", 450);
                         // Console.WriteLine(m1.Print());  //base class ref can point to derived object

                         employee1 e1 = new employee1(1, "Jiyana", new DateTime(2020, 1, 5));
                         //Console.WriteLine(e1.Print());

                         Console.WriteLine("enter empid b.w 1001 - 25000");
                         int id = Convert.ToInt32(Console.ReadLine());
                         if (id < 1001 || id > 25000)
                             throw new InvalidEmpIdException("Entered empid is not in the range...");

                         Console.WriteLine("enter emp name");
                         string name = Console.ReadLine();

                         Console.WriteLine("enter doj");
                         DateTime doj = DateTime.Parse(Console.ReadLine());

                         employee1 e2 = new(id, name, doj);


                         List<employee1> list = new List<employee1>();
                         list.Add(m);
                         list.Add(m1);
                         list.Add(e1);
                         foreach (employee1 x in list)
                             Console.WriteLine(x.Print());

                    }
                    catch (InvalidEmpIdException e)
                     {
                         Console.WriteLine(e.Message);
                     }
                     catch (Exception e)
                     { }
                        CompanyManager m = new CompanyManager { Name = "Balaji", Surname = "R", Phone = "987456321" };
                    Company company = new Company { Name = "SSL", Address = "Global ", Manager = m, Phone = "987456321", Website = "sonata-software.com" };
                    Console.WriteLine(company.Print());
                        
            List<Animal> Animals = new List<Animal>();
            Animals.Add(new Dog());
            Animals.Add(new Cat());

            foreach (Animal a in Animals)
                Console.WriteLine(a.ToString());
           
            try
            {
                Person t = new Person("Tony", "Stark", "tonystark@stark.com", new DateOnly(1988, 05, 04));
                int byear = t.BirthYear();
                if (byear < 1900 || byear > 2022)
                {
                    throw new InvalidEmpIdException("ENTER VALID BIRTH YEAR");
                }
                string r = t.GetSunSign();
                string s = t.ChineseZodiac();
                string w = t.IsAdult();
                string b = t.BDayStatus();
                string u = t.DefaultUsername();
                string n = t.GetInfo();
                Console.WriteLine($"NAME = {n}");
                Console.WriteLine($"Sun Sign = {r}");
                Console.WriteLine($"Chinese Zodiac = {s}");
                Console.WriteLine($"Age Status = {w}");
                Console.WriteLine($"Birthday Status = {b}");
                Console.WriteLine($"Default Username = {u}");
            }
            catch (InvalidEmpIdException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception m)
            {
                Console.WriteLine(m.Message);
            }
        } */
            ScienceStudent Student = new ScienceStudent { regno = 12, Name = "vinay" };
            ScienceStudent sciencesubject = new ScienceStudent { physics = 54, chemistry = 75, maths = 45 };
            CommerceStudent Commercessubject = new CommerceStudent { economices = 44, accounts = 82, banking = 44 };

            Console.WriteLine(sciencesubject.GetAvgMarks());
            Console.WriteLine(Commercessubject.GetAvgMarks());
        }
    }
}