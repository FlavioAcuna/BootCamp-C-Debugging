// Challenge 1
bool amProgrammer = true;//no deben utilizarse comillas para los bool
Console.WriteLine(amProgrammer);
double Age = 27.9;//para decimales se debe utilizar el tipo double 
Console.WriteLine(Age);
List<string> Names = new List<string>();
Names.Add("Monica");//Para agregar a una lista se debe seleccionar usar .Add
Dictionary<string, string> MyDictionary = new Dictionary<string, string>();
MyDictionary.Add("Hello", "0");
MyDictionary.Add("Hi there", "0");//segundo elemento era un entero
// This is a tricky one! Hint: look up what a char is in C#
string MyName = "MyName"; //se deben utilizar comillas dobles para los string
Console.WriteLine(MyName);
// Challenge 2
List<int> Numbers = new List<int>() { 2, 3, 6, 7, 1, 5 };
for (int i = Numbers.Count - 1; i >= 0; i--)
//error en el indice ya que no se encontraba en el rango 
{
    Console.WriteLine(Numbers[i]);
}
// Challenge 3
List<int> MoreNumbers = new List<int>() { 12, 7, 10, -3, 9 };
foreach (int i in MoreNumbers)
{
    Console.WriteLine(i);// no se debe utilizar indices en el foreach ya que recorre la lista impriendo cada uno de los elementos
}
// Challenge 4
/*
List<int> EvenMoreNumbers = new List<int> { 3, 6, 9, 12, 14 };
foreach (int num in EvenMoreNumbers)
{
    if (num % 3 == 0)
    {
        num = 0;//No se puede asignar a 'num' porque es 'variable de iteración foreach'
    }
}
*/
List<int> EvenMoreNumbers = new List<int> { 3, 6, 9, 12, 14 };
for (int i = 0; i < EvenMoreNumbers.Count; i++)
{
    if (EvenMoreNumbers[i] % 3 == 0)
    {
        EvenMoreNumbers[i] = 0;
    }
    Console.WriteLine(EvenMoreNumbers[i]);
}
// Challenge 5
// What can we learn from this error message?
string MyString = "superduberawesome";
// MyString[7] = "p";//no se pueden asignar indices a un string a menos que este separado en una lista

// Challenge 6
// Hint: some bugs don't come with error messages
Random rand = new Random();
int randomNum = rand.Next(12,13);//para que se cumpla la condicion deberia ser 13 ya que en Random.next() el numero otorgado es menor a 12 en este caso seria 11
if (randomNum == 12)
{
    Console.WriteLine("Hello");
}

