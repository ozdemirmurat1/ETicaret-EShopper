using ETrade.Core.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETrade.Entities
{
    public class Review:IEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string FirstName { get; set; }
        public string Email { get; set; }
        public string Comment { get; set; }
        public DateTime Date { get; set; }
    }
}
