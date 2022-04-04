using System;

namespace DataStructureProgram
{ 
    public class PalindromeChecker
    {
        static char[] queue;
        static int top = -1;

        static void enqueue(char ele)
        {
            queue[++top] = ele;
        }

        static char dequeue()
        {
            return queue[top--];
        }

        // Function that returns 1
        // if str is a palindrome
        static int isPalindrome(char[] str)
        {
            int length = str.Length;

            queue = new char[length * 4];

            int i, mid = length / 2;
            for (i = 0; i < mid; i++)
            {
                enqueue(str[i]);
            }

            // Checking if the length of the String
            // is odd, if odd then neglect the
            // middle character
            if (length % 2 != 0)
            {
                i++;
            }

            // While not the end of the String
            while (i < length)
            {
                char ele = dequeue();

                // If the characters differ then the
                // given String is not a palindrome
                if (ele != str[i])
                    return 0;
                i++;
            }
            return 1;
        }
        static void Main(string[] args)
        {
            char[] str = "madam".ToCharArray();

            if (isPalindrome(str) == 1)
            {
                Console.Write("True");
            }
            else
            {
                Console.Write("False");
            }
        }
    }
}


