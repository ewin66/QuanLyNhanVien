﻿using QuanLyDaiHocGiaDinh.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDaiHocGiaDinh.IDao
{
    interface ISchedulePosition
    {
        void AddScheduleForPostion(SchedulePosition schedulePosition);
        void DeleteSchedulePostion(SchedulePosition schedule);
    }
}
