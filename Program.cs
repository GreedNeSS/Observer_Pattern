using Observer_Pattern;

Console.WriteLine("***** Observer Pattern *****");

User user = new User("GreedNeSS", "Init");
Observer observer = new Observer();
user.OnUpdateStatus += observer.ShowUpdateUserStatus;
user.SetStatus("Learning C#");