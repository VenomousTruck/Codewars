// Area or Perimeter

public class MathCheck {
    public static int AreaOrPerimeter(int l, int w) {
        if (l == w)
            return l * w;
        else
            return l * 2 + w * 2;
    }
}