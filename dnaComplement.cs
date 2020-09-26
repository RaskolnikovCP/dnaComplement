public string dnaComplement(string s)
        {
            char[] charArray = s.ToCharArray();

            Array.Reverse(charArray);

            string s1 = new string(charArray);

            //string s2 = "";

            StringBuilder sb = new StringBuilder(s1);
            
            for (int i = 0; i < sb.Length; i++)
            {
                if (sb[i] == 'G')
                {
                    sb[i] = 'C';
                }
                else if (sb[i] == 'C')
                {
                    sb[i] = 'G';
                }
                else if (sb[i] == 'A')
                {
                    sb[i] = 'T';
                }
                else if (sb[i] == 'T')
                {
                    sb[i] = 'A';
                }
            }

            //string s1 = string.Join("", charArray);

            string s2 = sb.ToString();

            return s2;

        }

        public static void Main(string[] args)
        {

            Program prg = new Program();

            string s = "AAATTGCCC";

            Console.WriteLine(prg.dnaComplement(s));

            Console.ReadKey();
            
        }
