using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrimeService
{
    public class SuperComputer
    {
        public decimal Sum(decimal x, decimal y)
        {
            try
            {
                return x + y;
            }
            catch (Exception ex)
            {
                throw SuperComputerException.OperationHasFailed(nameof(Sum), ex);
            }
        }

        public decimal Sub(decimal x, decimal y)
        {
            try
            {
                return x - y;
            }
            catch (Exception ex)
            {
                throw SuperComputerException.OperationHasFailed(nameof(Sub), ex);
            }
        }

        public decimal Mul(decimal x, decimal y)
        {
            try
            {
                return x * y;
            }
            catch (Exception ex)
            {
                throw SuperComputerException.OperationHasFailed(nameof(Mul), ex);
            }
        }

        public decimal Div(decimal x, decimal y)
        {
            try
            {
                return x / y;
            }
            catch (Exception ex)
            {
                throw SuperComputerException.OperationHasFailed(nameof(Div), ex);
            }
        }

        public bool IsSuperior(decimal x, decimal y)
        {
            return x > y;
        }

        public bool IsInferior(decimal x, decimal y)
        {
            return x < y;
        }

        public bool IsEquals(decimal x, decimal y)
        {
            return x == y;
        }
    }
}