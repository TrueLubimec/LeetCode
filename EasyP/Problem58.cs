namespace LeetCode;

// //DONE!                      МОЁ РЕШЕНИЕ        Memory 36.36MB | Runtime 64ms
// public class Solution {
//     public int LengthOfLastWord(string s) {
//         string[] ex = s.Split(" ");
//         List<string> words = ex.ToList();
//         for (int i = words.Count - 1; i >= 0; i--){
//             if (words[i] != " "){
//                 return words[i].Length;
//             }
//         }
//         return words.Last().Length;
//     }
// }


// //ЧУЖОЕ (тоже думал через трим)
// public class Solution {
//     public int LengthOfLastWord(string s) {
//         s = s.TrimEnd();                 //or you can use Trim()
//         string[] tmp = s.Split(' ');
//         return tmp[tmp.Length-1].Length; 
//     }
// }