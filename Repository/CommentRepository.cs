using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using backend.Models;
using DotNetCore.data;
using DotNetCore.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DotNetCore.Repository
{
    public class CommentRepository : ICommentRepository
    {
        private readonly ApplicationDBContext _context;
        public CommentRepository(ApplicationDBContext context)
        {
            _context = context;
        }
        public async Task<List<Comment>> GetAllAsync()
        {
            return await _context.Comments.ToListAsync();
        }

        public async Task<Comment?> GetByIdAsync(int id)
        {
            var commentModel = await _context.Comments.FindAsync(id);
            return commentModel;
        }
    }
}