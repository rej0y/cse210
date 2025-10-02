using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Apple";
        job1._jobTitle = "Computer Scientist";
        job1._startYear = 2019;
        job1._endYear = 2022;

        Job job2 = new Job();
        job2._company = "Red Hat";
        job2._jobTitle = "Software Engineer";
        job2._startYear = 2022;
        job2._endYear = 2023;


        Resume aResume = new Resume();

        aResume._name = "Scott Burton";
        aResume._jobs.Add(job1);
        aResume._jobs.Add(job2);
        aResume.DisplayResume();

    }
}