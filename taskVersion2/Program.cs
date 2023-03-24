Console.Clear();
string[] array = { "hom", "^)", "cat", "*9 9", "0098", "987" };
Console.Write($"В массиве [{string.Join(", ", array)}] следующие элементы состоят из не более трех символов:[");
GetNewArrayWithlLessThanThreeSymbol(array);

void GetNewArrayWithlLessThanThreeSymbol(string[] array)
{
  string[] arrayNew = new string[array.Length];
  int j = 0;
  for (int i = 0; i < array.Length; i++)
  {
    if (array[i].Length <= 3)
    {
      arrayNew[j] = array[i];
      Console.Write($"{arrayNew[j]} ");
      j++;
    }
  }
  Console.Write("]");
}