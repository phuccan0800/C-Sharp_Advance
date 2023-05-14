using System;
using System.Collections.Generic;

namespace DAY2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Chosse Problem you want (1-7): ");
            int chosse = int.Parse(Console.ReadLine());
            switch (chosse) {
                case 1:
                    Problem1();
                    break;
                case 2:
                    Problem2();
                    break;
                case 3:
                    Problem3();
                    break;
                case 4:
                    Problem4();
                    break;
                case 5:
                    Problem5();
                    break;
                case 6:
                    break;
                case 7:
                    break;
            }
        }
        static void Problem1()
        {
            int n = int.Parse(Console.ReadLine());
            Car[] Car = new Car[n];
            for (int i = 0; i < n; i++)
            {
                string temp = Console.ReadLine();
                string[] temp2 = new string[100];
                temp2 = temp.Split(' ');
                Car[i] = new Car().Add(temp);
            }
            string check = Console.ReadLine();
            for (int i = 0; i < n; i++) Car[i].checkCar(check);
        }
        static void Problem2()
        {
            Console.WriteLine("Input Number Of Engine: ");
            int m = int.Parse(Console.ReadLine());
            Engine[] Engines = new Engine[m];
            for (int i = 0; i < m; i++)
            {
                string temp = Console.ReadLine();
                Engines[i] = new Engine().Add(temp);
            }
            
            Console.WriteLine("Input Number Of Car: ");
            int n = int.Parse(Console.ReadLine());
            Car2[] Car = new Car2[n];
            for (int i = 0; i < n; i++)
            {
                string temp = Console.ReadLine();
                Car[i] = new Car2().Add(temp);
            }
            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                {
                    if (Engines[j].ModelGet() == Car[i].GetEngine())
                    {
                        Console.WriteLine(Car[i].ToString(Engines[j]));
                        break;
                    }
                }
        }
        static void Problem3()
        {
            string temp = Console.ReadLine();
            string[] ArrTemp = new string[2];
            ArrTemp = temp.Split(' ');
            int min = int.Parse(ArrTemp[0]);
            int max = int.Parse(ArrTemp[1]);
            temp = Console.ReadLine();
            ArrTemp = temp.Split(' ');
            int xOfIvo = int.Parse(ArrTemp[0]);
            int yOfIvo = int.Parse(ArrTemp[1]);
            temp = Console.ReadLine();
            ArrTemp = temp.Split(' ');
            int xOfEvill = int.Parse(ArrTemp[0]);
            int yOfEvill = int.Parse(ArrTemp[1]);
            Console.WriteLine("");
            int sum = 0;
            while ((xOfIvo < 0) || (yOfEvill < 0) || (xOfEvill < 0) || (yOfIvo < 0))
            {
                xOfIvo--;
                yOfIvo++;
                xOfEvill--;
                yOfEvill--;
            }
            int cutx = -1;
            int cuty = -1;
            int xTempOfIvo = xOfIvo;
            int yTempOfIvo = yOfIvo;
            for (int i = yOfIvo; i <= max; i++)
            {
                int xTempOfEvill = xOfEvill;
                int yTempOfEvill = yOfEvill;
                for (int j = yOfEvill; j > 0; j--)
                {
                    Console.WriteLine($"{xTempOfIvo} vs {xTempOfEvill} ; {yTempOfIvo} vs {yTempOfEvill}");
                    if (xTempOfIvo == xTempOfEvill && yTempOfIvo == yTempOfEvill) { cutx = xTempOfIvo; cuty = yTempOfIvo; break; }
                    xTempOfEvill--;
                    yTempOfEvill--;
                }
                xTempOfIvo--;
                yTempOfIvo++;
            }
            do
            {
                if (xOfIvo != cutx && yOfIvo != cuty) sum = sum + (max * xOfIvo + yOfIvo);
                xOfIvo--;
                yOfIvo++;
            }
            while (xOfIvo >= 0 && yOfIvo < max);

            Console.WriteLine($"{cutx} - {cuty}");
            Console.WriteLine(sum);
        }
        static void Problem4()
        {
            Patients[] patients = new Patients[100];
            string temp = Console.ReadLine();
            int i = 0;
            do
            {
                string[] ArrTemp = new string[4];
                ArrTemp = temp.Split(' ');
                if (ArrTemp.Length == 4)
                {
                    patients[i] = new(ArrTemp[0], $"{ArrTemp[1]} {ArrTemp[2]}", ArrTemp[3]);
                    i++;
                }
            }
            while (temp != "Output") ;
        }
        static void Problem5()
        {
            int Value = int.Parse(Console.ReadLine());
            string temp = Console.ReadLine() ;
            string[] ArrTemp = new string[temp.Length];
            ArrTemp = temp.Split(' ');
            List<TypeAndAmount> TypeAndAmounts = new List<TypeAndAmount>();
            List<ItemsAndAmount> ItemsAndAmounts = new List<ItemsAndAmount>();
            TypeAndAmount tempType = new TypeAndAmount("Gold", 0);
            TypeAndAmounts.Add(tempType);
            tempType = new TypeAndAmount("Gem", 0);
            TypeAndAmounts.Add(tempType);
            tempType = new TypeAndAmount("Cash", 0);
            TypeAndAmounts.Add(tempType);
            int i = 0;
            while (i < ArrTemp.Length)
            {
                if (ArrTemp[i] == "Gold")
                {
                    ItemsAndAmount tempItem = new ItemsAndAmount("Gold", ArrTemp[i], int.Parse(ArrTemp[i + 1]));
                    ItemsAndAmounts.Add(tempItem);
                    TypeAndAmounts[0].PlusAmount(int.Parse(ArrTemp[i + 1]));
                }
                else if (ArrTemp[i].Contains("gem") || ArrTemp[i].Contains("gem"))
                {
                    ItemsAndAmount tempItem = new ItemsAndAmount("Gem", ArrTemp[i], int.Parse(ArrTemp[i + 1]));
                    ItemsAndAmounts.Add(tempItem);
                    TypeAndAmounts[1].PlusAmount(int.Parse(ArrTemp[i + 1]));
                }
                else if (!ArrTemp[i].Contains("Gem"))
                {
                    ItemsAndAmount tempItem = new ItemsAndAmount("Cash", ArrTemp[i], int.Parse(ArrTemp[i + 1]));
                    ItemsAndAmounts.Add(tempItem);
                    TypeAndAmounts[2].PlusAmount(int.Parse(ArrTemp[i + 1]));
                }
                i = i + 2;
            }
            if (TypeAndAmounts[0].GetAmount() < Value)
            {
                Console.WriteLine($"<Gold> ${TypeAndAmounts[0].GetAmount()}");
                Value = Value - TypeAndAmounts[0].GetAmount();
                Console.WriteLine($"##Gold - {TypeAndAmounts[0].GetAmount()}");
            }
            else if (TypeAndAmounts[0].GetAmount() >= Value)
            {
                Console.WriteLine($"<Gold> ${Value}");
                Console.WriteLine($"##Gold - {Value}");
                Value = 0;
            } 
            for (i = 0; i < ItemsAndAmounts.Count-1; i++)
                for (int j = i+ 1; j < ItemsAndAmounts.Count; j++)
                    if (ItemsAndAmounts[i].GetItem().CompareTo(ItemsAndAmounts[j].GetItem()) < 0)
                    {
                        ItemsAndAmount tempItem = ItemsAndAmounts[i];
                        ItemsAndAmounts[i] = ItemsAndAmounts[j];
                        ItemsAndAmounts[j] = tempItem;
                    }
            if (Value > 0)
            {
                int tempValue = Value - TypeAndAmounts[1].GetAmount();
                if (tempValue > 0 && TypeAndAmounts[1].GetAmount()>0)
                {
                    Console.WriteLine($"<Gem> - {TypeAndAmounts[1].GetAmount()}");
                    for (i = 0; i < ItemsAndAmounts.Count; i++)
                    {
                        if (Value > tempValue
                            && (ItemsAndAmounts[i].GetTypeName().Contains("gem") ||
                            ItemsAndAmounts[i].GetTypeName().Contains("Gem"))
                            && (ItemsAndAmounts[i].GetAmount() > 0))
                        {
                            Value = Value - ItemsAndAmounts[i].GetAmount();
                            Console.WriteLine($"##{ItemsAndAmounts[i].GetItem()} - {ItemsAndAmounts[i].GetAmount()}");
                        }
                    }
                }
                else if (tempValue <= 0 && TypeAndAmounts[1].GetAmount() >0)
                {
                    Console.WriteLine($"<Gem> - {Value}");
                    for (i = 0; i < ItemsAndAmounts.Count; i++)
                    {
                        if (Value > tempValue
                            && 
                            ItemsAndAmounts[i].GetTypeName().Contains("Gem")
                            && (ItemsAndAmounts[i].GetAmount() > 0))
                        {
                            Value = Value - ItemsAndAmounts[i].GetAmount();
                            if (Value < 0) { Console.WriteLine($"##{ItemsAndAmounts[i].GetItem()} - {ItemsAndAmounts[i].GetAmount() + Value}"); break; }

                            else if  (Value > 0) Console.WriteLine($"##{ItemsAndAmounts[i].GetItem()} - {ItemsAndAmounts[i].GetAmount()}");
                        }
                    }
                }
            }
            if (Value > 0 && TypeAndAmounts[2].GetAmount()>0)
            {
                int tempValue = Value - TypeAndAmounts[2].GetAmount();
                if (tempValue > 0)
                {
                    Console.WriteLine($"<Cash> - {TypeAndAmounts[2].GetAmount()}");
                    for (i = 0; i < ItemsAndAmounts.Count; i++)
                    {
                        if (Value > tempValue
                            && ItemsAndAmounts[i].GetTypeName().Contains("Cash")
                            && (ItemsAndAmounts[i].GetAmount() > 0))
                        {
                            Value = Value - ItemsAndAmounts[i].GetAmount();
                            Console.WriteLine($"##{ItemsAndAmounts[i].GetItem()} - {ItemsAndAmounts[i].GetAmount()}");
                        }
                    }
                }
                else if (tempValue <= 0 && TypeAndAmounts[2].GetAmount() > 0)
                {
                    Console.WriteLine($"<Cash> - {Value}");
                    for (i = 0; i < ItemsAndAmounts.Count; i++)
                    {
                        if (Value > tempValue
                            && (ItemsAndAmounts[i].GetTypeName().Contains("Cash") ||
                            ItemsAndAmounts[i].GetTypeName().Contains("cash"))
                            && (ItemsAndAmounts[i].GetAmount() > 0))
                        {
                            Value = Value - ItemsAndAmounts[i].GetAmount();
                            if (Value < 0) { Console.WriteLine($"##{ItemsAndAmounts[i].GetItem()} - {ItemsAndAmounts[i].GetAmount() + Value}"); break; }

                            else if (Value > 0) Console.WriteLine($"##{ItemsAndAmounts[i].GetItem()} - {ItemsAndAmounts[i].GetAmount()}");
                        }
                    }
                }
            }
        }
    }
}
