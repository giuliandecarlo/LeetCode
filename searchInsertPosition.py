def searchInsert(nums,target):
    low = 0
    high = len(nums) - 1

    while(low <= high):
        mid_pos = (low + high)//2
        mid_val = nums[mid_pos]
        if(mid_val < target):
            low = mid_pos + 1
        elif(mid_val > target):
            high = mid_pos - 1
        else:
            return mid_pos
    return low