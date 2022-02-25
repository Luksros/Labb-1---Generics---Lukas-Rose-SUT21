using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Labb_1___Generics___Lukas_Rose_SUT21
{
    class LådaEnumerator : IEnumerator<Låda>
    {
        private LådaCollection boxes;
        private int curIndex;
        private Låda curLåda;
        public LådaEnumerator(LådaCollection boxesIn)
        {
            this.boxes = boxesIn;
            curIndex = -1;
            curLåda = default;
        }
        public Låda Current { get { return curLåda; } }

        object IEnumerator.Current { get { return curLåda; } }

        public void Dispose()
        {
           
        }

        public bool MoveNext()
        {
            if (++curIndex >= boxes.Count)
            {
                return false;
            }
            else
            {
                curLåda = boxes[curIndex];
            }
            return true;
        }

        public void Reset()
        {
            curIndex = -1;
        }
    }
}
