class PromptGenerator
{
    public static List<string> _prompts = new()
    {
        // ChatGPT, personal communication, October 11, 2025
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What is one thing I learned today, and how did I learn it?",
        "How did I show kindness to someone today?",
        "What challenged me most today, and how did I respond?",
        "What am I most grateful for today, and why?",
        "What moment from today do I want to remember a year from now?",
        "What did I do to care for my body and mind today?",
        "What surprised me today?",
        "Where did I notice beauty or wonder today?",
        "What did I avoid or procrastinate, and what held me back?",
        "Which habit did I strengthen or weaken today?",
        "If today had a headline, what would it be?",
        "What conversation from today is still on my mind, and why?",
        "What did I create, fix, or improve today?",
        "Where did I feel the Lord's guidance or comfort today?",
        "Who can I serve or pray for tomorrow, and how will I do it?"
    };
    
    public static string GetPrompt()
    {
        Random random = new();
        int promptIndex = random.Next(_prompts.Count);
        return _prompts[promptIndex];
    }
}