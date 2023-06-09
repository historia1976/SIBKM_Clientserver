﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models;

[Table("tb_m_roles")]
public class Role
{
    [Key, Column("id", TypeName = "int")]
    public int Id { get; set; }
    [Column("name", TypeName = "varchar(50)")]
    public string Name { get; set; }

    // Cardinality
    public ICollection<AccountRole> AccountRole { get; set; }
}