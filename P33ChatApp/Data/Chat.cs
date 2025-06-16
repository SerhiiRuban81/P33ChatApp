using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P33ChatApp.Data
{
    public class Chat
    {
        public int Id { get; set; }

        public string Name { get; set; } = default!;

        public ICollection<User>? Users { get; set; }
    }
}
