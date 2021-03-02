using Core.DataAccess.EntityFramework;
using Core.Entities.Concrete;
using DataAccess.Abstract;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfUserDal : EfEntityRepositoryBase<User, NortwindContext>, IUserDal
    {
        public List<OperationClaim> GetClaims(User user)
        {
            using (NortwindContext context=new NortwindContext())
            {
                var result = from operataionClaim in context.OperationClaims
                             join userOperationClaim in context.UserOperationClaims
                             on operataionClaim.Id equals userOperationClaim.OperationClaimId
                             where userOperationClaim.OperationClaimId == operataionClaim.Id
                             select new OperationClaim { Id = operataionClaim.Id, Name = operataionClaim.Name };
                return result.ToList();
            }
        }
    }
}