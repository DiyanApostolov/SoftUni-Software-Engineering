using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Data
{
    public class DataConstants
    {
        public const int DefaultMaxLength = 20;

        public const int UserMinUsername = 5;
        public const int UserMinPassword = 6;
        public const string UserEmailRegularExpression = @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";

        public const int ProductMinName = 4;
        public const double PriceMinRange = 0.05;
        public const double PriceMaxRange = 1000;
    }
}
