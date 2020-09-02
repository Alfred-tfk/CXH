using System;
namespace CXH.Model
{
	
	public  class Comment
	{
        public int Id { get; set; }
        public int WorkID { get; set; }
        public string WorkName { get; set; }
        public string UserName { get; set; }
        public string CommentContent { get; set; }
        public DateTime? CommentTime { get; set; }
	}
}

