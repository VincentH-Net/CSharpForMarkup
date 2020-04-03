using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpMarkupTools
{
    internal class Tree<T> where T : class
    {
        Tree<T> parent;
        readonly List<Tree<T>> children = new List<Tree<T>>();

        public Tree(T value, params Tree<T>[] children)
        {
            Value = value;
            Add(children);
        }

        public T Value { get; set; }

        public Tree<T> Parent 
        {
            get => parent;
            
            private set
            {
                if (object.ReferenceEquals(value, parent)) return;
                if (value != null && parent != null) throw new InvalidOperationException($"Node {Value} already has a parent");
                parent = value;
                parent.children.Add(this);
            }
        }

        public IReadOnlyList<Tree<T>> Children => children.AsReadOnly();

        public void Add(params Tree<T>[] children)
        {
            foreach (var child in children) child.Parent = this;
        }
    }
}