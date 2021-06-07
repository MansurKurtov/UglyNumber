namespace UglyNumber
{
    /// <summary>
    /// Ugly Number
    /// </summary>
    class Program
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            var prg = new Program();
            var result1 = prg.IsUgly(6); // true
            var result2 = prg.IsUgly(8); // true
            var result3 = prg.IsUgly(14); // false
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public bool IsUgly(int n)
        {
            if (n == 0)
                return false;

            n = div(n, 2);
            n = div(n, 3);
            n = div(n, 5);

            return (n == 1) ? true : false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="n"></param>
        /// <param name="d"></param>
        /// <returns></returns>
        private int div(int n, int d)
        {
            while (n % d == 0)
                n = n / d;
            return n;
        }
    }
}
