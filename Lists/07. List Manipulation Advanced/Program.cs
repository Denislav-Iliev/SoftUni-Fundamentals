using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<int> nums = Console.ReadLine()
            .Split(' ', StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToList();

        bool modified = false;

        string line;
        while ((line = Console.ReadLine()) != "end")
        {
            string[] parts = line.Split();
            string cmd = parts[0];

            switch (cmd)
            {
                
                case "Add":
                    {
                        int number = int.Parse(parts[1]);
                        nums.Add(number);
                        modified = true;
                        break;
                    }
                case "Remove":
                    {
                        int number = int.Parse(parts[1]);
                        
                        if (nums.Remove(number)) modified = true;
                        break;
                    }
                case "RemoveAt":
                    {
                        int index = int.Parse(parts[1]);
                        if (index >= 0 && index < nums.Count)
                        {
                            nums.RemoveAt(index);
                            modified = true;
                        }
                        break;
                    }
                case "Insert":
                    {
                        int number = int.Parse(parts[1]);
                        int index = int.Parse(parts[2]);
                        if (index >= 0 && index < nums.Count)
                        {
                            nums.Insert(index, number);
                            modified = true;
                        }
                        else if (index == nums.Count)
                        {
                            nums.Add(number);
                            modified = true;
                        }
                        break;
                    }

                
                case "Contains":
                    {
                        int number = int.Parse(parts[1]);
                        Console.WriteLine(nums.Contains(number) ? "Yes" : "No such number");
                        break;
                    }
                case "PrintEven":
                    {
                        Console.WriteLine(string.Join(' ', nums.Where(x => x % 2 == 0)));
                        break;
                    }
                case "PrintOdd":
                    {
                        Console.WriteLine(string.Join(' ', nums.Where(x => x % 2 != 0)));
                        break;
                    }
                case "GetSum":
                    {
                        Console.WriteLine(nums.Sum());
                        break;
                    }
                case "Filter":
                    {
                        string op = parts[1];   
                        int number = int.Parse(parts[2]);

                        IEnumerable<int> result = op switch
                        {
                            "<" => nums.Where(x => x < number),
                            ">" => nums.Where(x => x > number),
                            "<=" => nums.Where(x => x <= number),
                            ">=" => nums.Where(x => x >= number),
                            _ => Enumerable.Empty<int>()
                        };

                        Console.WriteLine(string.Join(' ', result));
                        break;
                    }

                default:
                    
                    break;
            }
        }

        
        if (modified)
        {
            Console.WriteLine(string.Join(' ', nums));
        }
    }
}
