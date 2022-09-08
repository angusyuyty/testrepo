﻿using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace CADPLIS.Model.workflow
{
    [Table("vHeads")]
    public class Head
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid HeadId { get; set; }
        public string HeadName { get; set; }
    }
}
