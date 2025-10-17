def isPalindrome(s):
    s = [c for c in s if c.isalnum()]
    for i in range(len(s)//2):
        if(s[i].lower() != s[len(s)-i-1].lower()):
            return False
    return True