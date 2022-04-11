
// See https://aka.ms/new-console-template for more information
int arraySizeN = 0;
string arraySize = "";
string arrayItemsString = "";

Console.WriteLine("||||||||--- written by EZGİ SARIBEK---|||||||||");
Console.WriteLine("Please enter the array size n: ");
arraySize = Console.ReadLine();

//Checking if the entered size is integer. If not: throw an error
while (!int.TryParse(arraySize.Trim(), out arraySizeN))
{
    Console.WriteLine("ERROR!! Please enter an integer: ");
    arraySize = Console.ReadLine();
}

//Finally Item size is set to the array
var enteredArray = new List<int>();


//Asking for the input
Console.WriteLine("Please enter the integer array : ");
arrayItemsString = Console.ReadLine();

arrayItemsString = arrayItemsString.Trim();


while (arrayItemsString.Trim().Length > arraySizeN)
{
    //Asking for the input
    Console.WriteLine("ERROR!! Please enter the integer array size of " + arraySizeN + " or less : ");
    arrayItemsString = Console.ReadLine();

    arrayItemsString = arrayItemsString.Trim();
}


for (int i = 0; i < arrayItemsString.Length; i++)
{
    int converted = 0;

    if (arrayItemsString[i] != ' ' && int.TryParse(arrayItemsString[i].ToString().Trim(), out converted))
    {
        enteredArray.Add(converted);

    }
}

if (enteredArray != null && enteredArray.Count > 0)
{
    var maxLeast = (from item in enteredArray
                    group item by item into g
                    orderby g.Count() descending
                    select new { Item = g.Key, Count = g.Count() }).First();


    Console.WriteLine("-----------------------------------------------");
    Console.WriteLine("The Maximum least number is : " + maxLeast.Item);
    Console.WriteLine("-----------------------------------------------\n");
    Console.ReadKey();
}







