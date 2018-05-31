using System.Collections.Generic;
using System.Linq;

namespace FindTheSingleton {
    public class Solution {
        public static int Run(int[] students) {
            var studentList = new List<int>(students);
            studentList.RemoveAll(x => studentList.Count(y => x == y) == 2);
            return studentList.FirstOrDefault();
        }
    }
}