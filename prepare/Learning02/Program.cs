using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job("Software Engineer","Microsoft",1996,2024);
        Job job2 = new Job("Student","BYU-I",1978,1996);
        
        Resume resume1 = new Resume("Allyn");
        
        resume1.AddJob(job1);
        resume1.AddJob(job2);
        
        resume1.Display();
    }
}