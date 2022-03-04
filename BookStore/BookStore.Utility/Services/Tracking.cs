using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Utility.Services
{
    public class Tracking
    {
        public static string GenerateNumber()
        {
            Random _random = new();
            int num = _random.Next(1000, 1000000);
            string generateUniqueId = Guid.NewGuid().ToString();
            string uniqueId = generateUniqueId[..8];
            string trackingNumber = string.Format("{0}-{1}", num, uniqueId);

            return trackingNumber;
        }
    }
}
