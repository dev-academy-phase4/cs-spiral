namespace Spiral
{
    public interface IDisplayableCreature
    {
        int DisplayRow { get; set; }
        int DisplayCol { get; set; }
        char Avatar { get; }
        System.ConsoleColor Color { get; }

        void Write();
    }
}
