
//// 2405. Optimal Partition of String
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