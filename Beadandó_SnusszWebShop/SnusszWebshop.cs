using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Beadandó_SnusszWebShop
{
    public class SnusszWebshop
    {
        public ReadOnlyCollection<Snussz> Katalogus {get; private set;}

        public SnusszWebshop(IList<Snussz> kezdoKeszlet)
        {
            Katalogus = new ReadOnlyCollection<Snussz>(kezdoKeszlet);
        }
    }
}