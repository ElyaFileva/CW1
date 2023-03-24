Console.Clear();
string[] array = { "hom", "^)", "cat", "*9 9" };
int length = GetCountElementsArrWithlLessThanThreeSymbol(array);

Console.Write($"В массиве [{string.Join(", ", array)}] следующие элементы состоят из не более трех символов: ");
GetNewArrayWithlLessThanThreeSymbol(array, length);

int GetCountElementsArrWithlLessThanThreeSymbol(string[] array)
{
  int count = 0;
  for (int i = 0; i < array.Length; i++)
  {
    if (array[i].Length <= 3)
    {
      count++;
    }
  }
  return count;
}
void GetNewArrayWithlLessThanThreeSymbol(string[] array, int len)
{
  string[] arrayNew = new string[len];
  int j = 0;
  for (int i = 0; i < array.Length; i++)
  {
    if (array[i].Length <= 3)
    {
      arrayNew[j] = array[i];
      j++;
    }
  }
  Console.WriteLine($"[{string.Join(", ", arrayNew)}]");
}