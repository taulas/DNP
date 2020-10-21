using System.Collections.Generic;
using Managing_Adults.Data.Impl;
using Models;

namespace Managing_Adults.Data
{
    public interface IAdultService
    {
        IList<Adult> GetAdults();
        void AddAdult(Adult adult);
        void RemoveAdult(int Id);
        void Update(Adult adult);

        Adult getAdultById(int Id);
    }
}