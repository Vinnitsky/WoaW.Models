using System;

namespace WoaW.Models.Parties.Identifications
{
    /// <summary>
    /// The UniqueIdentifier archetype represents an identifier that is unique within a given context.
    /// It must be unique across your whole business
    /// </summary>
    public class UniqueIdentifier
    {
        private readonly string _id;
        public UniqueIdentifier(string id)
        {
            _id = id;
        }
        public string Id { get { return _id; } }
    }
}
