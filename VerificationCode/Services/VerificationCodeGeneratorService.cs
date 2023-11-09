using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerificationCode.Services
{
    public class VerificationCodeGeneratorService
    {
        public string Generate => new Random().Next(10000, 99999).ToString();
    }
}
