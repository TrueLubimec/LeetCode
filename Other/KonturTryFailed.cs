// // #1
// using System;
 
// namespace ConsoleApp
// {
//     public class Sum
//     {
//         private static void Main()
//         {
//             var NT = Console.ReadLine().Split(" ");
//             var mins = Console.ReadLine().Split(" ");
//             var maxs = Console.ReadLine().Split(" ");
        
//             var min = int.Parse(mins.Max());
//             var max = int.Parse(maxs.Min());

//             int kek = int.Parse(NT[1]) / int.Parse(NT[0]);
//             bool yes = false;
//             for (int i = min; i <= kek; i++){
//                 if (int.Parse(NT[1]) - (min * int.Parse(NT[0])) == 0){
//                     Console.WriteLine("YES");
//                     yes = true;
//                 }
//             }
//             if (yes == false){
//                 Console.WriteLine("NO");
//             }
//         }
//     }
// }

// using System;
 
// namespace ConsoleApp
// {
//     public class Sum
//     {
//         private static void Main()
//         {
//             var NT = Console.ReadLine().Split(" ");
//             var mins = Console.ReadLine().Split(" ");
//             var maxs = Console.ReadLine().Split(" ");


//             int kek = int.Parse(NT[1]) / int.Parse(NT[0]);
//             bool yes = false;
//             for (int i = 0; i < int.Parse(NT[0]); i++){
//                 yes = false;
//                 for (int min = int.Parse(mins[i]); min < int.Parse(maxs[i]); min++){
//                     if (min % kek == 0){
//                         yes = true;
//                         break;
//                     }
//                 }
//                 if (yes == false){
//                     break;
//                 }
//             }
//             if (yes == true){
//                 Console.WriteLine("YES");
//             }
//             else{
//                 Console.WriteLine("NO");
//             }
//         }
//     }
// }



//#2

// using System;
 
// namespace ConsoleApp
// {
//     public class Sum
//     {
//         private static void Main()
//         {
//             var start = Console.ReadLine();
//             float count1 = 0.0f;
//             float count0 = 0.0f;
//             for (int i = 0; i < start.Length; i++){
//                 if (start[i] == 0){
//                     count0++;
//                 }
//                 else{
//                     count1++;
//                 }
//             }
//             if (start.Length - count0 <)
//         }
//     }
// }