﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models;

[Table("tb_tr_account_roles")]
public class AccountRole
{
    [Key, Column("id", TypeName = "int")]
    public int Id { get; set; }
    [Column("account_nik", TypeName = "char(5)")]
    public string? AccountNIK { get; set; }
    [Column("role_id", TypeName = "int")]
    public int? RoleId { get; set; }

    // Cardinality
    public Role Role { get; set; }
    public Account Account { get; set; }

}
