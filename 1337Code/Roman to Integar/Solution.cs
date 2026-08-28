public class Solution {
    public int RomanToInt(string s) {
        int result = 0;
        for (int i = 0; i < s.Length; i++) {
            if (i < s.Length - 1 && GetValue(s[i]) < GetValue(s[i + 1])) {
                result -= GetValue(s[i]);
            } else {
                result += GetValue(s[i]);
            }
        }
        return result;
    }

    private int GetValue(char c) {
        return c switch {
            'I' => 1,
            'V' => 5,
            'X' => 10,
            'L' => 50,
            'C' => 100,
            'D' => 500,
            'M' => 1000,
            _ => 0
        };  
    }
}