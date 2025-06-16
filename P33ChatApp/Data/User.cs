using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P33ChatApp.Data
{
    public class User
    {
        public int Id { get; set; }

        public string Name { get; set; } = default!;

        public string Password { get; set; } = default!;

        public string Email  { get; set; } = default!;

        public string IpAddress  { get; set; } = default!;

        public int Port { get; set; }

        public bool IsActive { get; set; }

        public ICollection<Chat>? Chats { get; set; }

        public ICollection<Message>? Messages { get; set; }
    }
}
