public class Job {
    public string _jobTitle;
    public string _jobCompany;
    public string _jobYear;

public void DisplayJobs(){
    Console.WriteLine($"{_jobTitle} ({_jobCompany}) {_jobYear}");
}
}
