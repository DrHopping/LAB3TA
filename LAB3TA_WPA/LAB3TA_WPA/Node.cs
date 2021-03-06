﻿using System.Collections.Generic;

namespace LAB3TAConsole
{
    public class Node<TK, TV>
    {
        private int degree;

        public Node(int degree)
        {
            this.degree = degree;
            this.Children = new List<Node<TK, TV>>(degree);
            this.Entries = new List<Entry<TK, TV>>(degree);

        }

        public List<Node<TK, TV>> Children { get; set; }

        public List<Entry<TK, TV>> Entries { get; set; }

        public bool IsLeaf
        {
            get
            {
                return this.Children.Count == 0;
            }
        }

        public bool HasReachedMaxEntries
        {
            get
            {
                return this.Entries.Count == (2 * this.degree) - 1;
            }
        }

        public bool HasReachedMinEntries
        {
            get
            {
                return this.Entries.Count == this.degree - 1;
            }
        }
    }
}

