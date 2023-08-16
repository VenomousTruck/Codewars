// Century From Year

public static class Kata {
    public static int СenturyFromYear(int year) {
        int age = 100;
        int century = 1;

        for (int i = age; i < year; i += age)
            century++;
        
        return century;
    }
}