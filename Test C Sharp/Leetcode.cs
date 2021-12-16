using System;
using System.Collections.Generic;
using System.Text;

namespace Test_C_Sharp
{
    class Leetcode
    {
        public static int[] DecompressRLElist(int[] nums)
        {
            int length = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (i % 2 == 0)
                {
                    length += nums[i];
                }
            }
            int[] list = new int[length];
            int count = 0;
            for (int i = 1; i < nums.Length; i++)
            {
                if (i % 2 == 1)
                {
                    
                    int temp = 1;
                    while (temp <= nums[i - 1])
                    {
                        list[count + temp - 1] = nums[i];
                        temp++;
                    }
                    count += nums[i - 1];
                }
            }
            return list;
        }
        public static IList<int> TargetIndices(int[] nums, int target)
        {            
            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = i; j < nums.Length; j++)
                {
                    if (nums[i] > nums[j])
                    {
                        int temp = nums[i];
                        nums[i] = nums[j];
                        nums[j] = temp;
                        nums[i].Equals(null);
                    }
                }                
            }
            IList<int> indicesList = new List<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == target)
                {
                    indicesList.Add(i);
                   
                }
            }
            
           
            return indicesList;
        }
        public static int[] CreateTargetArray(int[] nums, int[] index)
        {
            int[] target = new int[nums.Length];
            for (int i = 0; i < index.Length; i++)
            {
                if (target[index[i]].Equals(null))
                {
                    target[index[i]] = nums[i];
                }
                else
                {
                    int indexNull = new int();
                    for (int j = index[i] + 1; j < target.Length; j++)
                    {
                        if (target[j].Equals(null))
                        {
                            indexNull = j;
                            break;
                        }
                    }
                    for (int z = indexNull; z < target.Length && z > index[i]; z--)
                    {
                        target[z] = target[z - 1];
                    }
                    target[index[i]] = nums[i];
                }
            }
            return target;
        }
        public string Interpret(string command)
        {
            //char[] A = new char[command.Length];
            //int j = 0;
            StringBuilder B = new StringBuilder();
            //List<string> B = new List<string>();

            for (int i = 0; i < command.Length; /*increment will be placed in loop*/)
            {
                if (command[i] == 'G')
                {
                    B.Append('G');
                    i++;
                }
                else if (command[i] == '(' && command[i + 1] == ')')
                {
                    B.Append('o');
                    i += 2;
                }
                else
                {
                    B.Append('a');
                    B.Append('l');
                    i += 4;
                }
            }
            return B.ToString();
        }
        public static int BalancedStringSplit(string s)
        {
            char[] A = s.ToCharArray();
            int count = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] == 'R')
                {
                    int R = 1;
                    int L = 0;
                    while (L <= R)
                    {
                        for (int j = i + 1; j < A.Length; j++)
                        {
                            if (A[j] == 'L')
                            {
                                L++;
                            }
                            else
                                R++;
                        }
                    }
                    count++;
                }
                else
                {

                    if (A[i] == 'L')
                    {
                        int R = 0;
                        int L = 1;
                        while (R <= L)
                        {
                            for (int j = i + 1; j < A.Length; j++)
                            {
                                if (A[j] == 'L')
                                {
                                    L++;
                                }
                                else
                                    R++;
                            }
                        }
                        count++;
                    }
                }
            }
            return count;
        }
    }
}
