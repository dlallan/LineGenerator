using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GDIDrawer;
using System.Drawing;

namespace CMPE2800DAllanICA01
{
    interface IRenderable // place in different file before deadline
    {
        // method for rendering
        void Render(CDrawer dr, Rectangle rect);
    }

    class RenderingList <T> where T: IComparable, IRenderable
    {
        LinkedList<T> _llStorage; // background storage
        CDrawer _canvas;          // each object gets their own canvas
        public CDrawer canvas
        {
            get
            {
                return _canvas;
            }
        }
        
        // default CTOR
        public RenderingList()
        {
            _canvas = new CDrawer(800, 400, false);
            _llStorage = new LinkedList<T>();
        }

        // publicly available indexer
        public T this [int index]
        {
            get
            {
                if (index >= _llStorage.Count()) // invalid index
                {
                    throw new ArgumentException("Index out of range.");
                }
                else
                    return _llStorage.ElementAt(index);
            }
            set
            {
                if (index >= _llStorage.Count())
                    throw new ArgumentException("Index out of range.");
                LinkedListNode<T> node = _llStorage.First;
                for (int i = 0; i < index && node.Next != null; i++) // iterate over _llStorage
                {
                    if (i == index - 1)
                        node.Value = value; // when the right index is reached, set the value.
                    node = node.Next;
                }
            }
        }

        // sort linked list in background by leveraging array sorting
        public void Sort() {
            T[] tmp = _llStorage.ToArray();
            Array.Sort(tmp);
            _llStorage = new LinkedList<T>(tmp);
        }

        // add to end of _llStorage
        public void Add (T item)
        {
            _llStorage.AddLast(item);
        }

        // add T item at a point before a larger element is found, beginning at the front
        public void Insert(T item)
        {
            if (_llStorage.First == null)   // check for empty linked list first
            {
                _llStorage.AddFirst(item);  // add the first node manually
                return;
            }

            LinkedListNode<T> node = _llStorage.First; // start at the beginning
            while (node != null)  // traverse the linked list
            {
                // is node value greater than or equal item value?
                if (node.Value.CompareTo(item) >= 0)
                {
                    // insert new node and value before node
                    _llStorage.AddBefore(node, new LinkedListNode<T>(item));
                    return;
                }
                if (node.Next == null) // check for end of linked list
                {
                    _llStorage.AddLast(new LinkedListNode<T>(item));
                    return;
                }
                node = node.Next; // item is greater than next item, so move on.
            }
        }

        // give each member of _llStorage a rectangle, where they render it on the canvas.
        public void Render()
        {
            if (_llStorage.Count == 0) // don't try to render an empty collection
                return;
            int iRectWidth = _canvas.m_ciWidth / _llStorage.Count; // this makes rectangle width fit canvas
            int iCounter = 0;

            _canvas.Clear();
            foreach (T t in _llStorage) // iterate over linked list
            { 
                // position each rectangle beside each other.
                Rectangle rRect = new Rectangle(iCounter * iRectWidth, 0, iRectWidth, _canvas.m_ciHeight);
                t.Render(_canvas, rRect); // pass canvas and rect onto type's constrained Render method.
                ++iCounter;
            }
            _canvas.Render();
        }
    }
    
    class CLine : IComparable, IRenderable
    {
        float _fFillRatio;

        // default CTOR
        public CLine(int factor)
        {
            _fFillRatio = (float)factor / 20;
        }

        // custom CompareTo to sort CLine objects by ascending order of fill ratio
        public virtual int CompareTo(object obj)
        {
            if (!(obj is CLine)) // type check
                throw new InvalidOperationException("obj is not a CLine!");
            CLine arg = (CLine)obj;
            return this._fFillRatio.CompareTo(arg._fFillRatio);
        }

        // render as vertical bar in drawer
        public void Render(CDrawer cr, Rectangle rect)
        {
            int iFillHeight = (int)(rect.Height * _fFillRatio); // effective height of rectangle color
            // add rectangle to the bottom of the canvas
            cr.AddRectangle(rect.X, rect.Y + (cr.m_ciHeight - iFillHeight), rect.Width, iFillHeight,
                (this is CColourLine) ? (this as CColourLine).cColor : Color.Red, 1, Color.Black);
        }
    }

    class CColourLine : CLine
    {
        Color _cColor;
        public Color cColor // public property used by CLine Render method. See if Simon is okay with this...
        {
            get
            {
                return _cColor;
            }
        }

        // default CTOR that passes on iFactor arg to parent CTOR
        public CColourLine(int iFactor, int green) : base(iFactor)
        {
            _cColor = Color.FromArgb(0, green, 0);
        }

        // sort by color in fill ratio
        public override int CompareTo(object obj)
        {
            if (!(obj is CColourLine))
                throw new InvalidOperationException("obj is not a CColourLine!");
            CColourLine arg = (CColourLine)obj;

            // check if fill ratio is the same
            if (base.CompareTo(obj) == 0)
                return this._cColor.G.CompareTo(arg._cColor.G); // color (green) sort
            // fill ratio is different -- sort by height
            return base.CompareTo(obj);
        }

        new public void Render(CDrawer cr, Rectangle rect)
        {
            base.Render(cr, rect);
        }
    }
}
