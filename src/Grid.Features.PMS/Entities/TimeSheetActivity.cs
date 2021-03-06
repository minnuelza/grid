﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Grid.Features.HRMS;

namespace Grid.Features.PMS.Entities
{
    public class TimeSheetActivity: UserCreatedEntityBase
    {
        public int TimeSheetId { get; set; }
        [ForeignKey("TimeSheetId")]
        public virtual TimeSheet TimeSheet { get; set; }

        public string Title { get; set; }

        [DisplayName("New Activity")]
        [DataType(DataType.MultilineText)]
        public string Comment { get; set; }
    }
}
