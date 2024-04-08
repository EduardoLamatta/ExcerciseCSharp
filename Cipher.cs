using System;


namespace DecryptorProgram
{
    class Decryptor
    {
        //Exercise from BamtangGames.com

        static void Main(string[] args)
        {
            string statement = "Bgc-bfufb tegaedppqna ql aggv zge xof tegaedppfe'l lgjb.\r\n\r\nXof adpf vflqanfe logjbvn'x hf pdwqna d cgebv qn coqro xof tbdkfe ql mjlx d lpdbb tdex. Xof tbdkfe QL XOF HGLL; qx'l kgje vjxk xg fnxfexdqn oqp ge ofe.\r\n\r\nZgrjl ql d pdxxfe gz vfrqvqna codx xoqnal kgj def ngx agqna xg vg.\r\n\r\nXof rglx gz dvvqna d zfdxjef qln'x mjlx xof xqpf qx xdwfl xg rgvf qx. Xof rglx dblg qnrbjvfl xof dvvqxqgn gz dn ghlxdrbf xg zjxjef fstdnlqgn. Xof xeqrw ql xg tqrw xof zfdxjefl xodx vgn'x zqaox fdro gxofe. - Mgon Rdepdrw.\r\n\r\n(ccc.adpdljxed.rgp/uqfc/nfcl/234346?utkjpvbjr)\r\n\r\n(ccc.hedqnkijgxf.rgp/ijgxfl/djxogel/m/mgon_rdepdrw.oxpb)";
            List<char> listChars = new List<char>(statement);
            String[] invalidChars = new string[] { " ", "-", "_", ",", ";", ".", "/", "(", ")", "\r", "\n", "3", "4", "'", "?", "0", "2", "6", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
            Dictionary<string, int> dictNumbers = new Dictionary<string, int>();
            Dictionary<string, int> dictLetters = new Dictionary<string, int>();
            string message = string.Empty;

            int repeatCounter = 0, invalidCounter = 0;

            foreach (char c in listChars)
            {
                for (int i = 0; i < listChars.Count; i++)
                {
                    if (c == listChars[i]) repeatCounter++;
                }
                for (int i = 0; i < invalidChars.Length; i++)
                {
                    if (c.ToString() == invalidChars[i]) invalidCounter++;
                }

                if (!dictNumbers.ContainsKey(c.ToString()) && invalidCounter == 0)
                {
                    dictNumbers.Add(c.ToString(), repeatCounter);
                }

                repeatCounter = 0;
                invalidCounter = 0;
            }

            var orderValues = dictNumbers.OrderByDescending(pair => pair.Value);


            Dictionary<char, char> dictLetters = new Dictionary<char, char>()
            {
                {'x', 't'}, {'X', 'T'}, {'f', 'e'}, {'F', 'E'}, {'g', 'o'}, {'G', 'O'}, {'d', 'a'}, {'D', 'A'},
                {'q', 'i'}, {'Q', 'I'}, {'e', 'r'}, {'E', 'R'}, {'l', 's'}, {'L', 'S'}, {'o', 'h'}, {'O', 'H'},
                {'n', 'n'}, {'N', 'N'}, {'j', 'u'}, {'J', 'U'}, {'p', 'm'}, {'P', 'M'}, {'r', 'c'}, {'R', 'C'},
                {'v', 'd'}, {'V', 'D'}, {'b', 'l'}, {'B', 'L'}, {'a', 'g'}, {'A', 'G'}, {'c', 'w'}, {'C', 'W'},
                {'t', 'p'}, {'T', 'P'}, {'z', 'f'}, {'Z', 'F'}, {'k', 'y'}, {'K', 'Y'}, {'w', 'k'}, {'W', 'K'},
                {'m', 'j'}, {'M', 'J'}, {'u', 'v'}, {'U', 'V'}, {'h', 'b'}, {'H', 'B'}, {'i', 'q'}, {'I', 'Q'},
                {'s', 'x'}, {'S', 'X'}
            };


            foreach (char ch in statement)
            {
                if (dictLetters.TryGetValue(ch, out var value))
                {
                    message += value;
                }
                else message += ch;
            }

        }
            Console.WriteLine(message);


        }


    }
}
