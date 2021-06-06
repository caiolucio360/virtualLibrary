using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VirtualLibrary.Models;
using VirtualLibrary.Repository.Data;

namespace virtualLibrary.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BooksController : ControllerBase
    {
        public readonly DataContext _context;
        public BooksController(DataContext context)
        {
            _context = context;
        }
       
        //[HttpGet]
        //public string Get(string nome,string idade, string blabla)
        //{
        //    return $"Meu nome: {nome}, /n idade: {idade}";
        //}

        //[HttpPost]
        //public string Post()
        //{
        //    return "Exemplo de Post";
        //}

        [HttpGet]
        public IEnumerable<Book> Get()
        {
            return _context.Books;
        }

        [HttpGet("{id}")]
        public IEnumerable<Book> Get(Guid id)
        {
            return _context.Books.Where(Book => Book.Id == id);
        }
    }
}
