using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WrapperExample
{
    public partial class EnhancedSeatMapPortTypeClient
    {
        // Don't want to have to mark this as "virtual" as this is generated code.
        public EnhancedSeatMapRS EnhancedSeatMap(EnhancedSeatMapRQ EnhancedSeatMapRQ)
        {
            return new EnhancedSeatMapRS();
        }
    }

    public class EnhancedSeatMapRS
    {
        
    }

    public class EnhancedSeatMapRQ
    {
        
    }
}
