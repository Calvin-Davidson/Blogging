using Microsoft.EntityFrameworkCore;
using Blogging.Data;
using Blogging.Models;
using Microsoft.AspNetCore.Mvc;

namespace Blogging.Controllers;

public class FileController : Controller
{
    private readonly FileContext _context;

    public FileController(FileContext context)
    {
        _context = context;
    }

    [HttpPost]
    public async Task<ActionResult<List<MarkdownFile>>> AddFile(MarkdownFile model)
    {
        _context.Files.Add(model);
        await _context.SaveChangesAsync();
        return Ok(await _context.Files.AsQueryable().ToListAsync());
    }

    [HttpGet]
    public async Task<ActionResult<List<MarkdownFile>>> GetFiles()
    {
        List<MarkdownFile> models = await _context.Files.AsQueryable().ToListAsync();
        return Ok(models);
    }

    [HttpGet]
    public async Task<ActionResult<MarkdownFile>> GetFile(int id)
    {
        var post = await _context.Files.AsQueryable().FirstOrDefaultAsync(file => file.Id == id);
        return post == null ? BadRequest("File not found") : Ok(post);
    }
}