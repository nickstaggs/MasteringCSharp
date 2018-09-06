using System;
using System.Collections.Generic;
using System.Text;

namespace MasteringCSharp
{
    public class ShorthandEventRaiser
    {

        public event ClickHandler Click;

        public void OnClick()
        {
            ClickHandler tmp = Click;

            if (tmp != null)
            {
                tmp.Invoke(this, EventArgs.Empty);
            }
        }
    }
}
