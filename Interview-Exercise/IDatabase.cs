namespace Interview_Exercise
{
    public interface IDatabase
    {
        /// <summary>
        /// Inserts a new country in to data storage.
        /// </summary>
        /// <param name="country"></param>
        void Insert(Country country);

        /// <summary>
        /// Updates an existing country in data storage.
        /// </summary>
        /// <param name="country"></param>
        void Update(Country country);

        /// <summary>
        /// Deletes a country from data storage.
        /// </summary>
        /// <param name="code"></param>
        void Remove(string code);

        /// <summary>
        /// Retrieves country data from storage by code.
        /// </summary>
        /// <param name="code"></param>
        void Read(string code);

        /// <summary>
        /// Drops all partitions from data storage.
        /// </summary>
        void Clear();
    }
}
