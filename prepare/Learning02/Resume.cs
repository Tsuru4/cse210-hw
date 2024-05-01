public class Resume
{
    public string _name;
    public List<Job> _jobs;

    public Resume()
    {
        _name = "";
        _jobs = new List<Job>();
    }
    public Resume(string name)
    {
        _name = name;
        _jobs = new List<Job>();
    }

    public void Display()
    {
        Console.WriteLine(_name);
        foreach (Job j in _jobs)
        {
            j.Display();
        }
    }

    public void AddJob(Job job)
    {
        _jobs.Add(job);
    }

}