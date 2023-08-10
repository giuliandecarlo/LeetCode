def romanToInt(s):
        letters = list(s)
        i = 0
        tot = 0
        dictionary = {
            "I":1,
            "V":5,
            "X":10,
            "L":50,
            "C":100,
            "D":500,
            "M":1000,
        }
        
        for l in letters:
            if i+1 < len(letters) and dictionary[l] < dictionary[letters[i+1]]:
                    tot -= dictionary[l]
            else:
                tot += dictionary[l]
            i += 1
        return tot