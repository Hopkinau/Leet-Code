var containsDuplicate = (nums) => {
  const numsSet = new Set(nums);
  const isEqual = numsSet.size === nums.length;

  return !isEqual;
};
