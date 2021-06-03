using Garant.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Garant.Services
{
    public interface ISqlBaseRepository
    {
        Deal AddDeal(string namedeal, string explanation, string idexecutor, int summa, int daytocompleate, string idauthor);
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
        Finance SaveFinanceChanges(Finance finance);
        void AddRequestFinance(Finance addfinance);
        IEnumerable<Finance> GetFinances();
        public CommentsViewModel AddComment(string name, string surname, string login, string email, string message);
        public IEnumerable<CommentsViewModel> GetComments();
    }
}
