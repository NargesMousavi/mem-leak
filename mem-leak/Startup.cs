﻿using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(mem_leak.Startup))]
namespace mem_leak
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {


            ConfigureAuth(app);
        }
    }
}
