using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachineSpectre
{
    public class TableDraw
    {

        const int topleft = 218, hline = 196, topright = 191, vline = 179, bottomleft = 192, bottomright = 217, cross = 197, topT = 194, bottomT = 193, leftT = 195, rightT = 180;
        const int space = 10, spacer_ex = (space / 2) + 1;
        public void DrawBottom()
        {
            #region bottom
            Write(bottomleft);
            for (int i = 0; i < space; i++)
                Write(hline);
            Write(bottomT);
            for (int i = 0; i < space; i++)
                Write(hline);
            Write(bottomT);
            for (int i = 0; i < space; i++)
                Write(hline);
            Write(bottomright);

            Console.WriteLine();
            #endregion
        }
        public void DrawMiddle()
        {
            #region middle
            Write(leftT);
            for (int i = 0; i < space; i++)
                Write(hline);
            Write(cross);
            for (int i = 0; i < space; i++)
                Write(hline);
            Write(cross);
            for (int i = 0; i < space; i++)
                Write(hline);
            Write(rightT);

            Console.WriteLine();
            #endregion
        }
        public void DrawMidSpacer()
        {
            #region middlespacer
            for (int x = 0; x < spacer_ex; x++)
            {
                Write(vline);
                for (int i = 0; i < space; i++)
                    Console.Write(" ");
                Write(vline);
                for (int i = 0; i < space; i++)
                    Console.Write(" ");
                Write(vline);
                for (int i = 0; i < space; i++)
                    Console.Write(" ");
                Write(vline);

                Console.WriteLine();
            }
            #endregion
        }
        public void DrawTop()
        {
            #region top
            Write(topleft);
            for (int i = 0; i < space; i++)
                Write(hline);
            Write(topT);
            for (int i = 0; i < space; i++)
                Write(hline);
            Write(topT);
            for (int i = 0; i < space; i++)
                Write(hline);
            Write(topright);

            Console.WriteLine();
            #endregion
        }
        public void Write(int charcode)
        {
            Console.Write((char)charcode);
        }
        public void WriteLine(int charcode)
        {
            Console.WriteLine((char)charcode);
        }
    }
}
