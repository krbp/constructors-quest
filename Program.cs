namespace MultipleConstructors
{
    public static class Program
    {
        public static void Main()
        {
            Building firstBuilding = new Building(3, 3);
            Building secondBuilding = new Building(3);
            Console.WriteLine($"{firstBuilding.GetFloorCount()}{secondBuilding.GetFloorCount}");
        }
    }

    public class Building
    {
        private int _floors;
        private int _height;
        public Building(int floors)
        {
            _height = floors * 3;
            _floors = floors;
        }

        public Building(int floors, int height)
        {
            _floors = floors;
            _height = height;
        }

        public int GetFloorMaxSize()
        {
            return _height / _floors;
        }

        public int GetFloorCount()
        {
            return _floors;
        }

        public int GetSize()
        {
            return _height;
        }
    }
}
