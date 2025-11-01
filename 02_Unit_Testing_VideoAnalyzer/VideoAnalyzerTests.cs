using Microsoft.VisualStudio.TestTools.UnitTesting;
using VideoSurveillance; 

namespace VideoSurveillance.Tests
{
    [TestClass]
    public class VideoAnalyzerTests
    {
        [TestMethod]
        public void DetectMotion_ReturnsTrue_WhenFramesAreDifferent()
        {
            var analyzer = new VideoAnalyzer();
            byte[] frame1 = { 0, 0, 0 };
            byte[] frame2 = { 0, 255, 0 };

            bool result = analyzer.DetectMotion(frame1, frame2);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void DetectMotion_ReturnsFalse_WhenFramesAreSame()
        {
            var analyzer = new VideoAnalyzer();
            byte[] frame1 = { 1, 1, 1 };
            byte[] frame2 = { 1, 1, 1 };

            bool result = analyzer.DetectMotion(frame1, frame2);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsFrameEmpty_ReturnsTrue_WhenAllBytesAreZero()
        {
            var analyzer = new VideoAnalyzer();
            byte[] frame = { 0, 0, 0, 0 };

            bool result = analyzer.IsFrameEmpty(frame);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsFrameEmpty_ReturnsFalse_WhenAnyByteIsNotZero()
        {
            var analyzer = new VideoAnalyzer();
            byte[] frame = { 0, 0, 1, 0 };

            bool result = analyzer.IsFrameEmpty(frame);

            Assert.IsFalse(result);
        }
    }
}
