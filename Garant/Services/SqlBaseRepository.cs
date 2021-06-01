using Garant.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Garant.Services
{
    public class SqlBaseRepository : ISqlBaseRepository
    {
        ApplicationContext dbcontext;
        public SqlBaseRepository(ApplicationContext context)
        {
            dbcontext = context;
        }

        public Deal AddDeal(string namedeal, string explanation, string idexecutor, int summa, int daytocompleate, string idauthor)
        {
            Deal dealforadd = new Deal()
            {
                NameDeal = namedeal,
                Explanation = explanation,
                IdExecutor = idexecutor,
                QurencySumma = summa,
                DataCreated = DateTime.Now,
                DataFinish = DateTime.Now.AddDays(daytocompleate),
                Status = "В ожидании подтверждения",
                AcceptForAuthor = true,
                AcceptForExucator = false,
                FinishAcceptForAuthor = false,
                FinishAcceptForExecutor = false,
                IdAuthor = idauthor

            };
            dbcontext.Deals.Add(dealforadd);
            dbcontext.SaveChanges();
            return dealforadd;
        }

        public User GetUserByLogin(string login)
        {
            if (!string.IsNullOrEmpty(login))
            {
                foreach (var a in dbcontext.Users)
                {
                    if (a.UserName == login)
                    {
                        return a;
                    }
                }
            }
            return null;
        }

        public int GetUserQurencyDeal(string login)
        {
            foreach(var a in dbcontext.Users)
            {
                if(a.UserName == login)
                {
                    return a.QurencyDeals;
                }
            }
            return 0;
        }
        public void ChangeStatusForParticipantsDeal(string idexecute, string idathor, int id)
        {
            foreach(var a in dbcontext.Users) //Автор
            {
                if(a.Id == idathor)
                {
                    a.QurencyDeals = id;
                    a.Active = true;
                    var attacha = dbcontext.Users.Attach(a);
                    attacha.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                }
            }
            foreach (var ex in dbcontext.Users) //Исполнитель
            {
                if (ex.Id == idexecute)
                {
                    ex.QurencyDeals = id;
                    ex.Active = true;
                    var attachex = dbcontext.Users.Attach(ex);
                    attachex.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                }
            }
            dbcontext.SaveChanges();
        }

        public int SearchDeals(string idauthor)
        {
            IEnumerable<Deal> deals = dbcontext.Deals;
            foreach(var a in deals)
            {
                if(a.IdAuthor == idauthor)
                {
                    return a.Id;
                }
            }
            return 0;
        }

        public Deal GetDealInfo(int id)
        {
            Deal deal = dbcontext.Deals.Find(id);
            if (deal != null) return deal;
            else return null;
        }

        public User GetUserByID(string id)
        {
            foreach(var a in dbcontext.Users)
            {
                if(a.Id == id)
                {
                    return a;
                }
            }
            return null;
        }
    }
}
