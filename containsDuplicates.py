def containsDuplicate(nums):
        checkList = []
        for el in nums:
            if el in checkList:
                return True
            else:
                checkList.append(el)
        return False