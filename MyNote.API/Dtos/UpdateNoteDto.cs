﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyNote.API.Dtos
{
    public class UpdateNoteDto
    {
        public int Id { get; set; }

        [Display(Name = "Title")]
        [Required(ErrorMessage = "{0} is required.")]
        [StringLength(100, ErrorMessage = "{0} can not be longer than 100 characters")]
        public string Title { get; set; }

        public string Content { get; set; }
    }
}