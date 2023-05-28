using System.Data.Entity;
using System.Diagnostics;
using Blogging.Data;
using Blogging.Models;
using Microsoft.AspNetCore.Mvc;

namespace Blogging.Controllers;

public class BlogController : Controller
{
    private readonly FileContext _context;

    public BlogController(FileContext context)
    {
        _context = context;
    }

    [HttpPost]
    public async Task<ActionResult<List<MarkdownFile>>> AddBlog(MarkdownFile model)
    {
        if (model.Id < 0)
        {
            return BadRequest("No model provided");
        }
        _context.Files.Add(model);
        await _context.SaveChangesAsync();
        return Ok(await _context.Files.ToListAsync());
    }

    public async Task<ActionResult<List<MarkdownFile>>> GetBlogs()
    {
        List<MarkdownFile> models = await _context.Files.ToListAsync();
        for (int i = 0; i < models.Count; i++)
        {
            Console.WriteLine("Loaded model: " + models[i].Id);
        }
        return Ok(models);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<MarkdownFile>> GetBlog(int id)
    {
        var post = await _context.Files.FindAsync(id);
        return post == null ? BadRequest("Post not found") : Ok(post);
    }
}