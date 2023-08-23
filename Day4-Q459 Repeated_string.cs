public class Solution {
    public bool RepeatedSubstringPattern(string s) {
        string repeated = s + s;
        string sliced = repeated.Substring(1, repeated.Length - 2);
        
        return sliced.Contains(s);
        
    }
}
