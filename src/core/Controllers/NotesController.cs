using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Quarky.Core.Entities;

namespace Quarky.Core.Controllers;

[Route("api/[controller]")]
[ApiController]
public class NotesController : ControllerBase
{
    private static List<Note> _noteList = new();
    private Note note = new Note { Content = "yo", Title="Nice", Id="1", CreatedAt=DateTime.Now };


    [HttpGet]
    public List<Note> Get()
    {
        _noteList.Add(note);
        return _noteList;
    }

    [HttpDelete]
    public void DeleteAll()
    {
        _noteList.Clear();
    }
}

