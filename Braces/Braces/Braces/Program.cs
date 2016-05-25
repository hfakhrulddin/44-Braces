using System;
using System.Collections;

namespace Braces
{
    class Program
    {
        static void Main(string[] args)
        {
            bool Exit = false;
            while (Exit == false)
            {
                var foos1 = Console.ReadLine();
                string[] arr1 = foos1.Split(',');

                for (int i = 0; i < arr1.Length; i++)
                {
                        int Match = isMatch(arr1[i]);
                        Console.WriteLine(Match);
                }
            }
        }

        public static int isMatch(string str)
        {
            Stack s = new Stack();
            Queue q = new Queue();

            bool isRight = true;
            int t = 0;

            char OpeningBracket = ' ';
            char closingBracket = ' ';

            int v = str.Length;
            string data = str.Substring(1, (v - 2));

            char[] character = data.ToCharArray();

            for (int i = 0; i < character.Length; i++)
            {
                if (character[i] == '(' || character[i] == '{' || character[i] == '[')
                {
                    s.Push(character[i]);
                }
                else
                    q.Enqueue(character[i]);
            }

            if (s.Count == 0 || q.Count != s.Count) { return 0; }

                while (s.Count > 0 && q.Count > 0)
                {
                    OpeningBracket = (char)s.Pop();
                    closingBracket = (char)q.Dequeue();
                    if ((    OpeningBracket == '(' && closingBracket != ')')
                         || (OpeningBracket == '[' && closingBracket != ']')
                         || (OpeningBracket == '{' && closingBracket != '}')
                        )
                    {
                        isRight = false;
                    }
                }
            
                if (isRight)
                { return 1; }

            else if (isRight == false)
            {
                for (int x = 0; x < (character.Length) - 2; x++)
                {
                    for (int y = x + 1; y < (character.Length) - 1; y = y+2)
                    {
                        if ((character[x] == ')') || (character[x] == '}') || (character[x] == ']')) { return 0; }

                        else if (
                        (   character[x] == '(' && character[y] == ')')
                        || (character[x] == '[' && character[y] == ']')
                        || (character[x] == '{' && character[y] == '}')
                        )
                        {
                            character[y] = 'x';
                            t++;
                            break;
                        }
                        else { break; }
                    }
                    if (t > 0) { continue; } else { return 0; }
                }
                 { return 1; }
            }
                 { return 1; }
        }
    }
}

//public static int isMatch(string str1)
//{
//    int v = str1.Length;
//    string str2 = str1.Substring(1, (v-2));
//    char[] arr1 = str2.ToCharArray();
//    int t = 0;

//    //string sub1 = str2.Substring(1, ((v / 2) - 1));
//    //string sub2 = str2.Substring((v / 2), ((v / 2) - 1));

//    //char[] process1 = sub1.ToCharArray();
//    //char[] process2 = sub2.ToCharArray();
//    //Array.Reverse(process2);

//    //if ((arr1[0] == ')') || (arr1[0] == '}') || (arr1[0] == ']'))
//    //   { return 0; }

//    //else if (process1 == process2)
//    //        { return 1; }


//        for (int x = 0; x < (arr1.Length) - 2; x++)
//        {
//            for (int y = x+1; x < (arr1.Length) - 1; y = +2)
//            {
//            if ((arr1[x] == ')') || (arr1[x] == '}') || (arr1[x] == ']')) { return 0; }

//            else if (arr1[x] == 'x') { break; }
//            else if (arr1[x] == arr1[y])
//                    {
//                        arr1[y] = 'x';
//                        break;
//                    }
//                    else { t++; }
//                }
//            }
//     if (t > 0) { return 0; } else { return 1; } 

