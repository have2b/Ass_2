using Assignment_2;
using Assignment_2.ExerciseOne;
using Assignment_2.ExerciseTwo;

while (true)
{
    // Display Menu
    Utils.DisplayMenu();
    // Choose option
    sbyte choice = Utils.ChooseOption(1, 4);
    // Perform action based on choice
    PerformAction(choice);
}
void ExerciseOne()
{
    List<Member> members = MemberService.GenerateMembers();
    while (true)
    {
        // Display GUI
        Utils.DisplayExerciseOne();
        // Choose option
        sbyte choice = Utils.ChooseOption(0, 9);
        // Perform action based on choice
        PerformExerciseOne(choice, members);
    }
}

void PerformExerciseOne(sbyte choice, List<Member> members)
{
    switch (choice)
    {
        case 1:
            // Display all member
            MemberService.DisplayListMember(members);
            break;
        case 2:
            // Add new member
            MemberService.AddMember(members);
            break;
        case 3:
            // Find all males in list
            MemberService.FindMales(members);
            break;
        case 4:
            // Find the oldest member
            MemberService.FindOldestMember(members);
            break;
        case 5:
            // List full name of all member
            MemberService.ListFullNameOnly(members);
            break;
        case 6:
            // List 3 lists about members who was born in, before, after specific year
            MemberService.ListMemSurroundingYear(members, 2000);
            break;
        case 7:
            // Find first member who was born in Ha Noi
            MemberService.FindFirstBornInHaNoi(members);
            break;
        case 8:
            Console.Clear();
            break;
        case 9:
            Environment.Exit(0);
            break;
    }
}

async void ExerciseTwo()
{
    while (true)
    {
        Utils.DisplayExerciseTwo();
        var range = Number.InputRange();
        var primes = await Number.GetPrimesAsync(range.min, range.max);
        foreach(var prime in primes)
        {
            await Console.Out.WriteLineAsync(prime.ToString());
        }
    }
}

void PerformAction(sbyte choice)
{
    switch (choice)
    {
        case 1:
            ExerciseOne();
            break;
        case 2:
            ExerciseTwo();
            break;
        case 3:
            Console.Clear();
            break;
        case 4:
            Environment.Exit(0);
            break;
    }
}
