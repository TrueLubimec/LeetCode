
//          608 / 987
public class Solution {
    public int LengthOfLongestSubstring(string s) {
        List<char> chars = s.ToList();

        int tCount = 0;
        int c = 0;
        var last = 0;
        foreach (var ch in s){
            for (var bCount = last;bCount < tCount; bCount++){ 
               if (s[bCount] == ch){
                    chars.Insert(tCount + c,'!');
                    last = tCount;
                    c++;
                    break;
                }
            }
            tCount++;
        }

        var a = s.ToList();
        a.Reverse();
        List<char> charsA = s.ToList();
        charsA.Reverse();
        tCount = 0;
        c = 0; 
        last = 0;
        foreach (var ch in a){
            for (var bCount = last;bCount < tCount; bCount++){ 
               if (a[bCount] == ch){
                    charsA.Insert(tCount + c,'!');
                    last = tCount;
                    c++;
                    break;
                }
            }
            tCount++;
        }
        
        int countResult = 0;
        var count = 0;
        foreach (var item in chars){
            if (item == '!'){
              if (count > countResult){
                countResult = count;
              }  
              count = 0;
              continue;
            }
            count++;
        }
        if (count > countResult){
            countResult = count;
        }  
        count = 0;

        foreach (var item in charsA){
            if (item == '!'){
              if (count > countResult){
                countResult = count;
              }  
              count = 0;
              continue;
            }
            count++;
        }


        return countResult;
    }
}
