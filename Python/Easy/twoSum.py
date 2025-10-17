def twoSum(nums, target):
    dictionary = {}
    i = 0
    for n in nums:
        diff = target - n
        if diff in dictionary:
            return [dictionary[diff],i]
        dictionary[n] = i
        i += 1