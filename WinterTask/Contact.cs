namespace WinterTask
{
    /// <summary>
    ///     Информация о контакте
    /// </summary>
    public class Contact
    {
        #region Properties

        /// <summary>
        ///     Имя
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        ///     Телефонный номер
        /// </summary>
        public long PhoneNumber { get; set; }

        /// <summary>
        ///     Пол
        /// </summary>
        public Sex Sex { get; set; }

        #endregion

        #region Public methods

        /// <summary>
        ///     Перегрузка метода перевода объекта в строку
        /// </summary>
        /// <returns> Информацию о полях класса в формате [Name + ' ' + PhoneNumber + ' ' + Sex] </returns>
        public override string ToString()
        {
            return Name + ' ' + PhoneNumber + ' ' + Sex;
        }

        #endregion
    }
}