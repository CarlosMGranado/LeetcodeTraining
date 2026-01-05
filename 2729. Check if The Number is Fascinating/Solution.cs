public class Solution {
    public bool IsFascinating(int n) {
        int n1 = n;
        int n2 = 2 * n;
        int n3 = 3 * n;

        if (n1 < 123 || n1 > 987) return false;
        if (n2 < 123 || n2 > 987) return false;
        if (n3 < 123 || n3 > 987) return false;

        int number = n1 * 1000000 + n2 * 1000 + n3;
        int[] digits = [1,2,3,4,5,6,7,8,9]; 
        
        for(int i = 0; i<9;i++)
        {
            if(number %10 == 0||digits[number %10-1] == -1)
            {
                return false;
            }
            digits[number %10-1] = -1;
            number = (number - number%10)/10;
        }
        return true;
    }
}