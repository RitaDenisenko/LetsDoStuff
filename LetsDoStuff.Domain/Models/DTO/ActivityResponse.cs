﻿using System.Collections.Generic;

namespace LetsDoStuff.Domain.Models.DTO
{
    public sealed class ActivityResponse
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int Capacity { get; set; }

        public User Creator { get; set; }

        public List<string> Tags { get; set; }

        public ActivityResponse()
        {
            Tags = new List<string>();
        }
    }
}
