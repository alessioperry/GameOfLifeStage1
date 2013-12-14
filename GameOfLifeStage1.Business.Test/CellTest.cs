using GameOflifeStage1.Business;
using NUnit.Framework;

namespace GameOfLifeStage1.Business.Test
{
    [TestFixture]
    public class CellTest
    {

        public Cell sut;

        [SetUp]
        public void SetUp()
        {
            sut = new Cell();
        }

        [TearDown]
        public void TearDown()
        {
            sut = null;
        }

        [Test]
        public void EachAliveCellDeadIfItHaveLessThenTwoAliveNeighbours()
        {
            Assert.AreEqual(sut.Tick(), State.Dead);
        }

        [Test]
        public void EachAliveCellDeadIfItHaveMuchThenTreeAliveNeighbours()
        {
            Assert.AreEqual(sut.Tick(), State.Dead);
        }

        [Test]
        public void EachAliveCellRemainAliveIfHeHadTworTreeAliveNeighbours()
        {
            Assert.AreEqual(sut.Tick(), State.Alive);
        }
    }
}