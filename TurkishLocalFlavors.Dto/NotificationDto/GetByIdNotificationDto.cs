﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurkishLocalFlavors.Dto.NotificationDto
{
    public class GetByIdNotificationDto
    {
        public int NotificationID { get; set; }
        public string Type { get; set; }
        public string Icon { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public bool Status { get; set; }
    }
}