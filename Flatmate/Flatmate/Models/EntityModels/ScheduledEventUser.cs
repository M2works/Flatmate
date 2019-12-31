using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Flatmate.Models.EntityModels
{
    public class ScheduledEventUser
    {
        public int ScheduledEventId { get; set; }
        public int UserId { get; set; }
        public int TeamId { get; set; }
        public bool IsOwner { get; set; }
        public ScheduledEvent ScheduledEvent { get; set; }
        public UserTeam TeamMemberAssignment { get; set; }
    }
}
