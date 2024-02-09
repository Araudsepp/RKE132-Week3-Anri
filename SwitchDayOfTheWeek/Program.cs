int weekDay = Convert.ToInt32(DateTime.Now.DayOfWeek);
//näitab päeva 0 on pühap

switch (weekDay)//väärtus,väärtus mida kontrollitakse, ainult üks
{
    case 0: //case 0 = if kontrolliga if weekday == 0 
        Console.WriteLine("Its Sunday");
        break; //lõpetab switchi töö
case 1:
        Console.WriteLine("Its Monday");
        break;
        case 2:
        Console.WriteLine("Its tuesday"); 
            break;
        case 3: Console.WriteLine("Its Wednesday!");
            break;
        case 4: Console.WriteLine("Its Thursday!");
            break;
        case 5: Console.WriteLine("Its Friday!");
            break;
        case 6 : Console.WriteLine("Its Saturday!");
               break;
        default:
        Console.WriteLine("Oops. Your calendar must be broken.");
        break;

}


Console.WriteLine("Have a nice day!");