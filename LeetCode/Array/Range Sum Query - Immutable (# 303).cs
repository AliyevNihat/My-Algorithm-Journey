public class NumArray {
    List<int> arr = new List<int>();
    public NumArray(int[] nums) {
        foreach(int item in nums)
        {
            arr.Add(item);
        }
    }
    
    public int SumRange(int left, int right) {
      int sum = 0;
      for(int i = left; i<=right; i++)
      {
        sum += arr[i];
      }  
      return sum;
    }
}