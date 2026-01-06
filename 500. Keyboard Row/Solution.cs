public class Solution {
    public string[] FindWords(string[] words) {
    
        string firstRow = "qwertyuiopQWERTYUIOP";
        string secondRow = "asdfghjklASDFGHJKL";
        string thirdRow = "zxcvbnmZXCVBNM";

        bool addWord = true;

        List<string> result = new List<string>();
        byte containsFirstRow = 0;
        byte containsSecondRow = 0;
        byte containsThirdRow = 0;


        foreach(string word in words)
        {
            foreach(char character in word)
            {
                if(firstRow.Contains(character)) containsFirstRow = 1;
                if(secondRow.Contains(character)) containsSecondRow = 1;
                if(thirdRow.Contains(character)) containsThirdRow = 1;

                if(containsFirstRow+containsSecondRow+containsThirdRow > 1)
                {
                    addWord = false;
                    break;
                }
            }
            containsFirstRow =0;
            containsSecondRow = 0;
            containsThirdRow = 0;
            if(addWord)
            {
                result.Add(word);
            }
            addWord = true;
            
        }
    return result.ToArray();

    }
}