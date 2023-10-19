// namespace LeetCode;
// //                                  DONE         Runtime   125ms       Memory  42.80MB
// public class Solution {
//     public int[] PlusOne(int[] digits) {
//         List<int> result = digits.ToList();
//         for (int i = result.Count-1; i >= 0; i-- ){
//             if (i == 0 && result[i] == 9){
//                 result[i] = 0;
//                 result.Insert(i,1);
//                 break;
//             }
//             else if (result[i] == 9){
//                 result[i] = 0;
//                 continue;
//             }
            
//             result[i]++;
//             break;
//         }
//         int[] intRes = result.ToArray();
//         return intRes;
//     }
// }