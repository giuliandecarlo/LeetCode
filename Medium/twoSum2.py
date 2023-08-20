def twoSum(numbers, target):
    left = 0
    right = len(numbers) -1
    while left < right:
        if numbers[left] + numbers[right] == target:
            return [left +1,right+1]
        if numbers[left] + numbers[right] < target:
            left += 1
        if numbers[left] + numbers[right] > target:
            right -= 1
    return []

print(twoSum([1,3,8,1000],1008))