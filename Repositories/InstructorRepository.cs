using ExaminationSystem.Data;
using ExaminationSystem.Models;
using ExaminationSystem.ViewModels;
using System.Linq.Expressions;

namespace ExaminationSystem.Repositories
{
    public class InstructorRepository
    {
        private readonly Context _context;

        public InstructorRepository(Context context)
        {
            _context = context;
        }

        public void Add(Instructor instructor)
        {

        }

        public IQueryable<Instructor> GetAll()
        {
            //Context context = new Context();

            IQueryable<Instructor> query = _context.Instructors;

            return query;
        }

        public IQueryable<Instructor> Get(Expression<Func<Instructor, bool>> predicate)
        {
            //Context context = new Context();

            return _context.Instructors.Where(predicate);
        }

        public IQueryable<TResult> Get<TResult>(Expression<Func<Instructor, bool>> predicate,
            Expression<Func<Instructor, TResult>> selector)
        {
            //Context context = new Context();

            return _context.Instructors
                .Where(predicate)
                .Select(selector);
        }

        public Instructor GetByID(int id) 
        {
            //Context context = new Context();

            var instructor = _context.Instructors.FirstOrDefault(x => x.ID == id);

            return instructor;
        }
    }
}
