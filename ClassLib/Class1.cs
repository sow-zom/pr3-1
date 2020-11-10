using System;

namespace ClassLib
{
   public class Program
    {
        static int Main()
        {
            int x = -1;
            Worker f = new Worker();
            Company g = new Company();
            double v, m;
            Worker[] succ = ReadWorkersArray();
            while (true)
            {

                Console.WriteLine("\nClick to continue>> "); Console.ReadKey();
                Console.Clear(); Menu();
                Console.WriteLine("\nChoose an option >> "); x = int.Parse(Console.ReadLine());
                switch (x)
                {
                    case 1: Console.Clear(); Console.WriteLine("succ.[0]GetWorkExperience() = " + succ[0].GetWorkExperience()); break;
                    case 2: Console.Clear(); Console.WriteLine("succ.[0]GetTotalMoney() = " + succ[0].GetTotalMoney()); break;
                    case 3: Console.Clear(); Console.WriteLine("ReadWorkersArray() -  "); succ = ReadWorkersArray(); break;
                    case 4: Console.Clear(); Console.WriteLine("PrintWorker() = "); PrintWorker(succ[0]); break;
                    case 5: Console.Clear(); Console.WriteLine("PrintWorkers() = "); PrintWorker(succ); break;
                    case 6: Console.Clear(); Console.WriteLine("GetWorkerInfo(succ, out v, out m)  -- "); GetWorkerInfo(succ, out v, out m); Console.Write(" MaxSalary = " + v + " MinSalary = " + m + ".\n"); break;
                    case 7: Console.Clear(); Console.WriteLine("succ = SortWorkerBySalary(succ)"); succ = SortWorkerBySalary(succ); break;
                    case 8: Console.Clear(); Console.WriteLine("succ = SortWorkerByWorkExperiense(succ)"); succ = SortWorkerByWorkExperiense(succ); break;
                    case 9: Console.Clear(); Console.WriteLine(" Array.Sort(succ)"); Array.Sort(succ); ; break;
                    case 0: Console.Clear(); Console.WriteLine("Exit completed successfully"); return 0;
                    default: Console.Clear(); Console.WriteLine("Erorr 404, Pls try again"); return 0;
                }
            }


        }
        public static void Menu()
        {
            Console.Write("\n-----------------------------Menu-----------------------------");
            Console.Write("\n--------------------[1].GetWorkExperience()-------------------");
            Console.Write("\n--------------------[2].GetTotalMoney()-----------------------");
            Console.Write("\n--------------------[3].ReadWorkersArray()--------------------");
            Console.Write("\n--------------------[4].PrintWorker()-------------------------");
            Console.Write("\n--------------------[5].PrintWorkers()------------------------");
            Console.Write("\n--------------------[6].GetWorkersInfo()----------------------");
            Console.Write("\n--------------------[7].SortWorkerBySalary()------------------");
            Console.Write("\n--------------------[8].SortWorkerByWorkExperience()----------");
            Console.Write("\n--------------------[9].Array.Sort(succ)----------------------");

            Console.Write("\n\n--------------------[0].Exit----------------------------------");

        }
        public static int Menub(Worker[] succ)
        {
            int x = -1;
            double v, m;
            while (true)
            {

                Console.WriteLine("\nClick to continue>> "); Console.ReadKey();
                Console.Clear(); Menu();
                Console.WriteLine("\nChoose an option >> "); x = int.Parse(Console.ReadLine());
                switch (x)
                {
                    case 1: Console.Clear(); Console.WriteLine("succ.[0]GetWorkExperience() = " + succ[0].GetWorkExperience()); break;
                    case 2: Console.Clear(); Console.WriteLine("succ.[0]GetTotalMoney() = " + succ[0].GetTotalMoney()); break;
                    case 3: Console.Clear(); Console.WriteLine("ReadWorkersArray() -  "); succ = ReadWorkersArray(); break;
                    case 4: Console.Clear(); Console.WriteLine("PrintWorker() = "); PrintWorker(succ[0]); break;
                    case 5: Console.Clear(); Console.WriteLine("PrintWorkers() = "); PrintWorker(succ); break;
                    case 6: Console.Clear(); Console.WriteLine("GetWorkerInfo(succ, out v, out m)  -- "); GetWorkerInfo(succ, out v, out m); Console.Write(" MaxSalary = " + v + " MinSalary = " + m + ".\n"); break;
                    case 7: Console.Clear(); Console.WriteLine("succ = SortWorkerBySalary(succ)"); succ = SortWorkerBySalary(succ); break;
                    case 8: Console.Clear(); Console.WriteLine("succ = SortWorkerByWorkExperiense(succ)"); succ = SortWorkerByWorkExperiense(succ); break;
                    case 9: Console.Clear(); Console.WriteLine(" Array.Sort(succ)"); Array.Sort(succ); ; break;
                    case 0: Console.Clear(); Console.WriteLine("Exit completed successfully"); return 0;
                    default: Console.Clear(); Console.WriteLine("Erorr 404, Pls try again"); return 0 ;
                }
            }
        }
        public static void Menu2()
        {
            Console.Write("\nСhoose currency");
            
            Console.Write("\n[1].Grivna");
            Console.Write("\n[2].Dolar");
            Console.Write("\n[3].Euro");
        }
        
