def longestCommonPrefix(strs):
    pref=""

    for i in range(len(strs[0])):
        for word in strs:
            if i == len(word) or word[i] != strs[0][i]:
                return pref
        pref += strs[0][i]
    return pref