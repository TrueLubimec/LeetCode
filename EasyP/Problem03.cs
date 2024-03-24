public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int count = 0;
        int countResult = 0;
        List<char> chars = s.ToList();
        // foreach (var ch in chars){
        //     foreach(var letter in s){
        //         if (letter == ch){
        //             chars.Insert(count+1,'!');
        //             count++;
                    
        //         }
        //         else{
        //             count++; 
        //         }
        //     }
        // }

        int tCount = 0;
        foreach (var ch in s){
            tCount++;
            for (var bCount = 0;bCount < tCount - 1; bCount++){
               if (s[bCount] == ch){
                    chars.Insert(tCount-1,'!');
                }
            }
        }


        count = 0;
        foreach (var item in chars){
            if (item == '!'){
              if (count > countResult){
                countResult = count;
                count = 0;
              }  
            }
            count++;
        }

        return countResult;
    }
}
