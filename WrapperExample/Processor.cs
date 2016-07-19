using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WrapperExample
{
    public class Processor
    {
        private readonly IEnhancedSeatMapClient clientWrapper;

        public Processor(IEnhancedSeatMapClient clientWrapper)
        {
            this.clientWrapper = clientWrapper;
        }

        public virtual SeatMapResponse SeatMap(SeatMapRequest seatMapRequest)
        {
            return new SeatMapResponse();
        }
    }

    public class SeatMapRequest
    {
    }

    public class SeatMapResponse
    {
    }

    public interface IEnhancedSeatMapClient
    {
        EnhancedSeatMapRS EnhancedSeatMap(EnhancedSeatMapRQ enhancedSeatMapRequest);
    }

    public class EnhancedSeatMapClientWrapper : IEnhancedSeatMapClient
    {
        EnhancedSeatMapPortTypeClient client = new EnhancedSeatMapPortTypeClient();

        public EnhancedSeatMapRS EnhancedSeatMap(EnhancedSeatMapRQ enhancedSeatMapRequest)
        {
            return client.EnhancedSeatMap(enhancedSeatMapRequest);
        }
    }
}
