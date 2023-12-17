//there are two methods for this problem
// First Solution is using nesting loop, which is not efficient
// Second Solution is using hash table, which is efficient

// First Solution
let twoSum = function (nums, target) {
  for (let i = 0; i < nums.length; i++) {
    for (let j = i + 1; j < nums.length; j++) {
      if (target === nums[i] + nums[j]) {
        return [i, j];
      }
      return null;
    }
  }
};

// Second Solution
var twoSum2 = function (nums, target) {
  let mp = new Map();

  for (let i = 0; i < nums.length; i++) {
    let diff = target - nums[i];

    if (mp.has(diff)) {
      return [i, mp.get(diff)];
    }

    mp.set(nums[i], i);
  }
};
