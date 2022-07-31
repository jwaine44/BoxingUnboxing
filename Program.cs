// Create an empty List of type object
List<object> newList = new List<object>();

// Add the following values to the list: 7, 28, -1, true, "chair"
newList.Add(7);
newList.Add(28);
newList.Add(-1);
newList.Add(true);
newList.Add("chair");

// Loop through the list and print all values
foreach (var entry in newList)
{
    Console.WriteLine(entry);
}

// Add all values that are Int type together and output the sum
int sum = 0;
foreach (var entry in newList)
{
    if (entry is int) {
        sum += (int)entry;
    }
}

Console.WriteLine(sum);