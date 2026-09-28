class Solution:
    def hasDuplicate(self, nums: List[int]) -> bool:
        hash = set()
        for val in nums:
            if val in hash:
                return True;
            hash.add(val)
        return False