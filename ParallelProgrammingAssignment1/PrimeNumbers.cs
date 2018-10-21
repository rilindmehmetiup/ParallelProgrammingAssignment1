using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace ParallelProgrammingAssignment1
{
    public class PrimeNumbers
    {
        public int thread_count = Environment.ProcessorCount;

        protected static IEnumerable<ulong> ValidPrimeTests()
        {
            yield return 2;
            for (ulong n = 3; n < ulong.MaxValue - 1; n += 2)
                yield return n;
        }

        public ParallelQuery<ulong> Values()
        {
            return ValidPrimeTests()
                .AsParallel()
                .WithDegreeOfParallelism(thread_count)
                .AsOrdered()            
                .Where(v => IsPrime(v));
        }

        public bool IsPrime(ulong value)
        {
            switch (value)
            {
                // 0 and 1 are not prime numbers
                case 0:
                    return false;
                case 1:                                  
                case 2:
                case 3:
                    return true;

                default:
                    return value % 2 != 0
                        && value % 3 != 0
                        && IsPrimeInternal(value);
            }

        }

        public bool IsPrime(long value)
        {
            return IsPrime((ulong)Math.Abs(value));
        }



        protected virtual bool IsPrimeInternal(ulong value)
        {
            if (value < 380000)
            {
                // This method is faster up until a point.
                double squared = Math.Sqrt(value);
                ulong flooredAndSquared = Convert.ToUInt64(Math.Floor(squared));

                for (ulong idx = 3; idx <= flooredAndSquared; idx++)
                {
                    if (value % idx == 0)
                    {
                        return false;
                    }
                }
            }
            else
            {
                ulong divisor = 6;
                while (divisor * divisor - 2 * divisor + 1 <= value)
                {

                    if (value % (divisor - 1) == 0)
                        return false;

                    if (value % (divisor + 1) == 0)
                        return false;

                    divisor += 6;
                }
            }



            return true;
        }             
    }
}
