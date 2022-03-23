using System;
using System.Collections;
using System.Collections.Generic;
using Trees;

namespace CP
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //longestCommonPrefix();
            //Stack stack = new Stack();
            //TLG();
            //List<string> magazine = new List<string>();
            //List<string> note = new List<string>();
            //magazine.Add("two");
            //magazine.Add("times");
            //magazine.Add("three");
            //magazine.Add("is");
            //magazine.Add("not");
            //magazine.Add("four");
            //note.Add("two");
            //note.Add("times");
            //note.Add("two");
            //note.Add("is");
            //note.Add("four");
            //checkMagazine(magazine,note);
            //Console.WriteLine(ContainsDuplicate(new[] { 1, 1, 3, 4 }));
            //MaxSubArray(new[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 });
            //Merge(new[] { 1, 2, 3, 0, 0, 0 }, 6, new[] { 2, 3, 5 }, 3);
            //ReverseStringStack("GeeksforGeeks");
            //var result= BalanceExpression(")){}[]");
            //if (result == true)
            //{
            //    Console.WriteLine("Balanced Expression");
            //}
            //else
            //{
            //    Console.WriteLine("Unbalanced Expression");
            //}
            //LongestCommonPrefix();
            //KeplerLaw();
            //CovidCases();
            //TCSExamination();
            //ChefFixedDeposits();
            //Console.Write(isBalanced("{)[](}]}]}))}(())("));
            //Console.WriteLine(MajorityElement(new int[] {2,2,1,1,1,2,2}));
            //Console.WriteLine(ContainsNearbyDuplicate(new int[] { 1, 2, 3, 1, 2, 3 }, 2));
            //Console.WriteLine(IsAnagram("car", "rac"));
            //Console.WriteLine(ReversofWords("My Name is John"));

            SmallestNearLeft();

            //Tree tree = new Tree();
            //tree.CreateTree();

            Console.ReadKey();


        }
        public static void checkMagazine(List<string> magazine, List<string> note)
        {
            bool condition = true;
            Hashtable table = new Hashtable();
            for (int i = 0; i < magazine.Count; i++)
            {
                table.Add(i, magazine[i]);
            }
            for (int i = 0; i < note.Count; i++)
            {
                //Console.WriteLine(note[i]);
                //Console.WriteLine(magazine[i]);

                //Console.WriteLine(table.ContainsValue(note[i]));

                if (!table.ContainsValue(note[i]))
                {
                    condition = false;
                    break;
                }
            }
            if (condition)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
        public static void longestCommonPrefix()
        {
            string[] args = new string[3];
            args[0] = "flower";
            args[1] = "flow";
            args[2] = "fl";
            if (args.Length == 0) Console.WriteLine("");
            var prefix = args[0];
            for (int i = 1; i < args.Length; i++)
            {

                while (args[i].IndexOf(prefix) != 0)
                {
                    prefix = prefix.Substring(0, prefix.Length - 1);
                    if (prefix == "") Console.WriteLine("");
                }

            }
            Console.WriteLine(prefix);
            Console.ReadKey();
        }
        public static void TLG()
        {
            var inputCount = Console.ReadLine();
            var t = int.Parse(inputCount);

            var cumScoreA = 0;
            var cumScoreB = 0;
            var highestLead = 0;
            var player = 1;
            for (int i = 0; i < t; i++)
            {
                var input = Console.ReadLine();
                var scores = input.Split(' ');
                var scoreA = int.Parse(scores[0]);
                var scoreB = int.Parse(scores[1]);
                cumScoreA += scoreA;
                cumScoreB += scoreB;
                var diff = cumScoreA - cumScoreB;
                var lead = Math.Abs(diff);
                if (lead > highestLead)
                {
                    highestLead = lead;
                    player = diff >= 0 ? 1 : 2;
                }
            }

            Console.WriteLine($"{player} {highestLead}");

        }
        public static bool ContainsDuplicate(int[] nums)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();

            foreach (var value in nums)
            {
                if (dict.ContainsKey(value))
                {
                    dict[value]++;
                    if (dict[value] > 1)
                    {
                        return true;
                    }
                }
                else
                {
                    dict[value] = 1;
                }
            }
            return false;
        }
        public static int MaxSubArray(int[] nums)
        {
            int size = nums.Length;
            int max_so_far = int.MinValue;
            int max_ending_here = 0;

            for (int i = 0; i < size; i++)
            {
                max_ending_here = max_ending_here + nums[i];

                if (max_so_far < max_ending_here)
                {
                    max_so_far = max_ending_here;
                }
                if (max_ending_here < 0)
                {
                    max_ending_here = 0;
                }

            }
            return max_so_far;
        }
        public static void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            for (int i = 0; i < m; i++)
            {
                if (nums1[i] == 0)
                {
                    nums1[i] = nums2[i - n];
                }
            }



            foreach (var itme in nums1)
            {
                Console.WriteLine(itme);
            }
        }
        public static void ReverseStringStack(string s)
        {
            Stack<char> stack = new Stack<char>();
            foreach (var ele in s)
            {
                stack.Push(ele);
            }

            while (stack.Count != 0)
            {
                Console.Write(stack.Pop());
            }
        }
        public static bool MatchingPair(char c1, char c2)
        {
            if (c1.Equals('(') && c2.Equals(')'))
            {
                return true;
            }
            if (c1.Equals('[') && c2.Equals(']'))
            {
                return true;
            }
            if (c1.Equals('{') && c2.Equals('}'))
            {
                return true;
            }
            return false;
        }
        public static bool BalanceExpression(string s)
        {
            Stack stack = new Stack();

            foreach (char ele in s)
            {
                if (ele.Equals('(') || ele.Equals('{') || ele.Equals('['))
                {
                    stack.Push(ele);
                }
                if (ele.Equals(')') || ele.Equals('}') || ele.Equals(']'))
                {
                    //check matching pairs
                    if (stack.Count == 0)
                    {
                        return false;
                    }
                    else if (!MatchingPair((char)stack.Pop(), ele))
                    {
                        return false;
                    }
                }
            }
            if (stack.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public long[] NextLargerElement(long[] arr, int n)
        {
            //Your code here
            Stack<long> stack = new Stack<long>();
            long[] lg = new long[arr.Length];
            stack.Push(arr[0]);
            for (int i = 1; i < arr.Length; i++)
            {
                if (stack.Count != 0)
                {
                    while (arr[i] > stack.Peek())
                    {
                        lg[i - 1] = arr[i];
                        stack.Pop();
                        stack.Push(arr[i]);
                    }
                    if (arr[i] < stack.Peek())
                    {
                        stack.Push(arr[i]);
                        lg[i - 1] = -1;
                    }

                }
            }
            return lg;
        }
        public static void LongestCommonPrefix()
        {
            string result = string.Empty;

            string[] array = new string[4] { "geeksforgeeks", "geeks", "geeky", "geeyAnts" };
            for (int i = 0; i < array.Length; i++)
            {
                result = compare(array[0], array[i]);
            }
            Console.WriteLine(result);
        }
        public static string compare(string str1, string str2)
        {
            int n1 = str1.Length;
            int n2 = str2.Length;
            string result = string.Empty;
            for (int i = 0, j = 0; i < n1 && j < n2; i++, j++)
            {
                if (str1[i] != str2[j])
                {
                    break;
                }
                result += str1[i];
            }

            return result;
        }
        //CodeForces
        public static void KeplerLaw()
        {
            int[] array = new int[4] { 1, 8, 2, 8 };
            var a = Console.ReadLine().Split(",");
            int firstProportional = (array[0] * array[0]) * (array[3] * array[3] * array[3]);
            int secondProportional = (array[1] * array[1]) * (array[2] * array[2] * array[2]);
            if (firstProportional == secondProportional)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }

        }
        //CodeForces
        public static void CovidCases()
        {
            int t = Convert.ToInt32(Console.ReadLine());
            for (int j = 0; j < t; j++)
            {
                int sum = 1;

                var array = Console.ReadLine().Split(' ');
                int N = Convert.ToInt32(array[0]);
                int D = Convert.ToInt32(array[1]);
                for (int i = 1; i <= D && sum < N; i++)
                {
                    if (i < 11)
                    {
                        sum *= 2;
                    }
                    else
                    {
                        sum *= 3;
                    }
                }
                if (sum >= N)
                {
                    sum = N;
                }
                Console.WriteLine(sum);
            }
        }
        public static void printLeaders(int[] arr, int size)
        {
            int max_from_right = arr[size - 1];

            // Rightmost element is always leader
            Console.Write(max_from_right + " ");

            for (int i = size - 2; i >= 0; i--)
            {
                if (max_from_right < arr[i])
                {
                    max_from_right = arr[i];
                    Console.Write(max_from_right + " ");
                }
            }
        }
        public static void TCSExamination()
        {
            int t = Convert.ToInt32(Console.ReadLine());
            while (t > 0)
            {
                var dragon = Console.ReadLine().Split(' ');
                var sloth = Console.ReadLine().Split(' ');
                var sumDragon = Convert.ToInt32(dragon[0]) + Convert.ToInt32(dragon[1]) + Convert.ToInt32(dragon[2]);
                var sumSloth = Convert.ToInt32(sloth[0]) + Convert.ToInt32(sloth[1]) + Convert.ToInt32(sloth[2]);
                if (sumDragon == sumSloth)
                {
                    if (Convert.ToInt32(dragon[0]) == Convert.ToInt32(sloth[0]))
                    {
                        if (Convert.ToInt32(dragon[1]) == Convert.ToInt32(sloth[1]))
                        {
                            Console.WriteLine(FindGreater(Convert.ToInt32(dragon[2]), Convert.ToInt32(sloth[2])));
                            //if (Convert.ToInt32(dragon[2]) > Convert.ToInt32(sloth[2]))
                            //{
                            //    Console.WriteLine("DRAGON");
                            //}
                            //else if (Convert.ToInt32(dragon[2]) < Convert.ToInt32(sloth[2]))
                            //{
                            //    Console.WriteLine("SLOTH");
                            //}
                            //else
                            //{
                            //    Console.WriteLine("TIE");

                            //}
                        }
                        else
                        {
                            Console.WriteLine(FindGreater(Convert.ToInt32(dragon[1]), Convert.ToInt32(sloth[1])));
                        }

                        //else if (Convert.ToInt32(dragon[1]) > Convert.ToInt32(sloth[1]))
                        //{
                        //    Console.WriteLine("DRAGON");
                        //}
                        //else
                        //{
                        //    Console.WriteLine("SLOTH");
                        //}
                    }
                    else
                    {
                        Console.WriteLine(FindGreater(Convert.ToInt32(dragon[0]), Convert.ToInt32(sloth[0])));
                    }

                    //else if (Convert.ToInt32(dragon[0]) > Convert.ToInt32(sloth[0]))
                    //{
                    //    Console.WriteLine("DRAGON");
                    //}
                    //else
                    //{
                    //    Console.WriteLine("SLOTH");
                    //}
                }
                else if (sumDragon > sumSloth)
                {
                    Console.WriteLine("DRAGON");
                }
                else
                {
                    Console.WriteLine("SLOTH");
                }
            }

        }
        public static string FindGreater(int dragon, int sloth)
        {
            if (dragon > sloth) return "DRAGON";
            else if (dragon < sloth) return "SLOTH";
            return "TIE";
        }
        public static void ChefFixedDeposits()
        {
            int t = Convert.ToInt32(Console.ReadLine());
            while (t > 0)
            {
                var input = Console.ReadLine().Split(' ');
                int N = Convert.ToInt32(input[0]);
                int X = Convert.ToInt32(input[1]);
                var array = Console.ReadLine().Split(' ');
                int[] numbers = new int[N];
                //for (int i= 0;i<N;i++)
                //{
                //    numbers[i] = Convert.ToInt32(array[i]);
                //}

                //Sort array in descending order
                Array.Sort<int>(numbers, new Comparison<int>((i1, i2) => i2.CompareTo(i1)));
                int sum = 0;
                int fd = 0;
                bool goalReached = false;
                foreach (var ele in numbers)
                {
                    sum += ele;
                    if (sum >= X)
                    {
                        goalReached = true;
                        break;
                    }
                    else
                    {
                        fd++;
                    }
                }
                if (goalReached == true)
                {
                    Console.WriteLine(fd + 1);
                }
                else
                {
                    Console.WriteLine(-1);
                }


                t--;
            }
        }
        public static void CryColor()
        {





            int t = Convert.ToInt32(Console.ReadLine());
            while (t > 0)
            {
                int n = Convert.ToInt32(Console.ReadLine());
                var matrix = new int[3, 3];
                var box1 = Console.ReadLine().Split(' ');
                matrix[0, 0] = Convert.ToInt32(box1[0]);
                matrix[0, 1] = Convert.ToInt32(box1[1]);
                matrix[0, 2] = Convert.ToInt32(box1[2]);
                var box2 = Console.ReadLine().Split(' ');
                matrix[1, 0] = Convert.ToInt32(box2[0]);
                matrix[1, 1] = Convert.ToInt32(box2[1]);
                matrix[1, 2] = Convert.ToInt32(box2[2]);
                var box3 = Console.ReadLine().Split(' ');
                matrix[2, 0] = Convert.ToInt32(box3[0]);
                matrix[2, 1] = Convert.ToInt32(box3[1]);
                matrix[2, 2] = Convert.ToInt32(box3[2]);

                for (int i = 0; i < matrix.Length; i++)
                {
                    for (int j = 0; j < matrix.Length; j++)
                    {
                        Console.WriteLine(matrix[i, j]);
                    }
                }
                t--;
            }

        }
        public static string isBalanced(string s)
        {
            Stack stack = new Stack();

            for (int i = 0; i < s.Length; i++)
            {

                if (s[i] == '(' || s[i] == '[' || s[i] == '{')
                {
                    stack.Push(s[i]);
                }
                else if (stack.Count == 0)
                {
                    return "NO";
                }
                else
                {
                    if (s[i] == ')')
                    {
                        var popEle = Convert.ToChar(stack.Peek());
                        if (popEle == '(' && s[i] == ')')
                        {
                            stack.Pop();
                        }
                        else
                        {
                            return "NO";
                        }
                    }
                    else if (s[i] == ']')
                    {
                        var popEle = Convert.ToChar(stack.Peek());
                        if (popEle == '[' && s[i] == ']')
                        {
                            stack.Pop();
                        }
                        else
                        {
                            return "NO";
                        }
                    }
                    else if (s[i] == '}')
                    {
                        var popEle = Convert.ToChar(stack.Peek());
                        if (popEle == '{' && s[i] == '}')
                        {
                            stack.Pop();
                        }
                        else
                        {
                            return "NO";
                        }
                    }
                }

            }
            return "YES";
        }
        public static int MajorityElement(int[] nums)
        {
            int n = (nums.Length) / 2;
            int maxEle = 0;
            Dictionary<int, int> dic = new Dictionary<int, int>();
            if (nums.Length == 1)
            {
                return nums[0];
            }
            foreach (var e in nums)
            {
                if (!dic.ContainsKey(e))
                {
                    dic.Add(e, 1);
                }
                else
                {
                    dic[e]++;
                    int value = 0;
                    dic.TryGetValue(e, out value);
                    if (value > n)
                    {
                        maxEle = e;
                    }
                }
            }
            return maxEle;
        }
        /*LeetCode
        https://leetcode.com/problems/contains-duplicate-ii/
        */
        public static bool ContainsNearbyDuplicate(int[] nums, int k)
        {
            var dic = new Dictionary<int, int>();
            bool result = false;
            for (int i = 0; i < nums.Length; i++)
            {

                if (!dic.ContainsKey(nums[i]))
                {
                    dic.Add(nums[i], i);
                }
                else
                {
                    int prevIndex = dic[nums[i]];
                    dic[nums[i]] = i;

                    if (Math.Abs(prevIndex - i) <= k)
                    {
                        result = true;
                    }
                }
            }
            return result;
        }
        /* GFG
         * https://www.geeksforgeeks.org/window-sliding-technique/
         */
        public static int maxSum(int[] arr, int n, int k)
        {
            if (n < k)
            {
                return -1;
            }

            //Find the Max uptp k elements in arr
            int max_sum = 0;
            for (int i = 0; i < k; i++)
            {
                max_sum += arr[i];
            }
            // Compute sums of remaining windows by
            // removing first element of previous
            // window and adding last element of
            // current window.

            int window_sum = max_sum;
            for (int i = k; i < n; i++)
            {
                window_sum += arr[i] - arr[i - k];
                max_sum = Math.Max(max_sum, window_sum);
            }
            return max_sum;
        }
        /* LeetCode
         * https://leetcode.com/problems/valid-anagram/submissions/
         * */
        public static bool IsAnagram(string s, string t)
        {
            if (s.Length != t.Length)
            {
                return false;
            }
            var dic = new Dictionary<char, int>();
            for (int i = 0; i < s.Length; i++)
            {
                dic[s[i]] = dic.ContainsKey(s[i]) ? (dic[s[i]] + 1) : 1;
                //if (!dic.ContainsKey(s[i]))
                //{
                //    dic.Add(s[i], 1);
                //}
                //else
                //{
                //    dic[s[i]]++;
                //}
            }
            for (int i = 0; i < t.Length; i++)
            {
                if (dic.ContainsKey(t[i]))
                {
                    dic[t[i]]--;
                }
            }
            foreach (var d in dic)
            {
                if (d.Value > 0)
                {
                    return false;
                }
            }
            return true;
        }

        //print Reverse of Words
        public static string ReversofWords(string input)
        {
            string result = "";
            int end = input.Length - 1;
            int start = 0;
            for(int i = input.Length-1; i >=0; i--)
            {
                if (input[i]==' ')
                {
                    start = i + 1;
                    for(int j = start; j <= end; j++)
                    {
                        result += input[j];
                    }
                    result += " ";
                    end = start - 1;
                }
            }
            for(int j = 0; j <= end; j++)
            {
                result += input[j];
            }
            return result;
        }
        public static void SmallestNearLeft()
        {
            int[] arr = { 1, 3, 0, 2, 5 };
            Stack<int> s = new Stack<int>();

            for(int i = 0; i < arr.Length; i++)
            {
                while(s.Count!=0 && s.Peek() >= arr[i])
                {
                    s.Pop();
                }
                if (s.Count == 0)
                {
                    Console.WriteLine("-1");
                }
                else
                {
                    Console.WriteLine(s.Peek());
                }

                s.Push(arr[i]);
            }
        }
    }
}


