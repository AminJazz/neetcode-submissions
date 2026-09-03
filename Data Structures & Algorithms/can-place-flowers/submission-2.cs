public class Solution {
    public bool CanPlaceFlowers(int[] flowerbed, int n) {
        if (flowerbed.Length == 1 && flowerbed[0] == 0) return true;

        for (int i = 1; i < flowerbed.Length - 1; i++) {
            if (n == 0) return true;

            if (i == 1 && flowerbed[i - 1] == 0 && flowerbed[i] == 0) {
                flowerbed[i - 1] = 1;
                n--;
            }
            else if (flowerbed[i - 1] == 0 && flowerbed[i] == 0 &&
                flowerbed[i + 1] == 0) {
                flowerbed[i] = 1;
                n--;
            }
            else if (i == flowerbed.Length - 2 && flowerbed[i] == 0 &&
                flowerbed[i + 1] == 0) {
                    flowerbed[i + 1] = 0;
                    n--;
            }
        }

        return n == 0;
    }
}