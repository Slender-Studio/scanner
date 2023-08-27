using System;

namespace Slender.AssemblyScanner
{

    /// <summary>
    /// Represents a scanned <see cref="System.Reflection.Assembly"/>.
    /// </summary>
    public interface IAssemblyScan
    {

        #region - - - - - - Properties - - - - - -

        /// <summary>
        /// The types defined in the scanned <see cref="System.Reflection.Assembly"/>.
        /// </summary>
        Type[] Types { get; }

        #endregion Properties

    }

}
