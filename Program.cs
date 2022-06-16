//arrays initialisation
string[] testArray = {"go", "test", "one", "two", "three", "A", "oven", "mother", ":-)", "123", "if", "mother", "re"}; 
string[] newArray = new string[testArray.Length];

//method. adding to final array strings with size less or equal three symbols
string[] AddString (string value, int count)
{
    newArray[count] = value;
    return newArray;
}

//definition string with size less or equal three symbols
int count = 0;
for(int i = 0; i < testArray.Length; i++)
{
    if(testArray[i].Length <= 3)
    {
        AddString(testArray[i], count);
        count++;
    }
}


Array.Resize(ref newArray, newArray.Length - (newArray.Length - count)); //resizing final array to beautiful entering (deleting empty strings)

//entering final array
for(int i = 0; i < newArray.Length; i++)
{
    Console.WriteLine(newArray[i]);
}