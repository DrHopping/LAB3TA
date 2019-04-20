namespace LAB3TAConsole
{
    using System;
    public class Entry<TK, TV> : IEquatable<Entry<TK, TV>>
    {
        public TK Key { get; set; }

        public TV Value { get; set; }

        public bool Equals(Entry<TK, TV> other)
        {
            return this.Key.Equals(other.Key) && this.Value.Equals(other.Value);
        }
    }
}
