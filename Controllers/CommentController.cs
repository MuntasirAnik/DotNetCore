using DotNetCore.DTOs.Comment;
using DotNetCore.Interfaces;
using DotNetCore.Mappers;
using Microsoft.AspNetCore.Mvc;

namespace DotNetCore.Controllers
{
    [Route("api/comment")]
    [ApiController]
    public class CommentController :ControllerBase
    {
        private readonly ICommentRepository _commentRepo;
        private readonly IStockRepository _stockRepo;
        public CommentController(ICommentRepository commentRepo, IStockRepository stockRepo)
        {
            _commentRepo = commentRepo; 
            _stockRepo = stockRepo;          
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {;
            var comments = await _commentRepo.GetAllAsync();
            var commentDto = comments.Select(s => s.ToCommentDto());
            return Ok(commentDto);
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            var comment = await _commentRepo.GetByIdAsync(id);
            if( comment == null)
            {
                return  NotFound();
            }
            return Ok(comment.ToCommentDto());
        }

        [HttpPost("{stockId:int}")]
        public async Task<IActionResult> Create([FromRoute] int stockId, CreateCommentDto commentDto)
        {
            if(!ModelState.IsValid)
                return BadRequest(ModelState);
            if(!await _stockRepo.StockExists(stockId))
            {
                return BadRequest("Stock does not exist");
            }

            var commentModel = commentDto.ToCommentFromCreate(stockId);
            await _commentRepo.CreateAsync(commentModel);

            return CreatedAtAction(nameof(GetById), new {id= commentModel.Id}, commentModel.ToCommentDto() );
        }

        [HttpDelete]
        [Route("{id:int}")]
        public async Task<ActionResult> Delete([FromRoute] int id)
        {
            var commentModel = await _commentRepo.DeleteAsync(id);

            if(commentModel==null)
            {
                return NotFound("Comment does not exist");
            }
            return Ok(commentModel);
        } 

        [HttpPut]
        [Route("{id}")]
        public async Task<IActionResult> Update([FromRoute] int id, [FromBody] UpdateCommentDto updateDto)
        {
            var comment = await _commentRepo.UpdateAync(id, updateDto.ToCommentFromUpdate());

            if(comment==null)
            {
                return NotFound("Comment not found");
            }
            return Ok(comment.ToCommentDto());
        }
    }

}