﻿
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace Assignment2.Entities
    {
        public abstract class BaseEntity
        {
            public int UserId { get; set; }
            public bool IsDeleted { get; set; }
            public DateTime CreatedDateTime { get; set; }
            public DateTime UpdatedDateTime { get; set; }
        }
    }