public class Solution {
    public bool IsPalindrome(string s) {
        int left = 0, right = s.Length - 1;
        string lowerStr = s.ToLower();

        while (left <= right) {
            //ignore all special chars for left pointer
            while (left < right && !IsDigitOrLetter(lowerStr[left])) left++;
            
            //ignore all special chars for right pointer
            while (left < right && !IsDigitOrLetter(lowerStr[right])) right--;

            if (left <= left) {
                //convert to lower case and compare
                if (lowerStr[left] != lowerStr[right]) 
                    return false;
                else {
                    left++;
                    right--;
                }
            }
        }

        return true;
    }

    public bool IsDigitOrLetter(char c) {
        return (c >= 'a' && c <= 'z') ||
            (c >= 'A' && c <= 'Z') ||
            (c >= '0' && c <= '9');
    }
}
