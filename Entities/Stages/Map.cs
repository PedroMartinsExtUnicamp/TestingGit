using JewelCollector.Entities.Interfaces;


namespace JewelCollector.Entities.Stages
{
    public abstract class Map : IMap
    {
        public ICell[,]? Cells { get; set; }

        public Map()
        {
            
        }

        public abstract void Fill();

        public void Alocate(ICell cell, int row, int column)
        {
            Cells![row, column] = cell;
        }

        public void Print()
        {
            for(int row=0; row < Cells!.GetLength(0); row++)
            {
                for(int column=0; column < Cells.GetLength(1); column++)
                {
                    Cells[row, column].Print();
                    Console.Write(' ');
                }
                Console.Write("\n");
            }
        }
    }
}