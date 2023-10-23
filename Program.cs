
// Input array of strings from the console. Emply line ends the imput
string[] processInput() {
    var result = new List<string>();
    while (true) {
        string str = Console.ReadLine()??"";
        if (str == "") {
            break;
        } else {
            result.Add(str);
        }
    }
    return result.ToArray();
}

// Output result array to the console
void printArray(string message, string[] strings) {
    Console.Write(message);
    Console.WriteLine(string.Join(",", strings));
}

// In the given array of strings finds strings which length are less or equal to 3.
// Returns such strings in the resulting array
string [] findStringsLessThreeChars(string [] strings) {
    
    int countLessThan3 = 0;
    
    foreach(string s in strings) {
       if (s.Length<=3) {
            countLessThan3 ++;
       }
    }
    
    string [] result = new string[countLessThan3];
    int j = 0;
    foreach(string s in strings) {
       if (s.Length <= 3) {
            result[j++] = s;
       }
    }
    
    return result;
}

string[] input = processInput();

printArray("Input:\t", input);

string[] result = findStringsLessThreeChars(input);

printArray("Result:\t", result);