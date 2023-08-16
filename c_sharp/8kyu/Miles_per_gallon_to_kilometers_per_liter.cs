// Miles per gallon to kilometers per liter

public static class Kata {
    public static double Converter(int mpg) {
        double kilometer = 1.609344d;
        double litre = 4.54609188d; 
        double kpl = System.Math.Round((kilometer / litre) * mpg, 2) ;

        return kpl;
    }
}