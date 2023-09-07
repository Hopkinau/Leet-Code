//If Input: nums = [1,2,3,1]
var containsDuplicate = (nums) => {
  const numsSet = new Set(nums);
  //1.Create set class
  const isEqual = numsSet.size === nums.length;
  //2.Compare the set class and the actual length of array
  //because numsSet = {1,2,3}, duplicate value will be remove in set,so size =3;
  //nums.length is 4, size is not equal to length, isEqual =false;

  return !isEqual;
  //!false = ture; its mean this array have duplicate elements.
};
