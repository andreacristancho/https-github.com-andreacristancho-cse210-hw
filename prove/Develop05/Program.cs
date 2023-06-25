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

            if (userChoice == "1")
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
                    string eachGoal = (i+1)+". "+g.DisplayGoalsList();
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
                ReadFromFile();
                
            }


            else if (userChoice=="5")
            {//
                //Console.WriteLine("The goals are: ");
//
                //for (int i = 0; i < goalsList.Count; i++)
                //{
                //    Goal g = goalsList[i];
                //    string eachGoal = (i+1)+". "+g.GetName();
                //    Console.WriteLine(eachGoal);
                //}
                //Console.WriteLine("Wich goal did you accomplish? ");
                //string accomplishGoal = Console.ReadLine();
//
                ////ACA DEBO CUADRAR QUE SEGÚN LA ACTIVIDAD TRAIGA LOS POINTS RESPECTIVOS
            //
                //for (int i = 0; i < goalsList.Count; i++)
                //{
                //    Goal g = goalsList[i];
                //    string eachPosition = (i+1);
                //    if (eachPosition == accomplishGoal)
                //    Console.Write("Congratulations! You have earned "+ 
                //}
                //
    //


                
            }

            else if (userChoice=="6")
            {


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
                outputFile.WriteLine(goal.DisplayInFile()); // Agrega la representación del goal a la lista de líneas
            }

        
        }
    }


    public static  List<Goal> ReadFromFile()
    {
        Console.Write("What is the filename for the goal file?: ");
        
        List<Goal> eachGoal = new List<Goal>();

        string filePath = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(filePath);

        return eachGoal;
            
        
    }


    
}

