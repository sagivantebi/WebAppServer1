﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ServerFreak.Models;

namespace WebAppServer1.Data
{
    public class WebAppServer1Context : DbContext
    {
        public WebAppServer1Context (DbContextOptions<WebAppServer1Context> options)
            : base(options)
        {
        }

        public DbSet<ServerFreak.Models.Review>? Review { get; set; }

        public DbSet<ServerFreak.Models.MessageChat> MessageChat { get; set; }

        public DbSet<ServerFreak.Models.ChatBox> ChatBox { get; set; }

        public DbSet<ServerFreak.Models.Contact> Contact { get; set; }
    }
}
