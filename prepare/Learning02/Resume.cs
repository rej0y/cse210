public class Resume
{
    public string _name;
    public List<Job> _jobs = new List<Job>();
    public void DisplayResume()
    {
        // Output the Name.
        Console.WriteLine($"Name: {_name}");

        // Output the jobs.
        Console.WriteLine("Jobs:");
        foreach (Job job in _jobs)
        {
            job.DisplayJobDetails();
        }
    }
}