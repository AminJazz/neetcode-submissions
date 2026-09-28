class Solution:
    def getConcatenation(self, nums: List[int]) -> List[int]:
        result = []
        for i in range(2):
            for num in range(len(nums)):
                result.append(nums[num])
        return result
