namespace Spiral
{
    public interface IDisplayableCreature
    {
        int DisplayRow { get; set; }
        int DisplayCol { get; set; }
        char Avatar { get; set; }
        System.ConsoleColor Color { get; set; }
        bool Vanquished { get; set; }

        void DisplayDefeatedForm ();
        void Write ();
    }
}
