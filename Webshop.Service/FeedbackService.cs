using System.Collections.Generic;
using System.Linq;
using Webshop.Model.Models;
using WebShop.Data.Infrastructure;
using WebShop.Data.Repositories;

namespace Webshop.Service
{
    internal interface IFeedbackService
    {
        Feedback Add(Feedback feedback);

        void Update(Feedback feedback);

        Feedback Delete(int id);

        IEnumerable<Feedback> GetAll();

        IEnumerable<Feedback> GetAllFeedbackOfPost(int id);

        IEnumerable<Feedback> GetAllFeedbackOfProduct(int id);

        Feedback GetById(int id);

        void Save();
    }

    public class FeedbackService : IFeedbackService
    {
        private IFeedbackRepository _feedbackRepository;
        private IUnitOfWork _unitOfWork;

        public FeedbackService(IFeedbackRepository feedbackRepository, IUnitOfWork unitOfWork)
        {
            this._feedbackRepository = feedbackRepository;
            this._unitOfWork = unitOfWork;
        }

        public Feedback Add(Feedback feedback)
        {
            return _feedbackRepository.Add(feedback);
        }

        public Feedback Delete(int id)
        {
            return _feedbackRepository.Delete(id);
        }

        public IEnumerable<Feedback> GetAll()
        {
            return _feedbackRepository.GetAll();
        }

        public IEnumerable<Feedback> GetAllFeedbackOfPost(int id)
        {
            return _feedbackRepository.GetAll().Where(x => x.PostID == id);
        }

        public IEnumerable<Feedback> GetAllFeedbackOfProduct(int id)
        {
            return _feedbackRepository.GetAll().Where(x => x.ProductID == id);
        }

        public Feedback GetById(int id)
        {
            return _feedbackRepository.GetSingleById(id);
        }

        public void Save()
        {
            _unitOfWork.Commit();
        }

        public void Update(Feedback feedback)
        {
            _feedbackRepository.Update(feedback);
        }
    }
}