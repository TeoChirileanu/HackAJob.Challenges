using System.Collections.Generic;
using System.Linq;

namespace MaximumSubarray {
    public class Solution {
        public static int Run(int[] numbers) {
            return ComputeMaximumSum(numbers);
        }

        private static int ComputeMaximumSum(IReadOnlyList<int> numbers) {
            var maximumSum = int.MinValue;
            for (var i = 0; i < numbers.Count; i++) {
                var currentSum = numbers[i];
                for (var j = i + 1; j < numbers.Count; j++) {
                    currentSum += numbers[j];
                    if (currentSum > maximumSum)
                        maximumSum = currentSum;
                }
            }

            var maximumElement = numbers.Max();
            return maximumElement > maximumSum ? maximumElement : maximumSum;
        }
    }
}