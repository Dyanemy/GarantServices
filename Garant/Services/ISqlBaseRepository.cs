using Garant.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Garant.Services
{
    public interface ISqlBaseRepository
    {
        Deal AddDeal(string namedeal, string explanation, User executor, int summa, int daytocompleate, User author);
        User GetUserByLogin(string login);
        int GetUserQurencyDeal(string login);
        void ChangeStatusForParticipantsDeal(string idexecutor, string idauthor, int id);
        int SearchDeals(string idauthor);
        Deal GetDealInfo(int id);
        User GetUserByID(string id);
        void AddMoneyToUser(string name, int money);
        void TakeAwayMoneyForUser(string name, int money);
        User SaveUserChanges(User user);
        Deal SaveDealChanges(Deal deal);
    }
}
