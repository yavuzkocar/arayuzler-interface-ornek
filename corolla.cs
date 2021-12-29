namespace arayuzler_interface_ornek{
    public class corolla : IOtomobil
    {
        public marka HangiMarkanınAracı()
        {
            return marka.Toyota ;
        }

        public int kactekerlektenolusur()
        {
            return 4;
        }

        public renk StandartRengiNe()
        {
            return renk.beyaz;
        }
    }
}