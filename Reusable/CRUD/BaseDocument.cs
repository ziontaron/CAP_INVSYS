﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Reusable
{
    public abstract class BaseDocument : BaseEntity, Trackable
    {
        [NotMapped]
        public Track InfoTrack { get; set; }

        virtual public bool sys_active { get; set; }

        virtual public bool is_locked { get; set; }

        virtual public string document_status { get; set; }
    }
}
