using System;
using System.Collections.Generic;
using System.IO;
class Program
{
    static void Main(string[] args)

    {
        List<Goal> goalsList = new List<Goal>();
        Goal g1 = new Goal("", "", 1, false);

        //Este while me permite crear el bucle para MenuOptions
        string userChoice = " ";
        while (userChoice != "6")

        
        {
       
            userChoice = g1.MenuOptions();
            if (userChoice =="1")
        
            {
                string typeUserChoice = g1.TypeOfGoal();

                if (typeUserChoice == "1")
                {
                
                SimpleGoal s1 = new SimpleGoal(" ", "", 1, false );
                s1.CreateGoal();
                goalsList.Add(s1);
                
                //Console.Write(s1.DisplayGoalsList());
                }

                else if (typeUserChoice =="2")
                {
                
                EternalGoal e1 = new EternalGoal("","",1,true);
                e1.CreateGoal();
                goalsList.Add(e1);
                }


                else if (typeUserChoice =="3")
                {
                        
                    ChecklistGoal c1 = new ChecklistGoal("", "", 1, true, 1,1,1);
                    c1.CreateGoal();
                    goalsList.Add(c1);
    
                }
            }

            else if (userChoice =="2")
            { 
                Console.WriteLine("The goals are: ");
                for (int i = 0; i < goalsList.Count; i++)
                {
                    Goal g = goalsList[i];
                    string fulfilled = g.GetFulfilled() ? "X" : " ";
                    string eachGoal = $"{fulfilled} {i+1}. {g.DisplayGoalsList()}";
                    Console.WriteLine(eachGoal);
                }
                Console.WriteLine();
                Console.WriteLine("Press Enter to continue...");
                Console.ReadLine();
            }

            else if (userChoice=="3")
            {
                SaveGoals(goalsList);
            }
            

            else if (userChoice=="4")
            {
                
                goalsList =ReadFromFile();
                
            }

        //CUANDO ENTRO DE NUEVO NO ME ABRE EL ARCHIVO QUE HE GRABADO Y NO ME CORRE EL PUNTO 5
                    
                    
            else if (userChoice == "5")
            {
                Console.WriteLine("The goals are: ");
                for (int i = 0; i < goalsList.Count; i++)
                {
                    Goal g = goalsList[i];
                    int eachPosition = i + 1;
                    Console.WriteLine($"{eachPosition}.{g.DisplayGoalsList()}");
                }
                Console.Write("Which goal did you accomplish? ");
                string accomplishGoal = Console.ReadLine();
                int accomplishGoalInt = int.Parse(accomplishGoal);
    
                Goal goalToAccomplish = goalsList[accomplishGoalInt - 1];
    
                if (goalToAccomplish is SimpleGoal && !goalToAccomplish.GetFulfilled())
                {
                    goalToAccomplish.SetFulfilled(true);
                    Console.WriteLine($"Congratulations! You have earned {goalToAccomplish.GetOnlyPoints()} points for goal {accomplishGoalInt}.");
                }
                else if (goalToAccomplish is ChecklistGoal)
                {
                    ChecklistGoal checklistGoal = (ChecklistGoal)goalToAccomplish;
                    int bonus = checklistGoal.GetBonus();
                    int totalTimes = checklistGoal.GetTotalTimes();
                    int times = checklistGoal.GetTimes();
    
                    if (times < totalTimes)
                    {
                        checklistGoal.RecordGoal();
                        Console.WriteLine($"You have recorded goal {accomplishGoalInt}. Current progress: {times + 1}/{totalTimes}");
                        Console.WriteLine($"You have earned {goalToAccomplish.GetOnlyPoints()} points.");
                    }
                    else if (times == totalTimes)
                    {
                        checklistGoal.RecordGoal();
                        goalToAccomplish.SetFulfilled(true);
                        Console.WriteLine($"Congratulations! You have completed goal {accomplishGoalInt}.");
                        Console.WriteLine($"You have earned {goalToAccomplish.GetOnlyPoints()} points and a bonus of {bonus} points.");
                    }
                }
                else
                {
                    Console.WriteLine($"Goal {accomplishGoalInt} is already fulfilled or not applicable for this action.");
                }
    
                Console.ReadLine();
            }

        }
    
    }


    static void SaveGoals(List<Goal> goalsList)
    
    {
        Console.Write(" What is the filename for the goal file?: ");

        string filename = Console.ReadLine();

        List<string> goalLines = new List<string>();

       using (StreamWriter outputFile  = new StreamWriter(filename))
        {

        
            foreach (Goal goal in goalsList)
            {
                outputFile.WriteLine(goal.DisplayInFile()); 
            }

        
        }
    }


    static  List<Goal> ReadFromFile()
    {
        Console.Write("What is the filename for the goal file?: ");
        
        

        string filePath = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(filePath);

        List<Goal> eachGoal = new List<Goal>();

        for (int i =1; i<lines.Length; i++)
        {   
            

            string[] item = lines[i].Split(",");
            string name = item[0].Trim();
            string description = item[1].Trim();
            int points = Convert.ToInt16(item[2]);
            bool fulfilled = Convert.ToBoolean(item[3].Trim());

            if (item.Length == 4)
            {
                SimpleGoal simpleGoal = new SimpleGoal(name, description, points, fulfilled);
                eachGoal.Add(simpleGoal);
            }
            else if (item.Length == 5)
            {
                EternalGoal eternalGoal = new EternalGoal(name, description, points, fulfilled);
                eachGoal.Add(eternalGoal);
            }
            else if (item.Length == 7)
            {
                int times = Convert.ToInt32(item[4].Trim());
                int totalTimes = Convert.ToInt32(item[5].Trim());
                int bonus = Convert.ToInt32(item[6].Trim());

                ChecklistGoal checklistGoal = new ChecklistGoal(name, description, points, fulfilled, totalTimes, times, bonus);
                eachGoal.Add(checklistGoal);
            }

        }
        return eachGoal;      
    }

}

