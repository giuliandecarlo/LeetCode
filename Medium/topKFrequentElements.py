def topKFrequent(nums, k):
    elements = [[]for i in range(len(nums)+1)]
    count = {}
    res = []
    for el in nums:
        count[el] = count.get(el,0) + 1
    for el,f in count.items():
        elements[f].append(el)

    for i in range(len(elements)-1,-1,-1):
        for n in elements[i]:
            res.append(n)
            if(len(res)==k):
                return res
    return res