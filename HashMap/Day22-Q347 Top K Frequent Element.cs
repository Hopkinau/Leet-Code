//https://www.youtube.com/watch?v=YPTqKIgVk-k&t=3s

public int[] TopKFrequent(int[] nums, int k) {
    // Create a dictionary to store the frequency of each number.
    Dictionary<int, int> frequencyMap = new Dictionary<int, int>();
    //if input is [1,1,1,1,2,2,3,3,3,4] and k = 2, then frequencyMap will be {1:4, 2:2, 3:3, 4:1}
    // Count the frequency of each number in the array.
    foreach (int num in nums) {
        if (frequencyMap.ContainsKey(num)) {
            frequencyMap[num]++;
        } else {
            frequencyMap[num] = 1;
        }
    }

    // Create a list to store unique numbers.if input is [1,1,1,1,2,2,3,3,3,4] and k = 2, then uniqueNums will be [1,2,3,4]
    List<int> uniqueNums = frequencyMap.Keys.ToList();
    
    // Sort the unique numbers by their frequency in descending order.
    uniqueNums.Sort((a, b) => frequencyMap[b].CompareTo(frequencyMap[a]));
    //if input is [1,1,1,1,2,2,3,3,3,4] and k = 2, then uniqueNums will be sort as  [1,3,2,4]
    // Take the top K frequent elements from the sorted list.
    return uniqueNums.Take(k).ToArray();
    //uniqueNums.Take(k) uses the Take method to extract the first K elements from the uniqueNums list. These will be the top K frequent elements because you previously sorted uniqueNums by frequency.
   //.ToArray() converts the result into an array.
}
