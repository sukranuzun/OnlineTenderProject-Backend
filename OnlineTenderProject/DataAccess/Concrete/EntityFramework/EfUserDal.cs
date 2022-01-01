using Core.DataAccess.EntityFramework;
using Core.Entities.Concrete;
using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
namespace DataAccess.Concrete.EntityFramework
{
    public class EfUserDal : EfEntityRepositoryBase<User, DataContext>, IUserDal 
    {
        public List<OperationClaim> GetClaims(User user)
        {
            using (var context = new DataContext())
            {
                var result = from operationClaim in context.operationClaims
                             join userOperationClaim in context.userOperationClaims
                                 on operationClaim.OperationClaimId equals userOperationClaim.OperationClaimId
                             where userOperationClaim.UserId == user.UserId
                             select new OperationClaim { OperationClaimId = operationClaim.OperationClaimId, OperationClaimName = operationClaim.OperationClaimName };
                return result.ToList();

            }
        }
    }
}
