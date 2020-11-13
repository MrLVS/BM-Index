using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Mvvm;

namespace BM_Index.ViewModels
{
    public class Persone : ViewModelBase
    {
        private double myWeightPersone;
        private int myAge;
        private int myHeight;
        private Sex mySexPersone;

        public double Weight
        {
            get => myWeightPersone;
            set
            {
                if (myWeightPersone == value)
                    return;
                myWeightPersone = value;
                RaisePropertiesChanged();
            }
        }

        public int Age
        {
            get => myAge;
            set
            {
                if (myAge == value)
                    return;
                myAge = value;
                RaisePropertiesChanged();
            }
        }

        public int Height
        {
            get => myHeight;
            set
            {
                if (myHeight == value)
                    return;
                myHeight = value;
                RaisePropertiesChanged();
            }
        }

        public Sex SexPersone
        {
            get => mySexPersone;

            set
            {
                if (mySexPersone == value)
                    return;
                mySexPersone = value;
                RaisePropertiesChanged();
            }
        }

    }
    public enum Sex
    {
        [Display(Name = "Мужчина")]
        Man = 0,

        [Display(Name = "Женщина")]
        Woman = 1
    }
}




