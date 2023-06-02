using JewelCollector.Entities.Interfaces;
using JewelCollector.Entities.Jewels;
using JewelCollector.Entities.Obstacles;

namespace JewelCollector.Entities.Stages
{
    public class TestStage : Map
    {

        public TestStage()
        {
            Cells = new ICell[10, 10];
        }

        public override void Fill()
        {
            for(int row=0; row < 10; row++)
            {
                for(int column=0; column < 10; column++)
                {
                    Alocate(new Empty(), row, column);
                }
            }

            Alocate(new RedJewel(), 2, 2);
            Alocate(new GreenJewel(), 2, 3);
            Alocate(new BlueJewel(), 2, 4);
            Alocate(new Tree(), 3, 3);
            Alocate(new Water(), 3, 2);
            Alocate(new Water(), 3, 4);
        }
    }
}