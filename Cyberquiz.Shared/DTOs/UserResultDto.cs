using System;
using System.Collections.Generic;
using System.Text;

namespace Cyberquiz.Shared.DTOs
{
    public class UserResultDto
    {
        public int Id { get; set; }
        public string UserName { get; set; } = string.Empty;
        public int Score { get; set; }
        //public DateTime Date { get; set; }
    }
}
