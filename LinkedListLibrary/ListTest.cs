using System;
using LinkedListLibrary;

class ListTest
{
    public static void Main(string[] args)
    {
        // Create data to store in List
        bool aBoolean = true;
        char aCharacter = '$';
        int anInteger = 34567;
        string aString = "hello";

        // Create List container
        List list = new List();

        // Use List insert methods
        list.InsertAtFront(aBoolean);
        list.Display();
        list.InsertAtFront(aCharacter);
        list.Display();
        list.InsertAtBack(anInteger);
        list.Display();
        list.InsertAtBack(aString);
        list.Display();

        // Use List remove methods
        object removedObject;

        // Remove data from list and display after each removal
        try
        {
            removedObject = list.RemoveFromFront();
            Console.WriteLine(removedObject + " removed");
            list.Display();

            removedObject = list.RemoveFromFront();
            Console.WriteLine(removedObject + " removed");
            list.Display();

            removedObject = list.RemoveFromBack();
            Console.WriteLine(removedObject + " removed");
            list.Display();

            removedObject = list.RemoveFromBack();
            Console.WriteLine(removedObject + " removed");
            list.Display();
        }
        catch (EmptyListException emptyListException)
        {
            Console.Error.WriteLine("\n" + emptyListException);
        }
    }
}
