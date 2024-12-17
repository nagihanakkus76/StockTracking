using Core.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain.Entities
{
    public class UserOperationClaim : Entity
    {
        public int UserID { get; set; }
        public int OperationClaimID { get; set; }
    }
}
