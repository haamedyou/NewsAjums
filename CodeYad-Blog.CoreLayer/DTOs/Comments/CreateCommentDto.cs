﻿namespace News_Ajums.CoreLayer.DTOs.Comments
{
    public class CreateCommentDto
    {
        public int UserId { get; set; }
        public int PostId { get; set; }
        public string Text { get; set; }
    }
}