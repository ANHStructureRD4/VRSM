namespace ANH.Database
{
    /// <summary>
    /// A data model for Base list item
    /// </summary>
    public class MaterialDataModel
    {
        /// <summary>
        /// The display base name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The base count 
        /// </summary>
        public int count { get; set; }

        /// <summary>
        /// content
        /// </summary>
        public string  Contents { get; set; }

        /// <summary>
        /// True if this item is currently selected
        /// </summary>
        public bool IsSelected { get; set; }

        /// <summary>
        /// The icon source of local storage
        /// </summary>
        public string IconSource { get; set; }
    }
}
