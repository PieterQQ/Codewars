using System;

class Arge {
    
    public static int NbYear(int p0, double percent, int aug, int p) {
         int year;
        for (year = 0; p0  p; year++)
          p0 += (int)(p0percent100) + aug;
        return year;
    }
}