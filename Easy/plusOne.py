def plus(digits):
    for i in reversed(range(len(digits))):
        if digits[i] == 9:
            digits[i] = 0
            if i == 0:
                digits.insert(0,1)
                return digits
        else:
            digits[i] += 1
            return digits