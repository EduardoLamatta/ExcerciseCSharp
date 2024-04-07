using System;


namespace ProgramaDesencriptar
{
    class Desencriptar
    {
        static void Main(string[] args)
        {
            string enunciado = "Bgc-bfufb tegaedppqna ql aggv zge xof tegaedppfe'l lgjb.\r\n\r\nXof adpf vflqanfe logjbvn'x hf pdwqna d cgebv qn coqro xof tbdkfe ql mjlx d lpdbb tdex. Xof tbdkfe QL XOF HGLL; qx'l kgje vjxk xg fnxfexdqn oqp ge ofe.\r\n\r\nZgrjl ql d pdxxfe gz vfrqvqna codx xoqnal kgj def ngx agqna xg vg.\r\n\r\nXof rglx gz dvvqna d zfdxjef qln'x mjlx xof xqpf qx xdwfl xg rgvf qx. Xof rglx dblg qnrbjvfl xof dvvqxqgn gz dn ghlxdrbf xg zjxjef fstdnlqgn. Xof xeqrw ql xg tqrw xof zfdxjefl xodx vgn'x zqaox fdro gxofe. - Mgon Rdepdrw.\r\n\r\n(ccc.adpdljxed.rgp/uqfc/nfcl/234346?utkjpvbjr)\r\n\r\n(ccc.hedqnkijgxf.rgp/ijgxfl/djxogel/m/mgon_rdepdrw.oxpb)";
            List<char> lista = new List<char>(enunciado);
            String[] invalidChars = new string[] { " ", "-", "_", ",", ";", ".", "/", "(", ")", "\r", "\n", "3", "4", "'", "?", "0", "2", "6" , "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M",
    "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"};
            Dictionary<string, int > dictNumbers = new Dictionary<string, int>();
            //string freqLang = "TEOAISRHNUCMDLGWFPYKJBVQX";
            string mensaje = string.Empty;

            //List<char> freqLangList = new List<char>(freqLang);

            int count = 0, count_2 = 0;

            foreach (char c in lista)
            {
                for (int i = 0; i < lista.Count; i++)
                {
                    if (c == lista[i]) count++;
                }
                for (int i = 0; i < invalidChars.Length; i++)
                {
                    if (c.ToString() == invalidChars[i]) count_2++;
                }

                if (!dictNumbers.ContainsKey(c.ToString()) && count_2 == 0)
                {
                    dictNumbers.Add(c.ToString(), count);
                }
                
                count = 0;
                count_2 = 0;
            }
            
            var valoresOrdenados = dictNumbers.OrderByDescending(pair => pair.Value);

          /* Console.WriteLine(dictNumbers.Count);

            foreach (var par in valoresOrdenados)
            {
                Console.WriteLine($"Clave: {par.Key}, Valor: {par.Value}");
            }*/


            foreach(char ch in enunciado)
            {   
                if (ch == 'x' || ch == 'X')
                {
                    mensaje += 't';
                }
                
                else if (ch == 'f' || ch == 'F')
                {
                    mensaje += 'e';
                }
                else if (ch == 'g' || ch == 'G')
                {
                    mensaje += 'o';
                }
                else if (ch == 'd' || ch == 'D')
                {
                    mensaje += 'a';
                }
                else if (ch == 'q' || ch == 'Q')
                {
                    mensaje += 'i';
                }
                else if (ch == 'e' || ch == 'E')
                {
                    mensaje += 'r';
                }
                else if (ch == 'l' || ch == 'L')
                {
                    mensaje += 's';
                }
                else if (ch == 'o' || ch == 'O')
                {
                    mensaje += 'h';
                }
                else if (ch == 'n' || ch == 'N')
                {
                    mensaje += 'n';
                }
                else if (ch == 'j' || ch == 'J')
                {
                    mensaje += 'u';
                }
                else if (ch == 'p' || ch == 'P')
                {
                    mensaje += 'm';
                }
                else if (ch == 'r' || ch == 'R')
                {
                    mensaje += 'c';
                }
                else if (ch == 'v' || ch == 'V')
                {
                    mensaje += 'd';
                }
                else if (ch == 'b' || ch == 'B')
                {
                    mensaje += 'l';
                }
                else if (ch == 'a' || ch == 'A')
                {
                    mensaje += 'g';
                }
                else if (ch == 'c' || ch == 'C')
                {
                    mensaje += 'w';
                }
                else if (ch == 't' || ch == 'T')
                {
                    mensaje += 'p';
                }
                else if (ch == 'z' || ch == 'Z')
                {
                    mensaje += 'f';
                }
                else if (ch == 'k' || ch == 'K')
                {
                    mensaje += 'y';
                }
                else if (ch == 'w' || ch == 'W')
                {
                    mensaje += 'k';
                }
                else if (ch == 'm' || ch == 'M')
                {
                    mensaje += 'j';
                }
                else if (ch == 'u' || ch == 'U')
                {
                    mensaje += 'v';
                }
                else if (ch == 'h' || ch == 'H')
                {
                    mensaje += 'b';
                }
                else if (ch == 'i' || ch == 'I')
                {
                    mensaje += 'q';
                }
                else if (ch == 's' || ch == 'S')
                {
                    mensaje += 'x';
                }
                else
                {
                    mensaje += ch;
                }
            }
            Console.WriteLine(mensaje);


        }


    }
}
