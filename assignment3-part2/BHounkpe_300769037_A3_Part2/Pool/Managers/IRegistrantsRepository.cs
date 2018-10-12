namespace PoolLib.Managers
{
    public interface IRegistrantsRepository
    {
        int Number { get; set; }

        void Add(Registrant aRegistrant);
        Registrant GetByRegNum(int regNumber);
        void Load(string fileName, string delimiter);
        void Save(string fileName, string delimiter);
    }
}