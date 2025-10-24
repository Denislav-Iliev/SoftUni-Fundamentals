using System;
using System.Linq;
using System.Collections.Generic;

List<int> list = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToList();

string input;
while ((input = Console.ReadLine()) != "End")
{
    string[] command = input.Split();

    switch (command[0])
    {
        case "Add":
            {
                int number = int.Parse(command[1]);
                list.Add(number);
                break;
            }
        case "Insert":
            {
                int number = int.Parse(command[1]);
                int index = int.Parse(command[2]);
                if (index < 0 || index > list.Count)
                {
                    Console.WriteLine("Invalid index");
                }
                else
                {
                    list.Insert(index, number);
                }
                break;
            }
        case "Remove":
            {
                int index = int.Parse(command[1]);
                if (index < 0 || index >= list.Count)
                {
                    Console.WriteLine("Invalid index");
                }
                else
                {
                    list.RemoveAt(index);
                }
                break;
            }
        case "Shift":
            {
                if (list.Count == 0) break;

                string direction = command[1];
                int count = int.Parse(command[2]) % list.Count;

                if (direction == "left")
                {
                    for (int i = 0; i < count; i++)
                    {
                        int first = list[0];
                        list.RemoveAt(0);
                        list.Add(first);
                    }
                }
                else if (direction == "right")
                {
                    for (int i = 0; i < count; i++)
                    {
                        int last = list[list.Count - 1];
                        list.RemoveAt(list.Count - 1);
                        list.Insert(0, last);
                    }
                }
                break;
            }
    }
}

Console.WriteLine(string.Join(" ", list));
