using System;
using System.Collections.Generic;
using System.Linq;
using Exercicio1_1.models;

namespace Exercicio1_1.Repository
{
    internal class TableRepository
    {
        private  List<ModelTable> dataBase = new List<ModelTable>();

        public  void Add(ModelTable table)
        {
            dataBase.Add(table);
        }

        public  void Delete(string id)
        {
            var table = dataBase.FirstOrDefault(p => id.Equals(p.GetID) );
            if (table != null)
                dataBase.Remove(table);
        }

        public  ModelTable GetById(int id)
        {
            return dataBase.FirstOrDefault(p => id.Equals(p.GetID));
        }

        public  List<ModelTable> GetAll()
        {
            return dataBase;
        }
    }
}
