using System;

namespace Slender.AssemblyScanner
{

    public interface IAssemblyScan
    {

        #region - - - - - - Properties - - - - - -

        Type[] Types { get; }

        #endregion Properties

    }

}
