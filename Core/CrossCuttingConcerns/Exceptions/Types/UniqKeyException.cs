using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.CrossCuttingConcerns.Exceptions.Types
{
    public class UniqKeyException : Exception
    {
        public UniqKeyException(string? message) : base(message) 
        { 
        }
    }
}