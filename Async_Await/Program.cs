//using System.Diagnostics;

//string[] urls= new string[]
//{
//    "https://docs.microsoft.com",
//    "https://docs.microsoft.com/aspnet/core",
//    "https://docs.microsoft.com/azure",
//    "https://docs.microsoft.com/azure/devops",
//    "https://docs.microsoft.com/dotnet",
//    "https://docs.microsoft.com/dynamics365",
//    "https://docs.microsoft.com/education",
//    "https://docs.microsoft.com/enterprise-mobility-security",
//    "https://docs.microsoft.com/gaming",
//    "https://docs.microsoft.com/graph",
//    "https://docs.microsoft.com/microsoft-365",
//    "https://docs.microsoft.com/office",
//    "https://docs.microsoft.com/powershell"
//};
//GetHttpContent(urls);
//GetHttpContentAsync(urls);


//#region Non_async
//void GetHttpContent(string[] urls)
//{
//    HttpClient httpClient = new HttpClient();
//    Stopwatch sw = new Stopwatch();
//    sw.Start();
//    foreach (var url in urls)
//    {
//        var resault = httpClient.GetStringAsync(url).Result;
//        Console.WriteLine(resault.Length);
//    }
//    sw.Stop();
//    Console.WriteLine($"{sw.ElapsedMilliseconds / 1000} san");
//}

//#endregion



//#region Async
//async void GetHttpContentAsync(string[] urls)
//{
//    HttpClient httpClient = new HttpClient();
//    List<Task<string>> tasks = new List<Task<string>>();
//    Stopwatch sw = new Stopwatch();

//    foreach (var url in urls)
//    {
//        sw.Start();
//        string[] arr = await Task.WhenAll(tasks);
//        var resault = httpClient.GetStringAsync(url).Result;
//        Console.WriteLine(resault.Length);
//    }
//    sw.Stop();
//    Console.WriteLine($"{sw.ElapsedMilliseconds / 1000} san");
//} 
//#endregion

using Async_Await.Weapon;

Weapon<int> weapon = new Weapon<int>();



weapon.Fire("7,62",45);
weapon.Fire("5,56", 89);
weapon.PullTrigger();
weapon.PullTrigger();
weapon.PullTrigger();
weapon.PullTrigger();
weapon.PullTrigger();
weapon.PullTrigger();
weapon.PullTrigger();
weapon.PullTrigger();
weapon.PullTrigger();
weapon.PullTrigger();
weapon.PullTrigger();
weapon.Fill(23);







