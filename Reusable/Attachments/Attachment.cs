﻿using System.ComponentModel.DataAnnotations.Schema;

namespace Reusable.Attachments
{
    [NotMapped]
    public class Attachment
    {
        public string FileName { get; set; }
        public string Comments { get; set; }
        public string Directory { get; set; }
    }
}
