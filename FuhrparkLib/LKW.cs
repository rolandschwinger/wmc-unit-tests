using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FUHRPARK_LIB
{
    public class LKW : PKW
    {
        // Members
        private int m_Tonnen;
        // 1. KOnstrkutor
        public LKW(string marke, int ps, string kz)
            : base(marke, ps, kz)
        {
            m_Tonnen = 0;
        }
        // 2. Konstruktor
        public LKW(string marke, int ps, string kz, int tonnen)
            : this(marke, ps, kz)
        {
            m_Tonnen = tonnen;
        }

        public int GetTonnen()
        {
            return m_Tonnen;
        }

        //
        // 2. KONSTRUKTOR: Rückgabe der Objektdaten
        public override string ToString()
        {
            return String.Format("{0}; Tonnen: {1}", base.ToString(), m_Tonnen);
        }
        //
        // 3. POLYMORPHISMUS: Rückgabe der Objektdaten
        public new string GetSeparateData()
        {
            return String.Format("LKW: {0}, PS: {1}, Kennzeichen: {2}, Tonnen: {3}",
                   m_Marke, m_PS, m_KZ, m_Tonnen);
        }
    }
}
