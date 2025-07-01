using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P33ChatApp.Data
{
    public class ChatUsers
    {
        public int Id { get; set; }
        [ForeignKey("User")]
        public int UserId { get; set; }
        public User? User { get; set; }

        [ForeignKey("Chat")]
        public int ChatId { get; set; }
        public Chat? Chat { get; set; }
    }
}
