import unittest
from Python.list_pair_to_sum.PairToSumFunctions import PairFunctions

class TestPairFunctions(unittest.TestCase):

    def setUp(self):
        #sorted lists
        self.L0 = [1, 5, 6, 2, 8] #true expectation
        self.L1 = [1, 2, 3, 9, 17] #false expectation
        self.L2 = [1, 2, 4, 4, 5] #true expectation
        self.sum = 8

        #unsorted lists
        self.L3 = [10, 4, 6, 9, 5] #true expectation
        self.L4 = [1, 12, 7, 11, 2] #false expectation
        self.L5 = [8, 2, 5, 2, 3, 0, 7, 4, 1] #true expectation
        self.sum2 = 15

    def testSortedFunction(self):
        print("Sorted list function test:")

        self.assertTrue(PairFunctions.pairExistsWithSum_SortedList(self.L0, self.sum))
        self.assertFalse(PairFunctions.pairExistsWithSum_SortedList(self.L1, self.sum))
        self.assertTrue(PairFunctions.pairExistsWithSum_SortedList(self.L2, self.sum))

    def testUnsortedOrSortedFunction(self):
        print("Unsorted list function test:")

        self.assertTrue(PairFunctions.pairExistsWithSum_unsortedOrSortedList(self.L3, self.sum2))
        self.assertFalse(PairFunctions.pairExistsWithSum_unsortedOrSortedList(self.L4, self.sum2))
        self.assertTrue(PairFunctions.pairExistsWithSum_unsortedOrSortedList(self.L5, self.sum2))

    def testIndexesOfPairs(self):
        print("Get indexes of pairs function test:")

        self.assertEqual(PairFunctions.getIndexesOfSumPair(self.L0, self.sum), [2, 3])
        ## self.assertEqual(PairFunctions.getIndexesOfSumPair(self.L1, self.sum), None)
        self.assertIsNone(PairFunctions.getIndexesOfSumPair(self.L1, self.sum))
        self.assertEqual(PairFunctions.getIndexesOfSumPair(self.L2, self.sum), [2, 3])
        self.assertTrue(PairFunctions.getIndexesOfSumPair(self.L3, self.sum2), [2, 3])
        self.assertIsNone(PairFunctions.getIndexesOfSumPair(self.L4, self.sum2))
        self.assertTrue(PairFunctions.getIndexesOfSumPair(self.L5, self.sum2), [0, 6])

    def testGetPairEqualSumResults(self):
        print("Get pair equal to sem results function:")

        self.assertTrue(PairFunctions.getPairEqualSumResult(self.L0, self.sum))
        self.assertFalse(PairFunctions.getPairEqualSumResult(self.L1, self.sum))
        self.assertTrue(PairFunctions.getPairEqualSumResult(self.L2, self.sum))
        self.assertTrue(PairFunctions.getPairEqualSumResult(self.L3, self.sum2))
        self.assertFalse(PairFunctions.getPairEqualSumResult(self.L4, self.sum2))
        self.assertTrue(PairFunctions.getPairEqualSumResult(self.L5, self.sum2))

    def testgetCompletePairEqualSumResults(self):
        print("Testing final function. Get complete results function.")
        print("Returns tuple of result, bool result & indexes if applicable:")

        self.assertEqual(PairFunctions.getCompletePairEqualSumResults(self.L0, self.sum), (True, [2, 3]))
        self.assertFalse(PairFunctions.getCompletePairEqualSumResults(self.L1, self.sum), False)
        self.assertTrue(PairFunctions.getCompletePairEqualSumResults(self.L2, self.sum), (True, [2, 3]))
        self.assertTrue(PairFunctions.getCompletePairEqualSumResults(self.L3, self.sum2), (True, [2, 3]))
        self.assertFalse(PairFunctions.getCompletePairEqualSumResults(self.L4, self.sum2), False)
        self.assertTrue(PairFunctions.getCompletePairEqualSumResults(self.L5, self.sum2), (True, [0, 6]))

if __name__ == '__main__':
    unittest.main()