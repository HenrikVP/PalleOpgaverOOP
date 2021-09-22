namespace PalleOpgaverOOP
{
    //Example of use of abstract class (non instantiable)
    internal abstract class BaseClass
    {
        public int Id { get; set; }
        public string Name {  get; set; }

        //Example of override
        public override string ToString()
        {
            return Name;
        }
    }
}
