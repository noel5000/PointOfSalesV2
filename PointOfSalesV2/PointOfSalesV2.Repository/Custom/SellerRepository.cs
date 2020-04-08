using PointOfSalesV2.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PointOfSalesV2.Repository
{
    public class SellerRepository : Repository<Seller>, ISellerRepository
    {
        readonly ISequenceManagerRepository _sequenceRepo;
        public SellerRepository(MainDataContext context, ISequenceManagerRepository sequenceRepo) : base(context)
        {
            this._sequenceRepo = sequenceRepo;
        }

        public override Result<Seller> Add(Seller entity)
        {
            entity.Code = _sequenceRepo.CreateSequence(Common.Enums.SequenceTypes.Sellers);
            return base.Add(entity);
        }

        public override Result<Seller> Update(Seller entity)
        {
            entity.Code = string.IsNullOrEmpty(entity.Code) ? _sequenceRepo.CreateSequence(Common.Enums.SequenceTypes.Sellers) : entity.Code;
            return base.Update(entity);
        }

    }
}
