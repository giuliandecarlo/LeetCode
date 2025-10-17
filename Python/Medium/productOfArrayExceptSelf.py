def productExceptSelf(nums):
    res = [1]*len(nums)
    pre = 1
    post = 1
    for i in range(len(nums)):
        res[i]=pre
        pre *= nums[i]
    for i in range(len(nums)):
        res[len(nums)-i-1] *= post
        post *= nums[len(nums)-i-1]
    return res