// Growth of a Population

using System;

class Arge {
    public static int NbYear(int p0, double percent, int aug, int p) {
        int time = 0;
        int population = p0;
        percent = percent / 100;  

        while (population <= p) {
            population += (int)(population * percent + aug);
            time++;
        }

        if (percent == 0)
            return time - 1;
        return time;
    }
}