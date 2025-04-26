using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace parcial.Models
{
    [Table("t_playersteams")]
    public class PlayersTeams
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [ForeignKey("Players")]
        public int? IdPlayer { get; set; }
        public Players? Players { get; set; }
        [ForeignKey("Teams")]
        public int? IdTeam { get; set; }
        public Teams? Teams { get; set; }
    }
}