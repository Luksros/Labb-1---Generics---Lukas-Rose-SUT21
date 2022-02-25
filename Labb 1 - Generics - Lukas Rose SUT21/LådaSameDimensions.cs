using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Labb_1___Generics___Lukas_Rose_SUT21
{
    class LådaSameDimensions : IEqualityComparer<Låda>
    {
        public bool Equals( Låda x, Låda y)
        {
            if ((x.höjd == y.höjd && x.längd == y.längd && x.bredd == y.bredd))
            {
                return true;
            }
            return false;
        }

        public int GetHashCode([DisallowNull] Låda obj)
        {
            var hash = obj.höjd ^ obj.längd ^ obj.bredd;
            return hash;
        }
    }
}
