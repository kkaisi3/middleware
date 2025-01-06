namespace Adventure
{
    public class Adventurer
    {
        public enum ClassType
        {
            Warrior,
            Rouge,
            Mage
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public ClassType FightingClass { get; set; }
        public int Level { get; set; } = 1;

        public int XP { get; set; } = 0;

    
    public Adventurer(string name, ClassType fightingClass)
        {
            Name = name;
            FightingClass = fightingClass;
        }
    }
}
