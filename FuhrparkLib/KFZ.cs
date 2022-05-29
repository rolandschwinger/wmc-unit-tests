using System;

namespace FUHRPARK_LIB
{
    public class KFZ
    {
        // Members
        protected string m_Marke;
        protected int m_PS;
        // 1. Konstruktor
        public KFZ(string marke)
        {
            m_Marke = marke;
            m_PS = 0;
        }
        // 2. Konstruktor
        public KFZ(string marke, int ps): this(marke)
        {
            m_PS = ps;
        }
        //
        // 2. KONSTRUKTOR: Rückgabe der Objektdaten
        public override string ToString()
        {
            return String.Format("{0}; PS: {1}", m_Marke, m_PS);
        }
        //
        // 3. POLYMORPHISMUS: Rückgabe der Objektdaten
        public virtual string GetSeparateData()
        {
            return String.Format("KFZ: {0}, PS: {1}", m_Marke, m_PS);
        }
        //
        // 4. OOP: Rückgabe der PS-Zahl
        internal int GetPS()
        {
            return m_PS;
        }
    }
}
