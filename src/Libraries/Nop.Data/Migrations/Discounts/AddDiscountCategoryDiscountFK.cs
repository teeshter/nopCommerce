﻿using System.Data;
using FluentMigrator;
using Nop.Core.Domain.Discounts;
using Nop.Data.Extensions;
using Nop.Data.Mapping;

namespace Nop.Data.Migrations.Discounts
{
    [NopMigration("2019/11/19 04:19:29:5936887")]
    public class AddDiscountCategoryDiscountFK : AutoReversingMigration
    {
        #region Methods

        public override void Up()
        {
            this.AddForeignKey(NopMappingDefaults.DiscountAppliedToCategoriesTable,
                "Discount_Id",
                nameof(Discount),
                nameof(Discount.Id),
                Rule.Cascade);
        }

        #endregion
    }
}