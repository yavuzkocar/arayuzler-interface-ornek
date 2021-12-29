namespace arayuzler_interface_ornek{
    public class focus : IOtomobil
    {
        public marka HangiMarkanınAracı()
        {
            return marka.Ford;
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