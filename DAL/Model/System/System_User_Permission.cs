﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Model.System
{
    public class System_User_Permission
    {
        public System_User User { get; set; }
        public string UserPermission { get; set; }
        public string UserPermissionValue { get; set; }
        public System_User RerviewUser { get; set; }
        public DateTime ReviewDate { get; set; } = DateTime.Now;
    }
}
