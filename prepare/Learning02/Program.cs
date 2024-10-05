using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Nuclear Engineer";
        job1._company = "Los Alamos National Laboratory";
        job1._startYear = 2027;
        job1._endYear = 2030;

        Job job2 = new Job();
        job2._jobTitle = "Orthodontic Assistant";
        job2._company = "Rio Grande Orthodontics";
        job2._startYear = 2024;
        job2._endYear = 2026;

        Resume jobResume = new Resume();
        jobResume._name = "Nat Lee";
        jobResume._jobList.Add(job1);
        jobResume._jobList.Add(job2);

        jobResume.DisplayResume();

    }
}