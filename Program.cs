using System.Collections;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }

    public class Bank
    {
        public string Name { get; set; }
    }

    public class Branch
    {
        public string Name { get; set; }
        public string TotalAmountOfDeposits { get; set; }
    }

    public class ExceptionKolichestvoException
    {
        public string FullNameOfVkladchik { get; set; }
   
        public string VkladAmount { get; set; } 
        public double CalculateVkladAmount
        {
            get { return 0; }
            set
            {
                try
                {
                    if (value < 0)
                    {
                        throw new Exception("Сумма общего вклада:");
                    }
                    else CalculateVkladAmount = value;
                }
                catch (Exception ex)
                {
                    CalculateVkladAmount = 0;
                    Console.WriteLine("Error" + ex.Message);
                    Console.WriteLine($"Значение вызвавшее ошибку: {ex.Message}");

                }
                CalculateVkladAmount += value;
            }
        }

        public class ExceptionVkladException
        {
            public double Long_long_term {
                get { return (double)Long_long_term; }
                set
                {
                    try
                    {
                        if (Long_long_term < 0)
                        {
                            throw new Exception("Сумма долгосрочного вклада:");
                        }
                        else
                        {
                            Long_long_term = value;
                        }
                    }
                    catch (ArgumentException ex)
                    {
                        return;
                    }
                }
                }
                public double Demand_deposit { get { return 0; }
                set {
                    try
                    {
                        if (Demand_deposit < 0)
                        {
                            throw new Exception("Сумма вклада до востребования:");
                                }
                        else
                        {
                            Demand_deposit = value;
                        }
                    }
                    catch(Exception ex)
                    {
                        return;
                    }
                }
            }
            public double Short_term
            {
                get { return (double)Short_term; } set {
                    try
                    {
                      if(Short_term < 0)
                        {
                            throw new Exception("Сумма короткосрочного вклада:");
                        }
                        else
                        {
                            Short_term = value;
                        }
                    }
                    catch(Exception ex)
                    {
                        Short_term = 0;
                        Console.WriteLine("Невозможно создать вклад - указана отрицательная сумма вклада:");
                        return;
                    }
                    
                }
            }
            }

        }
    }

   
