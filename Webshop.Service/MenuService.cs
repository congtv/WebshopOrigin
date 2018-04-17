using System;
using System.Collections.Generic;
using Webshop.Model.Models;
using WebShop.Data.Infrastructure;
using WebShop.Data.Repositories;

namespace Webshop.Service
{
    public interface IMenuService
    {
        Menu Add(Menu menu);

        void Update(Menu menu);

        Menu Delete(int id);

        IEnumerable<Menu> GetAll();

        IEnumerable<Menu> GetAll(string keyword);

        Menu GetById(int id);

        void Save();
    }

    public class MenuService : IMenuService
    {
        private IMenuRepository _menuRepository;
        private IMenuGroupRepository _menuGroupRepository;
        private IUnitOfWork _unitOfWork;

        public MenuService(IMenuRepository menuRepository, IMenuGroupRepository menuGroupRepository, IUnitOfWork unitOfWork)
        {
            this._menuRepository = menuRepository;
            this._menuGroupRepository = menuGroupRepository;
            this._unitOfWork = unitOfWork;
        }

        //TODO
        public Menu Add(Menu menu)
        {
            throw new NotImplementedException();
        }

        public Menu Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Menu> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Menu> GetAll(string keyword)
        {
            throw new NotImplementedException();
        }

        public Menu GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void Update(Menu menu)
        {
            throw new NotImplementedException();
        }
    }
}