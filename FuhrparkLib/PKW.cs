using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FUHRPARK_LIB
{
    public class PKW: KFZ
    {
        // Members
        protected string m_KZ;
        // 1. Konstruktor
        public PKW(string marke): base(marke)
        {
            m_KZ = "?";
        }
        // 2. Konstruktor
        public PKW(string marke, int ps, string kz): base(marke, ps)
        {
            m_KZ = kz;
        }
        // 
        // 4. OOP: Rückgabe von Kennzeichen
        public string GetKZ()
        {
            return m_KZ;
        }
        //
        // 4. OOP: Rückgabe von Marke
        internal string GetMarke()
        {
            return m_Marke;
        }
        //
        // 2. KONSTRUKTOR: Rückgabe der Objektdaten
        public override string ToString()
        {
            return String.Format("{0}; KZ: {1}", base.ToString(), m_KZ);
        }
        //
        // 3. POLYMORPHISMUS: Rückgabe der Objektdaten
        public override string GetSeparateData()
        {
            return String.Format("Auto: {0}, Kennzeichen: {1}", m_Marke, m_KZ);
        }
    }

}
