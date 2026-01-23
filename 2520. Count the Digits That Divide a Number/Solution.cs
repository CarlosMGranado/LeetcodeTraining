public class Solution {
    public int CountDigits(int num) {
        int remainingDigit = num; 
        int result = 0;
        while(remainingDigit != 0)
        {
            if(num % (remainingDigit%10) == 0) {result++;}
            remainingDigit = (remainingDigit- remainingDigit%10)/10;
        }
        return result;
    }
}