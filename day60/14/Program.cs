class Program
{
  public static string LongestCommonPrefix(string[] strs)
  {
    if (strs == null || strs.Length == 0) return "";

    for (int i = 0; i < strs[0].Length; i++)
    {
      char currentChar = strs[0][i];
      for (int j = 1; j < strs.Length; j++)
      {
        if (i >= strs[j].Length || strs[j][i] != currentChar)
        {
          return strs[0].Substring(0, i);
        }
      }
    }
    return strs[0];
  }
  static void Main()
  {
    var strs = new string[] {"flower", "flight", "flow"};
    var result = LongestCommonPrefix(strs);
    Console.WriteLine(result);
  }
}