        public static Worker[] SortWorkerByWorkExperiense(Worker[] o)
        {
            for (int j = 0; j < o.Length; j++)
            {
                for (int i = 1; i < o.Length; i++)
                {
                    Worker y;
                    if ((o[i - 1].GetWorkExperience() > o[i].GetWorkExperience()))
                    {
                        Console.WriteLine("o[i-1] = " + o[i - 1].GetSalary() + ", o[i] = " + o[i].GetSalary());
                        y = o[i];
                        o[i] = o[i - 1];
                        o[i - 1] = y;
                        Console.WriteLine("o[i-1] = " + o[i - 1].GetSalary() + ", o[i] = " + o[i].GetSalary());
                    }

                }
            }
            return o;
        }
        public static Worker[] SortWorkerBySalary(Worker[] o)
        {
            for (int j = 0; j < o.Length; j++)
            {
                for (int i = 1; i < o.Length; i++)
                {
                    Worker y;
                    if ((o[i - 1].GetSalary() < o[i].GetSalary()))
                    {
                        //Console.WriteLine("o[i-1] = "+o[i-1].GetSalary()+", o[i] = "+ o[i].GetSalary());
                        y = o[i];
                        o[i] = o[i - 1];
                        o[i - 1] = y;
                        //Console.WriteLine("o[i-1] = " + o[i-1].GetSalary() + ", o[i] = " + o[i].GetSalary());
                    }

                }
            }
            return o;
        }
        public static void GetWorkerInfo(Worker[] o, out double v, out double m)
        {
            v = o[0].GetSalary(); m = o[0].GetSalary();
            for (int i = 1; i < o.Length; i++)
            {
                if (v < o[i].GetSalary()) { v = o[i].GetSalary(); }
                else if (m > o[i].GetSalary()) { m = o[i].GetSalary(); }
            }

        }

        public static Worker[] ReadWorkersArray()
        {
            double bts;
            Console.Write("\n(ReadWorkersArray):\nset Worker number>> ");
            while (!Double.TryParse(Console.ReadLine(), out bts))
            { Console.WriteLine("Invalid Erorr, Rls try again >>"); }
            int razm = Convert.ToInt32(bts);
            Worker[] array = new Worker[razm];


            for (int i = 0; i < razm; i++)
            {
                array[i] = new Worker();
                Company array2 = new Company();
                Console.Write("\n(ReadWorkersArray): " + (i + 1) + "\n");
                array[i] = new Worker();
                array[i].SetName();
                array[i].SetYear();
                array[i].SetMonth();
                array2.SetName();
                array2.SetPosition();
                array2.SetSalary();
                array[i].SetWorkPlace(array2);
                int x = -1;
                int y= 0; 
                while (y != 79)
                {
                    
                    
                    Menu2();
                    Console.WriteLine("\nChoose an option >> "); x = int.Parse(Console.ReadLine());
                    switch (x)
                    {
                        case 1: array[i].SetPremGrn(); y=79; break;
                        case 2: array[i].SetPremDol(); y = 79; break;
                        case 3: array[i].SetPremEu(); y = 79; break;
                        default: Console.Clear(); Console.WriteLine("Erorr 404, Pls try again"); Console.WriteLine("\nClick to continue>> "); Console.ReadKey(); break;
                    }
                }
                
            }

            return array;
        }

        public static void PrintWorker(Worker o)
        {
            Console.Write(o.GetName());
            Console.Write(o.GetYear());
            Console.Write(o.GetMonth());
            o.GetWorkPlace();
           
            Console.Write("\npr3\n");
            
            Console.Write("\nGetPremGrn()\n");
            Console.Write(o.GetPremGrn());
            Console.Write("\no.GetPremDol()\n");
            Console.Write(o.GetPremDol());
            Console.Write("\no.GetPremEu()\n");
            Console.Write(o.GetPremEu());

        }

