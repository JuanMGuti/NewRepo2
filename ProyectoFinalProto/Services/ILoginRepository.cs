using ProyectoFinalProto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalProto.Services
{
    public interface IloginRepository
    {
        Task<UserInfo> Login(string username, string password);
    }
}
