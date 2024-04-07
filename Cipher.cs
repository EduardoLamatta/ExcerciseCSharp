using System;


namespace ProgramaDesencriptar
{
    class Desencriptar
    {
        //Ejercicio extraido de BamtangGames.com

        static void Main(string[] args)
        {
            string statement = "Bgc-bfufb tegaedppqna ql aggv zge xof tegaedppfe'l lgjb.\r\n\r\nXof adpf vflqanfe logjbvn'x hf pdwqna d cgebv qn coqro xof tbdkfe ql mjlx d lpdbb tdex. Xof tbdkfe QL XOF HGLL; qx'l kgje vjxk xg fnxfexdqn oqp ge ofe.\r\n\r\nZgrjl ql d pdxxfe gz vfrqvqna codx xoqnal kgj def ngx agqna xg vg.\r\n\r\nXof rglx gz dvvqna d zfdxjef qln'x mjlx xof xqpf qx xdwfl xg rgvf qx. Xof rglx dblg qnrbjvfl xof dvvqxqgn gz dn ghlxdrbf xg zjxjef fstdnlqgn. Xof xeqrw ql xg tqrw xof zfdxjefl xodx vgn'x zqaox fdro gxofe. - Mgon Rdepdrw.\r\n\r\n(ccc.adpdljxed.rgp/uqfc/nfcl/234346?utkjpvbjr)\r\n\r\n(ccc.hedqnkijgxf.rgp/ijgxfl/djxogel/m/mgon_rdepdrw.oxpb)";
            List<char> listChars = new List<char>(statement);
            String[] invalidChars = new string[] { " ", "-", "_", ",", ";", ".", "/", "(", ")", "\r", "\n", "3", "4", "'", "?", "0", "2", "6" , "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"};
            Dictionary<string, int > dictNumbers = new Dictionary<string, int>();
            //string freqLang = "TEOAISRHNUCMDLGWFPYKJBVQX";
            string message = string.Empty;

            //List<char> freqLangList = new List<char>(freqLang);

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

            foreach(char ch in statement)
            {   
                if (ch == 'x' || ch == 'X')
                {
                    message += 't';
                }
                
                else if (ch == 'f' || ch == 'F')
                {
                    message += 'e';
                }
                else if (ch == 'g' || ch == 'G')
                {
                    message += 'o';
                }
                else if (ch == 'd' || ch == 'D')
                {
                    message += 'a';
                }
                else if (ch == 'q' || ch == 'Q')
                {
                    message += 'i';
                }
                else if (ch == 'e' || ch == 'E')
                {
                    message += 'r';
                }
                else if (ch == 'l' || ch == 'L')
                {
                    message += 's';
                }
                else if (ch == 'o' || ch == 'O')
                {
                    message += 'h';
                }
                else if (ch == 'n' || ch == 'N')
                {
                    message += 'n';
                }
                else if (ch == 'j' || ch == 'J')
                {
                    message += 'u';
                }
                else if (ch == 'p' || ch == 'P')
                {
                    message += 'm';
                }
                else if (ch == 'r' || ch == 'R')
                {
                    message += 'c';
                }
                else if (ch == 'v' || ch == 'V')
                {
                    message += 'd';
                }
                else if (ch == 'b' || ch == 'B')
                {
                    message += 'l';
                }
                else if (ch == 'a' || ch == 'A')
                {
                    message += 'g';
                }
                else if (ch == 'c' || ch == 'C')
                {
                    message += 'w';
                }
                else if (ch == 't' || ch == 'T')
                {
                    message += 'p';
                }
                else if (ch == 'z' || ch == 'Z')
                {
                    message += 'f';
                }
                else if (ch == 'k' || ch == 'K')
                {
                    message += 'y';
                }
                else if (ch == 'w' || ch == 'W')
                {
                    message += 'k';
                }
                else if (ch == 'm' || ch == 'M')
                {
                    message += 'j';
                }
                else if (ch == 'u' || ch == 'U')
                {
                    message += 'v';
                }
                else if (ch == 'h' || ch == 'H')
                {
                    message += 'b';
                }
                else if (ch == 'i' || ch == 'I')
                {
                    message += 'q';
                }
                else if (ch == 's' || ch == 'S')
                {
                    message += 'x';
                }
                else
                {
                    message += ch;
                }
            }
            Console.WriteLine(message);


        }


    }
}
