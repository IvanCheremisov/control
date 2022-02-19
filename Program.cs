using static System.Console;

string[] stringArray = { "hello", "world", "2", ":-)" };

void PrintStringArray(string[] stringArray)
{
  Write("["); // пятая строка убирает console 
  for (int i = 0; i < stringArray.Length; i++)
  {
    Write($"\"{stringArray[i]}\"");
    if (i != stringArray.Length - 1)
    {
      Write(", ");
    }
  }
  Write("]");
}

int SearchStringWithSizeLessOrEqual3(string[] stringArray)
{
  int numberOfString = 0;
  for (int i = 0; i < stringArray.Length; i++)
  {
    if (stringArray[i].Length < 4)
    {
      numberOfString++;
    }
  }
  return numberOfString;
}

string[] CreatArrayWithSizeLessOrEqual3(string[] stringArray, int sizeNewArray)
{
  string[] newStringArray = new string[sizeNewArray];
  int j = 0;
  for (int i = 0; i < stringArray.Length; i++)
  {
    if (stringArray[i].Length < 4)
    {
      newStringArray[j] = stringArray[i];
      j++; 
    }
  }
  return newStringArray;
}


PrintStringArray(stringArray);
// WriteLine();
// WriteLine(SearchStringWithSizeLessOrEqual3(stringArray));
int sizeNewArray = SearchStringWithSizeLessOrEqual3(stringArray); 
string[] newStringArray = CreatArrayWithSizeLessOrEqual3(stringArray, sizeNewArray); 
Write(" --> ");
PrintStringArray(newStringArray);