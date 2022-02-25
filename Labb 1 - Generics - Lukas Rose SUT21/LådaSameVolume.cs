using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Labb_1___Generics___Lukas_Rose_SUT21 
{
    class LådaSameVolume : EqualityComparer<Låda>
    {
        public override bool Equals(Låda x, Låda y)
        {
            if (x.höjd * x.längd * x.bredd == y.höjd * y.längd * y.bredd)
            {
                return true;
            }
            return false;
        }

        public override int GetHashCode(Låda obj)
        {
            var hash = obj.höjd ^ obj.längd ^ obj.bredd;
            return hash;
        }
    }
}
