
//// 2405. Optimal Partition of String                                                                        DONE
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


//// 1. Two Sum                                                                            для меня DONE
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



//// 9. Palindrome Number                                                             частично DONE, прост на 10ки метод не работал

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



//// 14. Longest Common Prefix                                                                                  //// 122 / 124

//var test = new Solution();
//string[] strings = { "ac", "ac", "a", "a" };
//var lelel = test.LongestCommonPrefix(strings);
//Console.WriteLine(lelel);
//public class Solution
//{
//    public string LongestCommonPrefix(string[] strs)
//    {
//        if (strs.Any() == false)
//            return "";
//        if (strs.Length == 1)
//            return strs[0];
//        List<char> result = new List<char>();
//        var firstWord = strs[0];
//        var secondWord = strs[1];
//        for (int a = 0; a < firstWord.Length && a < secondWord.Length; a++)
//        {
//            if (firstWord[a] == secondWord[a])
//                result.Add(firstWord[a]);
//            else
//                break;
//        }
//        if (result.Any() ==  false) 
//            return "";
//        for (int i = 2; i < strs.Length; i++)
//        {
//            var word = strs[i];
//            if (word.Length == 0)
//                return "";
//            for (int b = 0; b < word.Length && b < result.Count; b++)
//            {
//                if (word[b] == result[b])
//                    continue;
//                else
//                {
//                    result.RemoveRange(b,result.Count - b);
//                    break;
//                }
//            }
//        }
//        var wat = String.Join("", result.ToArray());
//        return wat;
//    }
//}


//// SOLV

//public class Solution
//{
//    public string LongestCommonPrefix(string[] ss)
//    {
//        string shortest = ss.OrderBy(s => s.Length).First();

//        for (int i = 0; i < shortest.Length; i++)
//        {
//            if (ss.Select(s => s[i]).Distinct().Count() > 1) return shortest[..i];
//        }

//        return shortest;
//    }
//}





//// 13. Roman to Integer                                                                                           // solution is not mine

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

//// 20. Valid Parentheses                                                                                      //// PIZDOS SNOVA   //// LOSE

//public class Solution
//{
//    public bool IsValid(string s)
//    {
//        foreach (char bracket in s)
//        {
//            if (s[s.IndexOf(bracket)] == '(')
//            {
//                if (s[s.IndexOf(bracket) + 1] == ')')
//                    continue;
//                else return false;
//            }
//            if (s[s.IndexOf(bracket)] == '[')
//            {
//                if (s[s.IndexOf(bracket) + 1] == ']')
//                    continue;
//                else return false;
//            }
//            if (s[s.IndexOf(bracket)] == '{')
//            {
//                if (s[s.IndexOf(bracket) + 1] == '}')
//                    continue;
//                else return false;
//            }
//        }
//        return true;
//    }
//}

//// STOLEN SOLV
//public class Solution
//{
//    public bool IsValid(string s)
//    {
//        // Get ready initial state (enforce element type)
//        var k = new Stack<char>();
//        // Evaluate each character for potential mismatch 
//        foreach (char c in s)
//        {
//            // Push closing round bracket onto the stack
//            if (c == '(') { k.Push(')'); continue; }
//            // Push closing curly bracket onto the stack
//            if (c == '{') { k.Push('}'); continue; }
//            // Push closing square bracket onto the stack
//            if (c == '[') { k.Push(']'); continue; }
//            // Look out for imbalanced strings or mismatches
//            if (k.Count == 0 || c != k.Pop()) return false;
//        }
//        // Empty stack means string is valid and invalid otherwise
//        return k.Count == 0;
//    }
//}



//// TINKOFF

//Human human = new Human();
//Robot robot = new Robot(human);
//robot.HumanOperator.Name = "Masha";
//Console.WriteLine(robot.HumanOperator.Name);

//public class Robot
//{
//    public readonly Human HumanOperator;
//    public Robot(Human humanOperator) => HumanOperator = humanOperator;
//}

//public class Human
//{
//    public string Name;
//}

//Container container = new Container() { Value = 1 };
//Container.Nullify(container);
//Console.WriteLine(container.Value);

//public struct Container
//{
//    public int Value;
//    public static void Nullify(Container container) => container.Value = 0;
//}



//// 121. Best Time to Buy and Sell Stock

//public class Solution
//{
//    public int MaxProfit(int[] prices)
//    {

//    }
//}





////21. Merge Two Sorted Lists


// Definition for singly-linked list.
using System.Security.Cryptography.X509Certificates;

public class ListNode {
     public int val;
     public ListNode next;
     public ListNode(int val=0, ListNode next=null) {
         this.val = val;
         this.next = next;
     }
 }
 
public class Solution {
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
        List<int> result = new List<int>();
        string leng = list1.ToString();
        for (int i = 0; leng.Length > i; i++ )
        {
            result.Add(int.Parse(list1.next));

        }
        result.Sort();
        return result;
    }
}