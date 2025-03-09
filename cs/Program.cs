using System.Runtime.InteropServices;

var res = Lib.Add(1, 2);
Console.WriteLine($"Result: {res}");

unsafe
{
    Lib.GetNumbers(out var arrayPtr, out var arrSize);

    for (int i = 0; i < arrSize; i++)
    {
        var num = arrayPtr[i];
        Console.WriteLine($"Array number: {num}");
    }

    Lib.FreeNumbers(arrayPtr);
}

unsafe static partial class Lib
{
    [LibraryImport("lib.so", EntryPoint = "add")]
    public static partial int Add(int x, int y);

    [LibraryImport("lib.so")]
    public static partial void GetNumbers(out int* array, out int size);

    [LibraryImport("lib.so")]
    public static partial void FreeNumbers(int* array);
}

