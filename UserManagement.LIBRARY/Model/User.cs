using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UserManagement.LIBRARY.Model
{
    public partial class User
    {
        [Column("ID", TypeName = "int(255)")]
        public int Id { get; set; }
        [Required]
        [Column(TypeName = "varchar(255)")]
        public string Username { get; set; }
        [Required]
        [Column(TypeName = "varchar(255)")]
        public string Email { get; set; }
        [Required]
        [Column(TypeName = "longtext")]
        public string Password { get; set; }
        [Column(TypeName = "varchar(255)")]
        public string Phone { get; set; }
        [Column(TypeName = "longtext")]
        public string Address { get; set; }
        [Column(TypeName = "longtext")]
        public string Image { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Birthday { get; set; }
        [Column(TypeName = "bit(1)")]
        public bool? IsEnabled { get; set; }
        [Column(TypeName = "varchar(255)")]
        public string Nationality { get; set; }
        [Required]
        [Column("SSN", TypeName = "varchar(255)")]
        public string Ssn { get; set; }
        [Required]
        [Column(TypeName = "varchar(255)")]
        public string Firstname { get; set; }
        [Required]
        [Column(TypeName = "varchar(255)")]
        public string Lastname { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Created { get; set; }
    }
}
