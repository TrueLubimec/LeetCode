
//// 2405. Optimal Partition of String                                      DONE
//public class Solution
//{
//    public int PartitionString(string s)
//    {

//        List<char> recieved = new List<char>();
//        foreach (char c in s)
//        {
//            recieved.Add(c);
//        }
//        int count = 0;

//        for (int i = 0; i < s.Length; i++)
//        {
//            List<char> values = new List<char>();
//            if (recieved.Count == 0)
//                break;
//            foreach (var item in recieved)
//            {
//                if (!values.Contains(item))
//                {
//                    values.Add(item);
//                }
//                else
//                {
//                    break;
//                }
//            }
//            count++;
//            foreach (var item in values)
//            {
//                recieved.Remove(item);
//            }
//        }

//        return count;
//    }
//}


//// 1. Two Sum                                                             для меня DONE
//public class Solution
//{
//    public int[] TwoSum(int[] nums, int target)
//    {

//int[] nums = new int[] { 3, 2, 4 };
//int target = 6;
//int[] res = new int[2];
//for (int a = 0; a < nums.Length; a++)
//{

//    for (int i = 0; i < nums.Length; i++)
//    {
//        int var1 = nums[a];
//        int var2 = nums[i + 1];
//        if (Array.IndexOf(nums, var1) == Array.LastIndexOf(nums, var2))
//        {
//            continue;
//        }
//        else if (var1 + var2 == target)
//        {
//            res[0] = Array.IndexOf(nums, var1);
//            res[1] = Array.LastIndexOf(nums, var2);
//            break;
//        }
//    }
//}
//    }
//}



//// 9. Palindrome Number                                                   частично DONE, прост на 10ки метод не работал

// МОё изи решение (но на 10+ не работает)
//int x = int.Parse(Console.ReadLine());
//string extra = x.ToString();
//string extra2 = x.ToString();

//if (x < 0)
//    Console.WriteLine("False");
//else if (extra == extra2)
//    Console.WriteLine("True");
//Console.WriteLine("False");


// НУ ТРЕШ спизженный солв
//public class Solution
//{
//    public bool IsPalindrome(int x)
//    {
//        var y = x.ToString().ToCharArray();
//        Array.Reverse(y); //Reverses char array.
//        return x.ToString() == new string(y);
//    }
//}



//// 14. Longest Common Prefix

// public class Solution
// {
//     public string LongestCommonPrefix(string[] strs)
//     {
//         int lengthOfArray = strs.Length;
//         string firstStr = strs[0];
//         List<string> list = new List<string>();
//         int count = 0;
//         foreach (string str in strs)
//         {

//         }
//     }
// }



//// 13. Roman to Integer               // solution is not mine

// public class Solution {
//     public int RomanToInt(string s) {

//         var chars = s.ToCharArray();
//         var result = 0;
//         var currentValue = 0;
//         for(var i = 0; i < chars.Length - 1; i++){
//             currentValue = RomanNumerals(chars[i]);
//             result += (RomanNumerals(chars[i+1]) > currentValue ? -1 : 1) * currentValue;
//         }

//         return result +  RomanNumerals(chars[chars.Length - 1]);
//     }

//     public int RomanNumerals(char c)
//     {
//         switch(c){
//             case 'I' : return 1;
//             case 'V' : return 5;
//             case 'X' : return 10;
//             case 'L' : return 50;
//             case 'C' : return 100;
//             case 'D' : return 500;
//             case 'M' : return 1000;
//         };  
//         return 0;
//     }
// }

//// 20. Valid Parentheses
Solution test = new Solution();
var check = test.IsValid("()");

public class Solution {
    public bool IsValid(string s) {
        foreach (char bracket in s)
        {
            if (bracket == ')')
                continue;
            if (bracket == ']')
                continue;
            if (bracket == '}')
                continue;
            for (int i = 0; i < s.Length; i++)
            {
                if (bracket == '(')
                {
                    if (s[i] == ')')
                        break;
                    else continue;
                }
                else if (bracket == '[')
                {
                    if (s[i] == ']')
                        break;
                    else continue;
                }
                else if (bracket == '{')
                {
                    if (s[i] == '}')
                        break;
                    else continue;
                }   
            }
            return false;
        }
        return true;
    }
}
