using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using WrapperExample;
using Assert = NUnit.Framework.Assert;

namespace WrapperExampleTests
{
    [TestClass]
    public class ProcessorTests
    {
        private VirtualEnhancedSeatMapClientWrapper clientWrapper;
        private Processor processor;

        [SetUp]
        public void SetUp()
        {
            EnhancedSeatMapRS seatMapRs = new EnhancedSeatMapRS();
            var clientWrapper = new VirtualEnhancedSeatMapClientWrapper(seatMapRs);
            processor = new Processor(clientWrapper);
        }

        [Test]
        public void SeatMap_ReturnsNonEmptySeatMapResponse()
        {
            var seatMapRequest = new SeatMapRequest();
            var seatMapResponse = processor.SeatMap(seatMapRequest);
            Assert.IsNotNull(seatMapResponse);
        }
    }

    public class VirtualEnhancedSeatMapClientWrapper : IEnhancedSeatMapClient
    {
        private readonly EnhancedSeatMapRS response;
        public bool EnhancedSeatMapInvoked;

        public VirtualEnhancedSeatMapClientWrapper(EnhancedSeatMapRS response)
        {
            this.response = response;
        }

        public EnhancedSeatMapRS EnhancedSeatMap(EnhancedSeatMapRQ enhancedSeatMapRequest)
        {
            EnhancedSeatMapInvoked = true;
            return response;
        }
    }
}
