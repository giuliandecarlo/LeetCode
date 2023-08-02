def singleNumber(nums):
    res = 0
    for n in nums:
        res ^=n
    return res


print(singleNumber([1,2,4,1,2,4,0]))