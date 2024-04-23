using EntityFrameworkSqlite2.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace EntityFrameworkSqlite2.Repositories
{
    public class GradeR : Repository, GradeRepository
    {
        public void Add(Grade grade)
        {
            throw new NotImplementedException();
        }

        public void Delete(Grade grade)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<String> GetAll()
        {
            List<string> grade = new List<string>();
            var gradeList = Grades.ToList();
            foreach(var item in gradeList)
            {
                grade.Add(item.GradeName);
            }
            return grade;
        }

        public string GetById(int id)
        {
            var grade = Grades.Where(x => x.Id == id).Single();
            return grade.GradeName;
        }

        public Grade GetByValue(string name)
        {
            var grade = Grades.Where(x => x.GradeName == name).Single();
            return grade;
        }

        public void Update(Grade grade)
        {
            throw new NotImplementedException();
        }
    }
}

