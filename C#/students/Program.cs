using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        var studentData = new Dictionary<string, Dictionary<string, int>>();
        string helptext = "\n========= Student Database =========\nChoose Your Input:\n1- Add Student To Database.\n2- List of All Students & Scores.\n3- List of All Students & Scores & Average:\n4- List of All Medium Average Students\n5- List of All High Average Students\n6- List of All Low Average Students\n0- Exit.\n";
        Console.WriteLine(helptext);

        while (true)
        {
            Console.Write("Enter your choice: ");
            string input = Console.ReadLine();
            if (int.TryParse(input, out int choice))
            {
                switch (choice)
                {
                    case 1:
                        Console.Write("Enter the Name of the Student (or type 'done' to finish): ");
                        string studentName = Console.ReadLine();
                        if (studentName?.ToLower() == "done")
                        {
                            Console.WriteLine(helptext);
                            continue;
                        }

                        var subjectsScores = new Dictionary<string, int>();

                        // Math
                        Console.WriteLine("Enter score for Math:");
                        int MathScore = int.Parse(Console.ReadLine());
                        subjectsScores.Add("Math", MathScore);
                        // Psychology
                        Console.WriteLine("Enter score for Psychology:");
                        int PsychologyScore = int.Parse(Console.ReadLine());
                        subjectsScores.Add("Psychology", PsychologyScore);
                        // Programming
                        Console.WriteLine("Enter score for Programming:");
                        int ProgrammingScore = int.Parse(Console.ReadLine());
                        subjectsScores.Add("Programming", ProgrammingScore);
                        // Calculate Average of All Scores
                        int sum = MathScore + PsychologyScore + ProgrammingScore; 
                        int avgScore = sum / 3;
                        subjectsScores.Add("Average", avgScore);
                        studentData.Add(studentName, subjectsScores);
                        Console.WriteLine($"\nNice! All Scores Added for {studentName}.");
                        Console.WriteLine(helptext);
                        break;
                    case 2:
                        Console.WriteLine("List of All Students & Scores:");
                        foreach (var student in studentData)
                        {
                            Console.WriteLine($"\n------- {student.Key} -------");
                            foreach (var subjectScore in student.Value)
                            {
                                if(subjectScore.Key == "Average"){
                                    continue;
                                }
                                Console.WriteLine($"{subjectScore.Key} : {subjectScore.Value}");
                            }
                        }
                        break;
                    case 3:
                        Console.WriteLine("List of All Students & Scores & Average:");
                        foreach (var student in studentData)
                        {
                            Console.WriteLine($"\n------- {student.Key} -------");
                            foreach (var subjectScore in student.Value)
                            {
                                if(subjectScore.Key == "Average"){
                                    Console.WriteLine($"[+] {subjectScore.Key} : {subjectScore.Value}");
                                    continue;
                                }
                                Console.WriteLine($"{subjectScore.Key} : {subjectScore.Value}");
                            }
                        }
                        break;
                    case 4:
                        Console.WriteLine("List of All Students With Medium Average:");
                        foreach (var student in studentData)
                        {
                            foreach (var subjectScore in student.Value){
                                if(subjectScore.Key == "Average" && subjectScore.Value >= 10 && subjectScore.Value <= 15){
                                    Console.ForegroundColor = ConsoleColor.DarkGray;
                                    Console.WriteLine($"\n[+] {student.Key} With {subjectScore.Value} {subjectScore.Key} Score.");
                                    Console.ForegroundColor = ConsoleColor.Gray;

                                }
                            }
                        }
                        break;
                    case 5:
                        Console.WriteLine("List of All Students With High Average:");
                        foreach (var student in studentData){
                            foreach (var subjectScore in student.Value){
                                if(subjectScore.Key == "Average" &&  subjectScore.Value >= 15 && subjectScore.Value <= 20){
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine($"\n[+] {student.Key} With {subjectScore.Value} {subjectScore.Key} Score.");
                                    Console.ForegroundColor = ConsoleColor.Gray;
                                }
                            }
                        }
                        break;
                    case 6:
                        Console.WriteLine("List of All Students With Low Average:");
                        foreach (var student in studentData){
                            foreach (var subjectScore in student.Value){
                                if(subjectScore.Key == "Average" &&  subjectScore.Value >= 0 && subjectScore.Value <= 10){
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine($"\n[+] {student.Key} With {subjectScore.Value} {subjectScore.Key} Score.");
                                    Console.ForegroundColor = ConsoleColor.Gray;
                                }
                            }
                        }
                        break;
                    case 0:
                        Console.WriteLine("Exiting...");
                        return;
                    default:
                        Console.WriteLine("Invalid input. Please enter 1, 2, 3, 4, 5, 6 or 0.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Please enter a valid number.");
            }
        }
    }
}
