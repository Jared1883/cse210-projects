using System;

class Program
{
    static void Main(string[] args)
    {
        Job job = new Job();
        job._company = "Microsoft";
        job.Display();
        Resume resume = new Resume();
        resume._personName = "Juan Cruz";
        resume._jobs.Add(job);
        resume.DisplayJobs();


    }
}