def removeDuplicates(nums):
        n = 1
        for i in range(len(nums)-1):
            if(nums[i] != nums[i+1]):
                nums[n] = nums[i+1]
                n += 1
        return n