# LinkedListLibrary

## Overview

`LinkedListLibrary` is a C# library for implementing a simple linked list. It consists of:
- `ListNode`: Represents a single node in the linked list.
- `List`: A linked list class that can store any type of data.
- `EmptyListException`: A custom exception for handling operations on an empty list.

## Installation

To use `LinkedListLibrary` in your project:

1. **Clone the Repository:**
   ```bash
   git clone https://github.com/yourusername/LinkedListLibrary.git
   ```
2. **Add the Library to Your Project:**
Copy the LinkedListLibrary files into your project directory.
Include the LinkedListLibrary namespace in your code.
## Usage
**ListNode**
`ListNode` represents a node in the linked list.

``` bash
using LinkedListLibrary;

ListNode node = new ListNode(data);
ListNode anotherNode = new ListNode(data, nextNode);
```
## List
`List` provides methods for manipulating the linked list.

**Creating a List**
``` bash
List list = new List();
List namedList = new List("MyList");
```
**Inserting Items**
``` bash
list.InsertAtFront(data);
list.InsertAtBack(data);
```
**Removing Items**
``` bash
object removedItem = list.RemoveFromFront();
object removedItem = list.RemoveFromBack();
```
**Displaying List**
``` bash
list.Display();
```
**Handling Exceptions**
`EmptyListException` is thrown when attempting to remove items from an empty list.
``` bash
try
{
    list.RemoveFromFront();
}
catch (EmptyListException ex)
{
    Console.WriteLine(ex.Message);
}
```
## Example
Here’s a complete example of using `LinkedListLibrary`:
``` bash
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
```
