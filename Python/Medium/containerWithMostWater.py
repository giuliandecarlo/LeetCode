def maxArea(height):
    start = 0
    last = len(height) - 1
    maxA = 0
    area = 0
    while start < last:
        area = min(height[last],height[start]) * (last - start)
        maxA = max(maxA,area)
        if height[last] < height[start]:
            last -=1
        else:
            start +=1
    return maxA