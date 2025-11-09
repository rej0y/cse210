class ReflectionActivity : Activity
{
    private int _messageDuration;
    public ReflectionActivity(int messageDuration)
    {
        _name = "Reflection";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
        _messageDuration = messageDuration;
    }
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };
    private List<string> _reflectionQuestions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };
    public void DoActivity()
    {
        DoStartingMessage();
        PreparingAnimation(5);

        Console.WriteLine("Consider the following prompt:\n");

        int randomPromptIndex = new Random().Next(_prompts.Count);
        Console.WriteLine($"--- {_prompts[randomPromptIndex]} ---\n");
        Console.CursorVisible = true;
        Console.Write("When you have something in mind, press enter to continue: ");
        Console.ReadLine();
        Console.CursorVisible = false;

        Console.WriteLine();
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.\n");
        Console.Write("You may begin in: ");
        NumberTimer(5);
        Console.Clear();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        while (DateTime.Now <= endTime)
        {
            if (_reflectionQuestions.Count > 0)
            {
                int randomQuestionIndex = new Random().Next(_reflectionQuestions.Count);
                Console.Write($"> {_reflectionQuestions[randomQuestionIndex]} ");
                _reflectionQuestions.RemoveAt(randomQuestionIndex);
                SpinnerAnimation(_messageDuration);
            }
            else
            {
                Console.WriteLine("Run out of questions, exit early...\n");
                break;
            }
        }

        Console.WriteLine();
        DoEndingMessage();
    }

}