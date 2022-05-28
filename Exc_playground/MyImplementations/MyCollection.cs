using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exc_playground.MyImplementations
{
    public class MyCollection : IEnumerable<int>
    {
        public int[] data = {1,2,3,4,5,6,7,8};

        public IEnumerator<int> GetEnumerator() => new EnumeratorImpl(this);

        IEnumerator IEnumerable.GetEnumerator() => new EnumeratorImpl(this);

    }

    public class EnumeratorImpl : IEnumerator<int>
    {
        private MyCollection collection;
        int index = -1;

        public EnumeratorImpl(MyCollection items) => collection = items;

        public int Current => collection.data[index];
        object IEnumerator.Current => this.Current;

        public bool MoveNext() => ++index < collection.data.Length;        

        public void Reset() => index = -1;

        void IDisposable.Dispose() {}

    }
}
