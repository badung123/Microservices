
using Baitap.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Baitap.Homework
{
    public class LoaiBaitap
    {
        private Dictionary<BaitapEnum, Func<int>> _entityTypeMapper;

        public LoaiBaitap()
        {
            _entityTypeMapper = new Dictionary<BaitapEnum, Func<int>> ();
            _entityTypeMapper.Add(BaitapEnum.Baitap1, () => LoaiBaitap1());
            _entityTypeMapper.Add(BaitapEnum.Baitap2, () => LoaiBaitap2());
            _entityTypeMapper.Add(BaitapEnum.Baitap3, () => LoaiBaitap3());
        }

        public int GetEntityBasedOnType(BaitapEnum BaitapType)
        {
            return _entityTypeMapper[BaitapType]();
        }
        public int LoaiBaitap1()
        {
            return 1;
        }
        public int LoaiBaitap2()
        {
            return 2;
        }
        public int LoaiBaitap3()
        {
            return 3;
        }
    }
}
