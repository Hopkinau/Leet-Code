//https://www.youtube.com/watch?v=YPTqKIgVk-k&t=3s

public int[] TopKFrequent(int[] nums, int k) {
    // Create a dictionary to store the frequency of each number.
    Dictionary<int, int> frequencyMap = new Dictionary<int, int>();

    // Count the frequency of each number in the array.
    foreach (int num in nums) {
        if (frequencyMap.ContainsKey(num)) {
            frequencyMap[num]++;
        } else {
            frequencyMap[num] = 1;
        }
    }

    // Create a list to store unique numbers.
    List<int> uniqueNums = frequencyMap.Keys.ToList();

    // Sort the unique numbers by their frequency in descending order.
    uniqueNums.Sort((a, b) => frequencyMap[b].CompareTo(frequencyMap[a]));

    // Take the top K frequent elements from the sorted list.
    return uniqueNums.Take(k).ToArray();
}
