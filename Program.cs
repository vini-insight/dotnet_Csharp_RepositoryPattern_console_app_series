using System;
using Models;
using Enums;
using System.Threading;
using System.Collections.Generic;
namespace dotnet_Csharp_RepositoryPattern_console_app_series
{
    class Program
    {
        static SerieRepository repository = new SerieRepository();
        static void Main(string[] args)
        {
            string userChoice = GetUserChoice();
			while (userChoice.ToUpper() != "X")
			{
				switch (userChoice)
				{
					case "1":
						GetListSeries();
						break;
					case "2":
						AddSerie();
						break;
					case "3":
						UpdateSerie();
						break;
					case "4":
						DeleteSerie();
						break;
					case "5":
						ViewSeries();
						break;
					case "6":
						MakeIndication();
						break;
					case "C":
						Console.Clear();
						break;
					case "X":
						continue;
					default:						
						Console.WriteLine("You typed \"{0}\"\n", userChoice);
						Console.WriteLine("invalid option. choose one of the alternatives below:".ToUpper());
						Console.WriteLine("\t\t\t1\n\t\t\t2\n\t\t\t3\n\t\t\t4\n\t\t\t5\n\t\t\t6\t\t\t\n\t\t\tC\n\n\t\t\tOR\n\n\t\t\tX\n");
						break;
				}
				userChoice = GetUserChoice();
			}
			while (userChoice != "X");
			Console.Clear();						
			for (int i = 3; i > 0; i--)
			{
				Console.WriteLine("\n");
				Console.WriteLine();
				Console.WriteLine("Thank you for using our services. Check back often!");
				Console.WriteLine();
				Console.WriteLine("		Closing in {0} seconds.", i);
				Thread.Sleep(1000);
				Console.Clear();
			}
		}
		private static void MakeIndication()
		{
			List<string> seriesToIndication = new List<string>();
			seriesToIndication.Add("Prison Break");
			seriesToIndication.Add("House M.D.");
			seriesToIndication.Add("The Fresh Prince");
			seriesToIndication.Add("Game of Thrones");
			seriesToIndication.Add("How I Met Your Mother");
			seriesToIndication.Add("The Walking Dead");			
			seriesToIndication.Add("House of Cards.");			
			seriesToIndication.Add("Suits");
			seriesToIndication.Add("The Wife and Kids");
			seriesToIndication.Add("Mac Gyver");
			seriesToIndication.Add("CSI");
			seriesToIndication.Add("The Big Bang Theory");
			seriesToIndication.Add("Breaking Bad");
			seriesToIndication.Add("Smallville");
			seriesToIndication.Add("Friends");			
			seriesToIndication.Add("Lost");
			string[] arraySeries = seriesToIndication.ToArray();
			Random rs = new Random();			
			Console.WriteLine("I think you will like \"{0}\". Watch and tell me later", arraySeries[rs.Next(seriesToIndication.Count)]);
		}
		private static void AddSerie()
		{
			Console.WriteLine("Add new Series");
			// https://docs.microsoft.com/pt-br/dotnet/api/system.enum.getvalues?view=netcore-3.1
			// https://docs.microsoft.com/pt-br/dotnet/api/system.enum.getname?view=netcore-3.1
			foreach (int i in Enum.GetValues(typeof(Gender)))
			{
				Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Gender), i));
			}
			Console.Write("Enter the gender between the options above: ");
			int inputGender = int.Parse(Console.ReadLine());
			Console.Write("Enter the Series Title: ");
			string inputTitle = Console.ReadLine();
			Console.Write("Enter the Year of Beginning of the Series:");
			int inputYear = int.Parse(Console.ReadLine());
			Console.Write("Enter the Series Description:");
			string entradaDescricao = Console.ReadLine();
			Serie newSerie = new Serie(id: repository.NextId(), gender: (Gender)inputGender, title: inputTitle, year: inputYear, description: entradaDescricao);
			repository.Add(newSerie);
		}
		private static void UpdateSerie()
		{
			Console.Write("Enter the series id: ");
			int serieIndex = int.Parse(Console.ReadLine());
			// https://docs.microsoft.com/pt-br/dotnet/api/system.enum.getvalues?view=netcore-3.1
			// https://docs.microsoft.com/pt-br/dotnet/api/system.enum.getname?view=netcore-3.1
			foreach (int i in Enum.GetValues(typeof(Gender)))
			{
				Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Gender), i));
			}
			Console.Write("Enter the gender between the options above: ");
			int inputGender = int.Parse(Console.ReadLine());
			Console.Write("Enter the Series Title:");
			string inputTitle = Console.ReadLine();
			Console.Write("Enter the Series Start Year:");
			int inputYear = int.Parse(Console.ReadLine());
			Console.Write("Enter the Series Description:");
			string entradaDescricao = Console.ReadLine();
			Serie updateSerie = new Serie(id: serieIndex, gender: (Gender)inputGender,	title: inputTitle,	year: inputYear, description: entradaDescricao);
			repository.Update(serieIndex, updateSerie);
		}
		private static void GetListSeries()
		{
			Console.WriteLine("List series");
			var lista = repository.List();
			if (lista.Count == 0)
			{
				Console.WriteLine("No series registered.");
				return;
			}
			foreach (var serie in lista)
			{
				var deleted = serie.GetDeleted();                
				Console.WriteLine("#ID {0}: - {1} {2}", serie.GetId(), serie.GetTitle(), (deleted ? "*Deleted*" : ""));
			}
		}
		private static void ViewSeries()
		{
			Console.Write("Enter the series id: ");
			int serieIndex = int.Parse(Console.ReadLine());
			var serie = repository.GetById(serieIndex);
			Console.WriteLine(serie);
		}
	    private static void DeleteSerie()
		{
			Console.Write("Enter the series id: ");
			int serieIndex = int.Parse(Console.ReadLine());
			repository.Delete(serieIndex);
		}
	    private static string GetUserChoice()
		{
			Console.WriteLine();
			Console.WriteLine("DIO Series at your service !!!");
			Console.WriteLine("Enter the desired option:");
			Console.WriteLine("1 - List Series");
			Console.WriteLine("2 - Add new Série");
			Console.WriteLine("3 - Update Série");
			Console.WriteLine("4 - Delete série");
			Console.WriteLine("5 - View Série");
			Console.WriteLine("6 - Receive a Series indication to Watch");
			Console.WriteLine("C - Clear Screen");
			Console.WriteLine("X - Get out");
			Console.WriteLine();
			string userChoice = Console.ReadLine().ToUpper();
			Console.WriteLine();
			return userChoice;
		}
    }
}
