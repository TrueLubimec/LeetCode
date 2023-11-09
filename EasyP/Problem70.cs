// namespace LeetCode;

// //       DONE                     Runtime 16ms | Memory 26.22MB
// public class Solution {
//     public int ClimbStairs(int n) {
//         if (n == 1)
//             return 1;
//         int res= 0;
//         int first = 1;
//         int sec = 1;
//         for (int a = n - 1; a > 0; a--){
//             res = first + sec;
//             first = sec;
//             sec = res;
//         }
//         return res;
//     }
// }