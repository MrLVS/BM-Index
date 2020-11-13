using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Mvvm;
using DevExpress.Utils.Filtering.Internal;

namespace BM_Index.ViewModels
{
    class IndexCalculation:ViewModelBase

    {

        public IndexCalculation(Persone p)
        {
            Persone = Persone;
        }


        double a = Math.Round(145.4 / Math.Pow(64.4 / 100.0, 2.0), 2);

        public Persone Persone { set; get; }

    }
}