        public static void PrintWorker(Worker[] o)
        {
            for (int i = 0; i < o.Length; i++)
            {
                Console.Write("\nWorker " + (i + 1) + ":\n");
                PrintWorker(o[i]);
                Console.WriteLine("\nGetWorkExperience" + o[i].GetWorkExperience());
            }
        }
    }
    public class Company
    {
        protected string Name, Position;
        protected double Salary;
        public Company()
        {
            Name = "empty";
            Position = "empty";
            Salary = 0;
        }
        public Company(string a, string b, int c)
        {
            Name = a;
            Position = b;
            Salary = c;
        }
        public void SetName()
        {
            Console.Write("\nSetCompanyName\n");
            Name = Console.ReadLine().ToString();
        }
        public void SetPosition()
        {
            Console.Write("\nSetPosition\n");
            Position = Console.ReadLine().ToString();
        }
        public void SetSalary()
        {
            double bts;
            Console.Write("\nSetSalary\n");
            while (!Double.TryParse(Console.ReadLine(), out bts))
            { Console.WriteLine("Invalid Erorr, Pls try again >>"); }
            Salary = bts;
        }
        public string GetName()
        {
            Console.Write("\nGetCompanyName\n");
            return Name;
        }
        public string GetPosition()
        {
            Console.Write("\nGetPosition\n");
            return Position;
        }
        public double GetSalary()
        {
            //Console.Write("\nGetSalary\n");
            return Salary;
        }

    }

    public class Worker : IComparable
    {
        protected string Name;
        protected int Year, Month;
        protected Company WorkPlace;

        //pr3
        private float Prem;
        public void SetPremGrn()
        {
            Console.Write("\nSetPrem\n");
            int bts;
            while (!int.TryParse(Console.ReadLine(), out bts))
            { Console.WriteLine("Invalid Erorr, Pls try again >>"); }
            Console.Write("\nSetPrem\n");
            Prem = bts;
        }
        public void SetPremDol()
        {
            Console.Write("\nSetPrem\n");
            int bts;
            while (!int.TryParse(Console.ReadLine(), out bts))
            { Console.WriteLine("Invalid Erorr, Pls try again >>"); }
            Console.Write("\nSetPrem\n");
            Prem = bts * 28;
        }
        public void SetPremEu()
        {
            Console.Write("\nSetPrem\n");
            int bts;
            while (!int.TryParse(Console.ReadLine(), out bts))
            { Console.WriteLine("Invalid Erorr, Pls try again >>"); }
            Console.Write("\nSetPrem\n");
            Prem = bts * 33;
        }

        public float GetPremGrn()
        {
            Console.Write("\n GetPremGrn\n");
           return Prem; 
                   
        }
        public float GetPremDol()
        {
            Console.Write("\n GetPremDol\n");
            return Prem/28;

        }
        public float GetPremEu()
        {
            Console.Write("\n GetPremEu\n");
            return Prem/33;
        }


        public Worker()
        {
            Name = "empty";
            Year = 0;
            Month = 0;
            Prem = 0;
            WorkPlace = new Company();
        }
        public Worker(string a, int b, int c, Company d)
        {
            Name = a;
            Year = b;
            Month = c;
            WorkPlace = d;

        }
        public int CompareTo(object obj)
        {
            if (obj is Worker)
            {
                return this.Name.CompareTo((obj as Worker).Name);
            }
            throw new ArgumentException("Object is not a User");
        }

        public int CompareTo(Worker other) { return this.Name.CompareTo(other.Name); }

        public void SetName()
        {
            Console.Write("\nSetName\n");
            Name = Console.ReadLine();
        }
        public void SetYear()
        {
            Console.Write("\nSetYear\n");
            int bts;
            while (!int.TryParse(Console.ReadLine(), out bts))
            { Console.WriteLine("Invalid Erorr, Rls try again >>"); }
            Console.Write("\nSetSalary\n");
            Year = bts;
        }
        public void SetMonth()
        {
            Console.Write("\nSetMonth\n");
            int bts;
            while (!int.TryParse(Console.ReadLine(), out bts))
            { Console.WriteLine("Invalid Erorr, Rls try again >>"); }
            Month = bts;
        }
        public void SetWorkPlace(Company WP)
        {
            WorkPlace = WP;
        }
        public int GetMonth()
        {
            Console.Write("\nGetMonth\n");
            return Month;
        }
        public int GetYear()
        {
            Console.Write("\nGetYear\n");
            return Year;
        }
        public string GetName()
        {
            Console.Write("\nGetName\n");
            return Name;
        }
        public void GetWorkPlace()
        {
            Console.Write("\nGetWorkPlace\n");
            Console.Write(WorkPlace.GetName());
            Console.Write(WorkPlace.GetPosition());
            Console.Write(WorkPlace.GetSalary());
        }
        public double GetSalary()
        {
            return WorkPlace.GetSalary();
        }

        public int GetWorkExperience()
        {
            return ((DateTime.Now.Year - Year - 1) * 12 - Month + 1 + DateTime.Now.Month);//включно з місяцем прийнятя на роботу і теперішнім
        }
        public double GetTotalMoney()
        {
            return GetWorkExperience() * WorkPlace.GetSalary();
        }
    }
}
