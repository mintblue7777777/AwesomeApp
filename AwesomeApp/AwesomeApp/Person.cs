using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace AwesomeApp
{
    internal class Person : BindableObject
    {
        //バインダブルプロパティ
        public static readonly BindableProperty NameProperty = BindableProperty.Create(
            "Name",
            typeof(string),
            typeof(Person),
            "tanaka",
            validateValue:OnNameValidateValue);

        private static bool OnNameValidateValue(BindableObject bindable, object value)
        {
            //バリーデションロジック
            var name = (string)value;
            return !string.IsNullOrEmpty(name);
        }

        public string Name
        {
            get { return (string)this.GetValue(NameProperty); }
            set { this.SetValue(NameProperty, value); }
        }

        //読み取り専用バインダブルプロパティ
        private static readonly BindablePropertyKey AgePropertyKey = BindableProperty.CreateReadOnly(
            "Age",
            typeof(int),
            typeof(Person),
            0);

        public static readonly BindableProperty AgeProperty = AgePropertyKey.BindableProperty;

        public int Age
        {
            get { return (int)this.GetValue(AgeProperty); }
            //よ書き込みはBindablePropertyKeyでおこなう
            private set { this.SetValue(AgePropertyKey, value); }
        }

        //添付プロパティ
        //public static readonly BindableProperty RowProperty = BindableProperty.CreateAttached(
        //    "Row",
        //    typeof(int),
        //    typeof(MyGrid),
        //    0);
        //public static int GetRow(BindableObject obj)
        //{
        //    return (int)obj.GetValue(RowProperty);
        //}
        //public static void SetRow(BindableObject obj,int value)
        //{
        //    obj.SetValue(RowProperty, value);
        //}

    }
}
