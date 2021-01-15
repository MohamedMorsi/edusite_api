using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Role : BaseModel
    {
        public Role()
        {
            Accounts = new List<Account>();
        }
        public int RoleId { get; set; }
        public string RoleName { get; set; }
        public virtual ICollection<Account> Accounts { get; set; }
    }
}
