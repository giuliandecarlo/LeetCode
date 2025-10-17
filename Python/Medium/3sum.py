def threeSum(nums):
        nums = sorted(nums)
        res = set()
        for i in range(len(nums)):
            j = i + 1
            k = len(nums) - 1
            while j < k:
                total = nums[i]+nums[j]+nums[k]
                if total == 0:
                    res.add((nums[i],nums[j],nums[k]))
                    j += 1
                    k -= 1
                elif total < 0:
                    j += 1
                else:
                    k -= 1
        return res