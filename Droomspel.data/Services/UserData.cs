using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Droomspel.data.Models.Enums;
using Droomspel.data.Models;

namespace Droomspel.data.Services
{
    public class UserData : IUserData
    {
        public User user = new User();

        public UserData()
        {
            user.Name = "Ruben";
        }

        public void ChangeAvatar(string id, AvatarType newAvatar)
        {
            throw new NotImplementedException();
        }
        
        public void ChangeGamePoints(string id, GameType gameType, int points)
        {
            throw new NotImplementedException();
        }

        public void ChangeTheme(string id, ThemeType newTheme)
        {
            throw new NotImplementedException();
        }

        public void ChangeUserName(string id, string newName)
        {
            throw new NotImplementedException();
        }

        public void DeleteUser(string id)
        {
            throw new NotImplementedException();
        }

        public int GetGamePoints(string id, GameType gameType)
        {
            throw new NotImplementedException();
        }

        public User GetUserData(string id)
        {
            return user;
        }

        public List<User> GetUsers()
        {
            throw new NotImplementedException();
        }
    }
}
