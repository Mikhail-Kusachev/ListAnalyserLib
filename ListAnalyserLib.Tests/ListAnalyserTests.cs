namespace ListAnalyserLib.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void FindElementsForSum_BaseTest1()
        {

            //Arrange
            int start = 0;
            int end = 0;

            int expected_start = 5;
            int expected_end = 7;

            ListAnalyser listAnalyser = new ListAnalyser();

            //Act
            listAnalyser.FindElementsForSum(new List<uint> { 0, 1, 2, 3, 4, 5, 6, 7 }, 11, out start, out end);

            //Assert
            if   ((start == expected_start) && (end == expected_end)) Assert.Pass();
            else Assert.Fail();
        }

        [Test]
        public void FindElementsForSum_BaseTest2()
        {

            //Arrange
            int start = 0;
            int end = 0;

            int expected_start = 1;
            int expected_end = 4;

            ListAnalyser listAnalyser = new ListAnalyser();

            //Act
            listAnalyser.FindElementsForSum(new List<uint> { 4, 5, 6, 7 }, 18, out start, out end);

            //Assert
            if   ((start == expected_start) && (end == expected_end)) Assert.Pass();
            else Assert.Fail();
        }

        [Test]
        public void FindElementsForSum_BaseTest3()
        {

            //Arrange
            int start = 0;
            int end = 0;

            int expected_start = 0;
            int expected_end = 0;

            ListAnalyser listAnalyser = new ListAnalyser();

            //Act
            listAnalyser.FindElementsForSum(new List<uint> { 0, 1, 2, 3, 4, 5, 6, 7 }, 88, out start, out end);

            //Assert
            if   ((start == expected_start) && (end == expected_end)) Assert.Pass();
            else Assert.Fail();
        }
       
        [Test]
        public void FindElementsForSum_BaseTest4()
        {

            //Arrange
            int start = 0;
            int end = 0;

            int expected_start = 2;
            int expected_end = 3;

            ListAnalyser listAnalyser = new ListAnalyser();

            //Act
            listAnalyser.FindElementsForSum(new List<uint> { 0, 1, 2, 3, 4, 5, 6, 7 }, 2, out start, out end);

            //Assert
            if ((start == expected_start) && (end == expected_end)) Assert.Pass();
            else Assert.Fail();
        }

        [Test]
        public void FindElementsForSum_InputTest1()
        {

            //Arrange
            int start = 0;
            int end = 0;

            ListAnalyser listAnalyser = new ListAnalyser();

            //Act
            listAnalyser.FindElementsForSum(null, 2, out start, out end);

            //Assert
            Assert.Pass();
        }
    }
}