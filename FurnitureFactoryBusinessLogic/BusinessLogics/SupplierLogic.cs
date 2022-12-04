﻿using FurnitureFactoryDatabaseImplement.BindingModels;
using FurnitureFactoryDatabaseImplement.Implements;
using FurnitureFactoryDatabaseImplement.ViewModels;
using System;
using System.Collections.Generic;

namespace FurnitureFactoryBusinessLogic.BusinessLogics
{
    public class SupplierLogic
    {
        private readonly SupplierStorage _supplierStorage = new SupplierStorage();

        public SupplierLogic() {}

        public List<SupplierViewModel> Read(SupplierBindingModel model)
        {
            if (model is null)
            {
                return _supplierStorage.GetFullList();
            }
            if (model.Id.HasValue)
            {
                return new List<SupplierViewModel> { _supplierStorage.GetElement(model) };
            }
            return _supplierStorage.GetFilteredList(model);
        }

        public void CreateOrUpdate(SupplierBindingModel model)
        {
            var supplier = _supplierStorage.GetElement(new SupplierBindingModel
            {
                Name = model.Name
            });
            if (!(supplier is null) && !supplier.Id.Equals(model.Id))
            {
                throw new Exception("Уже есть поставщик с таким названием");
            }
            if (model.Id.HasValue)
            {
                _supplierStorage.Update(model);
            }
            else
            {
                _supplierStorage.Insert(model);
            }
        }
        public void Delete(SupplierBindingModel model)
        {
            var supplier = _supplierStorage.GetElement(new SupplierBindingModel
            {
                Id = model.Id
            });
            if (supplier is null)
            {
                throw new Exception("Поставщик не найден");
            }
            _supplierStorage.Delete(model);
        }
    }
}
