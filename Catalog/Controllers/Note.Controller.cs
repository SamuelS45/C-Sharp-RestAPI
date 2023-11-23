using Catalog.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Catalog.Entities;

namespace Catalog.Controllers
{
    [ApiController]
    [Route("notes")]

    public class NoteControllers:ControllerBase
    {
        private readonly InMemNotesRepository repository;

        public NoteControllers()
        {
            repository = new InMemNotesRepository();
        }
        [HttpGet]

        public IEnumerable<Note>GetNotes(){
            var notes = repository.GetNotes();
            return notes;
        }
    }
}