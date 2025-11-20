class ReflectionActivity : BaseActivity
{
    private List<string> _prompts = [
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    ];
    private List<string> _questions = [
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    ];

    private static Random _randomPrompt = new Random();
    private static Random _randomQuestion = new Random();

    public ReflectionActivity()
        : base("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience.\nThis will help you recognize the power you have and how you can use it in other aspects of your life.")
    {
        
    }

    public override void Run()
    {
        Console.WriteLine("Consider the following prompt:\n");
        Console.WriteLine($" --- {_prompts[_randomPrompt.Next(_prompts.Count)]} ---\n\nWhen you have someting in mind, press Enter to continue.");

        Console.ReadLine();

        Console.Clear();
        Console.WriteLine("now ponder on each of the following questions as the relate to this experience.");
        Console.Write("You may begine in: ");

        CountdownEvent(5);

        Console.Clear();

        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while(DateTime.Now < endTime){
            Console.Write($"\n> {_prompts[_randomPrompt.Next(_prompts.Count)]} ");
            Spinner(10);
        }
    }
}
