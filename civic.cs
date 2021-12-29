namespace arayuzler_interface_ornek
{
 public class civic : IOtomobil
    {
        public marka HangiMarkanınAracı()
        {
            return marka.Honda ;
        }

        public int kactekerlektenolusur()
        {
            return 4;
        }

        public renk StandartRengiNe()
        {
            return renk.gri;
        }
    }
}