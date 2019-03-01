namespace WinterTask
{
    /// <summary>
    /// Информация о контакте
    /// </summary>
    public class Contact
    {
        //Имя
        public string Name { get; set; }
        //Телефонный номер
        public long PhoneNumber { get; set; }
        //Пол
        public Sex Sex { get; set; }

        public override string ToString()
        {
            return Name + ' ' + PhoneNumber + ' ' + Sex.ToString();
        }
    }

	//TODO: В отдельный .cs
	/// <summary>
    /// Пол
    /// </summary>    
    public enum Sex
    {
        Male,
        Female
    }
    
}
