def maxProfit(prices):
        l = 0
        r = 1
        max_profit = 0
        while(r < len(prices)):
            current = prices[r]-prices[l]
            if current > max_profit: 
                max_profit = current
            if prices[r] < prices[l]:
                l = r
            r += 1
        return max_profit