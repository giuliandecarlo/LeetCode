def isAnagram(s, t):
    s = list(s)
    t = list(t)
    for c in s:
        if c in t:
            t.remove(c)
        else:
            return False
    if t:
        return False
    return True