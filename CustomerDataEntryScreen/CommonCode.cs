using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerDataEntryScreen
{
   public class CommonCode
    {
        public bool CheckValidation(string CustomerName) {
            if (CustomerName.Length == 0)
            {
                return false;
            }
            else {
                return true;
            }
        }
    }
}
