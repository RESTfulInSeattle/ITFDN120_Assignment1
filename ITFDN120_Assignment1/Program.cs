using System;

namespace ITFDN120_Assignment1
{
    class URLShortener
    {
        public static char[] letters = {'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q',
            'u','r','s','t','u','v','w','x','y','z','A','B','C','D','E','F','G','H','I','J','K','L','M','N',
                'O','P','Q','U','R','S','T','U','V','W','X','Y','Z','0','1','2','3','4','5','6','7','8','9'};

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
        public static int Encode(string input)
        {
            int i = 0;
            int encoded=0;

            while(i<input.Length)
            {
                encoded += GetIndex(input[i]) * 10 * (input.Length - i);
                i++;
            }

            return encoded;
        }
        static void Main(string[] args)
        {
            string url = "LpuPe81bc2w";
            string shortenedURL = "";
            
            //Encode the string url into a number based on the indicies of the letters
            int encoded = Encode(url);

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
