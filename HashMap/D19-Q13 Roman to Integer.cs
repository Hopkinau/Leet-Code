public class Solution 
{
        
    static Dictionary<char, int> romanDigits = new()
    {
        { 'I', 1 },
        { 'V', 5 },
        { 'X', 10 },
        { 'L', 50 },
        { 'C', 100 },
        { 'D', 500 },
        { 'M', 1000 }
    };
    
    public int RomanToInt(string s)
    {
        var result = 0;

        for(int i = 0; i < s.Length - 1; i++)
        {
            if(romanDigits[s[i]] < romanDigits[s[i + 1]])
                result -= romanDigits[s[i]];
            else
                result += romanDigits[s[i]];
        }

        return result + romanDigits[s[s.Length - 1]];
    }
}


example: Input: "XIV"

Initialize result to 0: var result = 0;

Iterating through the characters of the Roman numeral string from left to right:

i = 0: 'X' (Value: 10)

Since 'X' > 'I', it adds the value of 'X' to result: result = 0 + 10 = 10
i = 1: 'I' (Value: 1)

Since 'I' < 'V', it subtracts the value of 'I' from result: result = 10 - 1 = 9
The loop ends.

The final result after the loop is 9, which is correct for the first two characters, "XI."

However, there's one more character 'V' (Value: 5) in the Roman numeral string "XIV" that we haven't processed yet.

To account for the last character, we add its value to result using romanDigits[s[s.Length - 1]], which is equivalent to romanDigits['V'] or 5.

result now becomes result + romanDigits[s[s.Length - 1]], which is 9 + 5 = 14.

Finally, the function returns the updated result, which is 14, representing the correct integer value of the Roman numeral "XIV."

So, adding the value of the last character ensures that the full Roman numeral is correctly converted to its integer representation.





