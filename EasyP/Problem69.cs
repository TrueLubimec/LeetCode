// namespace LeetCode;

// //                                          DONE     украл, но разобрался 
// public class Solution {
//     public int MySqrt(int x) {
//         int first=0,last=x;
//         while (first<=last) {
// 			long mid=(first+last)/2,temp=mid*mid;
//             if (x==temp) 
//                 return (int)mid;
//             else if (temp>x) 
//                 last=(int)(mid-1);
//             else 
//                 first=(int)(mid+1);
//         }
//         return last;
//     }
// }