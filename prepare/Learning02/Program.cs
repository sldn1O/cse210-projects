using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Item Stocker";
        job1._company = "Local Supermarket";
        job1._startYear = 2015;
        job1._endYear = 2018;

        Job job2 = new Job();
        job2._jobTitle = "Mystery Solver";
        job2._company = "Mystery Inc.";
        job2._startYear = 2018;
        job2._endYear = 2023;

        Resume myResume = new Resume();
        myResume._name = "Fred Jones";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}