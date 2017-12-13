using System;

namespace WoaW.Models.Parties.Identifications
{
    /// <summary>
    /// The UniqueIdentifier archetype represents an identifier that is unique within a given context.
    /// It must be unique across your whole business
    /// </summary>
    public class UniqueIdentifier
    {
        private readonly Guid _id;
        public UniqueIdentifier(Guid id)
        {
            _id = id;
        }
        public Guid Id { get { return _id; } }
    }
}
