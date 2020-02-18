using System;

namespace WebApi_Intro
{
    public class Replies
    {
       public string Content { get; set; }

       public int MemberId { get; set; }

       public int TopicId { get; set; }
    }

    public class IdReplies : Replies
    {
        public int Id { get; set; }
    }
}
