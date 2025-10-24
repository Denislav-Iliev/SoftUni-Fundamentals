
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<string> schedule = Console.ReadLine()
            .Split(", ", StringSplitOptions.RemoveEmptyEntries)
            .ToList();

        string command;
        while ((command = Console.ReadLine()) != "course start")
        {
            string[] parts = command.Split(":", StringSplitOptions.RemoveEmptyEntries);
            string action = parts[0];

            switch (action)
            {
                case "Add":
                    AddTitle(schedule, parts[1]);
                    break;

                case "Insert":
                    InsertTitle(schedule, parts[1], int.Parse(parts[2]));
                    break;

                case "Remove":
                    RemoveTitle(schedule, parts[1]);
                    break;

                case "Swap":
                    SwapTitles(schedule, parts[1], parts[2]);
                    break;

                case "Exercise":
                    InsertExercise(schedule, parts[1]);
                    break;
            }
        }

        for (int i = 0; i < schedule.Count; i++)
        {
            Console.WriteLine($"{i + 1}.{schedule[i]}");
        }
    }

    static void AddTitle(List<string> schedule, string title)
    {
        if (!schedule.Contains(title))
        {
            schedule.Add(title);
        }
    }

    static void InsertTitle(List<string> schedule, string title, int index)
    {
        if (!schedule.Contains(title) && index >= 0 && index <= schedule.Count)
        {
            schedule.Insert(index, title);
        }
    }

    static void RemoveTitle(List<string> schedule, string title)
    {
        schedule.Remove(title);

        string exerciseTitle = $"{title}-Exercise";
        
        schedule.Remove(exerciseTitle);
    }

    static void SwapTitles(List<string> schedule, string firstTitle, string secondTitle)
    {
        int firstIndex = schedule.IndexOf(firstTitle);
        int secondIndex = schedule.IndexOf(secondTitle);

        if (firstIndex == -1 || secondIndex == -1) return;

        
        (schedule[firstIndex], schedule[secondIndex]) = (schedule[secondIndex], schedule[firstIndex]);

       
        MoveExerciseAfterLesson(schedule, firstTitle, secondIndex);
        MoveExerciseAfterLesson(schedule, secondTitle, firstIndex);
    }

    static void InsertExercise(List<string> schedule, string title)
    {
        string exerciseTitle = $"{title}-Exercise";

        if (!schedule.Contains(title))
        {
            schedule.Add(title);
            schedule.Add(exerciseTitle);
            return;
        }

       
        if (!schedule.Contains(exerciseTitle))
        {
            int lessonIndex = schedule.IndexOf(title);
            schedule.Insert(lessonIndex + 1, exerciseTitle);
        }
    }

    static void MoveExerciseAfterLesson(List<string> schedule, string title, int lessonIndexNow)
    {
        string exerciseTitle = $"{title}-Exercise";
        int exerciseIndex = schedule.IndexOf(exerciseTitle);

        if (exerciseIndex == -1) return; 

       
        if (exerciseIndex != lessonIndexNow + 1)
        {
            schedule.RemoveAt(exerciseIndex);
           
        
            int currentLessonIndex = schedule.IndexOf(title);
            schedule.Insert(currentLessonIndex + 1, exerciseTitle);
        }
    }
}
