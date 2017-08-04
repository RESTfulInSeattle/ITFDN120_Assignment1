using System;

namespace ITFDN120_Assignment1
{
    class URLShortener
    {
        public static char[] letters = {'0','1','2','3','4','5','6','7','8','9','A','B','C','D','E','F','G','H','I','J','K','L','M','N',
                'O','P','Q','U','R','S','T','U','V','W','X','Y','Z','a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q',
            'u','r','s','t','u','v','w','x','y','z'};

        //Given a letter, return its index in the char array of letters
        public static int GetIndex(char letter)
        {
            for(int i = 0; i<letters.Length; i++)
            {
                if (letters[i] == letter) return i;
            }

            return 0;
        }
        
        //Takes a string, and returns the number comprised of the indicies of the letters
        public static long Encode(string input)
        {
            int i = 0;
            long encoded=0;

            while(i<input.Length)
            {
                encoded = encoded*62 + GetIndex(input[i]);
                i++;
            }

            return encoded;
        }
        static void Main(string[] args)
        {
            string url = "LpuPe81bc2w";
            string shortenedURL = "";
            
            //Encode the string url into a number based on the indicies of the letters
            long encoded = Encode(url);

            while(encoded>0)
            {
                //Add the remainder of a base 62 division to the shortenedURL
                shortenedURL = GetIndex((char)(encoded % 62)) + shortenedURL;
                encoded = encoded / 62;
            }

            Console.WriteLine(shortenedURL);
            Console.ReadLine();
        }
    }
}
