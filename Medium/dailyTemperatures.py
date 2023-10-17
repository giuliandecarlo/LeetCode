def dailyTemperatures(temperatures):
        days = [0] * len(temperatures)
        stack = []
        for x,y in enumerate(temperatures):
            while stack and stack[-1][1] < y:
                index,value = stack.pop()
                days[index] = x - index
            stack.append([x,y])
        
        return days