using API.Dtos.Comment;
using API.Models;
using System.Runtime.CompilerServices;

namespace API.Mappers
{
    public static class CommentMapper
    {
        public static CommentDto ToCommentDto(this Comment commentDto)
        {
            return new CommentDto
            {
                Id = commentDto.Id,
                Title = commentDto.Title,
                Content = commentDto.Content,
                CreatedOn = commentDto.CreatedOn,
                StockId = commentDto.StockId
            };
        }


        public static Comment ToCommentFromCreate(this CreateCommentDto commentDto, int stockId)
        {
            return new Comment
            {
            
               Title = commentDto.Title,
               Content = commentDto.Content,
               StockId = stockId
            };
        }

        public static Comment ToCommentFromUpdate(this UpdateCommentRequestDto commentDto)
        {
            return new Comment
            {

                Title = commentDto.Title,
                Content = commentDto.Content,
             
            };
        }
    }
}
