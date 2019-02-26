namespace WinterTask
{
    public class Contact
    {
		//TODO: Публичные поля!
        public string Name;
        public long PhoneNumber;
        public Sex Sex; 

        public override string ToString()
        {
            return Name + ' ' + PhoneNumber + ' ' + Sex.ToString();
        }
    }
	//TODO: RSDN
    public enum Sex { Male, Female }
    
}
