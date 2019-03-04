namespace WinterTask
{
    /// <summary>
    ///     Информация о контакте
    /// </summary>
    public class Contact
    {
        #region Properties

        //Имя
        public string Name { get; set; }

        //Телефонный номер
        public long PhoneNumber { get; set; }

        //Пол
        public Sex Sex { get; set; }

        #endregion

        #region Public methods

        /// <summary>
        ///     Перегрузка метода перевода объекта в строку
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Name + ' ' + PhoneNumber + ' ' + Sex;
        }

        #endregion
    }
}