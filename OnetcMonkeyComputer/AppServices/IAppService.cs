﻿using OnetcMonkeyComputer.AppServices.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnetcMonkeyComputer.AppServices
{
    public interface IAppService
    {
        AppInfoDto GetAppInfo();

        LoginResult Login(string wallet, string name);
    }
}
