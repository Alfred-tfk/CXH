using System;
namespace CXH.Model
{
    public class WorkInfo
    {
        public  int Id { get; set; }
        public  string WorkName { get; set; }
        public  string WorkPicture { get; set; }
        public  DateTime UploadTime { get; set; }
        public  string WorkIntroduction { get; set; }
        public  string WorkVerify { get; set; }
        public  string UserName { get; set; }
        public  string ActivityName { get; set; }
        public  string Recommend { get; set; }
        public  DateTime? RecommendTime { get; set; }
    }
}

