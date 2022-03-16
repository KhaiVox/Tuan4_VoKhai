using System;

namespace NhaSach2.Models
{
    internal class MyDataDatacontext
    {
        public object Saches { get; internal set; }

        public static implicit operator MyDataDatacontext(MyDataDataContext v)
        {
            throw new NotImplementedException();
        }
    }
}