// Create a new file for your job class. By convention this should be named Job.cs .
// Create the class (Hint this is the public class Job syntax).
// Create member variables in the class for each element that this class should contain. By convention these member variables should begin with an underscore and a lowercase letter such as _jobTitle .
// Test your Job class
// Back in your Program.cs file, add code to your Main function.
// Create a new job instance named job1 .
// Set the member variables using the dot notation (for example, job1._jobTitle = "Software Engineer";
// Verify that you can display the company of this job on the screen, again using the dot notation to access the member variable.
// Create a second job, set its variables, display this company on the screen as well.
// Sample Output
// Microsoft
// Apple
// Add a Display method to the Job class
// Return to your Job.cs file and add a method (member function) to display the job details. This method should not have any parameters and does not need to return anything. By convention, this method should begin with a capital letter, such as Display, and if you have multiple words each word should be capitalized, such as DisplayJobDetails .
// This method should display the job details on the screen in the correct format. Remember that the method can access the member variables directly, without needing them to be passed into it.
// Return to your Program.cs file. Remove the lines of code where you displayed the company earlier, and replace them with calls to your new method. Remember that you call the method using the same dot notation such as job1.Display(); .
// Sample Output
// Software Engineer (Microsoft) 2019-2022
// Manager (Apple) 2022-2023
public class Job
{
    public string _company;
    public string _jobTitle;
    public int _startYear;
    public int _endYear;
    public void DisplayJobInfo()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }

}