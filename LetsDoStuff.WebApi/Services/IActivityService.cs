﻿using System.Collections.Generic;
using LetsDoStuff.Domain.Models.DTO;

namespace LetsDoStuff.WebApi.Services
{
    public interface IActivityService
    {
        List<ActivityResponse> GetAllActivities();

        void CreateActivity(CreateActivityCommand newActivity);

        ActivityResponse GetActivityById(int activityId);
    }
}
