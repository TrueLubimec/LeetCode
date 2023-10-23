namespace LeetCode;

//                                      70% DONE ну там реально бред, я такие длинные числа буду годами дебагать
public class Solution {
    public string AddBinary(string a, string b) {
        int ex = 0;
        int powerA = a.Length - 1;
        int powerB = b.Length - 1;
        for (int i = 0; i < a.Length; i++)
        {
            int f = (int)Math.Pow(2, powerA);
            int s = int.Parse(char.ToString(a[i]));
            ex += f * s;
            powerA--;
        }
        for (int i = 0; i < b.Length; i++)
        {
            int f = (int)Math.Pow(2, powerB);
            int s = int.Parse(char.ToString(b[i]));
            ex += f * s;
            powerB--;
        }
        return Convert.ToString(ex, 2);
    }
}