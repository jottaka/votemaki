﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Votemaki.Core.Entities.SecondaryEntities
{
    public class CalendarEvent

    {
        [Key]
        public Guid Id { get; set; }

        public DateTimeOffset Value { get; set; }
        public string Description { get; set; }
        public CalendarEventTypeEnum Type { get; set; }
    }

    public enum CalendarEventTypeEnum
    {
        BeginElection,
        EndElection,
        BeginPreElection,

        Others
    }
}