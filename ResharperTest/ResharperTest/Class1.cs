// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Class1.cs" company="">
//   
// </copyright>
// <summary>
//   The my class.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace ResharperTest
{
    /// <summary>
    /// The my class.
    /// </summary>
    internal class MyClass
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MyClass"/> class.
        /// </summary>
        /// <param name="name">
        /// The name.
        /// </param>
        public MyClass(string name)
        {
            this.Name = name;
        }

        /// <summary>
        /// Gets the name.
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// Gets or sets the timeout.
        /// </summary>
        public int Timeout { get; set; }

        /// <summary>
        /// The get string value.
        /// </summary>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        public string GetStringValue()
        {
            return string.Empty;
        }
    }
}