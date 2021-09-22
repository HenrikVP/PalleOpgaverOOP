namespace PalleOpgaverOOP
{
    //Example of Inheritance from BaseClass and Polymorphism (override)
    internal class Course : BaseClass
    {
        public string Classroom { get; set; }
        public Teacher Teacher {  get; set; }

        //Example of override that overrides an override from BaseClass
        public override string ToString()
        {
            return $"Course: {Name} ({Id}) Room: {Classroom} Teacher: {Teacher}";
        }
    }
}