class PairFunctions:
    # Function to determine is a pair exists in the SORTED list which adds to the sum
    # Linear time: O(n)
    @staticmethod
    def pairExistsWithSum_SortedList(sortedList, sum):
        low = 0
        high = len(sortedList) - 1

        while low < high:
            currentPairSum = sortedList[low] + sortedList[high]
            if currentPairSum == sum:
                return True
            elif currentPairSum < sum:
                low += 1
            elif currentPairSum > sum:
                high -= 1
        return False

    # Function to determine is a pair exists in the unsorted/sorted  list which adds to the sum
    # This method is cleaner code & can deal with an unsorted list as opposed to SortedList method
    # Linear time: O(n)
    @staticmethod
    def pairExistsWithSum_unsortedOrSortedList(L1, sum):
        compliment = []
        for item in L1:
            if item in compliment:
                return True
            compliment.append(sum - item)
        return False

    # Returns the index of the first pair in a list that adds to the sum, instead of returning a bool
    # Runs in Linear time O(n)
    @staticmethod
    def getIndexesOfSumPair(nums, sum):
        dict = {}  # Hold compliments and their indexes
        for index, num in enumerate(nums):
            if sum - num in dict:  # If the compliment for our current num exists in the dictionary
                # Return the value of the compliment in our dictionary (its index), & our current index
                return [dict[sum - num], index]
            dict[num] = index  # Add each number at its index to our dictionary

    # Returns bool if pairs exists or not. Utilizes dictionary instead of list, & enumeration
    # Runs in Linear time O(n)
    @staticmethod
    def getPairEqualSumResult(nums, sum):
        dict = {}  # Hold compliments and their indexes
        for index, num in enumerate(nums):
            if sum - num in dict:  # If the compliment for our current num exists in the dictionary
                return True  # return True
            dict[num] = index  # Add each number at its index to our dictionary
        return False

    # Returns tuple. Tuple includes bool if pair exists with sum, AND the indexes of where the pair exists
    # We could just call our getPairEqualsSumResult & getIndexesOfSumPair functions, but that would require
    # more work to be done for the result. Runs in Linear time O(n)
    @staticmethod
    def getCompletePairEqualSumResults(nums, sum):
        dict = {}  # Hold compliments and their indexes
        for index, num in enumerate(nums):
            if sum - num in dict:  # If the compliment for our current num exists in the dictionary
                return True, [dict[sum - num], index]
            dict[num] = index  # Add each number at its index to our dictionary
        return False

if __name__ == '__main__':
    L0 = [1, 4, 6, 2, 8]  # true expectation
    sum = 12

    test = PairFunctions.getCompletePairEqualSumResults(L0, sum)
    print(test)

    print("Entering list L0")
    #print(pairExistsWithSum_SortedList(L0, sum), "\n")
