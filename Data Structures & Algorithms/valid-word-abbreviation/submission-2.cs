public class Solution {
    public bool ValidWordAbbreviation(string word, string abbr) {
        int l = 0, r = 0;

        while (l < word.Length) {
            if (r < abbr.Length && word[l] == abbr[r]) {
                l++;
                r++;
            }
            else if (char.IsDigit(abbr[r])) {
                int i = Convert.ToInt32(abbr[r++].ToString());
                if (i == 0) return false;
                
                while (r < abbr.Length && char.IsDigit(abbr[r])) {
                    i = i * 10 + Convert.ToInt32(abbr[r++].ToString());
                }

                if (i + l > word.Length) return false;
                l += i;
            }
            else return false;
        }

        return r == abbr.Length ? true : false;
    }
}