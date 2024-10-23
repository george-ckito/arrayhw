using arrayhw;

Console.WriteLine("Programs:");
Console.WriteLine("1. Reverse Array");
Console.WriteLine("2. Max Element");
Console.WriteLine("3. Even Element");
Console.WriteLine("4. Copy Array");
Console.WriteLine("5. Duplicate Element");
Console.WriteLine("6. Element Count");
Console.WriteLine("7. Sort Array");
Console.Write("Choose which program to run: ");
string choice = Console.ReadLine();
Console.WriteLine("\n");
switch(choice)
{
    case "1":
        ReverseArray reverseArray = new ReverseArray();
        reverseArray.Execute();
        break;
    case "2":
        MaxElement maxElement = new MaxElement();
        maxElement.Execute();
        break;
    case "3":
        EvenNumbers evenNumbers = new EvenNumbers();
        evenNumbers.Execute();
        break;
    case "4":
        CopyArray copyArray = new CopyArray();
        copyArray.Execute();
        break;
    case "5":
        DuplicateElement duplicateElement = new DuplicateElement();
        duplicateElement.Execute();
        break;
    case "6":
        ElementCount elementCount = new ElementCount();
        elementCount.Execute();
        break;
    case "7":
        ArraySort arraySort = new ArraySort();
        arraySort.Execute();
        break;
}