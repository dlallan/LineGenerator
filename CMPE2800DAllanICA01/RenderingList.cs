/******************************************************** 
 * File: Classes.cs                                     *
 * Author: Dillon Allan                                 *
 * Description: File containing IRenderable interface,  *
 *              and the classes RenderingList, CLine,   *
 *              and CColourLine.                        *
 *******************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using GDIDrawer;
using System.Drawing;

namespace CMPE2800DAllanICA01
{
    class RenderingList <T> where T: IComparable, IRenderable
    {
        // members
        LinkedList<T> _llStorage; // background storage
        CDrawer _canvas;          // each object gets their own canvas
        public CDrawer canvas     // public get-only for setting canvas position in main form 
        {                         // (see line 30 Form1.cs)
            get
            {
                return _canvas;
            }
        }
        
        // default CTOR
        public RenderingList()
        {
            // initialize members
            _canvas = new CDrawer(800, 400, false); // custom size, manual rendering 
            _llStorage = new LinkedList<T>();
        }

        // publicly available indexer
        public T this [int index]
        {
            get
            {
                if (index >= _llStorage.Count()) // invalid index
                {
                    throw new ArgumentOutOfRangeException("Index out of range.");
                }
                else
                    return _llStorage.ElementAt(index); 
            }
            set
            {
                if (index >= _llStorage.Count()) // another invalid index
                    throw new ArgumentOutOfRangeException("Index is out of range.");
                
                LinkedListNode<T> node = _llStorage.First;
                for (int i = 0; i < index && node.Next != null; i++) // iterate over _llStorage
                {
                    if (i == index) // check if the specified node has been reached.
                    {
                        node.Value = value; // when the right index is reached, set the value.
                        return;
                    }
                    node = node.Next; // not the right node, so move on.
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
            LinkedListNode<T> node = _llStorage.First; // start at the beginning
            while (node != null)  // traverse the linked list
            {
                // is node value greater than or equal item value?
                if (node.Value.CompareTo(item) >= 0)
                {
                    // insert new node and value before node
                    _llStorage.AddBefore(node, item);
                    return;
                }
                if (node.Next == null) // check for end of linked list
                {
                    _llStorage.AddLast(item);
                    return;
                }
                node = node.Next; // item is greater than next item, so move on.
            }
            _llStorage.AddFirst(item);  // add the first node manually
            return;    
        }

        // give each member of _llStorage a rectangle, where they render it on the canvas.
        public void Render()
        {
            if (_llStorage.Count == 0) // don't try to render an empty collection
                return;
            float iRectWidth = (float)_canvas.m_ciWidth / _llStorage.Count; // this makes rectangle width fit canvas

            _canvas.Clear();
            for (int i = 0; i < _llStorage.Count; i++)
            {
                // position each rectangle beside each other.
                Rectangle rRect = new Rectangle((int)(i * iRectWidth), 0, (int)iRectWidth, _canvas.m_ciHeight);
                this[i].Render(_canvas, rRect); // pass canvas and rect onto each generic's Render method.
            }
            _canvas.Render();
        }
    }
}
