using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Droomspel.data.Models.Enums;
using Droomspel.data.Models;

namespace Droomspel.data.Services
{
    public interface IUserData
    {
        List<User> GetUsers();
        User GetUserData(string id);
        void ChangeGamePoints(string id, GameType gameType, int points);
        int GetGamePoints(string id, GameType gameType);
        void DeleteUser(string id);
        void ChangeUserName(string id, string newName);
        void ChangeAvatar(string id, AvatarType newAvatar);
        void ChangeTheme(string id, ThemeType newTheme);
    }
}
