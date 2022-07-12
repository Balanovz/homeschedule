/*
 * сделать распасание недели и выводить расписание в зависимости от выбранного дня
 */


using System;
using System.Collections.Generic;

class Day
{

    private List<string> morning;
    private List<string> evening;
    private List<string> night;

    public Day() 
    {
        morning = new List<string>();
        evening = new List<string>();
        night = new List<string>();

    }

    public void AddMorningToDoList(params string[] toDoList)
    {
        foreach (var i in toDoList)
            morning.Add(i);
    }

    public void AddEveningToDoList(params string[] toDoList)
    {
        foreach (var i in toDoList)
            evening.Add(i);
    }

    public void AddNightToDoList(params string[] toDoList)
    {
        foreach (var i in toDoList)
            night.Add(i);
    }

    private void PrintList(List<string> list)
    {
        int counter = 1;
        foreach (var i in list)
            Console.WriteLine(counter++ + ". " + i);
        
    }

    public void PrintDaySchedule()
    {
        Console.WriteLine("Morning:");
        PrintList(morning);
        Console.WriteLine();

        Console.WriteLine("Evening:");
        PrintList(evening);
        Console.WriteLine();

        Console.WriteLine("Night:");
        PrintList(night);
        Console.WriteLine();
    }
}



namespace homeSchedule
{
    class Program
    {
        public static void PrintWorkingDay(Day day)
        {
            Console.ForegroundColor = ConsoleColor.Green; // устанавливаем цвет
            day.PrintDaySchedule();
            Console.ResetColor(); // сбрасываем в стандартный
        }

        public static void PrintWeekendDay(Day day)
        {
            Console.ForegroundColor = ConsoleColor.Red; // устанавливаем цвет
            day.PrintDaySchedule();
            Console.ResetColor(); // сбрасываем в стандартный
        }

        public static void Menu(out string dayOfTheWeek)
        {
            Console.WriteLine("Enter the schedule day of the week: \nmonday\ntuesday\nwednesday\nthursday\nfriday\nsaturday\nsunday");
            Console.WriteLine("\n(press \"0\" to exit)");
            dayOfTheWeek = Console.ReadLine().ToLower();
            Console.ReadLine();
        }

        static void Main(string[] args)
        {
            Day monday = new Day();
            monday.AddMorningToDoList("проснуться", "умыться", "почистить зубы", "пробежка", "сделать завтрак");
            monday.AddEveningToDoList("поиграть баскетбол", "почитать техническую литературу");
            monday.AddNightToDoList("умыться", "почистить зубы", "лечь спать");

            Day tuesday = new Day();
            tuesday.AddMorningToDoList("проснуться", "умыться", "почистить зубы", "сделать завтрак");
            tuesday.AddEveningToDoList("сходить в бассейн", "почитать техническую литературу");
            tuesday.AddNightToDoList("умыться", "почистить зубы", "лечь спать");

            Day wednesday = new Day();
            wednesday.AddMorningToDoList("проснуться", "умыться", "почистить зубы", "сделать зарядку", "сделать завтрак");
            wednesday.AddEveningToDoList("сходить в автошколу", "погулять");
            wednesday.AddNightToDoList("посмотреть ютуб", "лечь спать");


            Day thursday = new Day();
            thursday.AddMorningToDoList("проснуться", "умыться", "почистить зубы", "выйти на пробежку");
            thursday.AddEveningToDoList("погулять", "почитать техническую литературу");
            thursday.AddNightToDoList("лечь спать");

            Day friday = new Day();
            friday.AddMorningToDoList("проснуться", "посмотреть ютуб", "лечь спать");
            friday.AddEveningToDoList("покушать");
            friday.AddNightToDoList("поиграть баскетбол", "лечь спать");

            Day saturday = new Day();
            saturday.AddMorningToDoList("проснуться");
            saturday.AddEveningToDoList("покушать");
            saturday.AddNightToDoList("лечь спать");

            Day sunday = new Day();
            sunday.AddMorningToDoList("проснуться", "покушать", "лечь спать");
            sunday.AddEveningToDoList("проснуться", "поиграть баскетбол", "покушать");
            sunday.AddNightToDoList("лечь спать");


            bool status = true;
            string dayOfTheWeek = default;


            while (status) {
                Menu(out dayOfTheWeek);

                switch (dayOfTheWeek)
                {
                    case "monday":
                        Console.Clear();
                        PrintWorkingDay(monday);
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case "tuesday":
                        Console.Clear();
                        PrintWorkingDay(tuesday);
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case "wednesday":
                        Console.Clear();
                        PrintWorkingDay(wednesday);
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case "thursday":
                        Console.Clear();
                        PrintWorkingDay(thursday);
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case "friday":
                        Console.Clear();
                        PrintWorkingDay(friday);
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case "saturday":
                        Console.Clear();
                        PrintWeekendDay(saturday);
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case "sunday":
                        Console.Clear();
                        PrintWeekendDay(sunday);
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case "0":
                        status = false;
                        break;
                    default:
                        Console.WriteLine("invalid day");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                }
            }

        }
    }
}
