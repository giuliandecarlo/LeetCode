def findRelativeRanks(score):
    res = []
    score_sorted = sorted(score,reverse=True)
    for points in score:
        rank = score_sorted.index(points)
        if rank > 2:
            res.append(str(rank + 1))
        elif rank ==0:
            res.append("Gold Medal")
        elif rank ==1:
            res.append("Silver Medal")
        elif rank==2:
            res.append("Bronze Medal")
    return res