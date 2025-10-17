def validParentheses(s):
    par = []
    bracket = {
        "}":"{",
        "]":"[",
        ")":"(",
    }

    for p in s:
        if(p == "{" or p == "[" or p == "("):
            par.append(p)
        else:
            if par and par[-1] == bracket[p]:
                par.pop()
            else:
                return False

    if not par:
        return True
    else:
        return False

