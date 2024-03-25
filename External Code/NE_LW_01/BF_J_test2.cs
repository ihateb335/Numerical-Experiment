    public static double BF_J_test2(int n, double x)
    {
      if (x < 20)
      {
        double p = 1.0, s = 1.0, z = x * 0.5, t = 0.0;
        while (Math.Abs(p) > 1.0E-17)
        {
          t += 1.0; p *= -(z / t) * (z / (t + n)); s += p;
        }
        for (int i = 1; i <= n; i++) s *= z / i;
        return s;
      }
      else
      {
        double p1 = 1.0, p = 1.0, t = -0.5;
        double q1 = 0.0, s = 1.0, z = 0.5 / x, q;
        while (s > 1.0E-17)
        {
          t += 1.0; q = p * (n - t) * z * (n + t) / (t + 0.5); q1 += q;
          t += 1.0; p = q * (t - n) * z * (n + t) / (t + 0.5); p1 += p;
          s = (Math.Abs(p) + Math.Abs(q)) / 2;
        }
        t = 2 * Math.PI; z = x; while (z > t) z -= t;
        z -= Math.PI * (n + 0.5) * 0.5;
        return Math.Sqrt(4.0 / x / t) * (p1 * Math.Cos(z) - q1 * Math.Sin(z));
      }
    }
