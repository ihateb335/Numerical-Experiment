    // Тестові функції Бесселя першого роду Jn(x)

    public static double BF_J_test1(int n, double x)
    {
      double p = 1.0, s = 1.0, z = x * 0.5, t = 0.0;
      while (Math.Abs(p) > 1.0E-17)
      {
        t += 1.0; p *= -(z / t) * (z / (t + n)); s += p;
      }
      for (int i = 1; i <= n; i++) s *= z / i;
      return s;
    }
