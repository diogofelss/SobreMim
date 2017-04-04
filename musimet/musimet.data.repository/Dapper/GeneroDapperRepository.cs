using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using musimet.data.repository.Dapper.Commons;
using musimet.domain.Interfaces.Common;
using musimet.domain.Interfaces.Service;
using musimet.domain.Validation;

namespace musimet.data.repository.Dapper
{
    public class GeneroDapperRepository : Commons.Repository, IReadOnlyRepository<GeneroDapperRepository>
    {
        public GeneroDapperRepository Get(int id)
        {
            using (var cn = MusiMetConnection)
            {
                
            }

            throw new NotImplementedException();
        }

        public IEnumerable<GeneroDapperRepository> All()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<GeneroDapperRepository> Find(Expression<Func<GeneroDapperRepository, bool>> predicate)
        {
            throw new NotImplementedException();
        }
    }
}
