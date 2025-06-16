using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P33ChatApp.Data
{
    public class Message
    {
        public int Id { get; set; }

        public string Text { get; set; } = default!;

        public bool IsReceived { get; set; }

        [ForeignKey("User")]
        public int AuthorId { get; set; }
        public User Author { get; set; } = default!;

        [ForeignKey("Chat")]
        public int? ChatId { get; set; }
        public Chat? Chat { get; set; } = default!;  

        public DateTime time { get; set; } = DateTime.Now;
    }
}
