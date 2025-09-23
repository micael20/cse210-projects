using System;

class Program
{
    static void Main(string[] args)
    {
        Job job = new Job();
        job._company = "Microsoft";
        job._jobTitle = "Graphics Designer";
        job._startYear = 2022;
        job._endYear = 2024;

        job.DisplayJobInfo();

        Job job2 = new Job();
        job2._company = "Apple";
        job2._jobTitle = "Artistist";
        job2._startYear = 2024;
        job2._endYear = 2026;

        job2.DisplayJobInfo();

        Resume resume = new Resume();
        resume._name = "Michael Mwidete";
        resume._jobs.Add(job);
        resume._jobs.Add(job2);

        resume.DisplayInfo();


     
    }   
}