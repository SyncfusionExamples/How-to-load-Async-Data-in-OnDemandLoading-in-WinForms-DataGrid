using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace WinFormsApp2
{
    public class OrderInfoCollection
    {
        public OrderInfoCollection()
        {
        }
        public async Task<ObservableCollection<OrderInfo>> GenerateOrders()
        {
            ObservableCollection<OrderInfo> _orders = new ObservableCollection<OrderInfo>();
           await Task.Delay(1000);
            _orders.Add(new OrderInfo(1001, "Maria Anders", "Germany", "ALFKI", "Berlin"));
            _orders.Add(new OrderInfo(1002, "Ana Trujilo", "Mexico", "ANATR", "Mexico D.F."));
            _orders.Add(new OrderInfo(1003, "Antonio Moreno", "Mexico", "ANTON", "Mexico D.F."));
            _orders.Add(new OrderInfo(1004, "Thomas Hardy", "UK", "AROUT", "London"));
            _orders.Add(new OrderInfo(1005, "Christina Berglund", "Sweden", "BERGS", "Lula"));
            _orders.Add(new OrderInfo(1006, "Hanna Moos", "Germany", "BLAUS", "Mannheim"));
            _orders.Add(new OrderInfo(1007, "Frederique Citeaux", "France", "BLONP", "Strasbourg"));
            _orders.Add(new OrderInfo(1008, "Martin Sommer", "Spain", "BOLID", "Madrid"));
            _orders.Add(new OrderInfo(1009, "Laurence Lebihan", "France", "BONAP", "Marseille"));
            _orders.Add(new OrderInfo(1010, "Elizabeth Lincoln", "Canada", "BOTTM", "Tsawassen"));
            _orders.Add(new OrderInfo(1011, "Maria Anders", "Germany", "ALFKI", "Berlin"));
            _orders.Add(new OrderInfo(1012, "Ana Trujilo", "Mexico", "ANATR", "Mexico D.F."));
            _orders.Add(new OrderInfo(1013, "Antonio Moreno", "Mexico", "ANTON", "Mexico D.F."));
            _orders.Add(new OrderInfo(1014, "Thomas Hardy", "UK", "AROUT", "London"));
            _orders.Add(new OrderInfo(1015, "Christina Berglund", "Sweden", "BERGS", "Lula"));
            _orders.Add(new OrderInfo(1016, "Hanna Moos", "Germany", "BLAUS", "Mannheim"));
            _orders.Add(new OrderInfo(1017, "Frederique Citeaux", "France", "BLONP", "Strasbourg"));
            _orders.Add(new OrderInfo(1018, "Martin Sommer", "Spain", "BOLID", "Madrid"));
            _orders.Add(new OrderInfo(1019, "Laurence Lebihan", "France", "BONAP", "Marseille"));
            _orders.Add(new OrderInfo(1020, "Elizabeth Lincoln", "Canada", "BOTTM", "Tsawassen"));
            _orders.Add(new OrderInfo(1021, "Maria Anders", "Germany", "ALFKI", "Berlin"));
            _orders.Add(new OrderInfo(1022, "Ana Trujilo", "Mexico", "ANATR", "Mexico D.F."));
            _orders.Add(new OrderInfo(1023, "Antonio Moreno", "Mexico", "ANTON", "Mexico D.F."));
            _orders.Add(new OrderInfo(1024, "Thomas Hardy", "UK", "AROUT", "London"));
            _orders.Add(new OrderInfo(1025, "Christina Berglund", "Sweden", "BERGS", "Lula"));
            _orders.Add(new OrderInfo(1026, "Hanna Moos", "Germany", "BLAUS", "Mannheim"));
            _orders.Add(new OrderInfo(1027, "Frederique Citeaux", "France", "BLONP", "Strasbourg"));
            _orders.Add(new OrderInfo(1028, "Martin Sommer", "Spain", "BOLID", "Madrid"));
            _orders.Add(new OrderInfo(1029, "Laurence Lebihan", "France", "BONAP", "Marseille"));
            _orders.Add(new OrderInfo(1030, "Elizabeth Lincoln", "Canada", "BOTTM", "Tsawassen"));
            _orders.Add(new OrderInfo(1031, "Maria Anders", "Germany", "ALFKI", "Berlin"));
            _orders.Add(new OrderInfo(1032, "Ana Trujilo", "Mexico", "ANATR", "Mexico D.F."));
            _orders.Add(new OrderInfo(1033, "Antonio Moreno", "Mexico", "ANTON", "Mexico D.F."));
            _orders.Add(new OrderInfo(1034, "Thomas Hardy", "UK", "AROUT", "London"));
            _orders.Add(new OrderInfo(1035, "Christina Berglund", "Sweden", "BERGS", "Lula"));
            _orders.Add(new OrderInfo(1036, "Hanna Moos", "Germany", "BLAUS", "Mannheim"));
            _orders.Add(new OrderInfo(1037, "Frederique Citeaux", "France", "BLONP", "Strasbourg"));
            _orders.Add(new OrderInfo(1038, "Martin Sommer", "Spain", "BOLID", "Madrid"));
            _orders.Add(new OrderInfo(1039, "Laurence Lebihan", "France", "BONAP", "Marseille"));
            _orders.Add(new OrderInfo(1040, "Elizabeth Lincoln", "Canada", "BOTTM", "Tsawassen"));
            _orders.Add(new OrderInfo(1041, "Maria Anders", "Germany", "ALFKI", "Berlin"));
            _orders.Add(new OrderInfo(1042, "Ana Trujilo", "Mexico", "ANATR", "Mexico D.F."));
            _orders.Add(new OrderInfo(1043, "Antonio Moreno", "Mexico", "ANTON", "Mexico D.F."));
            _orders.Add(new OrderInfo(1044, "Thomas Hardy", "UK", "AROUT", "London"));
            _orders.Add(new OrderInfo(1045, "Christina Berglund", "Sweden", "BERGS", "Lula"));
            _orders.Add(new OrderInfo(1046, "Hanna Moos", "Germany", "BLAUS", "Mannheim"));
            _orders.Add(new OrderInfo(1047, "Frederique Citeaux", "France", "BLONP", "Strasbourg"));
            _orders.Add(new OrderInfo(1048, "Martin Sommer", "Spain", "BOLID", "Madrid"));
            _orders.Add(new OrderInfo(1049, "Laurence Lebihan", "France", "BONAP", "Marseille"));
            _orders.Add(new OrderInfo(1050, "Elizabeth Lincoln", "Canada", "BOTTM", "Tsawassen"));
            _orders.Add(new OrderInfo(1051, "Maria Anders", "Germany", "ALFKI", "Berlin"));
            _orders.Add(new OrderInfo(1052, "Ana Trujilo", "Mexico", "ANATR", "Mexico D.F."));
            _orders.Add(new OrderInfo(1053, "Antonio Moreno", "Mexico", "ANTON", "Mexico D.F."));
            _orders.Add(new OrderInfo(1054, "Thomas Hardy", "UK", "AROUT", "London"));
            _orders.Add(new OrderInfo(1055, "Christina Berglund", "Sweden", "BERGS", "Lula"));
            _orders.Add(new OrderInfo(1056, "Hanna Moos", "Germany", "BLAUS", "Mannheim"));
            _orders.Add(new OrderInfo(1057, "Frederique Citeaux", "France", "BLONP", "Strasbourg"));
            _orders.Add(new OrderInfo(1058, "Martin Sommer", "Spain", "BOLID", "Madrid"));
            _orders.Add(new OrderInfo(1059, "Laurence Lebihan", "France", "BONAP", "Marseille"));
            _orders.Add(new OrderInfo(1060, "Elizabeth Lincoln", "Canada", "BOTTM", "Tsawassen"));
            return _orders;
        }
    }
}
