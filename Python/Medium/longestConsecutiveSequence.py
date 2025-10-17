def longestConsecutive(nums):
    setNums = set(nums)
    res = 0
    for el in setNums:
        if el-1 not in setNums:
            consecutive = 0
            while(el+consecutive in setNums):
                consecutive+=1
            res = max(res,consecutive)
    return res