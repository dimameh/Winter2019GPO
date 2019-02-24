namespace WinterTask
{
    public class Contact
    {
        public string Name;
        public long PhoneNumber;
        public Sex Sex; 

        public override string ToString()
        {
            return Name + ' ' + PhoneNumber + ' ' + Sex.ToString();
        }
    }
    public enum Sex { Male, Female }
    
}
