using ReactNative.Bridge;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace Nano.RNNano
{
    /// <summary>
    /// A module that allows JS to share data.
    /// </summary>
    class RNNanoModule : NativeModuleBase
    {
        /// <summary>
        /// Instantiates the <see cref="RNNanoModule"/>.
        /// </summary>
        internal RNNanoModule()
        {

        }

        /// <summary>
        /// The name of the native module.
        /// </summary>
        public override string Name
        {
            get
            {
                return "RNNano";
            }
        }
    }
}
