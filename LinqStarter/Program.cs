using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LinqStarter
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = new Data();
            var people = data.GetPeople();
            var animals = data.GetAnimals();
            var intList = Enumerable.Range(1, 100);
            #region Select / SelectMany
            #endregion

            #region Where / First / FirstOrDefault / Single / SingleOrDefault
            #endregion

            #region GroupBy / Join / GroupJoin / Aggregate
            #endregion

            #region Skip / Take / Any / All / Order
            #endregion

            #region Expressions

            #endregion

            #region exercises
            //na podstawie intList napisz listę list, która zawiera dla danego n wszystkie wielokrotności z danego przedziału
            

            //napisz funkcje, która na podstawie intList zgrupujesz elementy po 2 tj. na wyjściu lista list, gdzie wewnętrzna ma 2 elementy. {{1,2},{3,4}, {...}}. Rozwiązanie powinno w łatwy sposób
            //umożliwić zmianę liczby elementów zgrupowanych. Podpowiedź, Select( (x,y) => new {x, y}) y to index.


            //napisz funkcje, która ustawi liczby parzystę najpierw w kolejności rosnącej następnie nieparzyste w malejącej
            //sprawdź funkcje Union

            //Zadanie domowe, napiszcie własny filtr za pomocą Expression
            #endregion
        }
    }
}
