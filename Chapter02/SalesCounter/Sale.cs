﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesCounter {
    internal class Sale {
        //店舗名
        public string ShopName { get; set; }
        //商品カテゴリ
        public string ProductCategory { get; set; }
        //売上高
        public string Amount { get; set; }
    }
}
