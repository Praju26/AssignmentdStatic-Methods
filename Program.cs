using System;

namespace AssignmentdStatic_Methods
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Compare To");
            string s1 = "hello";
            string s2 = "hello";
            string s3 = "csharp";
            Console.WriteLine(s1.CompareTo(s2));
            Console.WriteLine(s2.CompareTo(s3));

            Console.WriteLine("Compare");
            Console.WriteLine(string.Compare(s1, s2));
            Console.WriteLine(string.Compare(s2, s3));

            Console.WriteLine("Compare Ordinal");
            Console.WriteLine(string.CompareOrdinal(s1, s2));
            Console.WriteLine(string.CompareOrdinal(s1, s3));

            Console.WriteLine("Compare To");
            Console.WriteLine(s1.CompareTo(s2));
            Console.WriteLine(s2.CompareTo(s3));

            Console.WriteLine(" Contains");
            Console.WriteLine(s1.Contains(s2));
            Console.WriteLine(s1.Contains(s3));

            Console.WriteLine("GetType");
            Console.WriteLine(s1.GetType());

            Console.WriteLine("CopyTo");
            char[] ch = new char[15];
            s1.CopyTo(10, ch, 0, 12);
            Console.WriteLine(ch);

            Console.WriteLine("Endswich");
            Console.WriteLine(s1.EndsWith(s2));
            Console.WriteLine(s1.EndsWith(s3));

            Console.WriteLine("Equals");
            Console.WriteLine(s1.Equals(s2));
            Console.WriteLine(s1.Equals(s3));

            Console.WriteLine("GetType ");
            Console.WriteLine(s1.GetHashCode());
            Console.WriteLine(s1.GetType());
            Console.WriteLine(s1.GetTypeCode());

            Console.WriteLine("IndexOf");
            int index = s1.IndexOf('e');
            Console.WriteLine(index);

            string S3 = s1.Insert(5, "-");
            Console.WriteLine(S3);

            string S25 = string.Intern(s1);
            Console.WriteLine(s1);
            Console.WriteLine(S25);

            string S4 = string.Intern(s1);
            string S5 = string.IsInterned(s1);
            Console.WriteLine(S4);
            Console.WriteLine(S5);
          
            string S2 = s1.Remove(2);
            Console.WriteLine(S2);

            string S41 = s1.Replace('F', 'C');
            Console.WriteLine(S41);

           /* string[] S2 = s1.Split(' ');
            foreach (string S3 in s2)
            {
                string s2 = s1.Normalize();
            }*/

            Console.WriteLine(s2);
            bool b1 = string.IsNullOrEmpty(s1);
            bool b2 = string.IsNullOrEmpty(s2);
            Console.WriteLine(b1);
            Console.WriteLine(b2);

            string S8 = "Hello C#";
            string S9 = " ";
            string S10 = " 0";
            bool b= string.IsNullOrWhiteSpace(S8);
            bool bo1 = string.IsNullOrWhiteSpace(S9);
            bool bo2 = string.IsNullOrWhiteSpace(S10);
            Console.WriteLine(b);
            Console.WriteLine(bo1);
            Console.WriteLine(bo2);

            bool b5 = string.IsNullOrWhiteSpace(s1);
            bool b6 = string.IsNullOrWhiteSpace(s2);
            bool b7 = string.IsNullOrWhiteSpace(s3);
            Console.WriteLine(b5);
            Console.WriteLine(b6);
            Console.WriteLine(b7);

            string[] S11 = { "Hello", "C#", "by", "javatpoint" };
            string S12 = string.Join("-", S11);
            Console.WriteLine(S12);

            int index1 = s1.LastIndexOf('l');
            Console.WriteLine(index1);

            string S24 = "abracadabra";
            char[] ch1 = { 'r', 'b' };
            int index2 = S24.LastIndexOfAny(ch1);
            Console.WriteLine(index2);

            string S13 = "Hello C#";
            string S14 = S13.PadLeft(10);
            Console.WriteLine(S13);
            Console.Write(S14);
            Console.Write("JavaTpoint");

            bool b8 = s1.IsNormalized();
            Console.WriteLine(s1);
            Console.WriteLine(b8);

            string S15 = s1.Trim();
            Console.WriteLine(S15);

            string S16 = s1.ToLowerInvariant();
            Console.WriteLine(S16);

            string S17 = s1.TrimEnd(ch);
            Console.WriteLine(S17);

            string S18 = s1.TrimStart(ch);
            Console.WriteLine(S18);

            string S19 = string.Format("{0:D}", DateTime.Now);
            Console.WriteLine(S19);

            /*CharEnumerator ch2 = s2.GetEnumerator();
            while (ch.MoveNext())
            {
                Console.WriteLine(ch.Current);
           }

            Console.WriteLine(string.Concat(s1, s2));*/


            string S20 = "Hello C Sharp";
            bool b9 = S20.StartsWith("h");
            bool b10 = S20.StartsWith("H");
            Console.WriteLine(b9);
            Console.WriteLine(b10);

            string S21 = "Hello C Sharp";
            string S22 = S21.Substring(52);
            Console.WriteLine(S22);

            string S23 = "Hello C#";
            char[] ch3 = S23.ToCharArray();
            foreach (char c in ch3)
            {
                Console.WriteLine(c);
            }
            string S27 = S24.ToLower();
            Console.WriteLine(S27);

            string S30 = s1.ToLowerInvariant();
            Console.WriteLine(S30);

            string S28 = "Hello C#";
            int a = 123;
            string S29 = S28.ToString();
            string S40 = a.ToString();
            Console.WriteLine(S29);
            Console.WriteLine(S40);

            string S31 = "Hello C#";
            string S32 = S31.ToUpper();
            Console.WriteLine(S32);

            string S33 = "Hello C#";
            string S34 = S33.ToUpperInvariant();
            Console.WriteLine(S34);

        }


    }
}

