using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Penalty_Calculation_Application
{
    #region SalesPersons

    public class SalesPersons
    {
        public string Name { get; set; }
        public double QS1 { get; set; }
        public double QS2 { get; set; }
        public double QS3 { get; set; }
        public double QS4 { get; set; }
        public double Total { get; set; }
        public int Year { get; set; }

        public static IList GetTopSalesPerson()
        {
            List<SalesPersons> SalesPersonCollection = new List<SalesPersons>();
            SalesPersons salesPerson = null;
            salesPerson = new SalesPersons()
            {
                Name = "Carol Elliott",
                QS3 = 656287.9884,
                QS4 = 1006810.7219,
                Total = 1663098.7103,
                Year = 2001
            };
            SalesPersonCollection.Add(salesPerson);
            salesPerson = new SalesPersons()
            {
                Name = "Linda Ecoffey",
                QS3 = 547589.0181,
                QS4 = 951811.3768,
                Total = 1499400.3949,
                Year = 2002
            };
            SalesPersonCollection.Add(salesPerson);
            salesPerson = new SalesPersons()
            {
                Name = "Shelley Dyck",
                QS3 = 551800.5660,
                QS4 = 823059.5628,
                Total = 1374860.1288,
                Year = 2001
            };
            SalesPersonCollection.Add(salesPerson);

            return SalesPersonCollection;
        }
    }

    #endregion

    #region Stores

    public class Stores
    {
        public string Name { get; set; }
        public double QS1 { get; set; }
        public double QS2 { get; set; }
        public double QS3 { get; set; }
        public double QS4 { get; set; }
        public double Total { get; set; }
        public int year { get; set; }

        public static IList GetTopStores()
        {
            List<Stores> StoreCollection = new List<Stores>();
            Stores store = null;
            store = new Stores()
            {
                Name = "Bicycle Company",
                QS3 = 656287.9884,
                QS4 = 1006810.7219,
                Total = 1663098.7103,
                year = 2001
            };
            StoreCollection.Add(store);
            store = new Stores()
            {
                Name = "Activity Center",
                QS3 = 656287.9884,
                QS4 = 1006810.7219,
                Total = 1663098.7103,
                year = 2002
            };
            StoreCollection.Add(store);
            store = new Stores()
            {
                Name = "Bike Shop",
                QS3 = 656287.9884,
                QS4 = 1006810.7219,
                Total = 1663098.7103,
                year = 2001
            };
            StoreCollection.Add(store);

            return StoreCollection;
        }
    }

    #endregion

    #region Products:

    public class Products
    {
        public string Name { get; set; }
        public double QS1 { get; set; }
        public double QS2 { get; set; }
        public double QS3 { get; set; }
        public double QS4 { get; set; }
        public double Total { get; set; }
        public int Year { get; set; }

        public static IList GetTopProducts()
        {
            List<Products> ProductCollection = new List<Products>();
            Products product = null;
            product = new Products()
            {
                Name = "AWC Logo Cap",
                QS3 = 2104165.3554,
                QS4 = 3308323.5938,
                Total = 5412488.9492,
                Year = 2001
            };
            ProductCollection.Add(product);
            product = new Products()
            {
                Name = "S-100 Helmet, B",
                QS3 = 1988382.4844,
                QS4 = 3279281.6611,
                Total = 5267664.1455,
                Year = 2001
            };
            ProductCollection.Add(product);
            product = new Products()
            {
                Name = "L-Sleeve Jrsey",
                QS3 = 1974839.7878,
                QS4 = 3282139.2608,
                Total = 5256979.0486,
                Year = 2001
            };
            ProductCollection.Add(product);

            return ProductCollection;
        }
    }

    #endregion
}
