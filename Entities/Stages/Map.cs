using JewelCollector.Entities.Interfaces;


namespace JewelCollector.Entities.Stages
{
    public abstract class Map : IMap
    {
        public void Alocate(ICell cell, int row, int column)
        {
            throw new NotImplementedException();
        }

        public void Fill()
        {
            throw new NotImplementedException();
        }

        public void Print()
        {
            throw new NotImplementedException();
        }
    }
}