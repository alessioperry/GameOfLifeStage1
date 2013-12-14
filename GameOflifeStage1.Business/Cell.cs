using System.Collections.Generic;
using System.Linq;

namespace GameOflifeStage1.Business
{
    public class Cell
    {
        private IEnumerable<Cell> neighbours;
        private State state;

        public Cell()
        {

        }


        public State Tick()
        {
            var result = neighbours.Count(cell => cell.state == State.Alive);

            if (result == 2 || result == 3)
                return State.Alive;

            return State.Dead;
        }

    }

    public enum State
    {
        Alive,
        Dead,
    }
}