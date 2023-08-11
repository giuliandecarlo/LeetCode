def groupAnagrams(strs):
    dictionary = {}
    for el in strs:
        temp = "".join(sorted(el))
        if temp in dictionary:
            dictionary[temp].append(el)
        else:
            dictionary[temp] = [el]
    return dictionary.values()