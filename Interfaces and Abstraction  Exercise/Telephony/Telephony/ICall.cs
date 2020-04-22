namespace Telephony
{
    using System;
    using System.Collections.Generic;
    using System.Dynamic;
    using System.Globalization;
    using System.Text;

    public interface ICall
    {
        string Call(string url);
    }
}
