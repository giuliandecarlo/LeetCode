def search(nums,target):
    start = 0
    last = len(nums) -1
    while start <= last:
        mid = (last - start // 2)
        if nums[mid] == target:
            return mid
        elif nums[mid] > target:
            last = mid -1
        elif nums[mid] < target:
            start = mid +1
    return -1

def searchR(nums,target):  #Recursive version
    def binaryS(start,last):
        if last < start:
            return -1
        mid = (last - start) //2
        if nums[mid] == target:
            return mid
        elif nums[mid] > target:
            return binaryS(start,mid-1)
        elif nums[mid] < target:
            return binaryS(mid+1,last)
    return binaryS(0,len(nums)-1)