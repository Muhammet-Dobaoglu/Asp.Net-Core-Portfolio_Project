using CV_Project.Business.Absract;
using CV_Project.Dal.Abstract;
using CV_Project.Entity.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV_Project.Business.Concrete
{
    public class PortfolioManager : IPortfolioService
    {
        IPortfolioDal _portfolioDal;

        public PortfolioManager(IPortfolioDal PortfolioDal)
        {
            _portfolioDal = PortfolioDal;
        }

        public Portfolio TGetById(int id)
        {
            return _portfolioDal.GetByID(id);
        }

        public List<Portfolio> TGetList()
        {
            return _portfolioDal.GetList();
        }

        public void TAdd(Portfolio t)
        {
            _portfolioDal.Insert(t);
        }
        public void TUpdate(Portfolio t)
        {
            _portfolioDal.Update(t);
        }
        public void TDelete(Portfolio t)
        {
            _portfolioDal.Delete(t);
        }

    }
}
