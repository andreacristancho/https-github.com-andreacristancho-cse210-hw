using System;

class Program
{
    static void Main(string[] args)
    {
        
        
        Console.Clear();
        Console.WriteLine("    ****   Exercise Tracking Program   ***");
        Console.WriteLine();
        Console.WriteLine("This APP will help to keep track of the training metrics in order to \nmeasure the progress and encourage the people to improve day by day.");
        Console.WriteLine();

        List<Activity> activities = new List<Activity>();

        // public Running (int minutes, string date, double distance) 
        Running r1 = new Running (50, "10 August 2023", 4000);
        activities.Add(r1);

        //public Cycling (int minutes, string date, int speed) 
        Cycling c1 = new Cycling(90, "11 August 2023", 25);
        activities.Add(c1);

        //public Swimming (int minutes, string date, int laps) 
        Swimming s1 = new Swimming(60, "13 August 2023", 400);
        activities.Add(s1);

        foreach (Activity a in activities)

        {
            int minutes = a.GetMinutes();
            //double distance = Math.Round(a.GetDistance(),2);
            //double speed = Math.Round(a.GetSpeed(),2);
            //double pace = Math.Round(a.GetPace(),2);
            string activityType = a.GetType().Name;
            string summary = a.GetSummary();
            //Console.WriteLine("Type of Activity: "+ activityType + " (" + minutes + " minutes). \nDistance: "+ distance +" kms"  + "\nSpeed: " + speed + " km per hr" + "\nPace: " + pace + " min per km");
            Console.WriteLine("Type of Activity: "+ activityType + " (" + minutes + " minutes). \n" + summary);
            Console.WriteLine();
        }

        
    }
}