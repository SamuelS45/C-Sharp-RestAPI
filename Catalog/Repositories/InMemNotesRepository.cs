using System;
using System.Collections.Generic;
using Catalog.Entities;


namespace Catalog.Repositories
{
    public class InMemNotesRepository
    {
        private readonly List<Note> notes = new()
        {
            new Note{ Id = Guid.NewGuid(), Content = "Walk the Dog", CreatedDate = DateTimeOffset.UtcNow},
            new Note{ Id = Guid.NewGuid(), Content = "Walk the Dog", CreatedDate = DateTimeOffset.UtcNow}
        };

        public IEnumerable<Note> GetNotes(){
            return notes;
        }

        public Note GetNote(Guid id)
        {
            return notes.Where(item=>item.Id==id).SingleOrDefault();
        }

    }
}