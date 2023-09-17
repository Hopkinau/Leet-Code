public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> anagramGroups = new     Dictionary<string, List<string>>();

        foreach (string str in strs) {
            char[] charArray = str.ToCharArray();
            Array.Sort(charArray);
            string sortedStr = new string(charArray);

            if (!anagramGroups.ContainsKey(sortedStr)) {
                anagramGroups[sortedStr] = new List<string>();
            }

            anagramGroups[sortedStr].Add(str);
        }

        return new List<IList<string>>(anagramGroups.Values);
    }
}

//////////////////////////////
If the input string is "eat," and you want to see the value of the anagramGroups dictionary after processing just the "eat" string, it would look like this:

csharp
Copy code
{
    "aet": ["eat"]
    //second one will be added
    //"aet": ["eat","tea"]
}
Here's how it works:

The string "eat" is converted to an array of characters: ['e', 'a', 't'].

The characters in the array are sorted alphabetically: ['a', 'e', 't'].

The sorted character array is converted back to a string: "aet".

The code checks if "aet" is already a key in the anagramGroups dictionary. Since it's not, it initializes it with an empty list: anagramGroups["aet"] = new List<string>();.

Finally, it adds the original string "eat" to the list associated with the key "aet": anagramGroups["aet"].Add("eat");.
        