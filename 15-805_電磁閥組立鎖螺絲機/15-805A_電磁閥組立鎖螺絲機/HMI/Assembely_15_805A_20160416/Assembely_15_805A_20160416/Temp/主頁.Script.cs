//--------------------------------------------------------------
// Press F1 to get help about using script.
// To access an object that is not located in the current class, start the call with Globals.
// When using events and timers be cautious not to generate memoryleaks,
// please see the help for more information.
//---------------------------------------------------------------

namespace Neo.ApplicationFramework.Generated
{
    using System.Windows.Forms;
    using System;
    using System.Drawing;
    using Neo.ApplicationFramework.Tools;
    using Neo.ApplicationFramework.Common.Graphics.Logic;
    using Neo.ApplicationFramework.Controls;
    using Neo.ApplicationFramework.Interfaces;
    
    
    public partial class 主頁
    {
		
		void AnalogNumeric_ValueChanged(System.Object sender, Neo.ApplicationFramework.Interfaces.Events.ValueChangedEventArgs e)
		{
			Globals.Tags.PickPOS_IndexX.Value=Globals.Tags.IndexX.Value;
			Globals.Tags.PickPOS_IndexY.Value=Globals.Tags.IndexY.Value;
		}
    }
}
