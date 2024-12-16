namespace Assignment7._1._2
{
    //You are given two strings word1 and word2. Merge the strings by adding letters in alternating order, starting with word1.
    //If a string is longer than the other, append the additional letters onto the end of the merged string.
    //Return the merged string.
    internal class Program
    {
        static void Main(string[] args)
        {
            string word1 = "abc";
            string word2 = "pqrs";

            //call the MergeStrings method
            string mergedString = MergeStrings(word1, word2);

            //print the merged string
            Console.WriteLine("Merged String: " + mergedString);
        }

        //method to merge two strings
        public static string MergeStrings(string word1, string word2)
        {
            string result = "";
            int i = 0, j = 0;

            //add characters in alternating order
            while (i < word1.Length && j < word2.Length)
            {
                result += word1[i];
                result += word2[j];
                i++;
                j++;
            }

            //add the rest of the characters from word1
            while (i < word1.Length)
            {
                result += word1[i];
                i++;
            }

            //add the rest of the characters from word2
            while (j < word2.Length)
            {
                result += word2[j];
                j++;
            }

            return result;
        }
    }
}
