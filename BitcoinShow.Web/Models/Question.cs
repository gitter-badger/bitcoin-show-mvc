using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BitcoinShow.Web.Models
{
    /// <summary>
    /// Question
    /// </summary>
    public class Question
    {
        public Question()
        {
            QuestionOptions = new List<QuestionOption>();
        }
        /// <summary>
        /// Question Id
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Question Title
        /// </summary>
        [Required]
        public string Title { get; set; }

        /// <summary>
        /// Question difficult level
        /// </summary>
        public QuestionLevel Level { get; set; }

        /// <summary>
        /// Question options
        /// </summary>
        public List<QuestionOption> QuestionOptions { get; set; }

        /// <summary>
        /// Questino answer
        /// </summary>
        // [ForeignKey("QuestionOption")]
        public QuestionOption Answer { get; set; }
    }
}