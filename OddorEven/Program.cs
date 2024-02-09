

Console.WriteLine("Enter a Number");

//converdib nriks ja salvestab int usernum
int userNum  = Convert.ToInt32(Console.ReadLine());

//kas kasutaja arv on paaris või paaritu

int result = userNum % 2;

Console.WriteLine(result);
//!= ei ole võrdne
if (result != 0)
{
    Console.WriteLine("User number is odd");
}
else
{
    Console.WriteLine("User number is even");
}
    