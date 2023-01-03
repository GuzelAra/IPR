

string[] arr1 = new string[5] {"hello", "my", "friend", "Mia", "!"};
string[] arr2 = new string[arr1.Length];
void Array2 (string[] arr1, string[] arr2)
{
int count = 0;
for (int i = 0; i < arr1.Length; i++)
    {
    if(arr1[i].Length <= 3)
        {
        arr2[i] = arr1[i];
        count++;
        }
    }
}

Array2 (arr1, arr2);
for (int i = 0; i < arr2.Length; i++)
    {
        Console.Write($"{arr2[i]} ");
    }
    Console.WriteLine();
