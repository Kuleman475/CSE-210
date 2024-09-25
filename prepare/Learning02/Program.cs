using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._jobCompany = "Microsoft";
        job1._jobYear = "1970 - 2024";

        Job job2 = new Job();
        job2._jobTitle = "Software Engineer";
        job2._jobCompany = "Apple";
        job2._jobYear = "2020-2024";

        // job1.DisplayJobs();

        Resume resume = new Resume();
        resume._personName = "Alison Rose";

        resume._jobs.Add(job1);
        resume._jobs.Add(job2);

        // Console.WriteLine($"{resume._jobs[1]._jobCompany}");
        resume.DisplayResume();

    }
}