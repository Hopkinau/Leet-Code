public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length) return false;
        if (s == t) return true;

        Dictionary<char, int> sCounts = new Dictionary<char, int>();
        Dictionary<char, int> tCounts = new Dictionary<char, int>();
        
        for (int i = 0; i < s.Length; i++) {
            sCounts[s[i]] = 1 + (sCounts.ContainsKey(s[i]) ? sCounts[s[i]] : 0);
            tCounts[t[i]] = 1 + (tCounts.ContainsKey(t[i]) ? tCounts[t[i]] : 0);
        }
        
//For the string s ("listen"):
// When i = 0, sCounts['l'] becomes 1.
// When i = 1, sCounts['i'] becomes 1.
// When i = 2, sCounts['s'] becomes 1.
// When i = 3, sCounts['t'] becomes 1.
// When i = 4, sCounts['e'] becomes 1.
// When i = 5, sCounts['n'] becomes 1.
// For the string t ("silent"):

// When i = 0, tCounts['s'] becomes 1.
// When i = 1, tCounts['i'] becomes 1.
// When i = 2, tCounts['l'] becomes 1.
// When i = 3, tCounts['e'] becomes 1.
// When i = 4, tCounts['n'] becomes 1.
// When i = 5, tCounts['t'] becomes 1.

        foreach (char c in sCounts.Keys) {
            int tCount = tCounts.ContainsKey(c) ? tCounts[c] : 0;
            if (sCounts[c] != tCount) return false;
        }
        return true;


//After the loops, we compare the character frequencies in the sCounts and tCounts dictionaries:

// For character 'l':

// sCounts['l'] is 1.
// tCounts.ContainsKey('l') is true, so tCounts['l'] is also 1.
// Since sCounts['l'] equals tCounts['l'], we move to the next character.
// For character 'i':

// sCounts['i'] is 1.
// tCounts.ContainsKey('i') is true, so tCounts['i'] is also 1.
// Since sCounts['i'] equals tCounts['i'], we move to the next character.
// ...and so on, for the rest of the characters.

// Since all character frequencies match in both sCounts and tCounts, the method returns true, indicating that "listen" and "silent" are indeed anagrams.
    }
}
