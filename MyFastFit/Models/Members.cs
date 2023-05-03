namespace MyFastFit.Models
{
    public class Members
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ShoeSize { get; set; }
        public ShoeType ShoeType { get; set; }

        public Members() { }
        public Members(string name, string shoeSize, ShoeType shoeType)
        {
            Name = name;
            ShoeSize = shoeSize;
            ShoeType = shoeType;
        }


    }
    public enum ShoeType
    {
        Man,
        Woman,
    }
}
