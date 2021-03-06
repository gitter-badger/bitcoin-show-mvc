using BitcoinShow.Web.Models;
using BitcoinShow.Web.Repositories.Interface;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Collections.Generic;

namespace BitcoinShow.Web.Repositories
{
    public class QuestionRepository : IQuestionRepository
    {
        private BitcoinShowDBContext _context;
        public QuestionRepository(BitcoinShowDBContext context)
        {
            this._context = context;
        }

        public void Add(Question question)
        {
             _context.Add (question);
             _context.SaveChanges();
        }
        
        public void Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public List<Question> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public Question GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public Question GetByLevel(QuestionLevelEnum level)
        {
            throw new System.NotImplementedException();
        }

        public void Update(Question quesiton)
        {
            throw new System.NotImplementedException();
        }
    }
}