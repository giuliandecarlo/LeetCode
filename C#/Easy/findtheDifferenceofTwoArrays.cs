public class Solution {
    public IList<IList<int>> FindDifference(int[] nums1, int[] nums2) {

        IList<IList<int>> result = new List<IList<int>>();
        List<int> res1 = new List<int>();
        List<int> res2 = new List<int>();

        for (int i = 0; i < nums1.Length; i++)
        {
            if (!nums2.Contains(nums1[i]) && !res1.Contains(nums1[i]))
            {
                res1.Add(nums1[i]);
            }
        }

        for (int i = 0; i < nums2.Length; i++)
        {
            if (!nums1.Contains(nums2[i]) && !res2.Contains(nums2[i]))
            {
                res2.Add(nums2[i]);
            }
        }

        result.Add(res1);
        result.Add(res2);

        return result;
    }
}

public class Solution {
    public IList<IList<int>> FindDifference(int[] nums1, int[] nums2) {
        HashSet<int> set1 = new HashSet<int>(nums1);
        HashSet<int> set2 = new HashSet<int>(nums2);
        
        set1.ExceptWith(nums2);
        set2.ExceptWith(nums1);
        
        return new List<IList<int>> { set1.ToList(), set2.ToList() };
    }
}