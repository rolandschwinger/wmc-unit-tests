using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FUHRPARK_LIB
{
    public class Fuhrpark
    {
        // Members
        private List<KFZ> m_KFZs = new List<KFZ>();
        // Konstruktor
        public Fuhrpark(KFZ[] kfzs)
        {            
            for (int i = 0; i < kfzs.Length; i++)
            {
                m_KFZs.Add(kfzs[i]);
            }
        }

        public KFZ GetByIdx(int index)
        {
            return m_KFZs[index];
        }

        //
        // Ermittle alle KFZs mit Kennzeichen beginend mit kzchar
        public List<KFZ> GetKFZsAus(string bezirk)
        {
            List<KFZ> kfzMitKZ = new List<KFZ>();
            foreach(KFZ kfz in m_KFZs)
            {
                if (kfz is PKW)
                {
                    PKW pkw = (PKW)kfz;
                    string kz = pkw.GetKZ();
                    //string kz = ((PKW)m_KFZs[nr]).GetKZ();

                    if (TestOrigin(kz, bezirk))
                    {
                        kfzMitKZ.Add(kfz);
                    }
                }
            }
            return kfzMitKZ;
        }

        private bool TestOrigin(string kz, string bezirk)
        {
            return kz.ToUpper().StartsWith(bezirk.ToUpper());
        }


        public int GetAnzKfzPS(int ps)
        {
            int anz = 0;
            foreach(KFZ kfz in m_KFZs)
            {
                int psX = kfz.GetPS();
                if (ps <= psX) anz++;
            }
            return anz;
        }

        public LKW GetMaxLoadLKW()
        {
            int max = 0;
            LKW maxLKW = null;

            foreach(KFZ kfz in m_KFZs)
            {
                LKW lkw = kfz as LKW;
                if(lkw != null)
                {
                    if( lkw.GetTonnen() > max)
                    {
                        maxLKW = lkw;
                        max = lkw.GetTonnen();
                    }
                }
            }
            return maxLKW;
        }
    }
}
