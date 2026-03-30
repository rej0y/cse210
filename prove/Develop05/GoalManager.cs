class GoalManager
{
    private List<Goal> _goals;
    private int _score;
    public GoalManager(List<Goal> goals = null, int score = 0)
    {
        _goals = goals ?? new List<Goal>();
        _score = score;
    }
    public int GetLevel()
    {
        return _score / 1000 + 1;
    }
    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} points.");
        Console.WriteLine($"You are in Level {GetLevel()}.");
    }
    public void ListGoalDetails()
    {
        Console.WriteLine("The goals are:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"  {i + 1}: {_goals[i].GetDetailsString()}");
        }
    }
    public void RecordEvent()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("There are no goals to record.");
            return;
        }
        
        Console.WriteLine("The goals are:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"  {i + 1}: {_goals[i].GetName()}");
        }

        Console.Write("Which goal did you accomplish? ");
        string userString = Console.ReadLine();

        int goalNumber;
        while (true)
        {
            if (int.TryParse(userString, out goalNumber))
            {
                if (goalNumber is >= 1 && goalNumber <= _goals.Count)
                {
                    break;
                }
                else
                {
                    Console.Write("The number is out of range; please try again: ");
                    userString = Console.ReadLine();
                }
            }
            else
            {
                Console.Write("That's not a correct number, please try again: ");
                userString = Console.ReadLine();
            }
        }

        int points = _goals[goalNumber - 1].RecordEvent();

        Console.WriteLine($"Congratulations! You have earned {points} points.");

        _score += points;
        Console.WriteLine($"You now have {_score} points.");
    }
    public void SaveGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();

        using (StreamWriter writer = new StreamWriter(filename))
        {
            writer.WriteLine(_score);

            foreach (Goal goal in _goals)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }
        }
    }
    public void LoadGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();

        if (File.Exists(filename))
        {
            string[] lines = File.ReadAllLines(filename);

            _score = int.Parse(lines[0]);

            _goals.Clear();

            for (int i = 1; i < lines.Length; i++)
            {
                string line = lines[i];
                string[] parts = line.Split(':');

                string type = parts[0];
                string data = parts[1];

                if (type == "SimpleGoal")
                {
                    string[] values = data.Split(',');

                    _goals.Add(
                        new SimpleGoal(
                            name: values[0],
                            description: values[1],
                            points: int.Parse(values[2]),
                            isComplete: bool.Parse(values[3])
                        )
                    );
                }
                else if (type == "EternalGoal")
                {
                    string[] values = data.Split(',');

                    _goals.Add(
                        new EternalGoal(
                            name: values[0],
                            description: values[1],
                            points: int.Parse(values[2])
                        )
                    );
                }
                else if (type == "ChecklistGoal")
                {
                    string[] values = data.Split(',');

                    _goals.Add(
                        new ChecklistGoal(
                            name: values[0],
                            description: values[1],
                            points: int.Parse(values[2]),
                            bonus: int.Parse(values[3]),
                            targetCount: int.Parse(values[4]),
                            amountCompleted: int.Parse(values[5])
                        )
                    );
                }
            }
        }
        else
        {
            Console.WriteLine("The file that you specify does not exist; please try again.");
        }
    }
    public void CreateGoal()
    {
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. Checklist Goal");

        Console.Write("Which type of goal would you like to create? ");
        string choice = Console.ReadLine();

        while (choice != "1" && choice != "2" && choice != "3")
        {
            Console.Write("That's not a correct choice; please try again: ");
            choice = Console.ReadLine();
        }

        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();

        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();

        Console.Write("What is the amount of points associated with this goal? ");
        string pointsString = Console.ReadLine();

        int points;
        while (true)
        {
            if (int.TryParse(pointsString, out points) && points > 0)
            {
                break;
            }

            Console.Write("That's not a valid number, please try again: ");
            pointsString = Console.ReadLine();
        }

        switch (choice)
        {
            case "1":
                _goals.Add(new SimpleGoal(name, description, points));
                break;

            case "2":
                _goals.Add(new EternalGoal(name, description, points));
                break;

            case "3":
                Console.Write("How many times does this goal need to be accomplished? ");
                string targetCountString = Console.ReadLine();

                int targetCount;
                while (true)
                {
                    if (int.TryParse(targetCountString, out targetCount) && targetCount > 0)
                    {
                        break;
                    }

                    Console.Write("That's not a valid number, please try again: ");
                    targetCountString = Console.ReadLine();
                }

                Console.Write("What is the bonus for accomplishing it that many times? ");
                string bonusString = Console.ReadLine();

                int bonus;
                while (true)
                {
                    if (int.TryParse(bonusString, out bonus) && bonus > 0)
                    {
                        break;
                    }

                    Console.Write("That's not a valid number, please try again: ");
                    bonusString = Console.ReadLine();
                }

                _goals.Add(new ChecklistGoal(name, description, points, bonus, targetCount));
                break;
        }
    }
}