using Matrix.Core.Application.DTOs;
using Matrix.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix.Infastructure.Persistence.Seeding
{
    public static class ModelBuilderExtensions
    {
        public static void SeedData(this ModelBuilder modelBuilder)
        {
            seedBanks(modelBuilder);
            seedBrands(modelBuilder);
            seedAreas(modelBuilder);
            seedSuppliers(modelBuilder);
            seedWarehouses(modelBuilder);
            seedModels(modelBuilder);

        }

        public static void seedBanks(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<tblBank>().HasData(
                new tblBank
                {
                    BankID = 1,
                    BankName = "Meezan Bank",
                    IsActive = EStatus.Active
                },
                new tblBank
                {
                    BankID = 2,
                    BankName = "Habib Metro",
                    IsActive = EStatus.Active
                },
                new tblBank
                {
                    BankID = 3,
                    BankName = "Bank Alfalah",
                    IsActive = EStatus.Active
                },
                new tblBank
                {
                    BankID = 4,
                    BankName = "Habib Bank",
                    IsActive = EStatus.Active
                },
                new tblBank
                {
                    BankID = 5,
                    BankName = "Muslim Commercial Bank Limited",
                    IsActive = EStatus.Active
                },
                new tblBank
                {
                    BankID = 6,
                    BankName = "National Bank of Pakistan",
                    IsActive = EStatus.Active
                },
                new tblBank
                {
                    BankID = 7,
                    BankName = "Allied Bank Limited",
                    IsActive = EStatus.Active
                },
                new tblBank
                {
                    BankID = 8,
                    BankName = "Faisal Bank",
                    IsActive = EStatus.Active
                }
            );
        }

        public static void seedBrands(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<tblBrands>().HasData(
                    new tblBrands
                    {
                        BrandID = 1,
                        BrandName = "Infinix",
                        IsActive = EStatus.Active
                    },
                    new tblBrands
                    {
                        BrandID = 2,
                        BrandName = "Realme",
                        IsActive = EStatus.Active
                    },
                    new tblBrands
                    {
                        BrandID = 3,
                        BrandName = "Samsung",
                        IsActive = EStatus.Active
                    },
                    new tblBrands
                    {
                        BrandID = 4,
                        BrandName = "Dell",
                        IsActive = EStatus.Active
                    },
                    new tblBrands
                    {
                        BrandID = 5,
                        BrandName = "Sony",
                        IsActive = EStatus.Active
                    },
                    new tblBrands
                    {
                        BrandID = 6,
                        BrandName = "Itel",
                        IsActive = EStatus.Active
                    },
                    new tblBrands
                    {
                        BrandID = 7,
                        BrandName = "Tecno",
                        IsActive = EStatus.Active
                    },
                    new tblBrands
                    {
                        BrandID = 8,
                        BrandName = "Huawei",
                        IsActive = EStatus.Active
                    },
                    new tblBrands
                    {
                        BrandID = 9,
                        BrandName = "Nokia",
                        IsActive = EStatus.Active
                    },
                    new tblBrands
                    {
                        BrandID = 10,
                        BrandName = "OtherBrands",
                        IsActive = EStatus.Active
                    }
                );
        }

        public static void seedAreas(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<tblAreas>().HasData(
                new tblAreas
                {
                    AreaID = 1,
                    AreaName = "East",
                    AreaCode = "001",
                    OrderBy = 1,
                    IsActive = EStatus.Active
                },
                new tblAreas
                {
                    AreaID = 2,
                    AreaName = "West",
                    AreaCode ="002",
                    OrderBy = 2,
                    IsActive = EStatus.Active
                },
                new tblAreas
                {
                    AreaID = 3,
                    AreaName = "North",
                    AreaCode ="003",
                    OrderBy = 3,
                    IsActive = EStatus.Active
                },
                new tblAreas
                {
                    AreaID = 4,
                    AreaName = "South",
                    AreaCode="004",
                    OrderBy = 4,
                    IsActive = EStatus.Active
                }
                );
        }
        public static void seedSuppliers(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<tblSuppliers>().HasData(
                new tblSuppliers
                {
                    SupplierID = 1,
                    SupplierName = "Taha",
                    IsActive = EStatus.Active
                },
                new tblSuppliers
                {
                    SupplierID = 2,
                    SupplierName = "Aaqib",
                    IsActive = EStatus.Active
                },
                new tblSuppliers
                {
                    SupplierID = 3,
                    SupplierName = "Sahil",
                    IsActive = EStatus.Active
                },
                new tblSuppliers
                {
                    SupplierID = 4,
                    SupplierName = "Daniyal",
                    IsActive = EStatus.Active
                }
                );
        }
        public static void seedModels(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<tblModels>().HasData(
                new tblModels
                {
                    ModelID = 1,
                    ModelName = "3310",
                    IsActive = EStatus.Active
                },
                new tblModels
                {
                    ModelID = 2,
                    ModelName = "C3",
                    IsActive = EStatus.Active
                },
                new tblModels
                {
                    ModelID = 3,
                    ModelName = "Note-30",
                    IsActive = EStatus.Active
                },
                new tblModels
                {
                    ModelID = 4,
                    ModelName = "Camon-30",
                    IsActive = EStatus.Active
                }
                );
        } public static void seedWarehouses(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<tblWareHouse>().HasData(
                new tblWareHouse
                {
                    WareHouseID = 1,
                    WareHouseName = "WH-1",
                    IsActive = EStatus.Active
                },
                new tblWareHouse
                {
                    WareHouseID = 2,
                    WareHouseName = "WH-2",
                    IsActive = EStatus.Active
                },
                new tblWareHouse
                {
                    WareHouseID = 3,
                    WareHouseName = "WH-3",
                    IsActive = EStatus.Active
                },
                new tblWareHouse
                {
                    WareHouseID = 4,
                    WareHouseName = "WH-4",
                    IsActive = EStatus.Active
                }
                );
        }
    }
}
