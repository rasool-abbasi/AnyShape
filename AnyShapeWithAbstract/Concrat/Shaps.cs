namespace AnyShapeWithAbstract.Concrat
{
    /// <summary>
    /// Class Abstract for Calculate Area ans enviroment Shaps
    /// </summary>
    public abstract class Shaps
    {
        public abstract string Name { get; }
        /// <summary>
        /// Class for Calculate Area
        /// </summary>
        /// <returns>Result Area</returns>
        public abstract float Area();
        /// <summary>
        ///  Class for Calculate Enviroment
        /// </summary>
        /// <returns>Result Enviroment</returns>
        public abstract float Enviroment();
    }
}
