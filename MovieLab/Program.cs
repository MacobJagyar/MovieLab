using MovieLab;

bool again = true;

List<string> todaysGenres = new List<string>()
{
    "Comedy",
    "Scifi",
    "Horror",
    "Anime",
    "Drama"
};

List<Movie> moviesList = new List<Movie>()
{
    new Movie{ Title = "Juno", Category = "Comedy" },
    new Movie{ Title = "Donnie Darko", Category = "Scifi"},
    new Movie{ Title = "Jurassic Park", Category = "Scifi"},
    new Movie{ Title = "Shaun of the Dead", Category = "Comedy"},
    new Movie{ Title = "Sinister", Category = "Horror"},
    new Movie{ Title = "Spirited Away", Category = "Anime"},
    new Movie{ Title = "Howl's Moving Castle", Category = "Anime"},
    new Movie{ Title = "The Ring", Category = "Horror"},
    new Movie{ Title = "The Green Mile", Category = "Drama"},
    new Movie{ Title = "The Shawshank Redemption", Category = "Drama"}
};

while (again)
{
    int count = 1;

    Console.Write("Hello! There are 10 movies to choose from. What genre sounds good today? \n\n");

    foreach (string genre in todaysGenres)
    {
        Console.WriteLine("-"+ genre);
        count++;
    }
    Console.WriteLine();

    count = 1;

    string input = Console.ReadLine().ToLower();
    string upperInput = Capitalize(input);

    List<Movie> categoryList = moviesList.Where(x => x.Category == upperInput).ToList();



    if (todaysGenres.Contains(upperInput))
    {
        Console.WriteLine("\nThe movies we have today in the " + input + " genre are:\n");

        foreach (Movie film in categoryList)
        {
            Console.WriteLine(count + ". " + film.Title);
            count++;
        }
    }
    else if (upperInput == "Sci-fi")
    {
        List<Movie> scifiList = moviesList.Where(x => x.Category == "Scifi").ToList();

        Console.WriteLine("\nThe movies we have today in the " + input + " genre are:\n");
        foreach (Movie scifi in scifiList)
        {
            Console.WriteLine(count +  ". " + scifi.Title);
            count++;
        }
        count = 1;
    }
    else
    {
        Console.WriteLine("\nLooks like we don't have that genre today!");
    }

    Console.Write("\nWould you like to start again? y/n: ");
    string againInput = Console.ReadLine().ToLower();

    if (againInput == "y")
    {
        again = true;
        Console.Clear();
    }
    else if (againInput == "n")
    {
        again = false;
        Console.WriteLine("\nGoodbye. Press any key to quit.");
    }
    else
    {
        Console.WriteLine("\nThat wasn't a valid input! Starting over anyway...");
        Thread.Sleep(1800);
    }
    Console.WriteLine(); //Here so that there's a line break for when the loop starts again.
}


string Capitalize(string s)
{
    if (string.IsNullOrEmpty(s))
        return string.Empty;
    return char.ToUpper(s[0]) + s.Substring(1).ToLower();
}

Console.ReadKey();