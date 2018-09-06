using System;
using System.Collections.Generic;
using System.Text;

namespace MasteringCSharp
{

    public delegate void ClickHandler(object sender, EventArgs e);
    public class LonghandEventRaiser
    {
        private ClickHandler currentHandler = null;

        public event ClickHandler Click
        {
            add { currentHandler += value; }
            remove { currentHandler -= value; }
        }

        public void OnClick()
        {
            ClickHandler tmp = currentHandler;

            if (tmp != null)
            {
                tmp.Invoke(this, EventArgs.Empty);
            }
        }
    }
}

/*
 * public class LonghandEventRaiser
    {
        private ClickHandler currentHandler = null;

        public event ClickHandler Click
        {
            add { AddHandler(value); }
            remove { RemoveHandler(value); }
        }

        private void AddHandler(ClickHandler handler)
        {
            currentHandler = currentHandler + handler;
        }

        private void RemoveHandler(ClickHandler handler)
        {
            currentHandler = currentHandler - handler;

        }

        public void OnClick()
        {
            ClickHandler tmp = currentHandler;

            if (tmp != null)
            {
                tmp.Invoke(this, EventArgs.Empty);
            }
        }
    }
*/
