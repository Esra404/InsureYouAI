using System.ComponentModel;

namespace InsureYouAI.Entities
{
    public class Article
    {
        public int ArticleId {  get; set; }
        public string Title { get; set; }
        public DateTime CreateDate { get; set; }
        public string Content { get; set; }
        public string MainCoverImageUrl {  get; set; }
        public int CategoryId {  get; set; }
        public Category Category { get; set; }
    
    
    
    
    
    }
}
